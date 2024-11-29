using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float flapForceScalar = 1.0f;
    [SerializeField]
    private float moveSpeed = 1.0f;

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        Fly();
    }


    /// <summary>
    /// Applies a constant horizontal force, checks for a flap input to apply a vertical force
    /// </summary>
    private void Fly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocity = new Vector2(rb2d.linearVelocityX, flapForceScalar);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
