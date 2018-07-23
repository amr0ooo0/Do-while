using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int  mySalary = 1000 , incresment = 20, tagetsalary = 2000;
            int i = 0;

            do

            {
                mySalary += incresment;
                i++;
            }
            while (mySalary < tagetsalary);

            float years = i / 12;
            Console.WriteLine("{0}\n{1}", i, years);


            Console.ReadKey();


            



          

        }
    }
}
