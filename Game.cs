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
                new Question("What is the recommended minimum length for a strong password?", "a) 4 characters", "b) 6 characters", "c) 8 characters", "d) 10 characters", 'c'),
                new Question("Which of these is a common sign of a phishing email?", "a) Personalized greeting", "b) Spelling mistakes", "c) Sent from your own email", "d) No links included", 'b'),
                new Question("What should you do if you suspect an email is a phishing attempt?", "a) Click the link to verify", "b) Reply to ask", "c) Delete it or report it", "d) Forward it to friends", 'c'),
                new Question("What does 2FA stand for in cybersecurity?", "a) Two-Factor Authentication", "b) File Access Control", "c) Fast Access", "d) Firewall Access", 'a'),
                new Question("Which of the following is considered *not* secure?", "a) Using a password manager", "b) Reusing passwords across sites", "c) Changing passwords regularly", "d) Using complex passwords", 'b'),
                new Question("Which type of malware demands payment to restore your files?", "a) Virus", "b) Worm", "c) Ransomware", "d) Spyware", 'c'),
                new Question("What is the purpose of a firewall?", "a) To cool the CPU", "b) To block unauthorized access", "c) To store passwords", "d) To clean the screen", 'b'),
                new Question("Which action helps prevent phishing attacks?", "a) Clicking unknown links", "b) Ignoring browser warnings", "c) Hovering over links before clicking", "d) Downloading every attachment", 'c'),
                new Question("Which of these is a strong password example?", "a) 12345678", "b) password1", "c) !Q2w#e4R", "d) abcdefg", 'c'),
                new Question("Why should public Wi-Fi be used cautiously?", "a) It's slow", "b) It's expensive", "c) It's insecure", "d) It's private", 'c')

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
