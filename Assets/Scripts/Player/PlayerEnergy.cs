using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour
{
    public EnergyBar energyBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnergyParticles"))
        {
            Destroy(collision.gameObject);
            energyBar.slider.value++;
            if (energyBar.slider.value==energyBar.slider.maxValue)
            {
                return;
            }
        }
    }
}
