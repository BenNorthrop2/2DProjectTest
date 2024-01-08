using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LandMines : MonoBehaviour
{

    [SerializeField] private float startTimer = 2;

    private SpriteRenderer spriteRenderer;
    private CircleCollider2D circleCollider;

    private bool hit = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();

        spriteRenderer.color = Color.yellow;
    }

    void Update()
    {
        if (hit == true)
        {
            if(startTimer > 0 )
            {
                spriteRenderer.color = Color.white;
                startTimer--;
            }
            else
            {
                spriteRenderer.color = Color.yellow;
                startTimer = 2;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            hit = true;
            spriteRenderer.color = Color.red;
        }
    }
}
