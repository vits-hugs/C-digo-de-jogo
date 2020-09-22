using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogueManager : MonoBehaviour
{   
    public Animator player;
    public Animator anim;
    public Text nametext;
    public Text falas;
    public Dialogue vai;
    private Queue<string> frases;
    // Start is called before the first frame update
    void Start()
    {
        frases = new Queue<string>();
        StartDialogue(vai);
    }

    public void StartDialogue (Dialogue dialogue)
    {
        nametext.text = dialogue.name;

        frases.Clear();

        foreach (string frase in dialogue.frases)
        {
            frases.Enqueue(frase);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(frases.Count == 0)
        {
            EndDialogue();
            SceneManager.LoadScene(4);            
        }
        anim.SetInteger("start",anim.GetInteger("start")+ 1);
        player.SetInteger("plauer",anim.GetInteger("start"));
        string frase = frases.Dequeue();
        //falas.text = frase; mostra tudo
        StopAllCoroutines();//impedir que continue a escrever depois que pulou o dialogo
        StartCoroutine(TypeFrase(frase));
    }

    IEnumerator TypeFrase(string frase)
    {
        falas.text = "";
        foreach (char letra in frase.ToCharArray())
        {
            falas.text += letra;
            yield return null;
        }
    }

    void EndDialogue(){
        Debug.Log("acabou");
    }



}
