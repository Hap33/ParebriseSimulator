﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerMenu : MonoBehaviour
{

    public void ClickPlay()
    {
        StartCoroutine(FakeTimer());
    }

    IEnumerator FakeTimer()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game");
    }
}