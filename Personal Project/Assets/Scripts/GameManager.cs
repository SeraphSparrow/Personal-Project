using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private int score;
    public bool isGameActive;
    public GameObject titleScreen;
    public GameObject restartScreen;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateScore (int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
    }
}
