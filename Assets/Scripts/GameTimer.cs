using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    Text timeText;
    LevelLoader level;
    [SerializeField] int secondsLeft = 60;
    bool timeRunning = false;

    void Start()
    {
        timeText = GetComponent<Text>();

        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Training Day")
        {
            timeText.text = "00:30";
        }
        else if (sceneName == "Training Night")
        {
            timeText.text = "00:30";
        }
        else if (sceneName == "Gameplay Day")
        {
            timeText.text = "01:00";
        }
        else if (sceneName == "Gameplay Night")
        {
            timeText.text = "01:00";
        }

        level = FindObjectOfType<LevelLoader>();
    }

    void Update()
    {
        if (timeRunning == false && secondsLeft > 0)
        {
            StartCoroutine(RunTimer());
        }
        if ((secondsLeft < 1) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Gameplay Day"))
        {
            level.LoadGameOverDay();
        }
        else if((secondsLeft < 1) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Gameplay Night"))
        {
            level.LoadGameOverNight();
        }
        else if ((secondsLeft < 1) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Training Day"))
        {
            level.LoadTrainingWinDay();
        }
        else if ((secondsLeft < 1) && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Training Night"))
        {
            level.LoadTrainingWinNight();
        }
    }

    IEnumerator RunTimer()
    {
        timeRunning = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        if (secondsLeft < 10)
        {
            timeText.text = "00:0" + secondsLeft;
        }
        else
        {
            timeText.text = "00:" + secondsLeft;
        }

        timeRunning = false;
    }

    public void SubtractFromTime(int sub)
    {
        secondsLeft -= sub;
    }

    public int GetTime()
    {
        return secondsLeft;
    }
}
