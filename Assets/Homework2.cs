using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2 : MonoBehaviour
{
  // Start is called before the first frame update
  // Переменная объявлена на уровне класса для подсчета суммы
  int apples;
  // переменная объявлена на уровне класса для подсчета колисечтва шагов
  int count;
  //переменная объявлена на уровне класса как индикатор окончания игры
  int final_apples = 50;
  //метод Start() ничего не возвращает и не принимает  аргумент(ы). Тело функции: Вывод сообщений в консоль, переменной apples и count 
  //присвоено значение 0, так как на начало игры ходов 0 и сумма 0
  void Start()
  {
    Debug.Log("Welcome to the game!");
    Debug.Log("Enter numbers from 1 to 9");
    apples = 0;
    count = 0;
  }

  // Update is called once per frame
  
  // Метод Update() ничего не возвращает и не принимает аргумент(ы). Input.any.Key.Down - регистрация нажатия любой кнопки, при которой 
  // вызывается метод EndGame И если зарегистрировано нажатие Space, то вызов метода Start()
  // Метод EndGame() ничего не возвращает и не принимает аргумент(ы). Тело метода: при условии, если сумма < 50, то вывзывается метод
  // SummAples(int number) принимает аргумент типа int. Тело метода: происходит подсчет суммы и количества ходов.
  // SummApples(GetButton()), который принимает медот GetButton() в качестве аргумента, иначе игра заканчивается выводом сообщений, что описаны в EndGame() методе
  // Метод SummApples(GetButton()) ничего не возвращает, но принимает метод GetButton() в качестве аргумента. 
  // Метод GetButton() ничего не возвращает  и не принимает аргумент(ы). Тело метода: Объвлена переменная key с типом string. 
  // Метод прописан так, чтобы при вводе цифры даное число передавалось методу SummAplles а в случае ввода всего, кроме цифр программа не передавала аргумент методу, 
  // Но продалжала выводить сообщение: Debug.Log("You pressed '" + key + "' button.");
  void Update()
  {
    count++; 
    Debug.Log(count);
    if (Input.anyKeyDown)
    {
      EndGame();
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Start();
    }
  }

  int GetButton()
  {
    string key = Input.inputString;
    Debug.Log("You pressed '" + key + "' button.");
    int number = 0;
    int.TryParse(key, out number);
    return number;
  }

  void SummApples(int number)
  {
    if (number > 0)
    {
      apples = apples + number;
      Debug.Log("I have: " + apples + " apples");
      count++;
    }
  }

  void EndGame()
  {
    if (apples < final_apples) {
      SummApples(GetButton());
    }
    else {
      Debug.Log("There is enough apples.");
      Debug.Log("You used: " + count + " steps");
    }
  }
}