using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 10f;

    Rigidbody2D playerRigidbody;

    private float inputX;
    private float inputY;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
        MovementHandler();
    }

    private void InputHandler()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    private void MovementHandler()
    {
        playerRigidbody.velocity = new Vector2 (inputX, inputY);
    }
}
