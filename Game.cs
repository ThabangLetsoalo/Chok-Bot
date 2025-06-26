using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Game
    {
        public int score = 0;
        public List<Question> questions = new List<Question>
            {
                new Question("What is the capital of France?", "a) London", "b) Berlin", "c) Paris", "d) Madrid", 'c'),
                new Question("Which planet is known as the Red Planet?", "a) Earth", "b) Mars", "c) Jupiter", "d) Venus", 'b'),
                new Question("What is the largest ocean on Earth?", "a) Atlantic", "b) Indian", "c) Pacific", "d) Arctic", 'c'),
                new Question("What is the chemical symbol for water?", "a) H2O", "b) CO2", "c) O2", "d) HO", 'a'),
                new Question("Who wrote 'Romeo and Juliet'?", "a) Dickens", "b) Shakespeare", "c) Orwell", "d) Austen", 'b'),
                new Question("Which continent is Egypt in?", "a) Asia", "b) Europe", "c) Africa", "d) South America", 'c'),
                new Question("What gas do plants absorb?", "a) Oxygen", "b) Nitrogen", "c) Carbon Dioxide", "d) Hydrogen", 'c'),
                new Question("How many legs does a spider have?", "a) 6", "b) 8", "c) 10", "d) 4", 'b'),
                new Question("Which is the smallest prime number?", "a) 1", "b) 2", "c) 3", "d) 0", 'b'),
                new Question("What color do you get by mixing red and blue?", "a) Purple", "b) Green", "c) Yellow", "d) Orange", 'a')
            };
        
    }

    class Question
    {
        public string Text;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string OptionD;
        public char CorrectAnswer;

        public Question(string text, string a, string b, string c, string d, char correct)
        {
            Text = text;
            OptionA = a;
            OptionB = b;
            OptionC = c;
            OptionD = d;
            CorrectAnswer = correct;
        }
    }
}
