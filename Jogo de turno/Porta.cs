using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Troca de cenas
public class Porta : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
