using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumon : MonoBehaviour
{
    public GameObject [] bichus;
    public float respawnTime = 0.5f;
    private Vector2 screenBounds;
    
    // Start is called before the first frame update
    void Start()
    {
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    StartCoroutine(invocador());
    }
    void Update(){
   
    }
    private void sumona(){
        GameObject a  = Instantiate(bichus[Random.Range(0,bichus.Length)]) as GameObject;
        a.transform.position = new Vector2(Random.Range(-3,3),screenBounds.y);

    }

    IEnumerator invocador(){
        while(true){
        yield return new WaitForSeconds(respawnTime);
        sumona();
        }

    }
}