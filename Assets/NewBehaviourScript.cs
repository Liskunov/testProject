using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{   
    void Start()
    {
        MyList myList = new MyList();
        myList.Add(1);
        myList.Add(5);
        myList.Insert(1, 3);
        myList.Capacity = 4;
        myList.Remove(3);
        myList.RemoveAt(0);
    }

    void Update()
    {

    }
}
public class MyList
{
    public int[] m_array = new int[4];

    public int Count { get; private set; }

    public int Capacity { get { return 0; } set { } }

    public MyList()
    {
        Count = 0;
        Capacity = 0;
    }

    public MyList(int capacity)
    {
        Capacity = capacity;
        Count = 0;
    }

    public int this[int index] { get { return m_array[index]; } set { m_array[index] = value; } }

    public void Add(int item)
    {
        if (Count == 4)
        {
            return;
        }
        this[Count] = item;
        Count++;
    }

    public void Insert(int index, int item)
    {
        if ((index < 0 || index > Count) && Count >= 4)
        {
            return;
        }
        for (int i = Count; i > index; i--)
        {
            this[i] = this[i - 1];
        }
        this[index] = item;
        Count++;
    }

    public int IndexOf(int item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (this[i] == item)
            {
                return i;
            }
        }
        return -1;
    }

    public bool Remove(int item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (this[i] == item)
            {
                for (int j = i; j < Count - 1; j++)
                {
                    this[j] = this[j + 1];
                }
                this[Count - 1] = 0;
                Count--;
                return true;
            }
        }
        return false;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > Count)
        {
            return;
        }

        for (int i = index; i < Count - 1; i++)
        {
            this[i] = this[i + 1];
        }
        this[Count - 1] = 0;
        Count--;
    }

    public bool Contains(int item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (this[i] == item)
            {
                return true;
            }
        }
        return false;
    }

    public void Clear()
    {
        for (int i = 0; i < Count; i++)
        {
            this[i] = 0;
        }
        Count = 0;
    }
}