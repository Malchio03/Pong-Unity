using UnityEngine;

public class Ball : MonoBehaviour
{ 
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float maxInitialAngle = 0.67f;
    public float maxStartY = 4f;

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
            ResetBall();
            InitialPush();
        }
    }
}
