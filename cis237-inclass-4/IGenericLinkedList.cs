using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_4
{
    internal interface IGenericLinkedList<Type>
    {
        void AddToFront(Type Data);
        void AddToBack(Type Data);
        Type RemoveFromFront();
        Type RemoveFromBack();

        void Display();

        bool IsEmpty { get; }
        int Size { get; }

    }

}
