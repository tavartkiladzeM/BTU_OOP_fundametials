using UnityEngine;

public class InheritanceScript : MonoBehaviour
{
    B myObject;

    void Start ()
    {
        myObject.LogMe();
    }
}


public class A
{
    public float x;         //x is accesible from anywhere
    private float z;        //z is accesible only from the inside of A
    protected float t;      //t is accesible from any class derived from A

    public void LogMe()     //logs the value of z
    {
        Debug.Log(z);
    }
}

// all public members of A are also members of B
public class B : A
{
    public float y;

    void DoWork()
    {
        t = t + 5;
    }
}

public class C : B
{
    public float k;
}