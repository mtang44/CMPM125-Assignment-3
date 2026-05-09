
using Unity.Collections;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;


public class CameraController : MonoBehaviour
{
    public InputActionReference move;
    public Rigidbody rb;
    public float moveSpeed;
    private Vector2 _moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       _moveDirection = move.action.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:_moveDirection.x * moveSpeed, y:_moveDirection.y * moveSpeed);
    }
    
}
