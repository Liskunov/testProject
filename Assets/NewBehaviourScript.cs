using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MyClass
{
    public int i;
    public int j;
}

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = 0;
        float f = 0;
        double d = 0;

        object o = d;
        double d2 =(double)o;

        i = (int)l;
        l = i;

        TestFunc(out i);
        Debug.Log(i);
        int i3;
        MyClass mc = new MyClass();
        TestFunc(mc);
    }

    public void TestFunc(ref int i)
    { 
        i = 10;
    }

    public void TestFunc(MyClass mc)
    {

    }

}




public class MyList
{
    private int[] m_array = new int[4];

    public int count { get; }
    public void Push(int i)
    {



    }

    public int Index0f(int item) 
    {

        return 
    }
}
