using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vidaHUD : MonoBehaviour
{   
    public TimeManager diavolo;
    public GameObject guerreiro;
    public Transform x;
    public static int vida;
    public Chacoalha chacoalha;

    AudioSource dano;
    bool g=false;
    bool o = true;
    bool tomadano = true;
    bool tomidano =true;
    public Animator vidaframe;
    
    // Start is called before the first frame update
    void Awake()
    {
        dano = GetComponent<AudioSource>();
        vida = 3;
    }
    // Update is called once per frame

    void Update()
    {
        /*switch (vida){
            case 1:
            vidaframe.SetTrigger("vida2");
            dano.Play();
            break;
            case 2:
            dano.Play();
            vidaframe.SetTrigger("more");
            break;
            default:
            break;
        }
        */
        if (vida == 2){
            vidaframe.SetTrigger("vida2");
            if(tomadano == true)
            {
                dano.Play();
                tomadano = false;
            }
        }
        if (vida == 1){
            if(tomidano == true)
            {   
                dano.Play();
                tomidano = false;
            }
            vidaframe.SetTrigger("more");
        }
        
        if(pontos.score > 150)
        {
            g = o;
        }
        if (vida > 0){
        return;  
        }
        else
        {   
            if(g == true){
            diavolo.Chegadapica();
            StartCoroutine(chacoalha.Shake(0.2f,.4f));
            GameObject b = Instantiate(guerreiro) as GameObject;
            b.transform.position= x.transform.position;
            o = false;
            vida =1;
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject target in gameObjects)
            {
                GameObject.Destroy(target);
            }
            }
            
            else{
            
            if( pontos.score > PlayerPrefs.GetFloat("Highscore",0))
            {  
            PlayerPrefs.SetFloat("Highscore", pontos.score);
            }
            SceneManager.LoadScene("PERDESTE");
            }
        }          
    }
}
