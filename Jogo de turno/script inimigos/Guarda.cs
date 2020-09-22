using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guarda : Inimigo
{
    private string aviso = "Toma cuidado";
    private string soltar = "Eu avisei!!!";
    public override string Agir()
    {
        if(Getvida() == 1)
        {
            SoltarParede();
            return soltar;
        }
        return aviso;
    }
    
    #region ataques
    private void  SoltarParede()
    {
        Atacar(999);
    }
   

    #endregion
  
}
