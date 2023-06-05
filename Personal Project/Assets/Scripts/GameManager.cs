using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        isGameActive = true; 
    }

    void Update()
    {
        
    }

// Scoring
    public void UpdateScore (int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }

// Start Game
    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        titleScreen.gameObject.SetActive(false);
        restartScreen.gameObject.SetActive(false);
    }

// Open Restart Menu
    public void OpenMenu()
    {
        restartScreen.gameObject.SetActive(true);
        isGameActive = false;
    }

// Accept Restart Button
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

// Deny Restart Button
    public void CloseMenu()
    {
       restartScreen.gameObject.SetActive(false);
       isGameActive = true;
    }
}
