

using System;

[Serializable]
public class TestClass
{
    public string name;
    public int age;
    public float height;
    public bool doSmoke;

    public void AgeOneYear()
    {
        age++;
    }
}


[Serializable]
public struct MyVector2
{
    public float x, y;

    public void Normalize()
    {
        // itt megcsin�ljuk a normalize met�dust  �jra (ez m�r l�tezik)
    }
}

public enum Direction { Up, Right, Down, Left }
