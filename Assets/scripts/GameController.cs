using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    public GameObject gameOverPanel;
    public GameObject tapToStart;
    public GameObject score;
    public AudioSource audioSource;

    public void Start()
    {
       gameOverPanel.SetActive(false);
        score.SetActive(false);
        
       PauseGame();
        tapToStart.SetActive(true);

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        score.SetActive(false);
        audioSource.Play();

    }

    public void Restart()
    {
        SceneManager.LoadScene("level");
    }
    public void QuitGame()
    {
           Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1.0f;
        tapToStart.SetActive(false);
       // Debug.Log("Start Game Runs");
        score.SetActive(true);
    }
    
}
