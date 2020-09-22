using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slow = 0.05f;
    public float slowduraçao = 2f;

    void Update()
    {
        Time.timeScale += (1f / slowduraçao) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void Chegadapica(){
        Time.timeScale = slow;
    }
}
