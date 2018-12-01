using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Create_ReturnsCorrectActionType_ViewResult()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            IActionResult view = controller.Create("this is a sentence","sentence");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
        }
    }
}

