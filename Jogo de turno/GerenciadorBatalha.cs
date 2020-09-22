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

    public GameObject player;
    private Inimigo playervida;
    private iniciaCombate initCombat;
    private GameObject InimigoGO;

    public Text BattleText;
    public Inimigo inimigo;

    public BattleState  state;
    // Start is called before the first frame update
    public void ReStart()
    {
        initCombat = player.GetComponent<iniciaCombate>();
        InimigoGO = initCombat.vilao;

        playervida = player.GetComponent<Inimigo>();

        BattleText.text =  "mamão";
        state = BattleState.PLAYERTURN;
        inimigo = InimigoGO.GetComponent<Inimigo>();
        PlayerTurn();
    }
    void PlayerTurn(){
    
    }
    #region Lógica botão
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
    public void OnBafoButton()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }
        PlayerBafo();
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
    public void OnCuspidaButton()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }
        Cuspida();
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
    public void PlayerBafo()
    {
        BattleText.text = "bafo mortal";
        inimigo.TakeDamage(danoPlayer/2);
        isTonto = true;
    }
    public void Cuspida()
    {
        BattleText.text = "Cuspida aidética";
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
            Debug.Log("you morreu man");
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
 //   public void Restart()
  //  {
        //initCombat = null;
        //InimigoGO = null;
   //     inimigo = null;
    //    initCombat = player.GetComponent<iniciaCombate>();
    //    InimigoGO = initCombat.vilao;

    //    playervida = player.GetComponent<Inimigo>();

       // BattleText.text =  "mamão";
      //  state = BattleState.PLAYERTURN;
      //  PlayerTurn();
 //   }
    
    


 
}
