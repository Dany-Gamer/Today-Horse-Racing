using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public  List<GameObject> pref = new List<GameObject>();
    int countI, countJ;
    private float posX = -797f;
    private float posY = -334f;
    int k;


    void Start()
    {
        countI = SelectBreed.GetCounterI();
        countJ = SelectMisc.GetCounterJ();

        Debug.Log("Count I " + countI);
        Debug.Log("Count J" + countJ);
        Counter();
    }

    private void Counter()
    {
        

        if ((countI == 0) && (countJ == 0))
        {
            k = 0;
            Spawn();
        }

        else if ((countI == 0) && (countJ == 1))
        {
            k = 1;
            Spawn();
        }

        else if ((countI == 0) && (countJ == 2))
        {
            k = 2;
            Spawn();
        }

        else if ((countI == 1) && (countJ == 0))
        {
            k = 3;
            Spawn();
        }

        else if ((countI == 1) && (countJ == 1))
        {
            k = 4;
            Spawn();
        }

        else if ((countI == 1) && (countJ == 2))
        {
            k = 5;
            Spawn();
        }

        else if ((countI == 2) && (countJ == 0))
        {
            k = 6;
            Spawn();
        }

        else if ((countI == 2) && (countJ == 1))
        {
            k = 7;
            Spawn();
        }

        else if ((countI == 2) && (countJ == 2))
        {
            k = 8;
            Spawn();
        }

    }


    private void Spawn()
    {
       Vector2 pos = new Vector2((posX), (posY));
       transform.position = pos;
       var horse = Instantiate(pref[k], transform.position, transform.rotation);
       GameObject.FindObjectOfType<CameraFollow>().target = horse.transform;
       GameObject.FindObjectOfType<MoveRunner>().obj = horse;

        horse.transform.SetParent(this.transform);
    }

    

   
}