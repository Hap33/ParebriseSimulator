using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManagerInGame : MonoBehaviour
{
    public GameObject endPanel;
    public GameObject hud;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickedButtonEndPanel()
    {
        hud.SetActive(false);
        endPanel.SetActive(true);
    }

    public void OnClickedButtonMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnClickedButtonNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
