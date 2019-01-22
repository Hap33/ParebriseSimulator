using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerMainMenu : MonoBehaviour
{
    #region Singleton

    public static UIManagerMainMenu instance;

    private void Awake()
    {
        if (UIManagerMainMenu.instance != null)
            Destroy(this);
        else UIManagerMainMenu.instance = this;
    }

    #endregion
}
