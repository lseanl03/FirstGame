using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public EnemyPatrol enemyPatrol;
    private void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.enemyPatrol = GetComponent<EnemyPatrol>();
    }
    private void Update()
    {
        if (this.enemyPatrol.currentWayPoint == 1)
        {
            this.spriteRenderer.flipX = false;
        }
        else
        {
            this.spriteRenderer.flipX = true;
        }
    }
}
