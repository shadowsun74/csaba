using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] KeyCode shootKey = KeyCode.Space;
    [SerializeField] GameObject projectilePrototype;
    [SerializeField] float projectileSpopeed = 10;

    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            // Shoot
            GameObject newBullet = Instantiate(projectilePrototype);
            newBullet.transform.position = transform.position;
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();

            rb.velocity = transform.up * projectileSpopeed;
        }
    }
}
