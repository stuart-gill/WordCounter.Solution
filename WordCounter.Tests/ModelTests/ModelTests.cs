using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
 
namespace WordCounter.Tests
{

 
  [TestClass]
  public class WordCounterClassTest
  {
    [TestMethod]
    public void WordCounterConstructor_CreatesInstanceofWordCounter_WordCounter()
    {
      WordCounterClass newWordCounterClass = new WordCounterClass("test sentence", "testword");
      Assert.AreEqual(typeof(WordCounterClass), newWordCounterClass.GetType());
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string testSentence = "Snarfle Darfle";
      WordCounterClass newWordCounterClass = new WordCounterClass(testSentence, "testword");
      string result = newWordCounterClass.GetSentence();
      Assert.AreEqual(testSentence, result);
    }

    [TestMethod]
    public void SetSentence_SetsSentence_String()
    {
      string testSentence = "Barfle Snarfle";
      WordCounterClass newWordCounterClass = new WordCounterClass(testSentence, "testword");
      string updatedTestSentence = "Snarfle Barfle";
      newWordCounterClass.SetSentence(updatedTestSentence);
      string result = newWordCounterClass.GetSentence();
      Assert.AreEqual(updatedTestSentence, result);
    }

    [TestMethod]
    public void IsSentence_ChecksIfIsSentence_Bool()
    {

      string testSentence = "sentence contains nonalphabetic characters dd44dd" ;
      WordCounterClass newWordCounterClass = new WordCounterClass(testSentence, "testword");
      newWordCounterClass.IsSentence(testSentence);
      bool result = newWordCounterClass.IsSentence(testSentence);
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void SentenceToLowerCase_ChecksForLowerCase_Bool()
    {
      string testSentence = "This Sentence Has Upper Case Letters";
      WordCounterClass newWordCounterClass = new WordCounterClass(testSentence, "testword");
      newWordCounterClass.SentenceToLowerCase(testSentence);
      string resultingSentence = newWordCounterClass.SentenceToLowerCase(testSentence);
      bool result = resultingSentence.Any(char.IsUpper);
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void CountWordInSentence_CountsWordsInSentence_Int()
    {
      string testWord = "tarfle";
      string testSentence = "barfle snarfle tarfle darfle tarfle";
      WordCounterClass newWordCounterClass = new WordCounterClass(testSentence, testWord);
      newWordCounterClass.CountWordInSentence(testSentence, testWord);
      int result = newWordCounterClass.CountWordInSentence(testSentence, testWord);
      Assert.AreEqual(2, result);
    }
  }
}
