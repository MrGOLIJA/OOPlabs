using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    public class Pupil
    {
        protected int CurrentGrade;
        virtual public void Study() { }
        virtual public void Read() { }
        virtual public void Write() { }
        virtual public void Relax() { }
        virtual public int GetCurrentGrade() {
            Random rand = new Random();
            return rand.Next(2,5);
        }
    }
}
