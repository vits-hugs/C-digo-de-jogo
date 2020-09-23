using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{   public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public Animator exprode;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > screenBounds.y * 2){
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if  (other.tag == "Enemy"){
            
            pontos.score ++;
           
            Destroy(other.gameObject);
            exprode.SetTrigger("exploda");

        }
        
        Destroy(this.gameObject,0.1f);
    }
}
