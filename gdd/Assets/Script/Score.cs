using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
     ScoreNum = 0;
     MyScoreText.text = "Score : " + ScoreNum;   
    }

    void OnTriggerEnter2D(Collider2D Crystal)
    {
        if(Crystal.tag == "crystal")
        {
            ScoreNum++;
            Destroy(Crystal.gameObject);
            MyScoreText.text = "Score : " + ScoreNum;
        }
    }
}
