using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class LibraryEnum :IEnumerator
    {
        public BookCard[] _books;

        int position = -1;

        public LibraryEnum(BookCard[] list)
        {
            _books = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _books.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public BookCard Current
        {
            get
            {
                try
                {
                    return _books[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
