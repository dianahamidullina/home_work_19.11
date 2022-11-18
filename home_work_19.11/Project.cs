using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_19._11
{
    internal class Project
    {


        private string _description;
        private DateTime _deadline;
        private Person _reporter;
        private Person _teamlead;
        private List<Task> _tasks;
        private string _status;

        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        public DateTime deadline
        {
            set { _deadline = value; }
            get { return _deadline; }
        }
        public Person reporter
        {
            set { _reporter = value; }
            get { return _reporter; }
        }
        public Person teamlead
        {
            set { _teamlead = value; }
            get { return _teamlead; }
        }
        public List<Task> tasks
        {
            set { _tasks = value; }
            get { return _tasks; }
        }
        public string status
        {
            set { _status = value; }
            get { return _status; }
        }

        public Project(string description, DateTime deadline, Person reporter, Person teamlead, List<Task> tasks, string status)
        {
            this.description = description;
            this.deadline = deadline;
            this.reporter = reporter;
            this.teamlead = teamlead;
            this.tasks = tasks;
            this.status = status;
        }

    }
}

}
