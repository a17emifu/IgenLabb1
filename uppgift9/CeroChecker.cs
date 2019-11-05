using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift9
{
    class CeroChecker
    {
        int age;
        public CeroChecker(Person person)
        {
            age = person.GetAge();
        }

        public int CeroCalc() 
        {
            if(age>=15)
            {
                return 0; //all
            }
            if ((age<15)&&(age>=11))
            {
                return 1; //11-årsgräns
            }
            if ((age<11)&&(age>=7))
            {
                return 2; //7- årsgräns
            }
            if (age<=7)
            {
                return 3; //barntillåten
            }
           else
            {
                return 4;
            }
        }
    }
}
