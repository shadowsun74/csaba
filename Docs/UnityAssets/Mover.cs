
using UnityEngine;

public class Mover : MonoBehaviour
{
    // [SerializeField] Vector3 velocity; //kikommenteztük mert nem beállításból jön
    [SerializeField] float speed = 5; // ami szerializált field-ek, azok megjelennek az editorban

    void Update()
    {

        bool up = Input.GetKey(KeyCode.UpArrow); // ez éppen le van nyomva (GetKeyDown), de itt folyamatosat jelent; || Input.GeKey(KeyCode-W); kiegészíthetõ
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        // hogyan csinálunk vektorból egységnyit itt?

        float z = 0;
    
        if (up && down)
            z = 0;
        else if (up)
            z = 1; // pozitív az up
        else if (down)
            z = -1;


        float x = 0;
       
        if (right && left)
            z = 0;
        else if (left)
            x -= 1;
        else if (right) 
            x += 1; // right a pozitív, left negatív

        // de átlóban sokkal gyorsabb, nem egy, ezért normalizálni kell


        Vector3 velocity = new Vector3(x, 0, z);

        velocity.Normalize(); // a speed elõtt, hogy azt ne normalizálja

        velocity *= speed;

       

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);
        transform.position = newPos;

        if (velocity != Vector3.zero) // ugyanaz, mintha a velocity vektor nem egyezik meg a 0, 0, 0 vektorral. If nélkül mindíg visszafordul.
        transform.rotation = Quaternion.LookRotation(velocity); // arra nézzen az elõre, amerre mész. Ezért kellett az orrot  kék nyil irányában létrehozni.


    }
    //ha ezek után beírjuk, hogy y = 0.01, és run, elkezd felfelé menni


    /*
      
     [SerializeField] Vector3 pos; // ez meg is jelenik a Unity-ben

     void Start()
    {
        Vector2 v2a = new Vector2(1, 4); // new kulcsszó ha bármit létre akarunk hozni 
        Vector3 v3a = new Vector3(4, 5, 7.54f); // am,i idáig volt, az primitív típus volt, ez összetett típus

        float f1 = v2a.x; // pont operátorral nyerjük ki az egyik elemet.
        float f2 = v3a.z;

        // tudjuk, h. transformja mindnek van.

        Transform t = transform; // új típus. Mindíg nagybetû, ha nem primitív típus
        t.position = v3a;

        void Update() // minden egyes képfrissítésre hívja meg
        {
            transform.position = new Vector3(1,2,3);
        }
    }
    */
}
