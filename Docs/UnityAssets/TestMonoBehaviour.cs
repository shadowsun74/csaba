using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    [SerializeField] List<TestClass> persons;
    [SerializeField] Direction TestDirection;  

    void Start()
    {

        TestClass person1 = new TestClass();
        person1.name = "Tivadar";
        person1.age = 85;
        person1.height = 170;
        person1.doSmoke = true;

        person1.AgeOneYear();

        Debug.Log(person1.age);

        // --------------

        MyVector2 mv2 = new MyVector2();
        mv2.Normalize();

        Direction dir = Direction.Right;
        dir = Direction.Left;

        // -------------------------------------------------------------


        TestClass personA = new TestClass() { name = "Alad�r" };   // Class
        MyVector2 mvA = new MyVector2() { x = 1, y = 2 };           // Struct

        TestClass personB = personA;
        MyVector2 mvB = mvA;


        personA.name = "J�lia";
        mvA.x = 100;

        Debug.Log(personB.name);     // ???
        Debug.Log(mvB.x);            // ???


    }
}






