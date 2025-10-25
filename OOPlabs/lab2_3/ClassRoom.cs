using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    public class ClassRoom
    {
        private static int countPupil;
        private ArrayList Pupils = new ArrayList();
        public double GetRoundGrade()
        {
            int TotalGrade = 0;
            foreach (Pupil p in Pupils)
            {
                TotalGrade += p.GetCurrentGrade();
            }
            return (double)TotalGrade/countPupil;
        }
        public ClassRoom(params Pupil[] pupils )
        {
            foreach( Pupil p in pupils)
            {
                countPupil++;
                Pupils.Add(p);
            }
        }
    }
}
