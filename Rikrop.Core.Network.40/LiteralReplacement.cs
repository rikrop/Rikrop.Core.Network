namespace Rikrop.Core.Network
{
    internal class LiteralReplacement
    {
        internal static string Replace(string input, int index, ref int lastUsedIndex)
        {
            switch (input[index])
            {
                case 'A':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'E':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Æ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Á";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Â";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "À";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'h':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Α";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Å";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ã";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ä";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'B':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Β";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'C':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'i':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'l':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ç";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Χ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'D':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'r':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "‡";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Δ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'E':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'T':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'H':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Ð";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "É";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Ê";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "È";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "Ε";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Η";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ë";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'G':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Γ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'I':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Í";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Î";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ì";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ι";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ï";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'K':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Κ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'L':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'b':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'a':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Λ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'M':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "Μ";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'N':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ñ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "Ν";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'O':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'E':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Œ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ó";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Ô";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ò";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Ω";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'c':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'r':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "Ο";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'h':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ø";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Õ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ö";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'P':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Φ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "Π";
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "″";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Ψ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'R':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Ρ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'S':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'n':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Š";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Σ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'T':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'H':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'O':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'R':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'N':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Þ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "Τ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Θ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'U':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ú";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "Û";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ù";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "Υ";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ü";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'X':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "Ξ";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'Y':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "Ý";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ÿ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'Z':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "Ζ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'a':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "á";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "â";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "´";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "æ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "à";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'f':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'y':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'm':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "ℵ";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'h':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "α";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "&";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'n':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'd':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∧";
                                    }
                                    break;
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∠";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "'";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "å";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'y':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'p':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "≈";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ã";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ä";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'b':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "„";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "β";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'v':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'b':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'r':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "¦";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "•";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'c':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∩";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'i':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'l':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ç";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'd':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "¸";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "¢";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "χ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'c':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ˆ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'b':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "♣";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "≅";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'y':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "©";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'r':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "↵";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∪";
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'n':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "¤";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'd':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'A':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⇓";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'r':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "†";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "↓";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "°";
                                    }
                                    break;
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "δ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "♦";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'v':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "÷";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'e':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "é";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ê";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "è";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'y':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "∅";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return " ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'n':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return " ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "ε";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'q':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "≡";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "η";
                                    }
                                    break;
                                case 'h':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "ð";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ë";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'o':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "€";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'x':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "∃";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'f':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'n':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'f':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ƒ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'l':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "∀";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'c':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case '1':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case '2':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "½";
                                                            }
                                                            break;
                                                        case '4':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "¼";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case '3':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case '4':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "¾";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "⁄";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'g':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "γ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "≥";
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return ">";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'h':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'A':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⇔";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "↔";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 's':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "♥";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'i':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'p':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "…";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'i':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "í";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "î";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'x':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'c':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "¡";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ì";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ℑ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'n':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'f':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'n':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "∞";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∫";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ι";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'q':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'e':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 't':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "¿";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "∈";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ï";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'k':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "κ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'l':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'A':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⇐";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'b':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'a':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "λ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "〈";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "«";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "←";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "⌈";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "“";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "≤";
                            }
                            break;
                        case 'f':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'o':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'r':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "⌊";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'w':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 't':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "∗";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'z':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "◊";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "‎";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'q':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'u':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "‹";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "‘";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "<";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'm':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "¯";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'h':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "—";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "µ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'd':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 't':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "·";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "−";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "μ";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'n':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'b':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "∇";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'b':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return " ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'h':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "–";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "≠";
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "∋";
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'n':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "∉";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            lastUsedIndex = index;
                                            return "¬";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'b':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⊄";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ñ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "ν";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'o':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ó";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ô";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "œ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ò";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "‾";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ω";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'c':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'r':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "ο";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "⊕";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'd':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'f':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ª";
                                            }
                                            break;
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "º";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    lastUsedIndex = index;
                                    return "∨";
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'h':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ø";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 't':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "õ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 's':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "⊗";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ö";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'p':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "¶";
                                            }
                                            break;
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "∂";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'i':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'l':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "‰";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⊥";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "φ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'v':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "ϖ";
                                    }
                                    break;
                                case ';':
                                    lastUsedIndex = index;
                                    return "π";
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 's':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'm':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'n':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "±";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'o':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'd':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "£";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "′";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "∏";
                                            }
                                            break;
                                        case 'p':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "∝";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "ψ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'q':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "\"";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'r':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'A':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⇒";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'd':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "√";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'g':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "〉";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "»";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "→";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "⌉";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "”";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ℜ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "®";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'f':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'o':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'r':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "⌋";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "ρ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'l':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "‏";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 's':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'q':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'u':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "›";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "’";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 's':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'b':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'q':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "‚";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'o':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'n':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "š";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'd':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⋅";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "§";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'y':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "­";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'g':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'm':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'f':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ς";
                                                            }
                                                            break;
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "σ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∼";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 's':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "♠";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'b':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'e':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⊆";
                                            }
                                            break;
                                        case ';':
                                            lastUsedIndex = index;
                                            return "⊂";
                                    }
                                    break;
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "∑";
                                    }
                                    break;
                                case 'p':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case '1':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "¹";
                                            }
                                            break;
                                        case '2':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "²";
                                            }
                                            break;
                                        case '3':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "³";
                                            }
                                            break;
                                        case 'e':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⊇";
                                            }
                                            break;
                                        case ';':
                                            lastUsedIndex = index;
                                            return "⊃";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'z':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'g':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ß";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 't':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'u':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "τ";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'h':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'e':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case '4':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "∴";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case 't':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'a':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 's':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'y':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case 'm':
                                                                            index++;
                                                                            if (index >= input.Length)
                                                                            {
                                                                                return null;
                                                                            }
                                                                            switch (input[index])
                                                                            {
                                                                                case ';':
                                                                                    lastUsedIndex = index;
                                                                                    return "ϑ";
                                                                            }
                                                                            break;
                                                                        case ';':
                                                                            return null;
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "θ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'n':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'p':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return " ";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'o':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'n':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "þ";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "˜";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'e':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 's':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "×";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'r':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'a':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'd':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'e':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "™";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'u':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'A':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "⇑";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ú";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "↑";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'c':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'r':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'c':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "û";
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'g':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'r':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'v':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ù";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'm':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'l':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "¨";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'p':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 's':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'i':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'h':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case ';':
                                                            lastUsedIndex = index;
                                                            return "ϒ";
                                                    }
                                                    break;
                                                case 'l':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'o':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case 'n':
                                                                    index++;
                                                                    if (index >= input.Length)
                                                                    {
                                                                        return null;
                                                                    }
                                                                    switch (input[index])
                                                                    {
                                                                        case ';':
                                                                            lastUsedIndex = index;
                                                                            return "υ";
                                                                    }
                                                                    break;
                                                                case ';':
                                                                    return null;
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ü";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'w':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'i':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'e':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 'r':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'p':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "℘";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'x':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'i':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case ';':
                                    lastUsedIndex = index;
                                    return "ξ";
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'y':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'a':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'c':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'u':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case 't':
                                                    index++;
                                                    if (index >= input.Length)
                                                    {
                                                        return null;
                                                    }
                                                    switch (input[index])
                                                    {
                                                        case 'e':
                                                            index++;
                                                            if (index >= input.Length)
                                                            {
                                                                return null;
                                                            }
                                                            switch (input[index])
                                                            {
                                                                case ';':
                                                                    lastUsedIndex = index;
                                                                    return "ý";
                                                            }
                                                            break;
                                                        case ';':
                                                            return null;
                                                    }
                                                    break;
                                                case ';':
                                                    return null;
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "¥";
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'u':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'm':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'l':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ÿ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
                case 'z':
                    index++;
                    if (index >= input.Length)
                    {
                        return null;
                    }
                    switch (input[index])
                    {
                        case 'e':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 't':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'a':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "ζ";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case 'w':
                            index++;
                            if (index >= input.Length)
                            {
                                return null;
                            }
                            switch (input[index])
                            {
                                case 'j':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case ';':
                                            lastUsedIndex = index;
                                            return "‍";
                                    }
                                    break;
                                case 'n':
                                    index++;
                                    if (index >= input.Length)
                                    {
                                        return null;
                                    }
                                    switch (input[index])
                                    {
                                        case 'j':
                                            index++;
                                            if (index >= input.Length)
                                            {
                                                return null;
                                            }
                                            switch (input[index])
                                            {
                                                case ';':
                                                    lastUsedIndex = index;
                                                    return "‌";
                                            }
                                            break;
                                        case ';':
                                            return null;
                                    }
                                    break;
                                case ';':
                                    return null;
                            }
                            break;
                        case ';':
                            return null;
                    }
                    break;
            }
            lastUsedIndex = index;
            return null;
        }
    }
}