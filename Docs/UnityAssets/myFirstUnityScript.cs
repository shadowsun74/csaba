using UnityEngine;

public class myFirstUnityScript : MonoBehaviour
{
    void Start() //eredetileg pribate volt, t�r�lt�k. Ha start a n�v, amikor l�trej�na komponens, akkor indul
    {
        
        Debug.Log($"Hello I'm {name}"); // a game object nev�t �rja ki
        Debug.Log("I'm a GameObject");
    }
}
