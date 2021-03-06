﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    #region Singleton
    public static GameManager Singleton;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
    #endregion

    public GameObject Player;
    
    void Start () {
        Time.timeScale = 1f;
        Instantiate(Player);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Submit"))
        {
            #region Spawn Enemy
            foreach (GameObject spawner in GameObject.FindGameObjectsWithTag("EnemySpawner"))
            {
                spawner.GetComponent<SpawnEnemy>().SpawnAnEnemy();
            }
            #endregion
        }

        if (Input.GetButtonDown("Cancel"))
        {
            #region Destroy Enemy
            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if (enemy.GetComponent<EnemyBehaviour>().IsInTrigger)
                {
                    enemy.GetComponent<EnemyBehaviour>().Death();
                    foreach (GameObject spawner in GameObject.FindGameObjectsWithTag("EnemySpawner"))
                    {
                        spawner.GetComponent<SpawnEnemy>().ResetSpawner();
                    }
                }
            }
            #endregion
        }
	}

}
