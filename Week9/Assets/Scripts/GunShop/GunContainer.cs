using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunContainer : MonoBehaviour
{
    [SerializeField] private float speed; // Speed at which the gun container rotates

    // Update is called once per frame
    private void Update()
    {
        // Rotate the gun container around its y-axis over time
        // Time.deltaTime ensures smooth rotation regardless of frame rate
        // Multiplying by 'speed' controls the rotation speed
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, 
            transform.eulerAngles.y + Time.deltaTime * speed, transform.eulerAngles.z);
    }
}