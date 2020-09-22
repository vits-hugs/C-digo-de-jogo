using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidemovement : MonoBehaviour
{   bool d = true;
    public Rigidbody2D rb;
    public float speed=10f;
    Vector2 movement;
    public GameObject bulletPrefab;
    float firerate = 0.3f;

    public AudioSource caboom;
    // Start is called before the first frame update
    void Start()
    {
        caboom = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if(Input.GetKey(KeyCode.F)){
            if(d==true){
                StartCoroutine(atirar());
            }
        }
    
        if(Input.GetKey(KeyCode.LeftShift)){
            speed = 3;
            firerate = 0.2f;

        }
        else{
            speed = 10;
            firerate = 0.3f;
        }
        
    }
    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
  
    }

    IEnumerator atirar(){
        d = false;
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = rb.position;
        yield return new WaitForSeconds(firerate);
        caboom.Play();
        d = true;
        
    
    }
}
