using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event firstEvent = new Event("Встреча с группой П11", "Проведение занятия, проверка ДЗ", DateTime.Parse("2023-09-19 18:30:00"));
            Event checkDZ = new Event("Проверка домашних заданий", "Проверка ДЗ по C++", DateTime.Parse("2023-09-20"));
            Meeting meeting = new Meeting("Встреча с группой П11", "Беседа",DateTime.Parse("2023-09-19 18:30"), DateTime.Parse("2023-09-19 21:20"),new string[] {"Елисеев, Голубцов, Колотов, Федоров, Курятков, Солдатов" }.ToList());
            AbstractTask[] tasks = { firstEvent, checkDZ, meeting };
            foreach(AbstractTask task in tasks)
            {
                Console.WriteLine(task);
                Console.WriteLine();
            }
        }
    }
}
