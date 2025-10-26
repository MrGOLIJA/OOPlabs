using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_4
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Доккумент отредактирован");
        }   
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, для сохранения в новом, используйте версию Expert");
        }
    }
}
