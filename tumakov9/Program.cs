using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tumakov9.Shet2;

namespace tumakov9
{
    enum Shet
    {
        tekushie,
        sberegateln
    }
    class Shet2
    {
        private System.Collections.Queue Queue;
        public int shetnum { get; set; }
        public double balance { get; set; }
        public Shet Type { get; set; }
        
        public Shet2(double balance)
        {

            this.balance = balance;
            ShetNum();

        }
        public Shet2(double balance, Shet Type) : this(balance)
        {

            this.balance = balance;
            this.Type = Type;
            ShetNum();
        }        
        public void ShetNum()
        {
            Guid ID;
            ID = Guid.NewGuid();
            Console.WriteLine(ID);
        }

        public void Polozit(int sum)
        {
            Console.WriteLine(sum + balance); ;
            Queue.Enqueue(new BankTransiction(sum));

        }
        public void Snyat( int summoney)
        {
           
           if( balance -summoney>0 )
            {
                double itog = balance - summoney;
                Console.WriteLine($"Your balance after transiction- {itog}");
            }
            else
            {
                Console.WriteLine("Try again");
            }
            Queue.Enqueue(new BankTransiction(summoney));
        }
        public void Dispose()
        {
            foreach (var item in Queue)
            {
                StreamWriter z = new StreamWriter("C:\\Users\\Diana\\source\\repos\\home_work_19.11\\tumakov9\\TextFile1.txt");
                    z.WriteLine(item.ToString());
            }
            GC.SuppressFinalize(this);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //9.1
            Shet2 balance1 = new Shet2(3564654);
            Shet2 type = new Shet2(3564654, Shet.tekushie);
            Console.WriteLine($"Balance - {balance1} , Shetnum and Balance - {type}");
            //9.2
            Shet2 method = new Shet2(6546878);
            method.Polozit(65487);
            method.Snyat(65468);
            //9.3
            method.Dispose();
            //9.1DZ
            Songs mySong = new Songs();//where is mistake?

        }
    }
}
