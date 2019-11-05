using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift7
{
    class Calc
    {
        List<int> divlist;
        int numOne,numTwo;

        public int rest { get; set; }
        public int counter { get; set; }

        public void SetNum(int numone, int numtwo)
        {
            numOne = numone;
            numTwo = numtwo;
        }
        public void ListMaker()
        {
            divlist = new List<int>();
            int numForList = numTwo;
            while(numForList > 0)
            {
                    divlist.Add(0);
                    numForList = numForList -1 ;
            }
        }

        public void DivCalc()
        {
            counter =0;
            while (numOne > numTwo) 
            {
                counter++;
                foreach (var item in divlist)
                {
                    rest =numOne - 1;
                    numOne = numOne-1;
                }
            }

        }
       
    }
}
