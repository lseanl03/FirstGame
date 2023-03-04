using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2d;
    public enum Movementstate { Idle, Running, Jumping, Falling }
    private void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rb2d= GetComponent<Rigidbody2D>();
    }
    public void AnimationPlayer(float directionX)
    {
        Movementstate state;

        if (directionX > 0f)
        {
            state = Movementstate.Running;
        }
        else if (directionX < 0f)
        {
            state = Movementstate.Running;
        }
        else
        {
            state = Movementstate.Idle;
        }
        if (this.rb2d.velocity.y > .1f)
        {
            state = Movementstate.Jumping;
        }
        else if (this.rb2d.velocity.y < -.1f)
        {
            state = Movementstate.Falling;
        }
        animator.SetInteger("State", (int)state);//cài đặt số nguyên
    }
}
