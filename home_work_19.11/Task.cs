using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_19._11
{
    enum status
    {
        Назначена,
        В_работе,
        На_проверке,
        Выполнена


    }
    public class Task
    {
        public string discrabtion;
        public DateTime deadline { get; set; }
        public Person reporter { get; set; }
        public Person? assignee { get; set; }
        private string _status;
        private Report _report;
        public string description
        {
            set { description = value; }
            get { return description; }
        }
      
        public string status
        {
            set { _status = value; }
            get { return _status; }
        }
        public Report report
        {
            set { _report = value; }
            get { return _report; }
        }

        public Task(string description, DateTime deadline, Person reporter, Person? assignee, string status, Report report)
        {
            this.description = description;
            this.deadline = deadline;
            this.reporter = reporter;
            this.assignee = assignee;
            this.status = status;
            this.report = report;
        }
    }
}
    


