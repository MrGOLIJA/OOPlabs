using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_3
{
    public class Programm
    {
        public static void Main(string[] args) {       
            BadPupil badPupil = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();
            ExcelentPupil excelentPupil = new ExcelentPupil();
            BadPupil badPupil1 = new BadPupil();
            GoodPupil goodPupil1 = new GoodPupil();
            ClassRoom room = new ClassRoom(badPupil,badPupil1,goodPupil,goodPupil1,excelentPupil);
            Console.WriteLine(room.GetRoundGrade().ToString());
        }
    }
}
