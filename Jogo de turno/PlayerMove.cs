using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator anim;
    
    //velocidade vertical e horizontal
    public float Hvelo;
    public float Vvelo;
    
    private Vector2 movimento;
    
    [SerializeField]
    private float speed;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
      Hvelo =   Input.GetAxisRaw("Horizontal");
      Vvelo =   Input.GetAxisRaw("Vertical");
      movimento = new Vector2(Hvelo,Vvelo);
      anim.SetFloat("Hvelo",Hvelo);
      anim.SetFloat("Vvelo",Vvelo);
    }
    void FixedUpdate(){
        rb.MovePosition(rb.position + movimento.normalized * speed * Time.deltaTime);
    }
   
}
