using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congela : MonoBehaviour
{
    public float duration = 1f;
    bool isFrozen = false;
    void Update()
    {
        if (batatinha > 0 && !isFrozen)
        {
            StartCoroutine(freza());
        }
        
    }

    float batatinha = 0f;

    public void Congelador(){
        batatinha = duration;
    }

    IEnumerator freza(){
        isFrozen = true;
        var original = Time.timeScale;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = original;
        batatinha =0;
        isFrozen = false;
    }
}

