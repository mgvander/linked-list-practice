/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_4
{
    internal interface IIntegerLinkedList
    {
        void AddToFront(int IntegerData);
        void AddToBack(int IntegerData);
        int RemoveFromFront();
        int RemoveFromBack();

        void Display();

        bool IsEmpty { get; }
        int Size { get; }

    }

}
