using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelTime : MonoBehaviour
{
    static double tempo = 0;


    // Start is called before the first frame update
    void Start()
    {
     tempo = CountDownTimer.timeValue;
    }


}