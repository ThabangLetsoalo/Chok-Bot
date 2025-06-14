using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Utilities
    {

        public static void TypeEffect(string message, int delay = 50)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void Greeting()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SoundPlayer sp = new SoundPlayer(@"C:\Users\choki\source\repos\CSABApp\CSABApp\bin\Debug\greetings.wav");
            sp.Play();
            Thread.Sleep(5000);

        }//end of greeting


    }
}
