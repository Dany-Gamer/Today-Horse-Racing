using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static AudioSource  audioSrc;
    public  List<AudioClip> aud = new List<AudioClip>();

    void Start()
    {
        DontDestroyOnLoad(this);
        if(audioSrc == null) {
         
         audioSrc = GetComponent<AudioSource>();
            
        }
        SetUpSingelton();
        SceneManager.sceneLoaded += OnSceneLoad;


    }

    private void SetUpSingelton()
    {
        int numberOfMusicPlayers = FindObjectsOfType<MusicPlayer>().Length;
        if (numberOfMusicPlayers> 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    public static void MuteMusicAudio()
    {
        audioSrc.mute = true;
        SaveToggleSettings.SetSound(false);

    }

    public static void UnMuteMusicAudio()
    {
        audioSrc.mute = false;
        SaveToggleSettings.SetSound(true);

    }
    private void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Training Day"
        || scene.name == "Training Night"
        || scene.name == "Gameplay Day"
        || scene.name == "Gameplay Night")
        {

            audioSrc.clip = aud[1];
            if (!audioSrc.isPlaying && OfBtnToggle.GetFlag() == false)
            {
                audioSrc.Play();
            }

        }

        else
        {

           audioSrc.clip = aud[0];

            if (!audioSrc.isPlaying && OfBtnToggle.GetFlag() == false)
            {
                audioSrc.Play();
            }

        }

    }

    public static AudioSource GetMusicAudio()
    {
        return audioSrc;
    }

}
