using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlabs.lab2_4
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер ключа для получения доступа к Pro или Expert версии");
            string? NumberKey = Console.ReadLine();

            DocumentWorker worker;

            // Создаем соответствующий экземпляр в зависимости от ключа
            if (NumberKey.Length >= 5 && NumberKey.Length < 10)
            {
                worker = new ProDocumentWorker();
                Console.WriteLine("Активирована Pro версия!");
            }
            else if (NumberKey.Length >= 10 && NumberKey.Length <15)
            {
                worker = new ExpertDocumentWorker();
                Console.WriteLine("Активирована Expert версия!");
            }
            else
            {
                worker = new DocumentWorker();
                Console.WriteLine("Вы в бесплатной версии, вот что вы можете сделать:\n" +
                    "1. Открыть документ\n" +
                    "2. Редактировать документ\n" +
                    "3. Сохранить документ\n" +
                    "4. Выйти\n" +
                    "Остальные функции доступны в версии Pro и выше");
            }

            // Основной цикл программы
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nВыберите действие:");
                if (worker is DocumentWorker && !(worker is ProDocumentWorker))
                {
                    Console.WriteLine("1. Открыть документ");
                    Console.WriteLine("4. Выйти");
                }
                else
                {
                    Console.WriteLine("1. Открыть документ");
                    Console.WriteLine("2. Редактировать документ");
                    Console.WriteLine("3. Сохранить документ");
                    Console.WriteLine("4. Выйти");
                }

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        worker.OpenDocument();
                        break;
                    case "2":
                        worker.EditDocument();
                        break;
                    case "3":
                        worker.SaveDocument();
                        break;
                    case "4":
                        isRunning = false;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
