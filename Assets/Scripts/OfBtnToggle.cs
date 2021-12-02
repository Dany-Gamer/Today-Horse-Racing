using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfBtnToggle : MonoBehaviour
{
    AudioSource src;
    private static bool flag;

    void Update()
    {
        src = MusicPlayer.GetMusicAudio();
    }

    private  void OnMouseDown()
    {
        if (src.isPlaying)
        {
            src.Stop();
            flag = true;
        } 
    }

    public static void ResetFlag()
    {
        flag = false;
    }
    public static bool GetFlag()
    {
        return flag;
    }

    
}
