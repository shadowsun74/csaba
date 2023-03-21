using UnityEngine;

[ExecuteAlways]                                                     // mindíg fusson
[RequireComponent(typeof(BoxCollider2D), typeof(SpriteRenderer))]   // ezekre szükség van, jelezzük
class BoxCOlliderAutoSize : MonoBehaviour
{
    [SerializeField] BoxCollider2D boxCollider;
    [SerializeField] SpriteRenderer spriteRenderer;

    void OnValidate()
    {
        if (boxCollider == null)
            boxCollider = GetComponent<BoxCollider2D>();

        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void Start()
    {
        if (Application.isPlaying) // ha fut, akkor csinálja
        Destroy(this);          // megsemmisítés (this= komponens, this.gameobject - a játékobjektumot is törli- Azért, hogy ez játékon kívülrõl létezzen, utána kuka
    }

    void Update()
    {
        boxCollider.size = spriteRenderer.size;     // execute always hatására tud mindíg lefutni ez is
    }

}
