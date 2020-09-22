using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public enum BattleState {PLAYERTURN,ENEMYTURN,WON,LOST}
public class GerenciadorBatalha : MonoBehaviour
{
    #region Ataquelogic
    public float danoPlayer = 2;
    bool isTonto = false;
    #endregion
    
    //referencia ao player a classe Inimigo controla as variaveis chaves tanto do player quanto dos inimigos.
    public GameObject player; 
    private Inimigo playervida; // vida do player
    
    private iniciaCombate initCombat;
    private GameObject InimigoGO; // Referencia ao Game Object do inimigo
    public Inimigo inimigo; 
    
    // texto que fica na tela durante o combate.
    public Text BattleText;
   
    public BattleState  state;
    
    public void ReStart()
    {
        initCombat = player.GetComponent<iniciaCombate>();
        InimigoGO = initCombat.vilao;

        playervida = player.GetComponent<Inimigo>();

        BattleText.text =  "Inicio de combate";
        inimigo = InimigoGO.GetComponent<Inimigo>();
        PlayerTurn();
    }
    void PlayerTurn(){
        state = BattleState.PLAYERTURN;
    }
    #region Lógica botão //Funções para serem chamadas a partir de botões clicaveis no jogo.
    public void OnAttackButton()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }

         PlayerAttack();
          if(inimigo.IsDead() == true){
            Debug.Log("you win");
            state = BattleState.WON;
            initCombat.sumacombat();
            Destroy(InimigoGO);
           
        }
        else{
         state = BattleState.ENEMYTURN;
         StartCoroutine(Enemyturn());
        }
        
    }
    public void OnEscudoButton()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }
        PlayerStun();
         if(inimigo.IsDead() == true){
            Debug.Log("you win");
            state = BattleState.WON;
            initCombat.sumacombat();
            Destroy(InimigoGO);
           
        }
        else{
         state = BattleState.ENEMYTURN;
         StartCoroutine(Enemyturn());
        }
    }
    public void OnDardoButton()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }
        DardoVenenoso();
        state = BattleState.ENEMYTURN;
        StartCoroutine(Enemyturn());

    }
    public void OnPassTurnButton()
    {
        state = BattleState.ENEMYTURN;
        StartCoroutine(Enemyturn());
    }
    #endregion
    
    #region ataquescript
    public void PlayerAttack(){
        Debug.Log("pow");
        BattleText.text = "yaaa";
        inimigo.TakeDamage(danoPlayer);
      
    }
    public void PlayerStun()
    {
        BattleText.text = "Escudada";
        inimigo.TakeDamage(danoPlayer/2);
        isTonto = true;
    }
    public void DardoVenenoso()
    {
        BattleText.text = "Você envenenou o inimigo";
        inimigo.SetVeneno(1);

    }

    #endregion

    public void mata(){
        Destroy(InimigoGO);
    }
    IEnumerator Enemyturn(){
        inimigo.Fazturno();
        yield return new WaitForSeconds(1f);
        if(isTonto == true)
        {
            if(Random.Range(0,2) == 1 )
            {
              BattleText.text = inimigo.Agir();  
            }
            else{
                BattleText.text = "seu inimigo não conseguiu atacar";
            }
           
        }
        else{
        BattleText.text = inimigo.Agir();
        
        }
        isTonto = false;
        yield return new WaitForSeconds(1f);
        
        
       
        if(playervida.IsDead() == true){
            StartCoroutine(StarteMorte());
        }
        else{
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
        IEnumerator StarteMorte()
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("YouDead");

        }
    }



 
}
