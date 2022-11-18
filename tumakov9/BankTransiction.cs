using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov9
{
    public class BankTransiction
    {
        readonly DateTime data = DateTime.Now;
        readonly decimal summ;
        public BankTransiction(decimal summ)
        {
            this.summ = summ;
        }
        public void Print()
        {
            Console.WriteLine($"Date : {data}\n Summa :{summ}\n");
        }
    }
}
