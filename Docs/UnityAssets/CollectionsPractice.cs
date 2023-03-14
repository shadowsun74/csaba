using System.Collections.Generic;
using UnityEngine;

class CollectionsPractice : MonoBehaviour
{
    [SerializeField] int[] intArraySetting;
    [SerializeField] string[] stringArraySetting;
    [SerializeField] GameObject[] gameObjectArraySetting;

    [SerializeField] List<string> stringList;

    [SerializeField] int[][] arrayOfArraies;   // NEM M�K�DIK
    [SerializeField] int[,] matrix;            // NEM M�K�DIK

    void Start()
    {

        int a = 67;

        int[] intArray = new int[10];   // 10 elemsz�m
        string[] stringArray = { "Alma", "K�rte", "Barack" };

        intArray[2] = 15;

        int element = intArray[5];

        // int e2 = intArray[10];  // ERROR

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = i + 1;
        }

        for (int i = 0; i < gameObjectArraySetting.Length; i++)
        {
            Debug.Log(gameObjectArraySetting[i].name);
        }

        char myFirstChar = '*';
        string s = "B�rmi";
        char[] chars = s.ToCharArray();
        string s2 = new string(chars);

        string s3 = s.Substring(s.Length / 2, s.Length / 2);
        string s4 = s.Replace("�", "a");

        string s5 = s.Replace(".", "");

        string s6 = s.ToLower();
        string s7 = s.ToUpper();
        bool contains = s.Contains("�rm");  // true
        int indexOf = s.IndexOf("�rm");     // 1

        // -------------------------------------------------------

        List<int> ints = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            ints.Add(i * i);
        }

        Debug.Log(ints.Count);

        for (int i = 0; i < ints.Count; i++)
        {
            Debug.Log(ints[i]);
        }

        List<string> strings = new List<string> { "Alma", "K�rte", "Ban�n" };

        bool succes = strings.Remove("K�rt�t");  // false
        strings.RemoveAt(2);                     // 2-es indexen t�r�l

        strings.Sort();
        strings.Insert(1, "1111235436");

        string sss = strings[2];
        strings.RemoveAt(2);
        strings.Insert(2, sss);

        strings.Clear();


    }
}

// ----------------------------------------------------