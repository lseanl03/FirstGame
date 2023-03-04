using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRotate : MonoBehaviour
{
    public float rotationSpeed = 1f;
    private void Update()
    {
        transform.Rotate(0, 0, 360 * this.rotationSpeed * Time.deltaTime);
        Invoke("DestroyObj", 0.1f);
    }
    void DestroyObj()
    {
        Destroy(gameObject);
    }
}
