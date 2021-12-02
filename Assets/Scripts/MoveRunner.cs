using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoveRunner : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 5f;
    [SerializeField] float backwardSpeed = 5f;
    public float movementSpeed = 1000f;
    private Vector3 target = new Vector3(214f, -92f);
    private Vector3 initPos = new Vector3(-208f,-92f);
    Animator sliderAnim;
    Animator horseAnim;
    public GameObject slider;
    public GameObject obj;
    Coroutine waitCoroutine;
    RectTransform run;
    private float timer = 0;
    private const float SlidingTime = 4.0f;
    private const float LoadingTime = 7.0f;

    LevelLoader level;
    static int count;

    void Start()
    {
        sliderAnim = slider.GetComponent<Animator>();
        horseAnim =  obj.GetComponent<Animator>();
        level = FindObjectOfType<LevelLoader>();

        run = GetComponent<RectTransform>();
        StartCoroutine(WaitAndRun());
    }


    void Update()
    {
        obj.transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);

        if (Input.touchCount > 0)
        {
           run.anchoredPosition = Vector3.MoveTowards(run.anchoredPosition, target, Time.deltaTime * forwardSpeed);
        }

        else
        {
            run.anchoredPosition = Vector3.MoveTowards(run.anchoredPosition, initPos, Time.deltaTime * backwardSpeed);
        }

        timer += Time.deltaTime;
        Debug.Log(timer);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Run"))
        {
            horseAnim.speed = 1.5f;
            movementSpeed = 1500f;

            Debug.Log("Mov speed " + movementSpeed);

            Debug.Log("horse speed " + horseAnim.speed);

            sliderAnim.SetTrigger("toIdle");

            if (waitCoroutine != null)
            {
               ResetTime();
               StopCoroutine(waitCoroutine);

            }

            Debug.Log("Collision");
;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Run"))
        {
            horseAnim.speed = 1f;
            movementSpeed = 1000f;

            Debug.Log("Mov speed " + movementSpeed);
            Debug.Log("horse speed " + horseAnim.speed);

            ResetTime();
            waitCoroutine =  StartCoroutine(WaitAndRun());
            Debug.Log("Not collision");

        }
    }



   
    IEnumerator  WaitAndRun()
    {

        for (int i = 0; i <= 100; i++)
        {
            yield return new WaitForSeconds(1);

            if (timer > SlidingTime)
            {


                sliderAnim.ResetTrigger("toColor");
            }

            sliderAnim.SetTrigger("toColor");


            if (timer > LoadingTime)
            {
                if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Gameplay Day"))
                {
                    level.LoadGameOverDay();
                }

                else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Gameplay Night"))
                {

                    level.LoadGameOverNight();
                }

                else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Training Day"))
                {

                    level.LoadTrainingLoseDay();
                }

                else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Training Night"))
                {

                    level.LoadTrainingLoseNight();
                }
            }

            count++;
            i++;
        }
    }

    private void ResetTime()
    {
        timer = 0;
    }

    public static int GetCount()
    {
        return count;
    }
 
}
