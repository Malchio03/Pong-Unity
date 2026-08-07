using UnityEngine;

public class Ball : MonoBehaviour
{ 
    public GameManager gameManager;
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float maxInitialAngle = 0.67f;
    public float maxStartY = 4f; 
    public float speedMultiplier = 1.3f;

    private float startX = 0f;

    void Start()
    {
       InitialPush();   
    }

    private void InitialPush()
    {
        Vector2 dir = Vector2.left;     // Start moving the ball to the left
        if(Random.value < 0.5f)
            dir = Vector2.right;        // Randomly change direction to the right

        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb.linearVelocity = dir * moveSpeed;
    }

    private void ResetBall()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZone scorezone = collision.GetComponent<ScoreZone>();
        if(scorezone != null)
        {
            gameManager.OnScoreZoneReached(scorezone.id);
            ResetBall();
            InitialPush();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        P1 paddle1 = collision.collider.GetComponent<P1>();
        P2 paddle2 = collision.collider.GetComponent<P2>();

        if (paddle1 || paddle2)
        {
            rb.linearVelocity *= speedMultiplier;
        }

    }


}
