using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

    #region Singleton
    public static MusicManager Singleton;

    private void Awake()
    {
        if(Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    private AudioSource MusicSource;
    private string SceneName;

    public AudioClip MenuMusic, GameMusic;

    // Use this for initialization
    void Start () {
        MusicSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        SceneName = SceneManager.GetActiveScene().name;
	}

    void CheckScene()
    {
        switch (SceneName)
        {
            case "Menu":
                MusicSource.Stop();
                MusicSource.PlayOneShot(MenuMusic);
                break;
            case "Game":
                MusicSource.Stop();
                MusicSource.PlayOneShot(GameMusic);
                break;
            default:
                MusicSource.Stop();
                break;
        }
    }
}
