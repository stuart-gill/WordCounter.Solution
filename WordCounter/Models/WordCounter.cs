using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter;

namespace WordCounter.Models
{
    public class WordCounterClass
    
    {
    private string _sentence;
    private string _word;
    public List<string> stringList;

    
    
    public WordCounterClass (string sentence, string word)
    {
      _sentence = sentence;
      _word = word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public int CountWordInSentence(string sentence, string targetWord)
    {
       int counter; 
       counter = 0;
       _sentence = sentence;
       _word = targetWord;      
       stringList = _sentence.Split().ToList();
       foreach(string word in stringList)
       {
         if (word == _word)
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
        _sentence = sentence;
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
