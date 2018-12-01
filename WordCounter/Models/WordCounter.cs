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

      public int CountWordInSentence()
        {
          int counter; 
          counter = 0; 
          stringList = _sentence.ToLower().Split().ToList();
          foreach(string word in stringList)
          {
            if (word == _word.ToLower())
            {
              counter+=1;
            }
          }
          return counter;
        }

      public bool IsWord()
      {
        stringList = _word.Split().ToList();
        if (_word == null)
        {
          return false;
        }
        else if (stringList.Count > 1)
        {
          return false;
        }
        else
        {
          return true;
        }
      }

      public bool IsSentence()
        {
          if (_sentence == null)
          {
            return false;
          }
          else
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
}
