using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class leveloader : MonoBehaviour
{
    public Animator transition;
    // Update is called once per frame
    public Chacoalha chacoalha;
    public GameObject terremoto;
    bool g = true;
    

    void Update()
    {   
        if(pontos.score > 100)
        {   
            if(g == true){
            GameObject b =Instantiate(terremoto) as GameObject;
            g = false;
            }
            
            StartCoroutine(chacoalha.Shake(2f,.4f));
              GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject target in gameObjects)
            {
                GameObject.Destroy(target);
            }
            LoadNextLevel();
        }
        
    }

    void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(3));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}
