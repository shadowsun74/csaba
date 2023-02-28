
using UnityEngine;

class LightDimmer : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] Color c1 = Color.white;
    [SerializeField] Color c2 = Color.white;
    [SerializeField] float frequency = 1;


    void OnValidate()   //ezzel oldjuk meg, hogy unity-n belül is gybõl mutassa
    {
        Update();
    }

    void Update()
    {
        float t = Time.time;    // lekérdezzük mennyi idõ múlt el a játék kezdete óta
        t *= frequency;
        t *= Mathf.PI * 2; // azzal kell szorozni, ami a teljes szélesség, 2pi raián, mert fokkban kell

        float sin = Mathf.Sin(t);
        sin += 1;
        sin /= 2;

        light.color = Color.Lerp(c1, c2, sin); // lerp az mindíg 0 és 1 közötti érték. Mivel a színus 1 és -1 között mászkál ezt át kell konvertálnunk +1 hogy ne legyen negatív, majd oszt 2-vel

    }
}
