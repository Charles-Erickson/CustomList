using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
   public class CustomList<T>
    {
        private T[]items =new T[1];

        public void Add(T item)
        {
            items[0] = item;
        }

        public void Remove(T item)
        {

        }
        public string ToString()
        {

        }
        public List<T> Zipper();
    }
}
