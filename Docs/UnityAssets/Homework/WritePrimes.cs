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

        // ide kerülne a második szakasz
        bool IsPrime(int z)
        {
            if (z < 2)                                      // 2 alatt nincs prymszám
                return false;

            float negyzetgyok = Mathf.Sqrt(z);       // z négyzetgyöke, négyzetgyök felett felesleges osztót keresni, (float)-tal átalakítom

            for (int k = 2; k <= negyzetgyok; k++)
            {
                if (z % k == 0)
                    return false;


            }
            return true;
        }
    }
}
