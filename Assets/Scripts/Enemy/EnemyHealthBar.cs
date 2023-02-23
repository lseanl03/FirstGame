using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    private void Start()
    {
        this.slider = GetComponent<Slider>();
        gameObject.SetActive(false);
    }
    private void Update()
    {
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        this.fill.color = this.gradient.Evaluate(slider.normalizedValue);
        if (health < slider.maxValue)
            gameObject.SetActive(true);
        if (health <= 0)
            Invoke("Destroy", 0.5f);

    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        this.fill.color = this.gradient.Evaluate(1f);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}