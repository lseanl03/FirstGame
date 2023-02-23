using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnergyRotate : MonoBehaviour
{
    public float speedRotate=1f;
    private void Update()
    {
        transform.Rotate(0, 0, -360 * this.speedRotate * Time.deltaTime);
    }
}
