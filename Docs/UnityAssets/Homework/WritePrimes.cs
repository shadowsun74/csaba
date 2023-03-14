using UnityEngine;

public class WritePrimes : MonoBehaviour
{
    [SerializeField] int num = 10;

    void Start()
    {
        WriteNPrimes(num);
    }

    // Update is called once per frame
    void WriteNPrimes(int count)
    {
        int found = 0;
        int i = 2;

        while (found != count)
        {
            if (IsPrime(i))
            {
                found++;
                    Debug.Log(i);
            }
        }

        // ide ker�lne a m�sodik szakasz
        bool IsPrime(int z)
        {
            if (z < 2)                                      // 2 alatt nincs prymsz�m
                return false;

            float negyzetgyok = Mathf.Sqrt(z);       // z n�gyzetgy�ke, n�gyzetgy�k felett felesleges oszt�t keresni, (float)-tal �talak�tom

            for (int k = 2; k <= negyzetgyok; k++)
            {
                if (z % k == 0)
                    return false;


            }
            return true;
        }
    }
}
