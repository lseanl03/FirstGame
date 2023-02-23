using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    private void Awake()
    {
        this.slider = GetComponent<Slider>();   
    }
    void Update()
    {
        
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        this.fill.color = this.gradient.Evaluate(slider.normalizedValue);

    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        this.fill.color = this.gradient.Evaluate(1f);
    }
}
