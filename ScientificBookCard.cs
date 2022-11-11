using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class ScientificBookCard : BookCard
    {
        private bool _repeatDate;

        public string direction;

        public override int year
        {
            set
            {
                if (value > 1990 & value < 2022)
                {
                    _year = value;
                    if(value > 2016)
                        _repeatDate = true;
                    else
                        _repeatDate = false;
                }
                else
                {
                    Console.WriteLine("год издания должен быть не раньше 1990 г. и не позже текущего");
                    _year = 0;
                }
            }
            get => _year;
        }


        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("направление: " + direction);
            if (_repeatDate)
                Console.WriteLine("свежая");
            else
                Console.WriteLine("не свежая");
            

        }
    }
}
