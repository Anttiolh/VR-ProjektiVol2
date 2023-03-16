using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public MeshRenderer score1, score2, score3, score4, score5;
    public GameObject victoryText;

    private void Awake()
    {
        victoryText = GameObject.FindGameObjectWithTag("VictoryText");
        victoryText.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            score++;

            switch (score)
            {
                case 1:
                    score1.material.color = Color.green;
                    break;
                case 2:
                    score2.material.color = Color.green;
                    break;
                case 3:
                    score3.material.color = Color.green;
                    break;
                case 4:
                    score4.material.color = Color.green;
                    break;
                case 5:
                    score5.material.color = Color.green;
                    victoryText.SetActive(true);
                    break;
                default:
                break;
            }
        }
    }

    public void Reset()
    {
        score = 0;
        score1.material.color = Color.red;
        score2.material.color = Color.red;
        score3.material.color = Color.red;
        score4.material.color = Color.red;
        score5.material.color = Color.red;
        victoryText.SetActive(false);
    }
}
