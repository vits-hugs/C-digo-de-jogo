using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{   
    public Transform lancer;
    public GameObject lazer;
    public int mana = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if(mana > 0){
            Lazer();
            mana --;
            }
        }
        
    }
    void Lazer()
    {
     for(int i = 0;i < 3; i++){
       GameObject b = Instantiate (lazer) as GameObject;
       b.transform.position = new Vector2(-3 + i * 2.5f,-14f);
     }

    }
}
