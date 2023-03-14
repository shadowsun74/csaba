using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;
    int currentHealth;

    void OnTriggerEnter(Collider other)
    {
        // GameObject go = other.gameObject;  //ezt anno nem vett�k ki, csak most
        // Debug.Log(go.name);

        HealthObject ho = other.GetComponent<HealthObject>(); // am�g a GameObject go m�g nem volt kommentezve, itt a go szerepelt.


 //       Rigidbody rb = other.GetComponentInChildren<Rigidbody>(); //saj�t mag�n n�zn�, ut�na alatta, de ha megtal�lt m�r egyet is, akkor azzal t�r vissza
 //       Rigidbody rb = other.GetComponentInParent<Rigidbody>();

 //       Rigidbody[] rigidbodies = GetComponents<Rigidbody>();       // sz�pen sorban veszi a t�mb�kb�l
 //       Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
 //       Rigidbody[] rigidbodies = GetComponentsInParent<Rigidbody>();

        if (ho != null)
        {
            ho.Damage(damage);
        }
    }
}


