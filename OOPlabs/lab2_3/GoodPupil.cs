using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    sealed public class GoodPupil : Pupil
    {
        public override int GetCurrentGrade()
        {
            Random rand = new Random();
            return rand.Next(3, 5);
        }
        public override void Study()
        {
            Console.WriteLine("Я учусь хорошо");
        }
        public override void Read()
        {
            Console.WriteLine("Я читаю хорошо");
        }
        public override void Write()
        {
            Console.WriteLine("Я пишу хорошо");
        }
    }
}
