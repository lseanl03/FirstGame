using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordAtk : MonoBehaviour
{
    public LayerMask enemyLayers;
    private Animator animator;
    public Transform attackPoint;
    public PlayerLife playerLife;
    [SerializeField] private float attackRange = 0.7f;
    [SerializeField] private int attackDamage = 2;
    [SerializeField] private float timeBetweenAttacks = 0.7f;
    [SerializeField] private float nextTimeAttack = 0f;

    private void Start()
    {
        this.animator = GetComponent<Animator>();
        this.playerLife = GetComponent<PlayerLife>();
    }
    private void Update()
    {
        if (!playerLife.isDied)
        {
            if (Time.time >= nextTimeAttack && Input.GetMouseButtonDown(0))
            {
                
                {
                    this.Attack();
                    nextTimeAttack = Time.time + timeBetweenAttacks;
                }
            }
        }
    }

    void Attack()
    {
        this.animator.SetTrigger("Attack");
        Invoke("TakeDamage", 0.15f);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    void TakeDamage()
    {
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitenemies)
        {
            enemy.GetComponent<EnemyTakeDamage>().TakeDamage(attackDamage);
        }
    }
}
