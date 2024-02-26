using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] RectTransform fade;

    private void Start(){

        //Fade-transiçao
        fade.gameObject.SetActive(true);

        LeanTween.alpha (fade, 0, 0);
        LeanTween.alpha (fade, 1, 0.5f).setOnComplete (() => {
             fade.gameObject.SetActive (false);
        });
    }


    //MainMenu- Botão JOGAR
    public void PlayGame(){
        fade.gameObject.SetActive(true);

        LeanTween.alpha (fade, 0, 0);
         LeanTween.alpha (fade, 1, 0.5f).setOnComplete (() => {
             // tempo de espera antes de carregar o proximo nivel
             Invoke ("LoadGame", 0.5f);
         });
    }

    private void LoadGame () {
        SceneManager.LoadScene ("EscolhaDoOlho");
    }


    //MainMenu- Botão SAIR
    public void Quit(){
        Debug.Log("SAIU");
        Application.Quit();
    }

}
