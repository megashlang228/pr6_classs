using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class BookCard
    {
        public static int conditionsGood = 0;
        public static int conditionsNew = 0;
        public static int conditionsSpisanie = 0;
        public int ID { get; set; }
        private string _author;
        public string author
        {
            set
            {
                if (value.Length == 0 || value == " ")
                    Console.WriteLine("имя автора не должно быть пустым");
                else
                    _author = value;
            }
        }

        private string _title;
        public string title
        {
            set
            {
                if (value.Length == 0 || value == " ")
                    Console.WriteLine("название не должно быть пустым");
                else
                    _title = value;
            }
        }

        protected int _year = 0;
        public virtual int year
        {
            set
            {
                if (value > 1990 & value < 2022)
                    _year = value;
                else
                {
                    Console.WriteLine("год издания должен быть не раньше 1990 г. и не позже текущего");
                    _year = 0;
                }
            }
            get => _year;
        }
        private conditions _condition;
        public conditions condition
        {
            set
            {
                switch (value)
                {
                    case conditions.New:
                        conditionsNew++;
                        _condition = value;
                        break;

                    case conditions.Good:
                        conditionsGood++;
                        _condition = value;
                        break;

                    case conditions.Spisanie:
                        conditionsSpisanie++;
                        _condition = value;
                        break;

                }
            }
            get => _condition;

        }

        public enum conditions
        {
            Good,
            New,
            Spisanie
        }

      

        public virtual void getInfo()
        {
            Console.WriteLine("ID: " + ID.ToString());
            Console.WriteLine("автор: " + _author);
            Console.WriteLine("название книги: " + _title);
            Console.WriteLine("год: " + _year.ToString());
            string cond;
            switch (_condition)
            {
                case conditions.New:
                    cond = "новая";
                    break;

                case conditions.Good:
                    cond = "хорошее";
                    break;

                case conditions.Spisanie:
                    cond = "списание";
                    break;
                default:
                    cond = "";
                    break;

            }
            Console.WriteLine("состояние: " + cond);
        }
    }
}
