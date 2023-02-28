
using UnityEngine;

class LightDimmer : MonoBehaviour
{
    [SerializeField] Light light;
    [SerializeField] Color c1 = Color.white;
    [SerializeField] Color c2 = Color.white;
    [SerializeField] float frequency = 1;


    void OnValidate()   //ezzel oldjuk meg, hogy unity-n bel�l is gyb�l mutassa
    {
        Update();
    }

    void Update()
    {
        float t = Time.time;    // lek�rdezz�k mennyi id� m�lt el a j�t�k kezdete �ta
        t *= frequency;
        t *= Mathf.PI * 2; // azzal kell szorozni, ami a teljes sz�less�g, 2pi rai�n, mert fokkban kell

        float sin = Mathf.Sin(t);
        sin += 1;
        sin /= 2;

        light.color = Color.Lerp(c1, c2, sin); // lerp az mind�g 0 �s 1 k�z�tti �rt�k. Mivel a sz�nus 1 �s -1 k�z�tt m�szk�l ezt �t kell konvert�lnunk +1 hogy ne legyen negat�v, majd oszt 2-vel

    }
}
