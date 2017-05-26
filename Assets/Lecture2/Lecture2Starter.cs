using UnityEngine;

public class Lecture2Starter : MonoBehaviour
{
    A myVariable;
    Shape myShape;
    Rectangle myRect;
    Triangle myTriangle;

	void Start ()
    {
        myTriangle = new Triangle();
        myShape = myTriangle;

        Debug.Log( myShape.GetArea() );

        //myTriangle = new Triangle();
        //Debug.Log( myTriangle.GetArea() );

        //myRect = new Rectangle();
        //Debug.Log( myRect.GetArea() );

        //myShape = new Shape(5, 9);
        //Debug.Log(myShape.width + " " + myShape.height);

        // myVariable = new A();
        // myVariable.z = 5;
        // Debug.Log(myVariable.z);
    }
}

public class A
{
    public A()
    {
        x = 5;
        z = 7;
        k = 0.8f;
    }

    public int x;
    public int z;
    public float k;
}



// 1
// შექმენით ახალი კლასი სახელად Shape რომელსაც აქვს 2 ცვლადი:
// ინტეჯერის ტიპის width
// და ინტეჯერის ტიპის height

// 2
// შექმენით Shape-ის ტიპის ახალი ობიექტი Shape() კონსტრუქტორის გამოყენებით
// კონსტრუქტორში width და height-ს მიანიჭეთ თავდაპირველი მნიშვნელობა

// 3
// დალოგეთ ახლად შექმნილი ობიექტის width და height

public class Shape
{
    public int width;
    public int height;
    
    public Shape(int a, int b)
    {
        width = a;
        height = b;
    }

    public Shape()
    {
        width = 5;
        height = 5;
    }

    public virtual int GetArea()
    {
        return 0;
    }
}

public class Rectangle : Shape
{
    public int area;

    public Rectangle()
    {
        area = width * height;
    }

    public override int GetArea()
    {
        return width * height;
    }
}

public class Triangle : Shape
{
    public override int GetArea()
    {
        return width * height / 2;
    }
}