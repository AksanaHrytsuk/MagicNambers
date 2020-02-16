using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MagicNambersUi : MonoBehaviour
{
  private const int V = 0;
  public int guess;
    public int minNumber = 1;
    public int maxNumber = 1000;
    public Text textguess;
    public TextMeshProUGUI textCount;
    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        guess = Random.Range(minNumber, maxNumber + 1);
        textguess.text = "Ваше число " + guess.ToString() + "?";
        textCount.text = ("Надеюсь, я угадал.");
    }

    // Update is called once per frame
    void Update()
    {

    }
     public void UpdateGuess()
    {
        Debug.Log("Ваше число: " + guess + "?");
        count++;
    }
}


