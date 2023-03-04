using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    private void Start()
    {
        this.slider = GetComponent<Slider>();
        this.slider.value = 3;
    }
    private void Update()
    {
        
    }
    public void SetEnergy(int energy)
    {
        slider.value = energy;
        slider.maxValue = 3;
        slider.minValue = 0;
    }
}
