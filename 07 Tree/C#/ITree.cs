using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public interface ITree<T> where T : IComparable<T>
    {
        void Insert(T val);
        void Remove(T val);
        T Search();
    }
}
