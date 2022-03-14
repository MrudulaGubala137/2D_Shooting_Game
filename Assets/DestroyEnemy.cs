using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    
    ScoreManagerScript scoreManagerScript;
    private void Start()
    {
        scoreManagerScript = GameObject.Find("ScoreManager").GetComponent<ScoreManagerScript>();
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            scoreManagerScript.Score(10);
            Destroy(gameObject);
            

        }
       
    }
    public void Update()
    {
        time=time+Time.deltaTime;
        if(time>3.0f)
        {
            Destroy(gameObject);
        }
    }
}
