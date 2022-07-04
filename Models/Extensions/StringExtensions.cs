
using System.Collections.Generic;
using System.Linq;

namespace Models.Extensions
{
    public static class StringExtensions
    {

        public static List<string> ToCommands(this string text)
        {
            return text.Split().ToList();
        }
        


    }
}
