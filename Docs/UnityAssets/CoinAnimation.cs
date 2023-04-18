using UnityEngine;

class CoinAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AudioSource blinkSound;

    void Update()
    {
        Collector[] collectors = FindObjectsOfType<Collector>();
        float distance = float.MaxValue;

        if (collectors.Length > 0)
        {
            Vector3 pos = transform.position;
            for (int i = 0; i < collectors.Length; i++)
            {
                Collector c = collectors[i];
                float curredntDist =
                    Vector3.Distance(c.transform.position, pos);  // ez volt a , ut�n a 2. �rt�k: transform.position 
                if (curredntDist < distance)
                {
                    distance = curredntDist;
                }
            }

        }


        animator.SetFloat("PlayerDistance", distance);   // AZ�rt volt hiba, mert m�r l�trehoztam egy Animator-t �s az bezavart
    }


    public void Blink()
    {
        blinkSound.Play();

    }
}
