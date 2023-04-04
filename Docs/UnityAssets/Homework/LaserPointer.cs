using UnityEngine;

public class LaserPointer : MonoBehaviour
{

    [SerializeField] Transform[] points;            // lehetne tömb is, vagy lista, így nem kell gameobect.transform.position, hanem elég lesz a transform.position

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.up;

        Ray ray = new Ray(origin, direction);                           // így is lehet

        //Ray ray = new Ray();                                          // vagy így és utólag töljük fel a köv 2 sorral
        //ray.origin = origin;
        //ray.direction = direction;

        // Physics.Raycast(ray, out RaycastHit hit);                    // ezt a 2. körben vette kim, a fentit az elsõben

        bool isHit = Physics.Raycast(ray, out RaycastHit hit);          // sztem ez került be helyette (2 köri kidobás)

        if (isHit)                                                      // csak akkor ha van is találat
        {
            for (int i = 0; i < points.Length; i++)
            {
                Transform point = points[i];
                float t = i / (points.Length - 1f);                     // az egy után azért tett f-et, hogy float maradjon ha int osztva floattal vagy fordítva van
                point.position = Vector3.Lerp(origin, hit.point, t);
            }

        }

        //       else                                                   // így is lehet,e hogy kitesszük a képrõl
        //        {
        //        }

        foreach (Transform point in points)                            // de így csináljuk meg
        {
            point.gameObject.SetActive(isHit);
        }


    }
}


