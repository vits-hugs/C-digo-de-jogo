using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quebravel : MonoBehaviour
{
    public Animator vaso;
    public int maxVida = 100;
    int currentVida;
    // Start is called before the first frame update
    void Start()
    {
        currentVida = maxVida;
        
    }

    public void TakeDamage(int damage)
    {
        currentVida -= damage;

        // play hurt animation
        vaso.SetTrigger("Hurt");
        if (currentVida <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("w bwnufi nieewty");

        vaso.SetBool("isquebrado", true);
        // morte
        //disabilita
        GetComponent<Collider2D>().enabled=false;
        if (this.gameObject.tag == "morre")
        {
            Destroy(gameObject,0.5f);
        }
        else{
            Destroy(gameObject,5f);
        }
        this.enabled = false;

    }

  
}
