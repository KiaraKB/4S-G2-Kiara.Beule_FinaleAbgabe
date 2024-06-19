using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;


    private Vector2 inputVector;
    private Rigidbody2D rb;

    private float moveSpeed = 10f;
    public float defaultSpeed = 10f;
    public float jumpForce = 5f;
    public float sprintSpeed = 20f;

    public bool isGrounded = true;

    [Header("Ground Check")]
    [SerializeField] private Transform transformRaystart;
    [SerializeField] private float rayLength = 0.5f;
    [SerializeField] private LayerMask layerGroundCheck;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        moveSpeed = defaultSpeed;

    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(inputVector.x, 0);
        Vector2 moveVelocity = moveDirection * moveSpeed;

        Vector2 velocity = rb.velocity;
        velocity.x = moveVelocity.x;
        velocity.y = moveVelocity.y;

        rb.velocity = velocity;
    }

    private void OnMove(InputValue inputValue) 
    {
        Debug.Log("Moving");
        inputVector = inputValue.Get<Vector2>();
    }

    void OnJump() 
    {
        Debug.Log("JUMP!");

        
        //if (GroundCheck())
        {
            rb.velocity = new Vector2(rb.velocity.x, y: jumpForce);
        }

    }

    bool GroundCheck() 
    {

        return Physics.Raycast(transformRaystart.position, Vector3.down, rayLength, layerGroundCheck);

    }

    void OnPause(InputValue inputVal) 
    {
        Debug.Log("Paused");
        panelPause.SetActive(true);
        Time.timeScale = 0f;

    }

}
