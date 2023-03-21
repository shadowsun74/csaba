using UnityEngine;

[ExecuteAlways]                                                     // mind�g fusson
[RequireComponent(typeof(BoxCollider2D), typeof(SpriteRenderer))]   // ezekre sz�ks�g van, jelezz�k
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
        if (Application.isPlaying) // ha fut, akkor csin�lja
        Destroy(this);          // megsemmis�t�s (this= komponens, this.gameobject - a j�t�kobjektumot is t�rli- Az�rt, hogy ez j�t�kon k�v�lr�l l�tezzen, ut�na kuka
    }

    void Update()
    {
        boxCollider.size = spriteRenderer.size;     // execute always hat�s�ra tud mind�g lefutni ez is
    }

}
