using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape //INHERITANCE
{
    
    // Start is called before the first frame update
    void Start()
    {
        Area();
        ShapeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Area()
    {
        Length = 1;
        Width = 2;
        Debug.Log("Area of Square is " + Length * Width);
        
        
    }

    public override void ShapeColor()
    {
        gameObject.transform.localScale = new Vector2(Width, Length);
        gameObject.GetComponent<Renderer>().material.color = Color.red;

    }
}
