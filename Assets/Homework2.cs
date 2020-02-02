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
      Summ(1);
    }
    if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      Summ(2);
    }
    if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      Summ(3);
    }
    if (Input.GetKeyDown(KeyCode.Alpha4))
    {
      Summ(4);
    }
    if (Input.GetKeyDown(KeyCode.Alpha5))
    {
      Summ(5);
    }
    if (Input.GetKeyDown(KeyCode.Alpha6))
    {
      Summ(6);
    }
    if (Input.GetKeyDown(KeyCode.Alpha7))
    {
      Summ(7);
    }
    if (Input.GetKeyDown(KeyCode.Alpha8))
    {
      Summ(8);
    }
    if (Input.GetKeyDown(KeyCode.Alpha9))
    {
      Summ(9);
    }
  }
  void Summ(int number)
  {
    if (apples < final_apples)
    {
      apples = apples + number;
      Debug.Log(number);
      Debug.Log("I have: " + apples + " apples");
      count++;
    }
    else
    {
      Debug.Log("There is enough apples.");
      Debug.Log(count + " steps");
      Start();
    }
  }
}
