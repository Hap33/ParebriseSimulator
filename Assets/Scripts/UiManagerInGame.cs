using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerInGame : MonoBehaviour
{
    #region Singleton

    public static UIManagerInGame instance;

    private void Awake()
    {
        if (UIManagerInGame.instance != null)
            Destroy(this);
        else UIManagerInGame.instance = this;
    }

    #endregion

    public GameObject pauseMenu, endMenu;

    private bool gameIsPaused;

    // Initiates variables
    private void Start()
    {
        gameIsPaused = false;

        pauseMenu.SetActive(false);
        endMenu.SetActive(false);
    }

    // Checks if Pause is pressed
    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
            SetGamePause(!gameIsPaused);

        if (Input.GetKeyDown(KeyCode.M))
            EndGame();
    }

    // Pauses or unpauses the game
    public void SetGamePause(bool gamePause)
    {
        pauseMenu.SetActive(gamePause);

        Time.timeScale = gamePause ? 0f : 1f;
    }

    // Ends the game
    public void EndGame()
    {
        Time.timeScale = 0f;

        endMenu.SetActive(true);
    }
}
