using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fernando : Inimigo
{
    private string fernando = "Ovo chamar o leonir";
    private string pastel = "não aguento mais segurar parede";
    public override string Agir()
    {
        if(Getvida() == 1)
        {
            SoltarParede();
            return pastel;
        }
        Debug.Log("paredepareduda");
        return fernando;
    }
    #region ataques
    private void  SoltarParede()
    {
        Atacar(999);
    }
   

    #endregion
  
}
