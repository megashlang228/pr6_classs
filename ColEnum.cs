using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6
{
    internal class ColEnum : IEnumerator<BookCard>
    {
        private Col col;
        private int curIndex;
        private BookCard current;
        
        public BookCard Current
        {
            get => current;
        }

        object IEnumerator.Current
        {
            get => Current;
        }

        public ColEnum(Col collection)
        {
            col = collection;
            curIndex = -1;
            current = default(BookCard);
        }

        public bool MoveNext()
        {
            //Avoids going beyond the end of the collection.
            if (++curIndex >= col.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                current = col[curIndex];
            }
            return true;
        }

        public void Reset() { curIndex = -1; }

        void IDisposable.Dispose() { }

    
    }
}
