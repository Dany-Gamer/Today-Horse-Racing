using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBreed : MonoBehaviour
{
    public List<Sprite> horseBreed = new List<Sprite>();
    private SpriteRenderer mySprite;
    static int i = 0;

    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        mySprite.sprite = horseBreed[i];
    }

    public void ForwardSprite()
    {
        if (i >= 2)
        {
            i = 0;
            i--;
        }

        i++;
        mySprite.sprite = horseBreed[i];
    }

    public void BackwardSprite()
    {
        if(i <= 0)
        {
            i = 2;
            i++;
        }
            
        i--;
        mySprite.sprite = horseBreed[i];
    }

    public static int GetCounterI()
    {
        return i;
    }
}
