using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyTakeDamage : MonoBehaviour
{
    public Animator animator;
    public UpCoin upCoin;
    public EnemyPatrol enemyPatrol;
    public EnemyHealthBar healthBar;
    public int maxHealth = 10;
    public int currentHealth;
    private void Start()
    {
        this.currentHealth = this.maxHealth;
        this.healthBar.SetMaxHealth(this.maxHealth);
        this.animator = GetComponent<Animator>();
    }
    private void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        this.currentHealth -= damage;
        this.healthBar.SetHealth(this.currentHealth);
        this.SetHurtTrigger();
        if (this.currentHealth <= 0)
        {
            this.upCoin.coin++;
            Die();

        }
    }
    void SetHurtTrigger()
    {
        this.animator.SetTrigger("Hurt");
    }
    void SetDieBool()
    {
        this.animator.SetBool("Die", true);
    }
    public void Die()
    {
        Invoke("SetDieBool", 0.5f);
        this.enemyPatrol.speedMove = 0f;
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Invoke("DestroyEnemy", 1.5f);
    }
    void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}