using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class iniciaCombate : MonoBehaviour
{
    [SerializeField]
    public GameObject vilao;
    
    //registro da posição do jogador e da camera pré-combate.
    public Vector3 salva_pos;
    private Vector3 saveCam;
    
    private Animator anim;
    
    //posições pré-definidas pra momento do combate
    public Transform enemyPlace;
    public Transform jogadorPlace;
    public Transform camPlace;
    
    public Transform camera;

    private SpriteRenderer sprite;

    public GerenciadorBatalha geBat;
    

    [SerializeField]
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    public void sumacombat(){
        vilao = null;
        canvas.SetActive(false);
        this.transform.position = salva_pos;
        camera.transform.position = saveCam;
        this.GetComponent<PlayerMove>().enabled = true;
        anim.SetBool("isCombate",false);
    }
    void OnTriggerEnter2D(Collider2D other){
        saveCam = new Vector3(camera.transform.position.x,camera.transform.position.y,-10);
        camera.transform.position = new Vector3(camPlace.position.x,camPlace.position.y,-10) ;
        anim.SetBool("isCombate",true);
        vilao = other.gameObject;
        Debug.Log(vilao);
        sprite = vilao.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName="Combate";
        canvas.SetActive(true);
        geBat.ReStart();
        salva_pos = new Vector3(transform.position.x,transform.position.y,0);
        vilao.transform.position = new Vector3(enemyPlace.position.x,enemyPlace.position.y,0);
        this.transform.position = new Vector3(jogadorPlace.position.x,jogadorPlace.position.y,0);
        this.GetComponent<PlayerMove>().enabled = false;
        

    }

    
    
}
