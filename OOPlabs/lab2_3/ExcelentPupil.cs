using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    sealed public class ExcelentPupil : Pupil
    {
        public override int GetCurrentGrade()
        {
            Random rand = new Random();
            return rand.Next(4,5);
        }
        public override void Relax()
        {
            Console.WriteLine("Я не умею отдыхать");
        } 
        public override void Study()
        {
            Console.WriteLine("Я отлично учусь");
        }
        public override void Read()
        {
            Console.WriteLine("Я отлично читаю");
        }
        public override void Write()
        {
            Console.WriteLine("Я отлично пишу");
        }
    }
}
