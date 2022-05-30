using System;
using System.IO;

namespace Employee_Handbook
{
    class Program
    {
        /// <summary>
        /// Метод для добавления данных в файл
        /// </summary>
        /// <returns></returns>
        public static void InputData()
        {
            using (StreamWriter writerHandbook = new StreamWriter("Employee_Handbook.txt", true))
            {
                string handbook = string.Empty;

                Console.Clear();
                Console.Write("Введите ID сотрудника: ");
                handbook += $"{Console.ReadLine()}#";

                string data = DateTime.Now.ToShortDateString();
                handbook += $"{data} ";
                string time = DateTime.Now.ToShortTimeString();
                handbook += $"{time}#";

                Console.Clear();
                Console.Write("Введите Ф.И.О. сотрудника: ");
                handbook += $"{Console.ReadLine()}#";

                Console.Clear();
                Console.Write("Введите возраст сотрудника: ");
                handbook += $"{Console.ReadLine()}#";

                Console.Clear();
                Console.Write("Введите рост сотрудника: ");
                handbook += $"{Console.ReadLine()}#";

                Console.Clear();
                Console.Write("Введите дату рождения сотрудника: ");
                handbook += $"{Console.ReadLine()}#";

                Console.Clear();
                Console.Write("Введите место рождения сотрудника: ");
                handbook += $"{Console.ReadLine()}";

                writerHandbook.WriteLine(handbook);                               
                
            }
            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмити любую клавишу");
            Console.ReadKey();
            Console.Clear();
            StartProgram();
        }

        /// <summary>
        /// Метод для чтения файла и вывода данных консоль
        /// </summary>
        public static void ReadData()
        {

            if (File.Exists("Employee_Handbook.txt") == true)
            {
                using (StreamReader readHandbook = new StreamReader("Employee_Handbook.txt"))
                {
                    string line;
                    Console.Clear();
                    Console.WriteLine($"{"ID",2}{"Дата и время добавления",25}{"ФИО",28}{"Возраст",9}{"Рост",6}{"Дата рождения",15}{"Место рождения",20}");

                    while ((line = readHandbook.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],2}{data[1],25}{data[2],28}{data[3],9}{data[4],6}{data[5],15}{data[6],20}");
                    }
                }
                Console.WriteLine("Для продолжения нажмити любую клавишу");
                Console.ReadKey();
                Console.Clear();
                StartProgram();

            }
            else
            {
                Console.WriteLine("Файл не найден! Добавте данные сотрудника, что бы создать файл.");
                Console.ReadKey();
                Console.Clear();
                StartProgram();
            }
        }

        /// <summary>
        /// Метод запускающий начало программы
        /// </summary>
        public static void StartProgram()
        {
            Console.WriteLine("Для вывода справочника введите 1, для добавления данных введите 2:");
            string flag = Console.ReadLine();

            if (flag == "1")
            {
                ReadData();
            }
            if (flag == "2")
            {
                InputData();
            }
            else
            {
                Console.WriteLine("Ошибка! Для продолжения нажмити любую клавишу");
                Console.ReadKey();
                Console.Clear();
                StartProgram();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            StartProgram();
        }
    }
}
