using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listvideos = new List<string> { "pacman", "galaga", "super mario", "balloon pop", "candycrush" };
            var newlist = listvideos.OrderBy(X => X.Length);
        }
    }
}
