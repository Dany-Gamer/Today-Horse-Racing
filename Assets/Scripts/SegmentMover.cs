using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentMover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;
    RectTransform seg;
    private float timer = 0;
   [SerializeField]  float MAX_TIME = 5.0f;
    Vector3 dest;
    void Start()
    {
        seg = GetComponent<RectTransform>();
        dest = new Vector3((Random.Range(-209f, 128f)), -92f);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= MAX_TIME)
        {
            dest = new Vector3((Random.Range(-218f, 123f)), -92f);
            timer = 0;
        }

        seg.anchoredPosition = Vector3.MoveTowards(seg.anchoredPosition, dest, Time.deltaTime * movementSpeed);

    }
}
    

