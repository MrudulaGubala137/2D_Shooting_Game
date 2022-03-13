using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
   public GameObject shootPrefab;
    public Vector3 offSet;

    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
        
    {
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)&& transform.position.x>-7.8)
            {
            transform.Translate(-speed, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x<7.8)
        {
            transform.Translate(speed, 0, 0);
        }
        if(Input.GetMouseButtonDown(0))
        {

             Instantiate(shootPrefab,transform.position+offSet*speed*Time.deltaTime,Quaternion.identity);
            

        }
        
    }
}
