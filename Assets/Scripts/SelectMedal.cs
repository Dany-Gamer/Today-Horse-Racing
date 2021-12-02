using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMedal : MonoBehaviour
{
    public List<Sprite> medals = new List<Sprite>();
    SpriteRenderer spriteRenderer;
    int i;

    void Start()
    {
        i = MoveRunner.GetCount();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ShowMedals();
    }

    private void ShowMedals()
    {
        if (i <= 2)
        {
            spriteRenderer.sprite = medals[0];
        }

        if (i >= 3)
        {
            spriteRenderer.sprite = medals[1];
        }

        if (i >= 5)
        {
            spriteRenderer.sprite = medals[2];
        }

        Debug.Log(" the count is " + i);
    }
}
