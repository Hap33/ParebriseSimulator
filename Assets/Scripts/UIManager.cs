using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    #region Singleton

    public static UIManager instance;

    private void Awake()
    {
        if (UIManager.instance != null)
            Destroy(this);
        else UIManager.instance = this;
    }

    #endregion

    [SerializeField]
    public string MainMenuScene, GameScene;

    // Quits the game
    public void QuitGame()
    {
        Debug.Log("Quit Game !");
        Application.Quit();
    }

    // Loads the Main Menu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenuScene);
    }

    // Loads the Game scene
    public void LoadGame()
    {
        SceneManager.LoadScene(GameScene);
    }

    // Fakes a loading time
    private IEnumerator FakeLoadingTime(int buildIndex)
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(buildIndex);
    }
}
