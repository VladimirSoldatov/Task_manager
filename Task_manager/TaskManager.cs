using System;
using System.Collections.Generic;
using System.Linq;
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
        public void addGroupTask(Array groupArray)
        {
            foreach(AbstractTask task in groupArray) 
            {
                tasks.Add(task);
            }
            
        }
        public void AddTask()
        {
            Console.WriteLine("Привет, что хочешь создать: 1 - встреча, 2 - событие");
            string answer = Console.ReadLine();
            if(Int32.TryParse(answer, out int result))
            {
                switch(result)
                {
                    case 1:
                        Console.WriteLine("Введити название");
                        string name_meeting = Console.ReadLine();
                        Console.WriteLine("Введите описание");
                        string description_meeting = Console.ReadLine();
                        Console.WriteLine("Введите дату и время начала");
                        string str_beginDate_meeting = Console.ReadLine();
                        Console.WriteLine("Введите дату и время окончания");
                        string str_endDate_meeting = Console.ReadLine();
                        Console.WriteLine("Введите список участников");
                        string members = Console.ReadLine();
                        DateTime.TryParse(str_beginDate_meeting, out DateTime beginDate);
                        DateTime.TryParse(str_endDate_meeting, out DateTime endDate);
                        tasks.Add(new Meeting(name_meeting, description_meeting, beginDate, endDate, members.Split(new char[] { ' ' }).ToList()));
                        break;
                    case 2:
                        Console.WriteLine("Введити название");
                        string name_event = Console.ReadLine();
                        Console.WriteLine("Введите описание");
                        string description_event = Console.ReadLine();
                        Console.WriteLine("Введите дату и время оповещения");
                        string evendDate_event = Console.ReadLine();
                        DateTime.TryParse(evendDate_event, out DateTime event_date);
                        tasks.Add(new Event(name_event, description_event,event_date));
                        break;


                }
            }

        }
      //  public void DeleteTask();
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