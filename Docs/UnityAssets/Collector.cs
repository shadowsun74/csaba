using UnityEngine;

public class Collector : MonoBehaviour
{
     int collected = 0;
   // int currentHealth;

    void OnTriggerEnter(Collider other)
    {
        Collectable c = other.GetComponent<Collectable>();

        if (c != null)
        {
            collected += c.GetValue();
            Debug.Log(collected);

            c.Teleport();
        }
    }


}
