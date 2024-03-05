/// Author: Michael VanderMyde
/// Course: CIS 237
/// Inclass 4

using System;

namespace cis237_inclass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkedList integerLinkedList = new IntegerLinkedList();

            integerLinkedList.AddToFront(3);
            integerLinkedList.AddToFront(2);
            integerLinkedList.AddToFront(1);
            integerLinkedList.AddToBack(4);
            integerLinkedList.AddToBack(5);
            integerLinkedList.AddToBack(6);

            integerLinkedList.Display(); // Should be 1, 2, 3, 4, 5, 6

            integerLinkedList.RemoveFromFront();
            integerLinkedList.RemoveFromFront();
            integerLinkedList.RemoveFromBack();

            integerLinkedList.Display(); // Should be 3, 4, 5

            // Now do the same with the generic verison (the variable is called genricLinkedList
            // because integerLinkedList is already taken, up above)
            IGenericLinkedList<int> genericLinkedList = new GenericLinkedList<int>();

            genericLinkedList.AddToFront(3);
            genericLinkedList.AddToFront(2);
            genericLinkedList.AddToFront(1);
            genericLinkedList.AddToBack(4);
            genericLinkedList.AddToBack(5);
            genericLinkedList.AddToBack(6);

            genericLinkedList.Display(); // Should be 1, 2, 3, 4, 5, 6

            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromFront();
            genericLinkedList.RemoveFromBack();

            genericLinkedList.Display(); // Should be 3, 4, 5

            // Some examples of types that we want the GenericLinkedList to store.

            // Here is one that stores strings
            IGenericLinkedList<string> stringLinkedList = new GenericLinkedList<string>();

            // Here is one that stores doubles
            IGenericLinkedList<double> doubleLinkedList = new GenericLinkedList<double>();

            // One that stores generic linked lists of integer type.
            IGenericLinkedList<GenericLinkedList<int>> inception = new GenericLinkedList<GenericLinkedList<int>>();

        }
    }
}
