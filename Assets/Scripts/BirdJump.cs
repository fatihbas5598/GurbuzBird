using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    public float jumpSpeed = 10f;
    public Rigidbody2D rb;
    public AudioClip jumpSound;
    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
            JumpSound();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
    }

    void JumpSound()
    {
        AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score Area")
        {
            gameManager.UpdateScore();
        }
    }
}