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
                year = 2005,
                condition = BookCard.conditions.New
            };
            BookCard bookCard2 = new BookCard()
            {
                ID = 1,
                author = "гоголь",
                title = "мертвые души",
                year = 2002,
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
                year = 2004,
                condition = BookCard.conditions.Spisanie
            };
            BookCard bookCard5 = new BookCard()
            {
                ID = 1,
                author = "pushkin",
                title = "мертвые души",
                year = 2001,
                condition = BookCard.conditions.New
            };


            // клонируем
            Console.WriteLine("интерфейс IClonable:");
            BookCard bookCard6 = (BookCard)bookCard5.Clone();
            bookCard6.getInfo();
            Console.WriteLine();
            Console.WriteLine("СОРТИРОВКА");

            BookCard[] books = {bookCard1,bookCard2,bookCard3,bookCard4,bookCard5};
            Array.Sort(books);
            foreach(BookCard book in books)
            {
                book.getInfo();
            }

            Console.WriteLine("\nкласс наследник:");
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
            Console.WriteLine();
            Console.WriteLine("количество новых: " + BookCard.conditionsNew);
            Console.WriteLine("количество на списание: " + BookCard.conditionsSpisanie);
            Console.WriteLine("количество в хорошем состоянии: " + BookCard.conditionsGood);

            Console.WriteLine();
            Console.WriteLine("перебор через IEnumerable");
            // перебор через IEnumerable
            Library library = new Library(books);
            foreach (BookCard book in library)
            {
                book.getInfo();
            }

            Console.WriteLine();
            Console.WriteLine("перебор через ICollection");
            // ICollection
            Col bxList = new Col();

            bxList.Add(bookCard1);
            bxList.Add(bookCard2);
            bxList.Add(bookCard3);
            bxList.Add(bookCard4);
            bxList.Add(bookCard5);
            bxList.Add(bookCard6);

            bxList.Contains(bookCard6);

            bxList.Remove(bookCard6);

            foreach(BookCard book in bxList)
            {
                book.getInfo();
            }
            Console.ReadKey();
        }
    }
}
