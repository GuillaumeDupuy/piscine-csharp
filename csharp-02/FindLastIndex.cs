namespace CSharpDiscovery.Quest02
{
    public class FindLastIndex_Exercice
    {
        public static int? FindLastIndex(int[] tab, int a)
        {
            if(tab == null){
                return null;
            }
           for (int i = tab.Length - 1; i >= 0; i--)
           {
               if(tab[i] == a) {
                   return i;
               }
           }
            return null;
        }
    }
}