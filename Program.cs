using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCard bookCard1 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.New
            };
            bookCard1.getInfo();
            BookCard bookCard2 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.Good
            };
            BookCard bookCard4 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.Good
            };
            BookCard bookCard3 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.Spisanie
            };
            BookCard bookCard5 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.New
            };
           

            ScientificBookCard scientificCard = new ScientificBookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2003,
                condition = BookCard.conditions.New,
                direction = "химия"
            };
            scientificCard.getInfo();

            Console.WriteLine("количество новых: " + BookCard.conditionsNew);
            Console.WriteLine("количество на списание: " + BookCard.conditionsSpisanie);
            Console.WriteLine("количество в хорошем состоянии: " + BookCard.conditionsGood);



            Console.ReadKey();
        }
    }
}
