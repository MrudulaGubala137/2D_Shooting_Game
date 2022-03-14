using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemySpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
        
        if (transform.position.y>-4.5f)
        {
            Destroy(gameObject, 5.0f);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shoot")
        {

            Destroy(gameObject);
        }
        else //if(collision.gameObject.tag =="Player")
        {
            SceneManager.LoadScene(0);
        }
    }

}
