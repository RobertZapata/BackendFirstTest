using System;
using System.Text.RegularExpressions;

namespace BackendFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Campo de texto: ");
            Console.WriteLine("Campo de texto sin caracteres especiales: " + RemoveEspecialCharacters(Console.ReadLine()));

            static string RemoveEspecialCharacters(string text)
            {
                string emptyString = "NA";
                string formatedText = Regex.Replace(text, @"[^\w\s _-]", string.Empty);
                if (formatedText != String.Empty)
                    return formatedText;
                else return emptyString;
            }
        }
    }
}
