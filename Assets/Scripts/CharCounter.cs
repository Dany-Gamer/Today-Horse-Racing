using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharCounter : MonoBehaviour
{
    InputController controller;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text>();
        controller = FindObjectOfType<InputController>();
    }

    void Update()
    {
        controller.GetLength();
        scoreText.text = controller.GetLength().ToString();
    }
}
