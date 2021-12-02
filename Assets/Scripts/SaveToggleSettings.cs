using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveToggleSettings : MonoBehaviour
{
    static AudioSource sr;
    MusicPlayer mu;
    const string checkSoundToggle = "SOUNDACTIVE";

    private void Start()
    {
        sr = mu.GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey(checkSoundToggle))
        {
            if (PlayerPrefs.GetInt(checkSoundToggle) == 1)
            {
                sr.Play();
            }
            else
            {
                sr.Stop();
            }
        }
    }

    

    public static void SetSound(bool isSwitch)
    {
        PlayerPrefs.SetInt(checkSoundToggle, isSwitch ? 1 : 0);
    }
}
 


