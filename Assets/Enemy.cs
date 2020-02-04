using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player playerVar;

    // Start is called before the first frame update
    void Start()
    {
        playerVar.playerName = "Bad player";
        Debug.Log("Hello" + playerVar.playerName + "I am your enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
