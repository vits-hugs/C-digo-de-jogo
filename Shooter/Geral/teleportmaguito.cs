using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportmaguito : MonoBehaviour
{
    Vector3 posicao;
    private Vector2 screenBounds;
    public Rigidbody2D rb;
    public Animator mago;
    public GameObject vai;
    

    // Start is called before the first frame update
    void Start()
    {

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        posicao.x += 2f;
        StartCoroutine( teleporte(posicao));
        rb.velocity = new Vector3(0,-5,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < - screenBounds.y){
        vidaHUD.vida --;
        Destroy(this.gameObject);
        }
        
    }
    IEnumerator teleporte(Vector3 pastel){
        while(true){
        mago.SetTrigger("Telport");
        vai.GetComponent<Collider2D>().enabled=true;
        yield return new WaitForSeconds(0.8f);
        vai.GetComponent<Collider2D>().enabled=false;
        if (transform.position.x + pastel.x > 2.5 ){
            pastel.x = -pastel.x;
         
        }
        if(transform.position.x + pastel.x < -3.5f){
            pastel.x = -pastel.x;
        }
        transform.position += pastel;
        }
    
    }
}
