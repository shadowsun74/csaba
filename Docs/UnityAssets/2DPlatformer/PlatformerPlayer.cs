using UnityEngine;

class PlatformerPlayer : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpSpeed = 6;
    [SerializeField, Min(0)] int airJumpCount = 1;

    bool grounded;
    int airJumpBudget;

    void OnValidate()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded || airJumpBudget > 0)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpSpeed;
                rb.velocity = velocity;

                if (!grounded)
                    airJumpBudget--;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
        airJumpBudget= airJumpCount;

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}


