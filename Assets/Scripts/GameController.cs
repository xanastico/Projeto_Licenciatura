using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int scoreTotal;
    public Text scoreText;
    public GameObject gameOver;
    public static GameController instance;




    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }


    //SCORE
    public void UpdateScoreText(){
        scoreText.text = scoreTotal.ToString();
    }


    //GAME OVER
    public void ShowGameOver (){
        gameOver.SetActive(true);
    }


    //RESTART NIVEL
    public void RestartGame(string Xnivel)
    {
        SceneManager.LoadScene(Xnivel);
    }


}
