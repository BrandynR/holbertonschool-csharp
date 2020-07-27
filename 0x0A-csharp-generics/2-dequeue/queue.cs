/*using System;


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
}*/
using System;

///<summary>Class for que opperations</summary>
class Queue<T>
{
	//Setting node for queues
	public class Node
	{
		public T value = default(T);
		public Node next = null;

		public Node(T input)
		{
			value = input;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	///<summary>Add new node at the end</summary>
	public void Enqueue(T value)
	{
		Node node = new Node(value);
		if (head == null)
		{
			head = node;
			tail = node;
		}
		else
		{
			tail.next = node;
			tail = node;
		}
		count++;
	}

	///<summary>Add deleting the last node</summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}

	///<summary>Add new node at the end</summary>
	public int Count()
	{
		return count;
	}

	///<summary>Check if its a queue type</summary>
	///<return>returns a Queue type</return>
	public Type CheckType()
	{
		return typeof(T);
	}
}
