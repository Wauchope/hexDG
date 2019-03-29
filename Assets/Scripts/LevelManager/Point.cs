using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Point
{
    private float X, Y, Z;

    public Point(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float GetX()
    {
        return X;
    }

    public float GetY()
    {
        return Y;
    }

    public float GetZ()
    {
        return Z;
    }
}
