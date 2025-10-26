using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_4
{
    public class DocumentWorker
    {
        virtual public void OpenDocument()
        {
            Console.WriteLine("Документа открыт");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в Pro версии");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение доступно в Pro версии");
        }
    }
}
