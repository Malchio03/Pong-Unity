using UnityEngine;
using UnityEngine.InputSystem;

public class P1 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb; 

    void Update()
    {
        if (Keyboard.current == null) return;

        bool isPressingUp = Keyboard.current.wKey.isPressed;
        bool isPressingDown = Keyboard.current.sKey.isPressed;

        float yDirection = 0f;

        if (isPressingUp)
        {
            yDirection = 1f;
        }
        else if (isPressingDown)
        {
            yDirection = -1f;
        }

        rb.linearVelocity = new Vector2(0f, yDirection * moveSpeed);
    }
}