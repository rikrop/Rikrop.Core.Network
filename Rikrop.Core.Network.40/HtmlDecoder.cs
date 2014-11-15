using System;
using System.Text;

namespace Rikrop.Core.Network
{
    public static class HtmlDecoder
    {
        private static readonly Encoding Cp1252Encoding;

        static HtmlDecoder()
        {
            Cp1252Encoding = Encoding.GetEncoding(1252);
        }

        public static string DecodeHtml(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            var inputLength = input.Length;
            var result = new char[inputLength];
            var i = -1;
            var replacing = false;
            var destIndex = 0;
            while (++i < inputLength)
            {
                var c = input[i];
                if (c == '\0')
                {
                    continue;
                }
                if (!replacing)
                {
                    if (c == '&')
                    {
                        replacing = true;
                    }
                    else
                    {
                        result[destIndex++] = c;
                    }
                }
                else
                {
                    var lastUsedIndex = 0;
                    var replacement = GetLiteralReplacement(input, i, ref lastUsedIndex)
                                      ?? GetNumericReplacement(input, i, ref lastUsedIndex);
                    if (replacement != null && lastUsedIndex <= inputLength)
                    {
                        i = lastUsedIndex;
                        foreach (var t in replacement)
                        {
                            result[destIndex++] = t;
                        }
                    }
                    else
                    {
                        result[destIndex++] = '&';
                        result[destIndex++] = c;
                    }
                    replacing = false;
                }
            }
            return new string(result, 0, destIndex);
        }

        private static string GetLiteralReplacement(string input, int index, ref int resultIndex)
        {
            return LiteralReplacement.Replace(input, index, ref resultIndex);
        }

        private static string GetNumericReplacement(string input, int index, ref int lastUsedIndex)
        {
            if (input[index] == '#')
            {
                if (index >= input.Length - 1)
                {
                    return null;
                }
                var code = 0;
                while (true)
                {
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }

                    var c = input[index];
                    if (c == ';')
                    {
                        lastUsedIndex = index;
                        try
                        {
                            //по стандарту номера могут быть в определенном диапазоне в формате Unicode,
                            //некоторые сайты используют номера не из разрешенного стандартом диапазона, и браузер интерпретирует их как CP-1252(ISO-8859-1),
                            //
                            if (code >= 129 && code <= 159)
                            {
                                var bytes = new[] {(byte) (code)};
                                return Cp1252Encoding.GetString(bytes);
                            }

                            return char.ConvertFromUtf32(code);
                        }
                        catch (Exception)
                        {
                            return null;
                        }
                    }
                    var digit = c - '0';
                    if (digit >= 0 && digit <= 9)
                    {
                        code = code*10 + digit;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return null;
        }
    }
}