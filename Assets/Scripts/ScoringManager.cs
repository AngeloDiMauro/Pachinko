using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoringManager : MonoBehaviour
{
    public int container1Points = 1;
    public int container2Points = 2;
    public int container3Points = 3;
    public TextMeshProUGUI scoreText;

    private int score;
    private int goldPoint = 3;
    private int silverPoint = 2;
    private int bronzePoint = 1;
    private int blackPoint = -10;

    private int goldScore;
    private int silverScore;
    private int bronzeScore;
    private int blackScore;


    private void Start()
    {
        scoreText.text = "Score: " + score;
    }

    private void UpdateTotalScore()
    {
        score = goldScore + silverScore + bronzeScore + blackScore;
        scoreText.text = "Score: " + score.ToString();

    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Gold":
                switch (gameObject.tag)
                {
                    case "1PointContainer":
                        goldScore += (container1Points * goldPoint);
                        break;
                    case "2PointContainer":
                        goldScore += (container2Points * goldPoint);
                        Debug.Log("Gold in 2 point");
                        break;
                    case "3PointContainer":
                        goldScore += (container3Points * goldPoint);
                        Debug.Log("Gold in 3 point");
                        break;
                }
                break;
            
             
                
            case "Silver":
                switch (gameObject.tag)
                {
                    case "1PointContainer":
                        silverScore += (container1Points * silverPoint);
                        break;
                    case "2PointContainer":
                        silverScore += (container2Points * silverPoint);
                        break;
                    case "3PointContainer":
                        silverScore += (container3Points * silverPoint);
                        break;
                }
                break;

            case "Bronze":
                switch (gameObject.tag)
                {
                    case "1PointContainer":
                        bronzeScore += (container1Points * bronzePoint);
                        break;
                    case "2PointContainer":
                        bronzeScore += (container2Points * bronzePoint);
                        break;
                    case "3PointContainer":
                        bronzeScore += (container3Points * bronzePoint);
                        break;
                }
                break;

            case "Black":
                switch (gameObject.tag)
                {
                    case "1PointContainer":
                        blackScore += (container1Points * blackPoint);
                        break;
                    case "2PointContainer":
                        blackScore += (container2Points * blackPoint);
                        break;
                    case "3PointContainer":
                        blackScore += (container3Points * blackPoint);
                        break;
                }
                break;
        }
        UpdateTotalScore();

    }

}
        
   



