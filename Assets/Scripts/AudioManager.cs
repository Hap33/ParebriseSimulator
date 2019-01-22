using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

    #region Singleton
    public static AudioManager Singleton;

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
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    private AudioSource MusicSource;
    private string SceneName;

    public AudioClip MenuMusic, GameMusic, PauseMusic;
    private bool isPaused = false;

    // Use this for initialization
    void Start()
    {
        MusicSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        SceneName = SceneManager.GetActiveScene().name;
    }

    void PauseMusicManagement()
    {
        if (isPaused)
        {
            MusicSource.Pause();
            MusicSource.PlayOneShot(PauseMusic);
        } else
        {
            CheckScene();
        }
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
