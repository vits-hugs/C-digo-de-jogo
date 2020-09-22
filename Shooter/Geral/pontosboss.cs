using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontosboss : MonoBehaviour
{   
    public GameObject faze1;
    public GameObject faze2;
    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent <Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + pontos.score;
        
        if(pontos.score > 150)
        {
            faze1.GetComponent<Spawndeondas>().enabled=false;

        }
    }
}
