using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    private InputField input;
    int show;
    int limit = 12;

    void Awake()
    {
        input = GameObject.Find ("InputField").GetComponent<InputField>();
        input.characterLimit = limit;

    }
    public void GetInput(string guess)
    {

    }

    private void Update()
    {
        GetLength();
    }

    public int GetLength()
    {
        show = input.text.Length;
        return show;
    }



}