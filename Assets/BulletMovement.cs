using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed;
    void Start()
    {
        transform.Translate(0, bulletSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
