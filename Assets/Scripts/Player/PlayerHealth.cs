using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public PlayerHealthBar healthBar;
    private void Start()
    {
        this.currentHealth = this.maxHealth;
        this.healthBar.SetMaxHealth(this.maxHealth);

    }
    private void Update()
    {
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
