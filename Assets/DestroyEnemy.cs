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
            Destroy(gameObject);
            scoreManagerScript.Score(10);

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
