using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    sealed public class BadPupil : Pupil
    {
        public override int GetCurrentGrade()
        {
            Random rand = new Random();
            return rand.Next(2, 3);
        }
        public override void Read()
        {
            Console.WriteLine("Я плохо читаю");
        }
        public override void Write()
        {
            Console.WriteLine("Я плохо пишу");
        }
        public override void Study()
        {
            Console.WriteLine("Я вообще не хочу учиться");
        }
        public override void Relax()
        {
            Console.WriteLine("А отдыхать я люблю");
        }
    }
}
