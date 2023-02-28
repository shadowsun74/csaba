
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mover : MonoBehaviour
{
    // [SerializeField] Vector3 velocity; //kikommenteztük mert nem beállításból jön
    [SerializeField] float speed = 5; // ami szerializált field-ek, azok megjelennek az editorban
    [SerializeField] Transform cameraTransform;
    [SerializeField] bool moveInCameraSpace = true;
    [SerializeField] float angularVelocity = 100;
    [SerializeField] HealthObject healthObject;

        private void OnValidate()
    {
        if (healthObject == null)
        healthObject = GetComponent<HealthObject>();
    }

    void Update()
    {
        //  if (healthObject.currentHealth <= 0) return;

        if (healthObject != null)
        {
            if (!healthObject.IsAlive()) // negálás
                return;
        }

       //  if (HealthObject != null && !healthObject.IsAlive())                  // a fenti pontosan ugyanez
       //     return;

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

        //  Vector3 rightDir = Vector3.right;
        // Vector3 forwardDir = Vector3.forward;

        Vector3 rightDir = moveInCameraSpace ? cameraTransform.right : Vector3.right;
        Vector3 forwardDir = moveInCameraSpace ? cameraTransform.forward : Vector3.forward;

        // Vector3.velocity = new (x, 0, z);
        // Vector3 velocity = rightDir * x + forwardDir * z;
        Vector3 velocity = rightDir * x + forwardDir * z;
        velocity.y = 0;

        // azért csináltuk komplikáltabb módon mert ez az általános megoldás, elõállítja a mi irány vektorunkat
        // Ha kikapcsoljuk a akamera döntését, az kell

        velocity.Normalize(); // a speed elõtt, hogy azt ne normalizálja

        velocity *= speed;

       

        Vector3 p = transform.position;

        Vector3 newPos = p + (velocity * Time.deltaTime);
        transform.position = newPos;


        // if (velocity != Vector3.zero) // ugyanaz, mintha a velocity vektor nem egyezik meg a 0, 0, 0 vektorral. If nélkül mindíg visszafordul.
          //  transform.rotation = Quaternion.LookRotation(velocity); // arra nézzen az elõre, amerre mész. Ezért kellett az orrot  kék nyil irányában létrehozni.

        if (velocity != Vector3.zero) // ugyanaz, mintha a velocity vektor nem egyezik meg a 0, 0, 0 vektorral. If nélkül mindíg visszafordul.
        {
            Quaternion targetRotation = Quaternion.LookRotation(velocity);
            Quaternion currentRotation = transform.rotation;
            transform.rotation = Quaternion.RotateTowards(currentRotation, targetRotation, angularVelocity * Time.deltaTime);
        }
            
            

        

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
