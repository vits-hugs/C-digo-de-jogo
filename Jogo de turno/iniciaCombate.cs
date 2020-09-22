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

    public GerenciadorBatalha getBat;
    

    [SerializeField]
    private GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    public void sumacombat(){
        vilao = null;
        canvas.SetActive(false);
        this.transform.position = salva_pos;
        camera.transform.position = saveCam;
        this.GetComponent<PlayerMove>().enabled = true;
        anim.SetBool("isCombate",false);
    }
    
    //Essa Função é chamada quando ocorre colisão
    void OnTriggerEnter2D(Collider2D other){
    // salvando e configurando posição da camera
        saveCam = new Vector3(camera.transform.position.x,camera.transform.position.y,-10);
        camera.transform.position = new Vector3(camPlace.position.x,camPlace.position.y,-10) ;
      
        anim.SetBool("isCombate",true);
        //Configurando inimigo
        vilao = other.gameObject;
        sprite = vilao.GetComponent<SpriteRenderer>();
        sprite.sortingLayerName="Combate";
        
        //Ativando tela de combate
        canvas.SetActive(true);
        getBat.ReStart();
        salva_pos = new Vector3(transform.position.x,transform.position.y,0);
        // definindo posição do jogador e inimigo 
        vilao.transform.position = new Vector3(enemyPlace.position.x,enemyPlace.position.y,0);
        this.transform.position = new Vector3(jogadorPlace.position.x,jogadorPlace.position.y,0);
        //Desabilita jogador 
        this.GetComponent<PlayerMove>().enabled = false;
    }

    
    
}
