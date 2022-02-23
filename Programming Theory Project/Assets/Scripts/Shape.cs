using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private int length;
    private int width;

    public int Length //ENCAPSULATION
    {
        get
        {
            return length;
        }

        set
        {
            if(value >= 1)
            {
                length = value;
            }
        }
    }

    public int Width //ENCAPSULATION
    {
        get
        {
            return width;
        }

        set
        {
            if(value >= 1)
            {
                width = value;
            }
        }
    }
    
    public virtual void Area()
    {
        Debug.Log("The area is the amount of space taken up by a 2D shape.");
    }

    public virtual void ShapeColor()
    {
        //Color and scale
    }
}
