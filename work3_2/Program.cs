using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work3_2;

namespace NewWork3
{
    class Program
    {
        static void Main(string[] args)
        { try
            {
                string Taskname = "";


                try
                {
                    Taskname = GetTaskname();
                }
                catch (work3_2.EmptyString zeroSumEx)
                {
                    Console.WriteLine(zeroSumEx.Message);
                }
                catch (ArgumentOutOfRangeException ex2)
                {
                    Console.WriteLine($" Возникло исключение {ex2.Message}");
                }
                string TaskDiscription = "";


                try
                {
                    TaskDiscription = GetTaskDescription();
                }
                catch (work3_2.EmptyString zeroSumEx)
                {
                    Console.WriteLine(zeroSumEx.Message);
                }
                catch (ArgumentOutOfRangeException ex2)
                {
                    Console.WriteLine($" Возникло исключение {ex2.Message}");
                }
                int HourTask = 0;


                try
                {
                    HourTask = GetHourTask();
                }

                catch (ArgumentOutOfRangeException ex2)
                {
                    Console.WriteLine($" Возникло исключение {ex2.Message}");
                }

                DateTime Datetask = DateTime.Now.AddMonths(-1);


                try
                {
                    Datetask = GetDatetask();
                }

                catch (MinDate exm)
                {
                    Console.WriteLine($" Возникло исключение {exm.Message}");
                }
                catch (maxDate exmd)
                {
                    Console.WriteLine($" Возникло исключение {exmd.Message}");
                }

                DateTime Endtask = DateTime.Now;


                try
                {
                    Endtask = GetEndtask();
                }

                catch (MinDate exm)
                {
                    Console.WriteLine($" Возникло исключение {exm.Message}");
                }
                catch (Argum exar)
                {
                    Console.WriteLine($" Возникло исключение {exar.Message}");
                }


                Console.WriteLine($"Имя задачи {Taskname}");
                Console.WriteLine($"Описание {TaskDiscription}");
                Console.WriteLine($"Оценка по времени {HourTask}");
                Console.WriteLine($"Дата начала задачи {Datetask}");
                Console.WriteLine($"Дата окончания задачи {Endtask}");
            }

            finally
            {
                Console.WriteLine("Блок finally");
            }
            Console.WriteLine("Конец программы");
            Console.Read();

        }

        private static DateTime GetEndtask()
        {
            {
                Console.Write($"Введите дату окончания задачи: ");
                DateTime Endtask = DateTime.Parse(Console.ReadLine());
                //if (Endtask < DateTime.Now)
                //{
                //    throw new MinDate("Вы ввели дату меньше сегодня");
                //}
                //DateTime Datetask = DateTime.Now.AddMonths(-1);

                DateTime Datetask = DateTime.Now;

                if (Endtask > Datetask)
                {
                    throw new Argum("Вы ввели дату окончания меньше даты начало");
                }
                return Endtask;
            }
        }

        private static DateTime GetDatetask()
        {
            {
                Console.Write($"Введите дату начала задачи: ");
                DateTime Datetask = DateTime.Parse(Console.ReadLine());

                if (Datetask < DateTime.Now)
                {
                    throw new MinDate("Вы ввели дату меньше сегодня");
                }
         
                return Datetask;
            }
        }

        public static string GetTaskname()
            {
                Console.Write($"Введите имя задачи: ");
                var Taskname = Console.ReadLine();

                if (Taskname == "")
                {
                    throw new EmptyString("Вы ввели пустую строку");
                }
            if (Taskname.Length>5)
            {
                throw new ArgumentOutOfRangeException("Вы ввели строку больше 5 символов");
            }
            if (Taskname == " ")
            {
                throw new EmptyString("Вы не ввели название таски");
            }
            return Taskname;
            }

        public static string GetTaskDescription()
        {
            Console.Write($"Введите описание к задаче: ");
            var TaskDiscription = Console.ReadLine();

            if (TaskDiscription == "")
            {
                throw new EmptyString("Вы ввели пустую строку");
            }
            if (TaskDiscription.Length > 20)
            {
                throw new ArgumentOutOfRangeException("Вы ввели строку больше 20 символов");
            }
            if (TaskDiscription == " ")
            {
                throw new EmptyString("Вы не ввели описание задачи");
            }
            return TaskDiscription;
        }

        public static int GetHourTask()
        {
            Console.Write($"Введите оценку на задачу ");
            int HourTask = Int16.Parse(Console.ReadLine());

            if (HourTask>=2)
            {
                throw new ArgumentOutOfRangeException("Вы ввели оценку больше 2 часов");
            }
            if (HourTask==0)
            {
                throw new ArgumentOutOfRangeException("Вы ввели ноль часов");
            }
            return HourTask;
        }
       

    }
}