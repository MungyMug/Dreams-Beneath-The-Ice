using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D PlayerRigidBody2D;
    [SerializeField] float moveSpeed;

    float horizontalMovement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Apply horizontal velocity here
        PlayerRigidBody2D.linearVelocity = new Vector2(horizontalMovement * moveSpeed, PlayerRigidBody2D.linearVelocity.y);
    }


    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
