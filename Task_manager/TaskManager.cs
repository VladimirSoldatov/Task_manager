using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_manager
{
    internal class TaskManager
    {

        List<AbstractTask> tasks;

        public TaskManager()
        {
            tasks = new List<AbstractTask>();
        }
        public void AddTask()
        {
            Console.WriteLine("Привет, что хочешь создать: 1 - встреча, 2 - событие");
            string answer = Console.ReadLine();
            if(Int32.TryParse(answer, out int result)
            {
                switch(result)
                {
                    case 1:
                        Console.WriteLine("Введити название");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите описание");
                        string description = Console.ReadLine();
                        Console.WriteLine("Введите дату и время оповещения");

                        break;

                }
            }

        }
        public void DeleteTask();
        public int Length()
        {
            return tasks.Count;
        }
        public AbstractTask this[int index]
        {
            get
            {
                return tasks[index];
            }
        }
    }
}

//IEnumerable
//IComparable
//Sort() по дате события eventDate
//IClonable
//по индексу получать задание