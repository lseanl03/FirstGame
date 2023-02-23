using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2d;
    public PlayerHealth playerHealth;
    public HealthPoints healthPoints;
    public bool isDied;
    private void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rb2d = GetComponent<Rigidbody2D>();
        this.playerHealth = GetComponent<PlayerHealth>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") || collision.gameObject.CompareTag("Enemy"))
        {           
            this.healthPoints.healthValue -= 1;
            this.playerHealth.TakeDamage(1);           
            if (this.playerHealth.currentHealth == 0)
            {
                PlayerMovement playerMovement = GetComponent<PlayerMovement>();
                playerMovement.canMove = false;
                Die();
            }
        }
    }
    public void Die()
    {
        this.animator.SetTrigger("Death");
        this.rb2d.bodyType = RigidbodyType2D.Static;
        //FindObjectOfType<AudioManager>().PlaySounds("Death");
        PlayerSwordAtk swordAtk = GetComponent<PlayerSwordAtk>();
        isDied = true;
    }
    void RestartGame()
    {       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
