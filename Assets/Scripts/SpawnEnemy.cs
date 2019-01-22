using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject Enemy;

    private bool CanSpawnEnemy;

    private void Start()
    {
        CanSpawnEnemy = true;
    }
    // Update is called once per frame
    void Update () {
		
	}

    public void SpawnAnEnemy()
    {
        if (CanSpawnEnemy)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            CanSpawnEnemy = false;
        }
    }

    public void ResetSpawner()
    {
        CanSpawnEnemy = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            CanSpawnEnemy = true;
        }
    }
}
