using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    public class GenericQueue<T>
    {
        public T[] Queue;
        public int front=-1;
        public int rear=-1;
        public int size;
        public GenericQueue(int size) 
        {
            this.size = size;
            Queue = new T[size];
        }


        public void Enqueue(T a)
        {

            if (rear + 1 == size)
            {
                Console.WriteLine("Overflow");
                return;
            }

            else
            {
                if (rear==-1 && front == -1)
                {
                    rear = 0;
                    front = 0;
                } else
                {
                    rear++;
                }

                Queue[rear] = a;
            }

        }

        public T Dequeue()
        {
            T a;
            if (front>rear || rear == -1)
            {
                Console.WriteLine("Queue Empty");
                return default(T);

            } else
            {
                a = Queue[front];
                if (front == rear)
                {
                    rear = -1;
                    front = -1;
                } else
                {
                    front++;
                }

                return a;

            }

        }

      

        public bool IsFull()
        {
            if (rear==size-1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsEmpty()
        {
            if (front == rear)
            {
                return true;
            } else
            {
                return false;
            }
        }


    }
}
