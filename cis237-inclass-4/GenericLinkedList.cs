using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_4
{
    internal class GenericLinkedList<Type> : IGenericLinkedList<Type>
    {
        // Make node class as an inner class
        protected class Node
        {
            public Type Data { get; set; }
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
        public void AddToBack(Type data)
        {
            // Make a pointer to the tail called oldTail
            Node oldTail = _tail;

            // Make a new node and assign it the tail variable
            _tail = new Node();

            // Asign the data and set the next pointer
            _tail.Data = data;
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
        public void AddToFront(Type data)
        {
            // Make a new variable to also reference the head of the ist
            Node oldHead = _head;

            // Make a new node and assign it to the head variable
            _head = new Node();

            // Set the data on the new node
            _head.Data = data;

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

        // the big O for this is O(n)
        // Remove from the back is not as easy. It requires more work due to looping
        public Type RemoveFromBack()
        {
            // Check for empty, throw exception if it is.
            if (IsEmpty)
            {
                throw new Exception("List is empty");

            }

            // Get the return data right off the bat.
            Type data = _tail.Data;

            // Check to see if we are on the last node
            // If so, we can just set the head and tail to null since we want
            // to remove the only node remaining in the list
            if (_head == _tail)
            {
                _head = null;
                _tail = null;

            }
            // Else, we need to traverse the list and stop right before we reach the tail.
            else
            {
                // Create a temporary node to use to 'walk' down the list
                Node current = _head;

                // Keep moving forward until the current.Next is equal to the tail.
                // Keep looping while current.Next != _tail
                while (current.Next != _tail)
                {
                    // Set the current pointer to the current pointer's next node.
                    current = current.Next;

                }

                // I am now in position to do some work.
                // Set the tail to the current position.
                _tail = current;

                // Make the last node that we are removing go away
                // by setting tail's next property to null
                _tail.Next = null;

            }

            // Decrease the size
            _size--;

            // Return the returnData
            return data;

        }

        // This has a big O of O(1)
        public Type RemoveFromFront()
        {
            // If it is empty throw an error
            if (IsEmpty)
            {
                throw new Exception("List is Empty");

            }

            // Let's get the data to return
            Type data = _head.Data;

            // Move the head pointer to the next in the list.
            _head = _head.Next;

            // Check to see if we just removed the last node from the list
            if (IsEmpty)
            {
                _tail = null;

            }

            // Decrease the size
            _size--;

            // Return the returnData we pull out from the first node.
            return data;

        }

        public void Display()
        {
            Console.WriteLine("The list is:");

            // Setup a currentNode to walk the list
            // Start it at the head node
            Node current = _head;

            // Loop through the nodes until we hit null
            // which will signify the end of the list
            while (current != null)
            {
                Console.WriteLine(current.Data);

                // Move to the next node
                current = current.Next;
            }

            Console.WriteLine();

        }

    }

}
