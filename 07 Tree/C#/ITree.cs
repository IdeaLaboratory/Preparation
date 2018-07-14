using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    public interface ITree
    {
        void Insert(int val);
        void Remove(int val);
        int Search();
    }
}
