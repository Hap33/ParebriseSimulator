using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerMenu : MonoBehaviour {

	public void ClickPlay()
    {
        SceneManager.LoadScene("Game");
    }
}
