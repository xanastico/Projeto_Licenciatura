using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    //variaveis
    static public float timeValue = 1;
    public Text timerText;



    // Update is called once per frame
    void Update()
    {
        if(timeValue>0){
            timeValue += Time.deltaTime;
        }else{
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }


    //Timer
    void DisplayTime(float timeToDisplay){
        if(timeToDisplay < 0 ){
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{00:00}:{1:00} Min", minutes, seconds);
    }
}
