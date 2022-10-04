using System;
namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if(tab == null) {
                return false;
            }
          return Array.Exists(tab, x => x.Equals(value));
        }
    }
}