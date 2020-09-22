using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tia_luh : Inimigo
{

    private int ChoiceAtaque = 0;
    
  public override string Agir()
  { 
      ChoiceAtaque = Random.Range(0,2);
      if(ChoiceAtaque == 0)
      {
      ChuvadePoligonos();
      return "chuveneos de poliguenos";
      }
      else{
        EquaçãoMortal();
        return "pow";
      }
      Debug.Log("sou tia lue");
      return "sou tia lue";
  }
  #region Ataques
  private void ChuvadePoligonos()
  {
    Atacar(Random.Range(0,4));
  }
  private void EquaçãoMortal()
  {
      Atacar(2);
  }


  #endregion
}
