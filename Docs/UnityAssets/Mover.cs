
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] Vector3 velocity; //kikommentezt�k mert nem be�ll�t�sb�l j�n
    [SerializeField] float speed = 5; // ami szerializ�lt field-ek, azok megjelennek az editorban

    void Update()
    {

        bool up = Input.GetKey(KeyCode.UpArrow); // ez �ppen le van nyomva (GetKeyDown), de itt folyamatosat jelent; || Input.GeKey(KeyCode-W); kieg�sz�thet�
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        // hogyan csin�lunk vektorb�l egys�gnyit itt?

        float z = 0;
    
        if (up && down)
            z = 0;
        else if (up)
            z = 1; // pozit�v az up
        else if (down)
            z = -1;


        float x = 0;
       
        if (right && left)
            z = 0;
        else if (left)
            x -= 1;
        else if (right) 
            x += 1; // right a pozit�v, left negat�v

        // de �tl�ban sokkal gyorsabb, nem egy, ez�rt normaliz�lni kell


        Vector3 velocity = new Vector3(x, 0, z);

        velocity.Normalize(); // a speed el�tt, hogy azt ne normaliz�lja

        velocity *= speed;

       

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);
        transform.position = newPos;

        if (velocity != Vector3.zero) // ugyanaz, mintha a velocity vektor nem egyezik meg a 0, 0, 0 vektorral. If n�lk�l mind�g visszafordul.
        transform.rotation = Quaternion.LookRotation(velocity); // arra n�zzen az el�re, amerre m�sz. Ez�rt kellett az orrot  k�k nyil ir�ny�ban l�trehozni.


    }
    //ha ezek ut�n be�rjuk, hogy y = 0.01, �s run, elkezd felfel� menni


    /*
      
     [SerializeField] Vector3 pos; // ez meg is jelenik a Unity-ben

     void Start()
    {
        Vector2 v2a = new Vector2(1, 4); // new kulcssz� ha b�rmit l�tre akarunk hozni 
        Vector3 v3a = new Vector3(4, 5, 7.54f); // am,i id�ig volt, az primit�v t�pus volt, ez �sszetett t�pus

        float f1 = v2a.x; // pont oper�torral nyerj�k ki az egyik elemet.
        float f2 = v3a.z;

        // tudjuk, h. transformja mindnek van.

        Transform t = transform; // �j t�pus. Mind�g nagybet�, ha nem primit�v t�pus
        t.position = v3a;

        void Update() // minden egyes k�pfriss�t�sre h�vja meg
        {
            transform.position = new Vector3(1,2,3);
        }
    }
    */
}
