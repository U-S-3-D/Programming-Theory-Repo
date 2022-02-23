using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape //INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        Area(); //ABSTRACTION
        ShapeColor(); //ABSTRACTION
    }

    public override void Area() //POLYMORPHISM
    {
        Length = 2;
        Width = 2;
        Debug.Log("Area of Circle is " + Length * Width * Mathf.PI);
        
        
    }

    public override void ShapeColor() //POLYMORPHISM
    {
        gameObject.transform.localScale = new Vector3(Width, Length, 1);
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }
}
