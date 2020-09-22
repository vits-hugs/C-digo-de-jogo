using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralxzimzim : MonoBehaviour
{
    public GameObject tela;
    public float reTime = 0.5f;

    void Start(){

    StartCoroutine(aizim());
    }
    private void paralalala(){
        GameObject a  = Instantiate(tela) as GameObject;
        a.transform.position = this.transform.position;

    }

    IEnumerator aizim(){
        while(true){
            yield return new WaitForSeconds(reTime);
            paralalala();
        }

    }
    
}
