using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;
    private GameObject pointText;
    private int score = 0;

    void ScorePoint(int score)
    {
        this.pointText.GetComponent<Text>().text = "Score" + this.score;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("PointText");

        score = 0;
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

        else if(other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 10;
        }

        else if(other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 15;
        }

        ScorePoint(score);
    }
}
