using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;

    int score;

    private GameObject gameoverText;
    private GameObject ScoreText;

    void ScorePoint(int score)
    {
        this.ScoreText.GetComponent<Text>().text = "Score" + this.score;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.ScoreText = GameObject.Find("ScoreText");

        ScorePoint(score);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.score += 5;
        }

        else if(other.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
        }

        else if(other.gameObject.tag == "SmallClaudTag")
        {
            this.score += 10;
        }

        else if(other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 15;
        }
    }
}
