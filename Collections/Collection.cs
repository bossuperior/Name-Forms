using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public interface Collection
    {
        void add(Object e);
        void remove(Object e);
        bool contains(Object e);
        bool isEmpty();
        int size();
    }
}