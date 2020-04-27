using System;
using System.Collections;
using System.Collections.Generic;

namespace Set
{
    //Set is a generic class!
    class MySet<T>: ICollection<T>
    {
        private List<T> list = new List<T>();

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                //return ((ICollection<T>)list).IsReadOnly;
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (list.Count == 0);
            }
        }

        public void Clear()
        {
            list.Clear();
        }

        //GetEnumerator() helps to implement for-each-loop iteration.
        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection)list).GetEnumerator();
        }

        public bool Contains(T element)
        {
            return list.Contains(element);
        }

        public void CopyTo(T[] a, int index)
        {
            list.CopyTo(a, index);
        }

        public bool Remove(T element)
        {
            return list.Remove(element);
        }

        public void Add(T element)
        {
            if (!list.Contains(element))
            {
                list.Add(element);
            }
        }

        public bool IsSubsetOf(MySet<T> b)
        {
            foreach (var element in this)
            {
                if (!b.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }

        public MySet<T> UnionWith(MySet<T> b)
        {
            var resultSet = new MySet<T>();

            foreach (var element in this)
            {
                resultSet.Add(element);
            }

            foreach (var element in b)
            {
                resultSet.Add(element);
            }

            return resultSet;
        }

        public MySet<T> IntersectWith(MySet<T> b)
        {
            var resultSet = new MySet<T>();

            foreach (var element in this)
            {
                if (b.Contains(element))
                {
                    resultSet.Add(element);
                }
            }

            return resultSet;
        }
    }
}
