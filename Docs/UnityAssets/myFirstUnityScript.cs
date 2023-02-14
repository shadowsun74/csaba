using UnityEngine;

public class myFirstUnityScript : MonoBehaviour
{
    void Start() //eredetileg pribate volt, töröltük. Ha start a név, amikor létrejöna komponens, akkor indul
    {
        
        Debug.Log($"Hello I'm {name}"); // a game object nevét írja ki
        Debug.Log("I'm a GameObject");
    }
}
