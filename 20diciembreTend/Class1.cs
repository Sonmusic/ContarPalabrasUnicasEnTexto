using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _20diciembreTend
{
    public class Texto
    {
        public string texto;
        public Texto(string text)
        {
            texto = text;
        }
        public int CountDifferentWords()
        {
            List<string> list = texto.Split(',', ' ').ToList();
            List<string> listResult = new List<string>();
            foreach (var word in list)
            {
                var wordLower = word.ToLower();
                if (listResult.Contains(wordLower.ToLower()))
                {

                }
                else
                {
                    listResult.Add(wordLower);
                }
            }

                if (listResult == null)
                {
                    throw new InvalidOperationException();
                }


            return listResult.Count;
        }

      

    }
}
