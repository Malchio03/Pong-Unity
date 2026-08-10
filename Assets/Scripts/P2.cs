using UnityEngine;
using UnityEngine.InputSystem;

public class P2 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        GameManager.instance.onReset += ResetPosition;
    }

    private void ResetPosition()
    {
        transform.position = startPosition;
    }

    void Update()
    {
        if (Keyboard.current == null) return;

        bool isPressingUp = Keyboard.current.upArrowKey.isPressed;
        bool isPressingDown = Keyboard.current.downArrowKey.isPressed;

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