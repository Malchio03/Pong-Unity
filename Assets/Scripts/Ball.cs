using UnityEngine;

public class Ball : MonoBehaviour
{ 
    public Rigidbody2D rb;
    public float moveSpeed;
    public float maxInitialAngle = 0.67f;
    public float startX = 0f;
    public float maxStartY = 4f;
    void Start()
    {
       InitialPush();   
    }

    private void InitialPush()
    {
        Vector2 dir = Vector2.left * moveSpeed;     // Start moving the ball to the left
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb.linearVelocity = dir;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZone scorezone = collision.GetComponent<ScoreZone>();
        if(scorezone != null)
        {
            Debug.Log("todo");
        }
    }
}
