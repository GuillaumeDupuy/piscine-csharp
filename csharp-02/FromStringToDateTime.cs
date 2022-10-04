using System;
namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            dateStr += ":00";
            return DateTime.ParseExact(dateStr, "dd/MM/yyyy HH:mm:ss", null);
        }
    }
}