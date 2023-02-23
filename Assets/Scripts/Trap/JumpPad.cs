using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 15f;
    public Animator animator;

    private void Start()
    {
        this.animator=GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * this.bounce, ForceMode2D.Impulse);
            animator.Play("JumpPad");
        }
    }
}
