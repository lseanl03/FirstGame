using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    private Rigidbody2D rb2d;
    private CapsuleCollider2D coll; //cuộn dây
    public PlayerAnimation playerAnimation;
    [SerializeField] private float directionX=0f; //phương hướng
    [SerializeField] private float speedMove = 3f;
    [SerializeField] private float jumpForce = 10.5f;//lực nhảy
    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private bool facingRight = true;
    public bool canMove=true;
    private void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.coll= GetComponent<CapsuleCollider2D>();
    }
    private void Update()
    {
        if (canMove)
        {
            this.MovePlayer();
            this.playerAnimation.AnimationPlayer(directionX);
            this.PLayerFlip();
        }
    }
    void MovePlayer()
    {
        this.directionX = Input.GetAxisRaw("Horizontal");
        this.rb2d.velocity = new Vector2(this.directionX * this.speedMove, this.rb2d.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space)&&IsGrounded())
        {
            this.rb2d.velocity = new Vector2(this.rb2d.velocity.x, this.jumpForce);
            //FindObjectOfType<AudioManager>().PlaySounds("Jump");
        }
    }
    void PLayerFlip()
    {
        if(this.directionX > 0f && !facingRight)
            this.Flip();
        else if(this.directionX<0f && facingRight)
            this.Flip();
    }
    void Flip()
    {
        facingRight=!facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
    bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);//giới hạn
    }

}





