using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D rb2d;
    public int bulletDamage = 5;
    public GameObject impactEffect;
    public float distance = 10f;
    public Vector2 startMove;
    private void Start()
    {
        this.startMove=transform.position;
    }
    private void Update()
    {
        this.rb2d.velocity = transform.right * this.bulletSpeed;
        this.DestroyBullet();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        EnemyTakeDamage enemyHealth = collision.GetComponent<EnemyTakeDamage>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(bulletDamage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);      
        Destroy(gameObject);
    }
    void DestroyBullet()
    {
        float bulletMoved= Vector2.Distance(this.startMove,transform.position);
        if (bulletMoved >= distance)
        {
            Destroy(gameObject);
        }
    }

}
