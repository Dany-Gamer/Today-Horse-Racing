using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseAudio : MonoBehaviour
{
    AudioSource src;
    void Start()
    {
        src = GetComponent<AudioSource>();
        Check();
    }

    private void Check()
    {
        if(OfBtnToggle.GetFlag() == true)
        {
            src.Stop();
        }

        else 

        {
            src.Play();
        }
    }
}
