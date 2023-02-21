using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UniqueWordsLibrary;

namespace UniqueWordsLibraryTests
{
    [TestClass]
    public class UniqueWordsLibraryTest
    {
        /// <summary>
        /// Проверяем пустую строку
        /// </summary>
        [TestMethod]
        public void FindNonUniqueWords_EmptyString_ReturnList()
        {

            //Arrange

            string text = " ";
            List<string> list = new List<string>();
            List<string> actualList = new List<string>() {  };
            //Act

            list = UniqueWordsClass.FindNonUniqueWords(text);

            //Assert

            Assert.AreEqual(actualList.Count, list.Count);

        }



        /// <summary>
        /// Проверяем поиск одинаковых эллементов
        /// </summary>
        [TestMethod]
        public void FindNonUniqueWords_UniqueWords_ReturnList()
        {

            //Arrange

            string text = "b a b c, d d ef a !!!";
            List<string> list = new List<string>();
            List<string> actualList = new List<string>() { "a", "b", "d"  };
            //Act

            list = UniqueWordsClass.FindNonUniqueWords(text);
        
            //Assert

            Assert.AreEqual(actualList.Count, list.Count);

        }
        /// <summary>
        /// Влияют ли знаки препинания на поиск 
        /// </summary>
        [TestMethod]
        public void FindNonUniqueWords_PunctuationMarks_ReturnList()
        {

            //Arrange

            string text = "a!.??!. ??a";
            List<string> list = new List<string>();
            List<string> actualList = new List<string>() { "a" };
            //Act

            list = UniqueWordsClass.FindNonUniqueWords(text);

            //Assert

            Assert.AreEqual(actualList.Count, list.Count);

        }

        /// <summary>
        /// Смотрим на работу сортировки
        /// </summary>
        [TestMethod]
        public void FindNonUniqueWords_Sort_ReturnList()
        {

            //Arrange

            string text = "b. c d e f a s z x c v s b a e c s f s z s d e s a a!! ?";
            List<string> list = new List<string>();
            List<string> actualList = new List<string>() { "a", "b", "c", "d", "e", "f", "s", "z" };
            //Act

            list = UniqueWordsClass.FindNonUniqueWords(text);

            //Assert

            Assert.AreEqual(actualList.Count, list.Count);

        }
    }
}
