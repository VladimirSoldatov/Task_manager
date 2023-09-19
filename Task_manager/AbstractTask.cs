using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_manager
{
    abstract class AbstractTask
    {
        public AbstractTask()
        {
            name = string.Empty;
            createTime = DateTime.Now;
            description = string.Empty;
            eventTime = DateTime.Now;
        }
        public AbstractTask(string name, DateTime createTime, string description, DateTime eventTime)
        {
            this.name = name;
            this.createTime = createTime;
            this.description = description;
            this.eventTime = eventTime;
        }
        public abstract bool isOutDate();

        public string name;
        public DateTime createTime;
        public string description;
        public DateTime eventTime;
    }

    interface IMeeting
    {
        DateTime beginDate {set;get;}
        DateTime endDate { set;get;}
        List<string> members { set; get; }
        void AddMembers(string people);
    }
    class Meeting:AbstractTask, IMeeting
    {
        public DateTime beginDate { set;get;}   
        public DateTime endDate { set;get;}
        public List<string> members { get; set; }
        public Meeting() : base() { }
        public Meeting(string name, string description, DateTime beginDate, DateTime endDate, List<string> members)
            : base(name,DateTime.Now,description, beginDate.AddMinutes(-15))
        {
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.members = members;
        }
        public void AddMember(string people)
        {
            members.Add(people);
        }
        public void AddrangePeople(string[]people)
        {
            members.AddRange(people);
        }
        public override bool isOutDate()
        {
            return DateTime.Compare(DateTime.Now, eventTime) >0;
        }

        public void AddMembers(string people)
        {
            throw new NotImplementedException();
        }
        public override  string ToString()
        {
            return $"Name: {name}\n" +
                $"Дата создания: {createTime.ToString("dd.MM.yyyy HH:mm")}\n" +
                $"Описание: {description}\n" +
                $"Приглашенные: {getMembers()}\n" +
                $"Дата начала: {beginDate.ToString("dd.MM.yyyy HH:mm")}\n" +
                $"Дата окончания: {endDate.ToString("dd.MM.yyyy HH:mm")}\n" +
                $"Дата оповещения: {eventTime.ToString("dd.MM.yyyy HH:mm")}\n" +
                $"Статус: {getStatus()}";
        }
        string getStatus()
        {
            if(beginDate.CompareTo(DateTime.Now)<0 && endDate.CompareTo(DateTime.Now)>0)
            {
                return "Идет";
            }
            else 
            {
               return "";
            }
        }
        string getMembers()
        {
            string list_members = String.Empty;
            foreach (string member in members)
            {
                list_members += member + ',';
            }
            list_members = list_members.TrimEnd(',');
            return list_members;
        }
    }
    class Event : AbstractTask
    {
        public Event(string name, string description, DateTime eventDate) : base(name, DateTime.Now, description, eventDate) { }

        public override bool isOutDate()
        {
            return DateTime.Compare(DateTime.Now, eventTime) > 0;
        }
        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Дата создания: {createTime.ToString("dd.MM.yyyy HH:mm")}\n" +
                $"Описание: {description}\n" +
                $"Дата оповещения: {eventTime.ToString("dd.MM.yyyy HH:mm")}";
        }
    }
    
}
