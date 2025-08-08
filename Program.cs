using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for a sentence
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Prompt user for conversion choice
            Console.Write("Convert to (upper/lower): ");
            string choice = Console.ReadLine().ToLower();

            // Initialize an empty string for the converted sentence
            string convertedSentence = "";

            // Loop through each character in the sentence
            for (int i = 0; i < sentence.Length; i++)
            {
                char currentChar = sentence[i];

                if (choice == "upper")
                {
                    // Convert to uppercase
                    if (currentChar >= 'a' && currentChar <= 'z')
                    {
                        // Convert lowercase to uppercase
                        convertedSentence += (char)(currentChar - 32);
                    }
                    else
                    {
                        // Append non-alphabetic characters as is
                        convertedSentence += currentChar;
                    }
                }
                else if (choice == "lower")
                {
                    // Convert to lowercase
                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        // Convert uppercase to lowercase
                        convertedSentence += (char)(currentChar + 32);
                    }
                    else
                    {
                        // Append non-alphabetic characters as is
                        convertedSentence += currentChar;
                    }
                }
                else
                {
                    // Invalid choice
                    Console.WriteLine("Error: Please enter 'upper' or 'lower'.");
                    return;
                }
            }

            // Output the converted sentence
            Console.WriteLine($"Converted sentence: {convertedSentence}");
        }
    }
}




