using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawRotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.8f;
    public void Update()
    {
        transform.Rotate(0,0,360*this.rotationSpeed*Time.deltaTime);
    }
}
