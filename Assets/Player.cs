using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public Enemy enemyVar;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, my name is " + playerName);
        Debug.Log(enemyVar);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
