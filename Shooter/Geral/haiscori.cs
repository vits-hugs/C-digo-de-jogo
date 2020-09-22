using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class haiscori : MonoBehaviour
{
    Text haircore;
    // Start is called before the first frame update
    void Awake()
    {
        haircore = GetComponent<Text>();
        
    }
    void Start(){
        haircore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore").ToString();
    }

    public void Reset ()
    {
        PlayerPrefs.DeleteKey("Highscore");
    }
    
}
