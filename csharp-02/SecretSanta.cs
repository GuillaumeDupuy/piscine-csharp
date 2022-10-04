using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people)
        {
            var openWith = new Dictionary<string, string>();
            var random = new Random();
            var listPeople = people.ToArray();
            listPeople = listPeople.OrderBy(x => random.Next()).ToArray();


            for (var i = 0; i < listPeople.Length - 1; i++)
            for (var j = i + 1; j < listPeople.Length; j++)
                while (!openWith.ContainsKey(listPeople[i]))
                    openWith.Add(listPeople[i], listPeople[j]);
            openWith.Add(listPeople.Last(), listPeople[0]);
            return openWith;
        }
    }
}