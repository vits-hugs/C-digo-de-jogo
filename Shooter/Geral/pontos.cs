using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pontos : MonoBehaviour
{   

    public GameObject [] spawner;
    public GameObject GM;
    public static float score;
    public Image barra;
    private float calculo;
    
    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent <Text> ();
        score=0;
    
   
    }

    // Update is called once per frame
    void Update()
    {
      calculo = score/100;
     barra.fillAmount = calculo;
     text.text = "" + score;
     if(score > 25){
       Destroy(spawner[0]);

     GM.GetComponent<Spawndeondas>().enabled = true;
     }
     if(score > 50){
         GM.GetComponent<Spawndeondas>().enabled = false;
    
        spawner[1].GetComponent<sumon>().enabled = true;
     }
    
    
     }

 
    
}
