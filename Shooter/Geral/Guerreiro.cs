using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerreiro : MonoBehaviour
{   
    public AudioSource grito;
    
    float hvelo = 2f;
    public Rigidbody2D guerreiro;
    Vector3 movement;
    float velo = 15f;
    Vector3 charScale;

    bool vez = false;
    // Start is called before the first frame update
    void Start()
    {
        grito = GetComponent<AudioSource>();
        guerreiro.velocity = new Vector2(-velo,0);
        grito.Play();
        
        charScale = transform.localScale;
        transform.Rotate(0,0,90);
    }

    void Update(){
        {
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        movement = transform.position;
        
        if(transform.position.y > 10)
        {
            guerreiro.velocity = new Vector2 (0,-velo);
            movement.x = transform.position.x + hvelo;
            transform.position = movement;
            charScale.y = -1;
        
            
        }
          if(transform.position.y < -8)
        {
            guerreiro.velocity = new Vector2 (0,velo);
            movement.x = transform.position.x + hvelo;
            transform.position = movement;
            charScale.y = 1;
            
        }

        if(transform.position.x > 2.5f)
        {
            hvelo = -hvelo;
        }

        if(transform.position.x < -3.5f)
        {
            
            Destroy(this.gameObject);
        }
        if(transform.position.x < -3.3f )
        {
            if (vez == false){
                transform.Rotate(0,0,-90);
                vez = true;
            }
            guerreiro.velocity = new Vector2 (0,velo);
            
        }
        transform.localScale = charScale;
    }


       


    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
       
    }
}
