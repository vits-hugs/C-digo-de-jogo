using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batvoa : MonoBehaviour{

    private Vector2 screenBounds;
    public Rigidbody2D rb;
    public Animator eu;

    public GameObject slimefusaumprefab;

    void Start(){
     
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rb.velocity = new Vector3(0,-10,0);
        

       
 
    }
    void Update(){
        if(transform.position.y < - screenBounds.y){
            vidaHUD.vida --;
            Destroy(this.gameObject);
        }
    }
  
    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.name == "slimelittloe(Clone)"){
        Destroy(col.gameObject);
        eu.SetTrigger("slimefusion");


        }
    }
    void transforma(){
        GameObject b = Instantiate(slimefusaumprefab) as GameObject;
        b.transform.position = rb.position;
        Destroy(this.gameObject);
    }
    
    
    
    


}



