using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m7_2
{
    /// <summary>
    /// Класс, созданный на уроке.
    /// В контексте моего вопроса о наследовании он не важен
    /// </summary>
    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
