using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumonerfinal : MonoBehaviour
{
    public GameObject [] bichus;
    public float respawnTime = 0.5f;
    private Vector2 screenBounds;
    bool d = true;
    // Start is called before the first frame update
    void Start()
    {
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    
    }
    void Update(){
        if ( pontos.score > 154){
            if (d == true){
            StartCoroutine(invocadorfinale());
            d = false;
            }
        }
    }
    private void sumonafinal(){
        GameObject a  = Instantiate(bichus[Random.Range(0,bichus.Length)]) as GameObject;
        a.transform.position = transform.position;

    }

    IEnumerator invocadorfinale(){
        while(true){
        yield return new WaitForSeconds(respawnTime);
        sumonafinal();
        }

    }
}