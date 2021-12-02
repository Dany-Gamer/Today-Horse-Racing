using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBg : MonoBehaviour
{
    public GameObject bgPrefab;
    GameTimer timer;
    float k = 1910f;
    int sec;
    Transform t;
    void Start()
    {
        timer = FindObjectOfType<GameTimer>();
        StartCoroutine(Gen());
    }

    void Update()
    {
        sec = timer.GetTime();
    }

    IEnumerator Gen()
    {
        do
        {
            yield return new WaitForSeconds(0);
            var bg =  Instantiate(bgPrefab, new Vector2((k), 0f), transform.rotation);
            bg.transform.SetParent(this.transform);
            bg.transform.localScale = new Vector3(1f, 1f, 1f);
            k += 1927;
        } while (sec != 0);

    }

}
