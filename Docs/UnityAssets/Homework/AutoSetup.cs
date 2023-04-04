using UnityEngine;

public class AutoSetup : MonoBehaviour
{
    [SerializeField] float density = 1.0f;

    void Start()
    {
        var boxes = FindObjectsOfType<BoxCollider>();

        foreach (BoxCollider box in boxes)
        {
            Rigidbody rb = box.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 scale = box.transform.lossyScale;

                float volume =
                    box.size.x * box.size.y * box.size.z *
                    scale.x * scale.y * scale.z;

                // Debug.Log(scale);

                rb.mass = volume * density;
            }
        }
    }
}
