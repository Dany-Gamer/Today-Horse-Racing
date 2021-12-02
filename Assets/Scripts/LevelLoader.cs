using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    public void LoadMainMenuDay()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadMainMenuNight()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadDayTraining()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNightTraining()
    {
        SceneManager.LoadScene(23);
    }

    public void LoadDaySettings()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadNightSettings()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadPlayerInfoDay()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadPlayerInfoNight()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadHorseInfoDayMisc()
    {
        SceneManager.LoadScene(21);
    }

    public void LoadHorseInfoNightMisc()
    {
        SceneManager.LoadScene(22);
    }

    public void LoadHorseInfoDayBreed()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadHorseInfoNightBreed()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadSliderDay()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadSliderNight()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadGameDay()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadGameNight()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadStartScreenNight()
    {
        SceneManager.LoadScene(15);
    }

    public void LoadStartScreenDay()
    {
        SceneManager.LoadScene(24);
    }

    public void LoadGameplayDay()
    {
        SceneManager.LoadScene(20);
    }

    public void LoadGameplayNight()
    {
        SceneManager.LoadScene(25);
    }

    public void LoadTrainingDay()
    {
        SceneManager.LoadScene(14);
    }

    public void LoadTrainingNight()
    {
        SceneManager.LoadScene(23);
    }

    public void LoadMastDay()
    {
        SceneManager.LoadScene(21);
    }

    public void LoadMastNight()
    {
        SceneManager.LoadScene(22);
    }

    public void LoadGameOverDay()
    {
        SceneManager.LoadScene(12);
    }

    public void LoadGameOverNight()
    {
        SceneManager.LoadScene(13);
    }

    public void LoadTrainingWinDay()
    {
        SceneManager.LoadScene(19);
    }

    public void LoadTrainingWinNight()
    {
        SceneManager.LoadScene(18);
    }

    public void LoadTrainingLoseDay()
    {
        SceneManager.LoadScene(16);
    }

    public void LoadTrainingLoseNight()
    {
        SceneManager.LoadScene(17);
    }
}