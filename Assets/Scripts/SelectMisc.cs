using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMisc : MonoBehaviour
{ 
public List<Sprite> misc = new List<Sprite>();
private SpriteRenderer mySprite;
static int j = 0;

void Start()
{
    mySprite = GetComponent<SpriteRenderer>();
    mySprite.sprite = misc[j];

    }

    public void ForwardSprite()
    {
        if (j >= 2)
        {
            j = 0;
            j--;
        }

        j++;
        mySprite.sprite = misc[j];
    }

 public void BackwardSprite()
 {

        if (j <= 0)
        {
            j = 2;
            j++;
        }

        j--;
        mySprite.sprite = misc[j];

    }

  public static int GetCounterJ()
{
    return j;
}

}
