using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicToggle : MonoBehaviour
{
    AudioSource  src;
    void Update()
    {
        src = MusicPlayer.GetMusicAudio();
    }

    private void OnMouseDown()
    {
        if (!src.isPlaying)
        {
            src.Play();
            OfBtnToggle.ResetFlag();
            
        }

    }
}

