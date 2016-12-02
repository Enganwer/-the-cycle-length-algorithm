using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROBTNPO___The_3n_plus_1_problem
{
    class Program
    {
        int cycle = 1;
        int i = 1;
        public  int checkNum(int x)
        {  
          if (x == 1) {  cycle = i; i = 1; return cycle;  }
                   
      else if (x % 2 == 0) {i++; return checkNum(x = x / 2);}
                    
      else    { i++; return checkNum(x = (3 * x) + 1); }    
        }
        static void Main(string[] args)
        {//inputing in one line 
            string[] tokens = Console.ReadLine().Split(); int i = int.Parse(tokens[0]); int j = int.Parse(tokens[1]);
            int[] res = new int[10000];
            Program my = new Program();
            for (int counter = 0 ; i <= j; counter++ , i++)
            {res[counter] = my.checkNum(i);}

                 Console.WriteLine(res.Max());   Console.ReadKey();
        }
    }
}
