using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;

    // Update is called once per frame
    public void Score(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log(score);
        if(score==50)
        {
            Debug.Log("You Won");
            SceneManager.LoadScene(1);
        }

    }
}
