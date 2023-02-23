using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{

    public TextMeshProUGUI healthText;
    public int healthValue;
    private void Start()
    {
        this.healthValue = 10;
    }
    private void Update()
    {
        this.healthText.text = healthValue.ToString();
            if (this.healthValue == 0)
            {
                return;
            }
       
    }
}
