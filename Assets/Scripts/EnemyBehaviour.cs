using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    public bool IsInTrigger;
    public AudioClip DeathClip;

    private AudioSource EnemySource;
    private bool IsDead;

	// Use this for initialization
	void Start () {
        EnemySource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemySpawner"))
        {
            IsInTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("EnemySpawner"))
        {
            IsInTrigger = false;
        }
    }

    public void Death()
    {
        if (!IsDead)
        {
            IsDead = true;
            GetComponent<Collider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            EnemySource.PlayOneShot(DeathClip);
            Destroy(gameObject, 1);
        }
    }


}
