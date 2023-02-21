
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] float bigRange = 15;
    [SerializeField] float smallRange = 10;

    void Update()
    {
        Vector3 selfPosition = transform.position;
        Vector3 targetPosition= target.position;
        
        float distance = Vector3.Distance(selfPosition, targetPosition);

        if (distance <= bigRange)
        {
            float t = Mathf.InverseLerp(bigRange, smallRange, distance);
            float actualSpeed = Mathf.Lerp(0, speed, t);

            transform.position = Vector3.MoveTowards(selfPosition, targetPosition, actualSpeed * Time.deltaTime);
        }

        // Vector3 direction = targetPosition - selfPosition;
        /*
        direction.Normalize();

        Vector3 velocity= direction * speed;

        transform.position = transform.position + velocity * Time.deltaTime;
        */

       

        //nem nulla a vektor, mert ezt nem tudja
        //if (direction != Vector3.zero)
        //transform.rotation = Quaternion.LookRotation(direction);
            // quaternion olyan dolgo ami jól leír a 3d-s térben egy elfordulást
     
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, smallRange);
        Gizmos.DrawWireSphere(transform.position, bigRange);
    }
}
