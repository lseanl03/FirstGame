using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBallAtk : MonoBehaviour
{
    private Animator animator;
    public Transform firePoints;
    public GameObject bulletPrefab;
    public EnergyBar energyBar;
    public Bullet bullet;
    public PlayerLife playerLife;
    [SerializeField] private float nextTimeShoot = 0f;
    [SerializeField] private float timeBetweenShoot = 1.5f;
    [SerializeField] private float energyconsumption = 1;
    [SerializeField] private bool outOfEnergy;
    public void Start()
    {
        this.animator = GetComponent<Animator>();
        this.playerLife = GetComponent<PlayerLife>();
    }
    private void Update()
    {
        if (!playerLife.isDied)
        {
            if (Time.time > nextTimeShoot)
            {
                if (Input.GetMouseButtonDown(1) && !outOfEnergy)
                {
                    Invoke("Shoot", 0.9f);
                    this.animator.SetTrigger("Shoot");
                    this.nextTimeShoot = Time.time + this.timeBetweenShoot;
                    energyBar.slider.value -= energyconsumption;
                    if (energyBar.slider.value == 0)
                        outOfEnergy = true;
                }
                if (energyBar.slider.value > 0)
                    outOfEnergy = false;
            }
        }
    }
    void Shoot()
    {
        Instantiate(this.bulletPrefab, this.firePoints.position, this.firePoints.rotation);
    }
}
