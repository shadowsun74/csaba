using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;
    int currentHealth;

    void OnTriggerEnter(Collider other)
    {
        // GameObject go = other.gameObject;  //ezt anno nem vettük ki, csak most
        // Debug.Log(go.name);

        HealthObject ho = other.GetComponent<HealthObject>(); // amíg a GameObject go még nem volt kommentezve, itt a go szerepelt.


 //       Rigidbody rb = other.GetComponentInChildren<Rigidbody>(); //saját magán nézné, utána alatta, de ha megtalált már egyet is, akkor azzal tér vissza
 //       Rigidbody rb = other.GetComponentInParent<Rigidbody>();

 //       Rigidbody[] rigidbodies = GetComponents<Rigidbody>();       // szépen sorban veszi a tömbökbõl
 //       Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
 //       Rigidbody[] rigidbodies = GetComponentsInParent<Rigidbody>();

        if (ho != null)
        {
            ho.Damage(damage);
        }
    }
}


