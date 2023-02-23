using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    public GameObject[] wayPoints;
    public int currentWayPoint = 0;
    public float speedMove = 2f;
    private void Start()
    {
    }
    void Update()
    {
        if (Vector2.Distance(this.wayPoints[currentWayPoint].transform.position, transform.position) < 0.1f)
        {
                this.ChangeCurrentWayPoint();
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * speedMove);
    }
    void ChangeCurrentWayPoint()
    {
        
        this.currentWayPoint++;
        if (this.currentWayPoint >= wayPoints.Length)
        {
            this.currentWayPoint = 0;
        }
    }
}

