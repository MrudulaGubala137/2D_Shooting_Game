using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    //public int enemySpeed;
    public float time=1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time+ Time.deltaTime;
        if (time > 3.0f)
        {
            
            transform.position = new Vector3(Random.Range(-8.3f, 8.3f), Random.Range(2.0f, 4.2f), 0f);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            transform.Rotate(0f, 0f, 90.0f, Space.Self);
            time = 0f;
        }
        
    }
}
