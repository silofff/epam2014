using System.Collections.Generic;

namespace TextParser
{
    public static class Extention
    {
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, T replaceable, T replacement)
        {
            foreach (var c in source)
            {
                if (c.Equals(replaceable)) yield return replacement;
                else yield return c;
            }
        }

        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, T replaceable, IEnumerable<T> replacements)
        {
            foreach (var c in source)
            {
                if (c.Equals(replaceable))
                    foreach (var replacement in replacements)
                    {
                        yield return replacement;
                    }
                else yield return c;
            }
        }
    }
}
