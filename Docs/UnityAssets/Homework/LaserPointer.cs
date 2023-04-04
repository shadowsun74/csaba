using UnityEngine;

public class LaserPointer : MonoBehaviour
{

    [SerializeField] Transform[] points;            // lehetne t�mb is, vagy lista, �gy nem kell gameobect.transform.position, hanem el�g lesz a transform.position

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.up;

        Ray ray = new Ray(origin, direction);                           // �gy is lehet

        //Ray ray = new Ray();                                          // vagy �gy �s ut�lag t�lj�k fel a k�v 2 sorral
        //ray.origin = origin;
        //ray.direction = direction;

        // Physics.Raycast(ray, out RaycastHit hit);                    // ezt a 2. k�rben vette kim, a fentit az els�ben

        bool isHit = Physics.Raycast(ray, out RaycastHit hit);          // sztem ez ker�lt be helyette (2 k�ri kidob�s)

        if (isHit)                                                      // csak akkor ha van is tal�lat
        {
            for (int i = 0; i < points.Length; i++)
            {
                Transform point = points[i];
                float t = i / (points.Length - 1f);                     // az egy ut�n az�rt tett f-et, hogy float maradjon ha int osztva floattal vagy ford�tva van
                point.position = Vector3.Lerp(origin, hit.point, t);
            }

        }

        //       else                                                   // �gy is lehet,e hogy kitessz�k a k�pr�l
        //        {
        //        }

        foreach (Transform point in points)                            // de �gy csin�ljuk meg
        {
            point.gameObject.SetActive(isHit);
        }


    }
}


