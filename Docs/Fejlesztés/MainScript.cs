using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    public int maxNumbers = 10;
    public List<int> uniqueNumbers;
    public List<int> finishedList;
    public int p1c1;

    // Start is called before the first frame update
    void Start()
    {
        uniqueNumbers = new List<int>();
        finishedList = new List<int>();
        GenerateRandomList();
        p1c1 = (finishedList[0]);

        GameObject a2 = GameObject.Find("P1Card1Front");
        Debug.Log(a2.name);

        //1 // var texture = Resources.Load<Material>("Assets/Materials/0");
        //1 // a2.GetComponent<MeshRenderer>().material = texture;
        //1 // a2.GetComponent<Renderer>().material = texture;

        // var + 4 //var texture = Resources.Load<Material>("Materials/0");
        // var + 2 //Material texture = (Material)Resources.Load("Materials\0") as Material;
        // var + 3 //Material texture = Resources.Load<Material>("Materials\0") as Material;

        // 5 //
        Renderer rend = a2.GetComponent<Renderer>();
        // 5 //
        rend.material.mainTexture = Resources.Load("0") as Texture;

        Renderer _rend = a2.GetComponent<Renderer>();
        //Material _mat = _rend.material;
        //make sure face2 is in Assets/Resources  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        _rend.material.mainTexture = Resources.Load("0") as Texture;
        //_mat.color = Color.blue;

        // var 2 és 3 is // a2.GetComponent<MeshRenderer>().material = texture;


    }

    public void GenerateRandomList()
    {
        for (int i = 0; i < maxNumbers; i++)
        {
            uniqueNumbers.Add(i);
        }
        for (int i = 0; i < maxNumbers; i++)
        {
            int ranNum = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
            finishedList.Add(ranNum);
            uniqueNumbers.Remove(ranNum);
        }

    }

    void DebugList()
    {

     //  foreach (int s in uniqueNumbers)
     //  {
     //       Debug.Log(s);
     //   }



    }


    // Update is called once per frame
    void Update()
    {
     //   Debug.Log();
    
    }
}
