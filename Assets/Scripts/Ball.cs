using UnityEngine;

public class Ball : MonoBehaviour
{ 
    public Rigidbody2D rb;
    public float startingSpeed;
    void Start()
    {
        bool isRight = Random.value >= 0.5f;

        float xVelocity = -1f;

        if(isRight)
        {
            xVelocity = 1f;
        }

        float yVelocity = Random.Range(-1f, 1f);

        rb.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
