using System;
using System.Text;

namespace TarnsformacjaWartosciTypuString
{


    class Program
    {
        static void Main(string[] args)
        {
            // kebab case:
            // some-variable-name

            // camel case:
            // someVariableName  


           /* Console.WriteLine("Insert kebab cased variable name");
#pragma warning disable CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
            string kebabCased = Console.ReadLine();
#pragma warning restore CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            Console.WriteLine(KebabToCamelCase(kebabCased));
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
           */



           /* Console.WriteLine("Insert camel cased variable name");
#pragma warning disable CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
            string camelCased = Console.ReadLine();
#pragma warning restore CS8600 // Konwertowanie literału null lub możliwej wartości null na nienullowalny typ.
#pragma warning disable CS8604 // Możliwy argument odwołania o wartości null.
            Console.WriteLine(CamelCaseToKebabCase(camelCased));
#pragma warning restore CS8604 // Możliwy argument odwołania o wartości null.
           */


        }

        static string CamelCaseToKebabCase(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char currentChar in input)
            {
                if (char.IsUpper(currentChar))
                {
                    sb.Append("-");
                    sb.Append(char.ToLower(currentChar));

                }
                else
                {
                    sb.Append(currentChar);
                }

            }
            return sb.ToString();

        }

        static string KebabToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<input.Length; i++)
            {
                char currentChar = input[i];
                if(currentChar != '-') 
                {
                    sb.Append(currentChar);
                }
                else
                {
                    char nextChar = input[i+1];
                    sb.Append(char.ToUpper(nextChar)); // nextChar.ToString().ToUpper();
                    i++;
                }
            }
            return sb.ToString();

        }
    }
}