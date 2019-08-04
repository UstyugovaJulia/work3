using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Введите Имя задачи");
                string TaskName = Console.ReadLine();
                Console.WriteLine("Дата начала задачи");
                var Datetask = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Дата окончания задачи");
                var Endtask = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Оценка по времени");
                int HourTask = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Описание");
                string TaskDiscription = Console.ReadLine();

                //Random rand = new Random();
                //int i = rand.Next(5);

                Console.WriteLine($"Имя задачи {TaskName}");
                Console.WriteLine($"Дата начала задачи {Datetask}");
                //Console.WriteLine(Datetask1.ToString("##-##-####"));
                Console.WriteLine($"Дата окончания задачи {Endtask}");
                Console.WriteLine($"Оценка по времени {HourTask}");
                Console.WriteLine($"Описание {TaskDiscription}");

                validate(TaskName, HourTask, Datetask, Endtask, TaskDiscription);


            }
            catch (FormatException ex)
            {
                Console.WriteLine($" Возникло исключение {ex.Message}");
            }

            catch (Exception ex1)
            {
                Console.WriteLine($" Возникло исключение {ex1.Message}");
            }

            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();

        }



        public static void validate(string TaskName, int HourTask, DateTime Datetask, DateTime Endtask, string TaskDiscription)
        {
            if (TaskName.Length > 3)
            {
                throw new Exception("Длина строки больше 3 символов");
            }

            if (HourTask > 1)
            {
                throw new Exception("Задача больше 1-го часа");
            }
            if (TaskDiscription.Length > 10)
            {
                throw new Exception("Описание задачи больше 10 символов");
            }
            if (Datetask > Endtask)
            {
                throw new Exception("Дата создания не может быть больше даты окончания");
            }

            if (HourTask < 0)
            {
                throw new Exception("введено отрицательное число");
            }

            if (TaskName == " ")
            {
                throw new Exception("вы не ввели имя таски");
            }
            if (HourTask == 0)
            {
                throw new Exception("время не может быть нуль");
            }

            if (Datetask < DateTime.Now)
            {
                throw new Exception("Дата меньше текущей даты");
            }

        }
    }
}
