using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
   public GameObject textDisplay;
   public int secondsLeft = 30;
   public bool takingAway = false;
   public static Timer instance;
   public string nomeNivel;


    void Start(){
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    void Update(){
        if(takingAway == false && secondsLeft >0){
            StartCoroutine(TimerTake());
        }
        //QUANDO ACABA O TEMPO DO OLHO DIREITO
        /*if(nomeNivel == "D_nivel_1a" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1a_opacity-10");
        }
        if(nomeNivel == "D_nivel_1b" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1b_opacity-10");
        }
        if(nomeNivel == "D_nivel_1c" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1c_opacity-10");
        }
        if(nomeNivel == "D_nivel_1" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1_opacity-10");
        }
        if(nomeNivel == "D_nivel_2" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_2_opacity-10");
        }
        if(nomeNivel == "D_nivel_3" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_3_opacity-10");
        }
        if(nomeNivel == "D_nivel_4" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_4_opacity-10");
        }
        if(nomeNivel == "D_nivel_5" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_5_opacity-10");
        }
        if(nomeNivel == "D_nivel_6" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_6_opacity-10");
        }
        if(nomeNivel == "D_nivel_7" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_7_opacity-10");
        }
        if(nomeNivel == "D_nivel_1a_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1a_MAX");
        }
        if(nomeNivel == "D_nivel_1b_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1b_MAX");
        }
        if(nomeNivel == "D_nivel_1c_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1c_MAX");
        }
        if(nomeNivel == "D_nivel_1_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_1_MAX");
        }
        if(nomeNivel == "D_nivel_2_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_2_MAX");
        }
        if(nomeNivel == "D_nivel_3_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_3_MAX");
        }
        if(nomeNivel == "D_nivel_4_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_4_MAX");
        }
        if(nomeNivel == "D_nivel_5_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_5_MAX");
        }
        if(nomeNivel == "D_nivel_6_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_6_MAX");
        }
        if(nomeNivel == "D_nivel_7_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("D_nivel_7_MAX");
        }

        //QUANDO ACABA O TEMPO DO OLHO ESQUERDO
        if(nomeNivel == "E_nivel_1a" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1a_opacity-10");
        }
        if(nomeNivel == "E_nivel_1b" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1b_opacity-10");
        }
        if(nomeNivel == "E_nivel_1c" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1c_opacity-10");
        }
        if(nomeNivel == "E_nivel_1" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1_opacity-10");
        }
        if(nomeNivel == "E_nivel_2" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_2_opacity-10");
        }
        if(nomeNivel == "E_nivel_3" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_3_opacity-10");
        }
        if(nomeNivel == "E_nivel_4" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_4_opacity-10");
        }
        if(nomeNivel == "E_nivel_5" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_5_opacity-10");
        }
        if(nomeNivel == "E_nivel_6" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_6_opacity-10");
        }
        if(nomeNivel == "E_nivel_7" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_7_opacity-10");
        }
        if(nomeNivel == "E_nivel_1a_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1a_MAX");
        }
        if(nomeNivel == "E_nivel_1b_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1b_MAX");
        }
        if(nomeNivel == "E_nivel_1c_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1c_MAX");
        }
        if(nomeNivel == "E_nivel_1_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_1_MAX");
        }
        if(nomeNivel == "E_nivel_2_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_2_MAX");
        }
        if(nomeNivel == "E_nivel_3_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_3_MAX");
        }
        if(nomeNivel == "E_nivel_4_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_4_MAX");
        }
        if(nomeNivel == "E_nivel_5_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_5_MAX");
        }
        if(nomeNivel == "E_nivel_6_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_6_MAX");
        }
        if(nomeNivel == "E_nivel_7_opacity-10" && secondsLeft == 0){
            SceneManager.LoadScene("E_nivel_7_MAX");
        }*/
    }

   IEnumerator TimerTake(){
       takingAway = true;
       yield return new WaitForSeconds(1);
       secondsLeft -= 1;
       if(secondsLeft<10){
           textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
       }
       else{
       textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
       }
       takingAway = false;
   }



  
}
