using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
   public GameObject shootPrefab;
    public Vector3 offSet;
    public int bulletSpeed;
    Rigidbody2D rb;

    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)&& transform.position.x>-7.8)
            {
            transform.Translate(-speed, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x<7.8)
        {
            transform.Translate(speed, 0, 0);
        }
        if(Input.GetMouseButtonDown(0))
        {

           rb = Instantiate(shootPrefab,transform.position+offSet*speed*Time.deltaTime,Quaternion.identity).GetComponent<Rigidbody2D>();
            rb.AddRelativeForce(new Vector3(0, bulletSpeed, 0));
        }

    }

}
