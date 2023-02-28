using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField, Min(1)] int maxHealth = 100;

    public int currentHealth; // ez itt az új

    void Start()
    {
        currentHealth = maxHealth;
    }

   public bool IsAlive()
    { 
        return currentHealth > 0; 
    }

    public void Damage(int damage)
    {
       //  currentHealth -= damage;

        if (currentHealth == 0) return; // jvaasolt először a nem megyünk tovább, 4-5 felttel, hoigy ne is fusson, ha a feltétel jó-rossz

        currentHealth = Mathf.Max(currentHealth, 0); // ezzzel egy sorba bele tudjuk tenni if helyett

        if (currentHealth <= 0)
        {
    
   
            Debug.Log("Good By!");
        }
            
        
        // Debug.Log("Aucs!");
    }
}

