using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int backgroundSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - backgroundSpeed* Time.deltaTime, transform.position.y);
        if (transform.position.x < -9.0f)
        {
            transform.position = new Vector2(70.0f, transform.position.y);
        }
    }
}
