using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class Col : ICollection<BookCard>
    {
        private List<BookCard> books;
        public int Count => books.Count;
        public BookCard this[int index]
        {
            get { return (BookCard)books[index]; }
            set { books[index] = value; }
        }

        public bool IsReadOnly
        { 
            get => false;
        }

        public Col()
        {
            books = new List<BookCard>();
        }

        public void Add(BookCard item)
        {
            if (!Contains(item))
            {
                books.Add(item);
            }
            else
            {
                Console.WriteLine("kjhkjhljk");
            }
        }

        public void Clear()
        {
            books.Clear(); 
        }

        public bool Contains(BookCard item)
        {
            bool found = false;

            foreach (BookCard bx in books)
            {
                // Equality defined by the Box
                // class's implmentation of IEquatable<T>.
                if (bx.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(BookCard[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < books.Count; i++)
            {
                array[i + arrayIndex] = books[i];
            }
        }

        public IEnumerator<BookCard> GetEnumerator()
        {
            return new ColEnum(this);
        }

        public bool Remove(BookCard item)
        {
            return books.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ColEnum(this);
        }
    }
}
