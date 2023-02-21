
using UnityEngine;


public class autoRotator : MonoBehaviour
{
    [SerializeField] float angularVelocity = 360;
    [SerializeField] Vector3 axis = Vector3.up;
    [SerializeField] Space rotationSpace;


    void Update()
    {
        Vector3 eiler = new Vector3 (0, angularVelocity, 0);
        eiler *= Time.deltaTime;
        // transform.Rotate(eiler, Space.World);   // self, vagy world 
        // transform.Rotate(eiler, rotationSpace);
         transform.Rotate (axis, angularVelocity * Time.deltaTime, rotationSpace);
    }
    private void OnDrawGizmos()
    {
        Vector3 center = transform.position;

        Vector3 dir;
     //   Vector3 dir = axis.normalized; 

        if (rotationSpace == Space.World)
        {
            dir = axis.normalized;
                }
        else
        {
            dir = transform.TransformDirection(axis).normalized;

        }

        Vector3 a = center + dir * 2;
        Vector3 b = center + dir * 2;
        // Vector3 b = center - axis;
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a, b);
    }

}
