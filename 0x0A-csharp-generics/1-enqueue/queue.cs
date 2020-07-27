using System;


/// <summary>within Queue T, create a public class called Node.</summary>
class Queue<T>
{
    public class Node
{
    public T value;
    /// <summary>Pointer to the next node in our queue.</summary>
    public Node next = null;
       /// <summary>Creates a new node with given element as value for a new Node.</summary>
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

    /// <summary>Returns type of T parameter.</summary>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>Adds new element to the tail of the queue.</summary>
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
 /// <summary>Returns the number of nodes in the queue.</summary>
    public int Count() {
        return this.count;
    }
}