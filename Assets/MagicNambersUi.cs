using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MagicNambersUi : MonoBehaviour
{
    public int guess;
    public int minNumber = 1;
    public int maxNumber = 1000;
    public Text textguess;
    public TextMeshProUGUI textCount;


    // Start is called before the first frame update
    void Start()
    {
        guess = Random.Range(minNumber, maxNumber + 1);
        guess = (minNumber + maxNumber) / 2;
        textguess.text = "Ваше число " + guess.ToString() + "?";
        textCount.text = "Ololo";
    }

    // Update is called once per frame
    void Update()
    {

    }
}


