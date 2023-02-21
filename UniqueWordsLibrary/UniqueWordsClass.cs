using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueWordsLibrary
{
    public class UniqueWordsClass
    {




        /// <summary>
        ///  метод, который бы возвращал список всех слов, 
        ///  которые встречаются в указанном тексте более одного раза.
        /// </summary>
        /// 
        /// <param name="text">
        /// В качестве параметра передается строка, которая может 
        /// быть пустой или содержать некоторый текст. 
        /// Гарантируется, что текст содержит только буквы, 
        /// пробелы, переносы \n и знаки пунктуации ,, ., ! и ?.
        /// </param>
        /// 
        /// <returns>
        /// Метод возвращает список List<string> 
        /// всех слов, которые встречаются в 
        /// тексте два или более раз. Слова следует привести к нижнему регистру, 
        /// а список следует отсортировать в алфавитном порядке.
        /// </returns>
        public static List<string> FindNonUniqueWords(string text)
        {
           string newText = text.ToLower();

            Console.WriteLine($"Строка которую мы получили и перевели в нижний регистр:{newText}");
         
            List<string> list = new List<string>();    
            


            if (String.IsNullOrEmpty(newText))
            {
                return list; // ну пустая строка пришла просто вернули обратно 
            }
            else
            {

                newText = new string(newText.Where(c => !char.IsPunctuation(c)).ToArray()); // удаляем знаки препинания 

                string[] words = newText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // сплитуем по пробелу

                list = words.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList(); // ищем повторения
                                                         
                list.Sort(); // сортируем список

                foreach(string item in list) 
                { 
                    Console.WriteLine($"{item}"); // в консоли можем наблюдать наш красивый список
                }

                
            }
            return list;
        }




    }
}
