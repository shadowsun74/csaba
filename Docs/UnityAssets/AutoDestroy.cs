using UnityEngine;

class AutoDestroy : MonoBehaviour
{
    [SerializeField] float destroyDistance = 100;
    [SerializeField] float destroyTime = 100;

    Vector3 startPos;
    // float startTime;

    void Start()
    {
        startPos = transform.position;
        // startTime = Time.time;

        // Destroy(gameObject, destroyTime);   // KÚsleltetve

        Invoke(nameof(DestroySelf), destroyTime);
    }

    private void Update()
    {
        float currentDistance = Vector3.Distance(startPos, transform.position);
        if (currentDistance > destroyDistance)
        {
            DestroySelf();
        }

        /*
        float age = Time.time - startTime;
        if (age > destroyTime) 
        {
            Destroy(gameObject);
        }
        */
    }

    void DestroySelf()
    {
        // ...
        Destroy(gameObject);
    }
}
