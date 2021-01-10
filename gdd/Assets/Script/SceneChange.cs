using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;
    public void onNewGame() {
        Time.timeScale = 1f; 
        Level1();
    }
    public void onRetry() {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu() {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level1() {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Forest");
    }
    public void Level2()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Lake");
    }
    public void onLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void onResume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}