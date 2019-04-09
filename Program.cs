using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a dictionary with key value pairs to represent words (key) and its definition (value)
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");
            wordsAndDefinitions.Add("Steve", "instructor for Cohort 30");

            // use square bracket lookup to get the definition of a specific word

            // loop over dictionary to get the following output: "The definition of [WORD] is [DEFINITION]"
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definitionof {word.Key} is {word.Value}");
            }


            // Now, we are going to rebuild the structure of our data. Instead of one dictionary with key value pairs for words and definitions. We want to track more than just the word and its definition, so we are going to build a list of dictionaries.

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // We want to track the following about each word: word, definition, part of speech, example sentence

            /*
                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
             */

            // create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            Dictionary<string, string> cohortWord = new Dictionary<string, string>();
            cohortWord.Add("word", "cohort");
            cohortWord.Add("definition", "group of people");
            cohortWord.Add("part of speech", "noun");
            cohortWord.Add("example sentence", "I am in Cohort 30 at NSS.");

            // Add dictionaries to your list
            dictionaryOfWords.Add(excitedWord);
            dictionaryOfWords.Add(cohortWord);



            // create another dictionary and add that to the list

            // loop over your list of dictionaries and output the data

            /*
            Example output for one word in the list of dictionaries:
                word: excited
                definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                part of speech: adjective
                example sentence: I am excited to learn C#!
             */

            // iterate list
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // iterate key value pair of dictionary
                foreach (KeyValuePair<string, string> pair in word)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value}");
                }
                Console.WriteLine("");
            }
        }
    }
}
