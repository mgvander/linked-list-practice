using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_4
{
    class IntegerLinkedList : IIntegerLinkedList
    {
        // Make node class as an inner class
        protected class Node
        {            
            public int Data { get; set; }
            public Node Next { get; set; }

        }

        // a couple of pointers to the head and tail of the linked list.
        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get
            {

                // To check whether or not it is empty we can check
                // to see if the head pointer is null. If so, there
                // are no nodes in the list, so it must be empty.
                return _head == null;

            }

        }

        public int Size
        {
            get
            {
                return _size;
            }

        }

        // This has a big O of O(1)
        public void AddToBack(int IntegerData)
        {
            // Make a pointer to the tail called oldTail
            Node oldTail = _tail;

            // Make a new node and assign it the tail variable
            _tail = new Node();

            // Asign the data and set the next pointer
            _tail.Data = IntegerData;
            _tail.Next = null;

            // Check to see if the list is empty. If so, make the head
            // point to the same location as the tail
            if (IsEmpty)
            {
                _head = _tail;
            }
            // We need to take the oldTail and make it's next prperty
            // point to the tail that we just created.
            else
            {
                oldTail.Next = _tail;
            }

            // Increment the size
            _size++;

        }

        // This has a big O of O(1)
        public void AddToFront(int IntegerData)
        {
            // Make a new variable to also reference the head of the ist
            Node oldHead = _head;

            // Make a new node and assign it to the head variable
            _head = new Node();

            // Set the data on the new node
            _head.Data = IntegerData;

            // Make the next property of the new node point to the old head
            _head.Next = oldHead;

            // Increment the size of the list
            _size++;

            // Ensure that if we are adding the very first node to the list
            // that the tail will be pointing to the new node we create. But only on first add.
            if (_size == 1)
            {
                _tail = _head;
            }

        }           

        public int RemoveFromBack()
        {
            throw new NotImplementedException();
        }

        // This has a big O of O(1)
        public int RemoveFromFront()
        {
            // If it is empty throw an error
            if (IsEmpty)
            {
                throw new Exception("List is Empty");

            }

            // Let's get the data to return
            int returnData = _head.Data;

            // Move the head pointer to the next in the list.
            _head = _head.Next;

            // Decrease the size
            _size--;

            // Check to see if we just removed the last node from the list
            if (IsEmpty)
            {
                _tail = null;

            }

            // Return the returnData we pull out from the first node.
            return returnData;

        }

        public void Display()
        {
            throw new NotImplementedException();
        }

    }

}
