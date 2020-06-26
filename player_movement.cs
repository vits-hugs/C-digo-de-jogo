using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Transform AttackPoint;
    public float moveSpeed = 5f;
    Vector3 characterScale;

    int corrida = 1;
   

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    Vector3 jog;
    Vector3 natura;

    Vector3 lado;
    Vector3 lad;

    Vector3 ladod;
    Vector3 ladd;

    //cima
    Vector3 cima;
    Vector3 emcima;
    
    void Start()
    {
        jog.x = -0.209f;
        jog.y = -2f;
        natura = jog;
        lad.x = -1.95f;
        lad.y = -0.05f;
        ladd.x = 1.95f;
        ladd.y = -0.05f;

        cima.x = -0.209f;
        cima.y = 1f;
    }

    
    
  
    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y =Input.GetAxisRaw("Vertical");
      

       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.sqrMagnitude);
       natura = transform.position + jog;
       lado = transform.position + lad;
       ladod = transform.position + ladd;
       emcima = transform.position + cima;
       characterScale = transform.localScale;
       if (Input.GetAxis("Horizontal") > 0) {
           animator.SetBool("prafrente", false);
           animator.SetBool("cima",false);
               if(AttackPoint.position != ladod){
                AttackPoint.position = ladod;

           }      
        
           characterScale.x = -5;
       }
        if (Input.GetAxis("Horizontal") < 0) {
            animator.SetBool("prafrente", false);
            animator.SetBool("cima",false);   
             if(AttackPoint.position != lado){
                AttackPoint.position = lado;
                }
           characterScale.x = 5;
       }
        transform.localScale =  characterScale;  
       if (Input.GetAxis("Vertical") < 0) {
           animator.SetBool("prafrente", true);
           animator.SetBool("cima",false);
            if(AttackPoint.position != natura){
                AttackPoint.position = natura;

               
           }   
       }

           
       if (Input.GetAxis("Vertical") > 0){
           animator.SetBool("prafrente", false);
           animator.SetBool("cima", true);
           if(AttackPoint.position != emcima){
                AttackPoint.position = emcima;
           }
          
          
       }
       if(Input.GetKey(KeyCode.K))
       {
           corrida = 5;
       }
       else
       {
           corrida = 1;
       }
       
      
      
    

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement  * moveSpeed * corrida * Time.fixedDeltaTime);
      
    }
}
