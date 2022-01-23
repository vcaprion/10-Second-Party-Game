using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 10f;
    float timeLeft;
    public GameObject winText;


    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }

        else
        {
            winText.SetActive(true);
            Time.timeScale = 0;
        
        }
            if (Input.GetKeyDown("escape"))
            {
            Application.Quit();
            }
        
    }
}
