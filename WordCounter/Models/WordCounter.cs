using System;
using System.Collections.Generic;
using System.Linq;

using WordCounter;

namespace WordCounter.Models
{
    public class WordCounterClass
    
    {
    private string _sentence;
    public List<string> stringList;

    
    
    public WordCounterClass (string sentence)
    {
      _sentence = sentence;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public int CountWordInSentence(string targetWord)
    {
       int counter; 
       counter = 0;      
       stringList = _sentence.Split().ToList();
       foreach(string word in stringList)
       {
         if (word == targetWord)
         {
           counter+=1;
         }
       }
       return counter;
     }

     public string SentenceToLowerCase(string sentence)
     {
       string lowerCaseSentence;
       lowerCaseSentence = sentence.ToLower();
       return lowerCaseSentence;
     }

     public bool IsSentence(string sentence)
     {
       stringList = _sentence.Split().ToList();
       foreach(string word in stringList)
       {
         char[] characters = word.ToCharArray();
         foreach(char letter in characters)
         {
           bool result;
           result = Char.IsLetter(letter);
           if (result == false)
           {
             return false;
           }
         }
       }
       return true;
     }
    }
}
