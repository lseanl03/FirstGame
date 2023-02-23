using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject[] wayPoints;
    public Animator animator;
    public EnemyTakeDamage takeDamage;
    public int currentWayPoint = 0;
    public float speedMove=2f;
    public float waitTime = 0f;
    private void Start()
    {
        this.animator = GetComponent<Animator>();
        this.takeDamage = GetComponent<EnemyTakeDamage>();
    }
    private void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < 0.1)
        {
            
            this.waitTime += Time.deltaTime;
            this.speedMove = 0f;
            this.Wait();
            if (this.waitTime >= 1 && takeDamage.currentHealth>0)
            {
                ChangeWayPoint();
                this.speedMove = 2f;
                this.waitTime = 0;
                this.Run();
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, speedMove * Time.deltaTime);
    }
    void ChangeWayPoint()
    {
        currentWayPoint++;
        if(currentWayPoint>= wayPoints.Length)
        {          
            this.currentWayPoint = 0;
        }
    }
    void Wait()
    {
        this.animator.SetBool("Idle", true);
    }
    void Run()
    {
        this.animator.SetBool("Idle", false);
    }
}
