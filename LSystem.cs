using System;
using System.Collections.Generic;
using System.Text;

namespace Lindenmayer_System
{
    class LSystem
    {
        private string Word;
        private string Rule;

        public LSystem( string rule, string word)
        {
            Rule = rule;
            Word = word;
        }
        public string Generate()
        {
            var newWord = "";
            for (int a = 0; a < Word.Length; a++)
            {
                if (Word[a] == 'D')
                {
                    newWord += Rule;
                    //DrawCalculator(newWord, count);
                }
                else newWord += Word[a];
            }
            GetSetWord = newWord;
            return newWord;
        }
        public string GetSetWord
        {
            get => Word;
            set 
            {
                Word = value;
            } 
        }
    }
}
