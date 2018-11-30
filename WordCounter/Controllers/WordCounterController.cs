using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
      [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
    return View();
    }



    [HttpPost("/wordcounter")]
    public ActionResult Create(string sentence, string word)
    {
      WordCounterClass myWordCounterClass = new WordCounterClass(sentence, word);
      return RedirectToAction("Index");
    }
  }
}