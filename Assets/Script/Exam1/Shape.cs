using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class Shape : MonoBehaviour
{
    public string shapeName;


    public void Init(string init)
    {
        
    }

    public abstract void CalculateArea();

    public void Draw()
    {
        Debug.Log($"Drawing");
    }
    public void Resize()
    {
        Debug.Log("Resizing Shape..");
    }







}

