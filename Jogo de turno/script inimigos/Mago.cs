using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mago : Inimigo
{

    private int ChoiceAtaque;
    
  public override string Agir()
  { 
      ChoiceAtaque = Random.Range(0,2);
      if(ChoiceAtaque == 0)
      {
      Misseis();
      return "misseis magicos";
      }
      else{
        BoladeFogo();
        return "pow";
      }
      Debug.Log("mago");
      return "mago";
  }
  
  #region Ataques
  
  private void Misseis()
  {
    Atacar(Random.Range(0,4));
  }
  private void BoladeFogo()
  {
      Atacar(2);
  }


  #endregion
}
