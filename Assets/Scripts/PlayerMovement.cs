using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Values")]
    [SerializeField] private float playerSpeed = 10f;


    private Rigidbody2D playerRigidbody;

    private float inputX;
    private float inputY;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        HandleMovement();
    }

    private void HandleInput()
    {
        inputX = Input.GetAxis("Horizontal") * playerSpeed;
        inputY = Input.GetAxis("Vertical") * playerSpeed;
    }

    private void HandleMovement()
    {
        playerRigidbody.velocity = new Vector2 (inputX, inputY);
    }
}

