using System;


/// <summary>Class that stores a queue of objects of same type.</summary>
class Queue<T>
{
    /// <summary>new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value.</summary>
    public class Node
{
    public T value;
    public Node next = null;
       
    public Node(T value) {
        this.value = value;
    }
}

/// <summary>Pointer to head of queue.</summary>
public Node head;

/// <summary>Pointer to tail of queue.</summary>
public Node tail;


/// <summary>Number of nodes in queue.</summary>
public int count = 0;

    /// <summary>Returns type stored.</summary>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>Adds new element to tail of queue.</summary>
       public void Enqueue(T value) {
        Node node;

        node = new Node(value);
        if (this.head == null)
            this.head = node;
        if (this.tail != null)
            this.tail.next = node;
        this.tail = node;
        this.count++;
    }
 /// <summary>Returns number of nodes in queue.</summary>
    public int Count() {
        return this.count;
    }
///<summary>Removes first node from queue.</summary>
    public T Dequeue()
    {
       Node node;

        if (this.head == null) {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        node = this.head;
        this.head = node.next;
        this.count -= 1;
        return (node.value);
    }
}
