using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape //INHERITANCE
{
    private int sqLength;
    private int sqWidth;
    
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
        Square sq = gameObject.AddComponent<Square>();
        sq.Length = 1;
        sq.Width = 2;
        sqLength = sq.Length;
        sqWidth = sq.Width;
        Debug.Log("Area of Square is " + sq.Length * sq.Width);
    }

    public override void ShapeColor()
    {
        GameObject squareShape = GameObject.CreatePrimitive(PrimitiveType.Cube);
        squareShape.transform.localScale = new Vector2(sqWidth, sqLength);
        squareShape.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

    }
}
