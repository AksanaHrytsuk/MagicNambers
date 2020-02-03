using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour
{
  // Start is called before the first frame update
  int apples;
  int count;
  int final_apples = 50;
  void Start()
  {
    Debug.Log("Welcome to the game!");
    Debug.Log("Enter numbers from 1 to 9");
    apples = 0;
    count = 0;
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      EndGame(1);
    }
    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      EndGame(2);
    }
    if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      EndGame(3);
    }
    if (Input.GetKeyDown(KeyCode.Alpha4))
    {
      EndGame(4);
    }
    if (Input.GetKeyDown(KeyCode.Alpha5))
    {
      EndGame(5);
    }
    if (Input.GetKeyDown(KeyCode.Alpha6))
    {
      EndGame(6);
    }
    if (Input.GetKeyDown(KeyCode.Alpha7))
    {
      EndGame(7);
    }
    if (Input.GetKeyDown(KeyCode.Alpha8))
    {
      EndGame(8);
    }
    if (Input.GetKeyDown(KeyCode.Alpha9))
    {
      EndGame(9);
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Start();
    }
  }

  void PrintEnd()
  {
    Debug.Log("There is enough apples.");
    Debug.Log(count + " steps");
  }

  void EndGame(int number)
  {
    if (apples < final_apples)
    {
      Summ(number);
    }
    else
    {
      PrintEnd();
    }
  }
  
  void Summ(int number)
  {
    apples = apples + number;
    count++;
    Debug.Log(number);
    Debug.Log("I have: " + apples + " apples");
    if (apples >= final_apples)
    {
      PrintEnd();
    }
  }
}