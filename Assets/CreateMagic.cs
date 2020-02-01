using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMagic : MonoBehaviour
{
    int count = 0;
    int guess;
    int minNumber = 1;
    int maxNumber = 1000;
    // Start is called before the first frame update
    void Start()
    {
        //float health = 50.45f
        // bool 
        
        StartGame();

        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Ваше число : " + guess + "?");
    }
     void StartGame()
    {
        minNumber = 1;
        maxNumber = 1000;

        Debug.Log("Добро пожаловать.");
        Debug.Log("Загадайте число.");
        Debug.Log("Мин число : " + minNumber);
        Debug.Log("Макс чило: " + maxNumber);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            UpdateGuess();
            Debug.Log("Я угадал! Ваше число : " + guess);
            Debug.Log("Я угадал это число за: " + count + " попыток:)");
        }
    }

    private void UpdateGuess()
    {
        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Ваше число: " + guess + "?");
        count++;
    }
}
