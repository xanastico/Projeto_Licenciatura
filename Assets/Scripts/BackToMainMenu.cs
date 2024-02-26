using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{

    public GameObject PanelUi;

//MainMenu- voltar
    public void PlayGame(){
        SceneManager.LoadScene("Menu"); 
    }
}
