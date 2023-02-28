using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;
    int currentHealth;

    void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        // Debug.Log(go.name);

        HealthObject ho = go.GetComponent<HealthObject>();

        if (ho != null)
        {
            ho.Damage(damage);
        }
    }
}


