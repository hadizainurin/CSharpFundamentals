using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarisingText
{
    // Public class is x modifier
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20) // This for reusing the code in different place
        {
            //const int maxLength = 20; // This is hardcoded

            if (text.Length < maxLength)
                return text; //Console.WriteLine(text); is not need because is a sall value
            else
            {
                // Algorithm to count the number of word to break a sentence
                //sentence.Substring(0, maxLength); // Problem: this may cut off a word due to Substring which the summary text does not look clean
                var words = text.Split(' '); // Use a white space as a separator
                                             // If exceed 20 then that the boundary we need to cutoff
                var totalCharacters = 0;
                var summaryWords = new List<string>(); // List is similar to array but the size is dynamic


                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + "...";
                //Console.WriteLine(summary);
                return summary;
            }
        }
    }
}
