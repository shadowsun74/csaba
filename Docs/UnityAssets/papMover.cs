
using UnityEngine;
public class papMover : MonoBehaviour
{
    [SerializeField] Transform posA, posB;
    [SerializeField] float speed;
    [SerializeField, Range (0,1)] float startPosition = 0.5f; // range csúszkát ad

    Transform nextTarget; // ez egy filed változó, amíg az itt él, az megmarad folymatosan, ífgy tudjuk kezelni, hogy ne csak belül legyen



  void Start()
    {
        nextTarget = posA;
    }


    void Update()
    {

        Vector3 targetPosition = nextTarget.position;

        Vector3 nextPosition = Vector3.MoveTowards (transform.position, targetPosition, speed = Time.deltaTime); // a pontból az ektuális célig megyünk csak
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
        // irány elõállítás
        Vector3 velocity = direction * speed;
        // irányt reprezentáló vektor és hosszból lehet sebesség vektort készíteni
        transform.position += Time.deltaTime * velocity;    // egyenletes mozgás
        */
    }
    // ha így hagyjuk, akkor az update a cikluson belül fut le, ezért nem áll majd meg a nextPosition elenére sem. Valami majd kell kívül változó, ami megmarad

    void OnValidate() //ezt is csak fejelsztésre tudjuk hazsnálni, automatizáció, ami lfut az editorban
    {
        transform.position = Vector3.Lerp(posA.position, posB.position, startPosition); //  Lerp - linear interpolation (extrapolation).
        // ezzel rátettem egy csúszkára a 2 db gizmo közé a vonalra, hogy hol legyen az akadály
    }

    void OnDrawGizmos()
    {
        if (posA == null) return; // ha egyik nincs meg, nem rajzolunk, kilépünk
        if (posB == null) return;

        // színek felvétele
        Color c1 = Color.red;
        Color c2 = new Color(0, 0, 1); // RGB

        Gizmos.color = Color.Lerp(c1, c2, startPosition); // ezzel a kéát szín között tudunk "váltani"
        
        Gizmos.DrawSphere(posA.position, 0.1f);
        Gizmos.DrawSphere(posB.position, 0.1f);
        Gizmos.DrawLine (posA.position, posB.position);
    }
}
// kellenek majd Gizmo-k ami csak a sceneben jelenik meg a végleges játékban nem
