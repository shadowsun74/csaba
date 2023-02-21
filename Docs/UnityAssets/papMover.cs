
using UnityEngine;
public class papMover : MonoBehaviour
{
    [SerializeField] Transform posA, posB;
    [SerializeField] float speed;
    [SerializeField, Range (0,1)] float startPosition = 0.5f; // range cs�szk�t ad

    Transform nextTarget; // ez egy filed v�ltoz�, am�g az itt �l, az megmarad folymatosan, �fgy tudjuk kezelni, hogy ne csak bel�l legyen



  void Start()
    {
        nextTarget = posA;
    }


    void Update()
    {

        Vector3 targetPosition = nextTarget.position;

        Vector3 nextPosition = Vector3.MoveTowards (transform.position, targetPosition, speed = Time.deltaTime); // a pontb�l az ektu�lis c�lig megy�nk csak
        transform.position = nextPosition;

        if (nextPosition == targetPosition)
        {
            if (nextTarget == posA)
                nextTarget= posB;
            else
            {
                nextTarget= posA;
            }
            
        }
        
        /*
        Vector3 direction = posA.position - posB.position;
        direction.Normalize();
        // ir�ny el��ll�t�s
        Vector3 velocity = direction * speed;
        // ir�nyt reprezent�l� vektor �s hosszb�l lehet sebess�g vektort k�sz�teni
        transform.position += Time.deltaTime * velocity;    // egyenletes mozg�s
        */
    }
    // ha �gy hagyjuk, akkor az update a cikluson bel�l fut le, ez�rt nem �ll majd meg a nextPosition elen�re sem. Valami majd kell k�v�l v�ltoz�, ami megmarad

    void OnValidate() //ezt is csak fejelszt�sre tudjuk hazsn�lni, automatiz�ci�, ami lfut az editorban
    {
        transform.position = Vector3.Lerp(posA.position, posB.position, startPosition); //  Lerp - linear interpolation (extrapolation).
        // ezzel r�tettem egy cs�szk�ra a 2 db gizmo k�z� a vonalra, hogy hol legyen az akad�ly
    }

    void OnDrawGizmos()
    {
        if (posA == null) return; // ha egyik nincs meg, nem rajzolunk, kil�p�nk
        if (posB == null) return;

        // sz�nek felv�tele
        Color c1 = Color.red;
        Color c2 = new Color(0, 0, 1); // RGB

        Gizmos.color = Color.Lerp(c1, c2, startPosition); // ezzel a k��t sz�n k�z�tt tudunk "v�ltani"
        
        Gizmos.DrawSphere(posA.position, 0.1f);
        Gizmos.DrawSphere(posB.position, 0.1f);
        Gizmos.DrawLine (posA.position, posB.position);
    }
}
// kellenek majd Gizmo-k ami csak a sceneben jelenik meg a v�gleges j�t�kban nem
