using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{   
    //interações
    private string _fala = "cu";
    private GameObject jogador;
    private Inimigo Jogador;
    //status base
    [SerializeField]
    protected float vidaMax ;

    //Combate
    [SerializeField]
    protected float vidaAtual;
    [SerializeField]
    private bool isDead;

    #region statusVar
    private int Veneno;

    #endregion
    void Start(){
        vidaAtual = vidaMax;
        isDead = false;
        jogador = GameObject.FindGameObjectWithTag("Player");
    }

    public void TakeDamage(float dano){
        vidaAtual -= dano;
        if(vidaAtual <= 0)
        {
            isDead = true;
        }
        else{
            Debug.Log("au");
        }

    }
 
    public void SetVeneno(int verruga)
    {
        Veneno = verruga;
        Debug.Log(Veneno);
        
    }
    public void Envenenado(int v1)
    {
        TakeDamage(v1);
    }
    public virtual void Fazturno()
    {
        this.Envenenado(Veneno);
        Debug.Log("venaf");
    }

    public virtual string Agir()
    {
        Debug.Log("agindo");
        return _fala;
    }

    public virtual void Atacar(float dano)
    {
        Jogador = jogador.GetComponent<Inimigo>();
        Jogador.TakeDamage(dano);

    }
    
    public virtual bool IsDead(){
        return isDead;
        Destroy(this.gameObject);
    }

    public float Getvida()
    {
        return vidaAtual;
    }
    public float Getvidamax()
    {
        return vidaMax;
    }

}
