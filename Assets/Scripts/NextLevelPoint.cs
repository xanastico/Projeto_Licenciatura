using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
  [SerializeField] RectTransform fade;
  public Animator transition;
  public float transitionTime = 1f;
  public string nomeNivel;
  public WriteJson dados;
  public Jogada Player;





///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////   OLHO DIREITO   /////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

  //NIVEL INTRODUTORIO OLHO DIREITO PARA NIVEL 1a
  public void OnCollisionEnter2D(Collision2D collision){
    if(nomeNivel=="D_Introdutorio"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_1a");
        }); 
      }
    }  


    //NIVEL 1a -----> nivel 1b
    if(nomeNivel=="D_nivel_1a"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1b");
        }); 
      }
    }  

    //Nivel 1b -----> nivel 1c
    if(nomeNivel=="D_nivel_1b"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_1c");
        });  
      }
    }

    //Nivel 1c -----> nivel 1
    if(nomeNivel=="D_nivel_1c"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_1");
        });
           
      }
    }

    //Nivel 1 -----> nivel 2
    if(nomeNivel=="D_nivel_1"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_2");
        });
           
      }
    }

    //Nivel 2 -----> nivel 3
    else if(nomeNivel=="D_nivel_2"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_3");
        });
          
      }
    }

    //Nivel 3 -----> nivel 4
    else if(nomeNivel=="D_nivel_3"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_4");
        });
          
      }
    }

    //Nivel 4 -----> nivel 5
    else if(nomeNivel=="D_nivel_4"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
         WriteJson.instance.guarda();
         fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_5");
        });
         
      }
    }

    //Nivel 5 -----> nivel 6
    else if(nomeNivel=="D_nivel_5"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_6");
        });
          
      }
    }

    //Nivel 6 -----> nivel 7
    else if(nomeNivel=="D_nivel_6"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("D_nivel_7");
        });
          
      }
    }


    //Nivel 7 -----> FIM
    else if(nomeNivel=="D_nivel_7"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("Fim");
        });
          
      }
    }

    //OLHO DIREITO COM MENOS OPACIDADE
    ////////////////////////////////////


    //NIVEL 1a OLHO DIREITO com menos opacidade -----------------> nivel 1b
    if(nomeNivel=="D_nivel_1a_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1b");
        }); 
      }
    } 

    //NIVEL 1b OLHO DIREITO com menos opacidade -----------------> nivel 1c
    if(nomeNivel=="D_nivel_1b_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1c");
        }); 
      }
    } 


    //NIVEL 1c OLHO DIREITO com menos opacidade -----------------> nivel 1
    if(nomeNivel=="D_nivel_1c_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1");
        }); 
      }
    } 


    //NIVEL 1 OLHO DIREITO com menos opacidade -----------------> nivel 2
    if(nomeNivel=="D_nivel_1_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_2");
        }); 
      }
    } 


    //NIVEL 2 OLHO DIREITO com menos opacidade -----------------> nivel 3
    if(nomeNivel=="D_nivel_2_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_3");
        }); 
      }
    }


    //NIVEL 3 OLHO DIREITO com menos opacidade -----------------> nivel 4
    if(nomeNivel=="D_nivel_3_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_4");
        }); 
      }
    }

    //NIVEL 4 OLHO DIREITO com menos opacidade -----------------> nivel 5
    if(nomeNivel=="D_nivel_4_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_5");
        }); 
      }
    }

    //NIVEL 5 OLHO DIREITO com menos opacidade -----------------> nivel 6
    if(nomeNivel=="D_nivel_5_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_6");
        }); 
      }
    }
    

    //NIVEL 6 OLHO DIREITO com menos opacidade -----------------> nivel 7
    if(nomeNivel=="D_nivel_6_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_7");
        }); 
      }
    }

    //NIVEL 7 OLHO DIREITO com menos opacidade -----------------> nivel FIM
    if(nomeNivel=="D_nivel_7_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("Fim");
        }); 
      }
    }

   
  //OLHO DIREITO COM O MAXIMO DE OPACIDADE
  ////////////////////////////////////
    
  //NIVEL 1a OLHO DIREITO  -----------------> nivel 1b
    if(nomeNivel=="D_nivel_1a_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1b");
        }); 
      }
    } 

    //NIVEL 1b OLHO DIREITO  -----------------> nivel 1c
    if(nomeNivel=="D_nivel_1b_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1c");
        }); 
      }
    } 


    //NIVEL 1c OLHO DIREITO  -----------------> nivel 1
    if(nomeNivel=="D_nivel_1c_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_1");
        }); 
      }
    } 


    //NIVEL 1 OLHO DIREITO  -----------------> nivel 2
    if(nomeNivel=="D_nivel_1_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_2");
        }); 
      }
    } 


    //NIVEL 2 OLHO DIREITO  -----------------> nivel 3
    if(nomeNivel=="D_nivel_2_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_3");
        }); 
      }
    }


    //NIVEL 3 OLHO DIREITO  -----------------> nivel 4
    if(nomeNivel=="D_nivel_3_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_4");
        }); 
      }
    }

    //NIVEL 4 OLHO DIREITO  -----------------> nivel 5
    if(nomeNivel=="D_nivel_4_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_5");
        }); 
      }
    }

    //NIVEL 5 OLHO DIREITO  -----------------> nivel 6
    if(nomeNivel=="D_nivel_5_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_6");
        }); 
      }
    }
    

    //NIVEL 6 OLHO DIREITO  -----------------> nivel 7
    if(nomeNivel=="D_nivel_6_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("D_nivel_7");
        }); 
      }
    }

    //NIVEL 7 OLHO DIREITO  -----------------> nivel FIM
    if(nomeNivel=="D_nivel_7_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("Fim");
        }); 
      }
    }

    

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////   OLHO ESQUERDO   //////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

  
    if(nomeNivel=="E_Introdutorio"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_1a");
        }); 
      }
    }  


    //NIVEL 1a -----> nivel 1b
    if(nomeNivel=="E_nivel_1a"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1b");
        }); 
      }
    }  

    //Nivel 1b -----> nivel 1c
    if(nomeNivel=="E_nivel_1b"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_1c");
        });  
      }
    }

    //Nivel 1c -----> nivel 1
    if(nomeNivel=="E_nivel_1c"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_1");
        });
           
      }
    }

    //Nivel 1 -----> nivel 2
    if(nomeNivel=="E_nivel_1"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_2");
        });
           
      }
    }

    //Nivel 2 -----> nivel 3
    else if(nomeNivel=="E_nivel_2"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_3");
        });
          
      }
    }

    //Nivel 3 -----> nivel 4
    else if(nomeNivel=="E_nivel_3"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_4");
        });
          
      }
    }

    //Nivel 4 -----> nivel 5
    else if(nomeNivel=="E_nivel_4"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
         WriteJson.instance.guarda();
         fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_5");
        });
         
      }
    }

    //Nivel 5 -----> nivel 6
    else if(nomeNivel=="E_nivel_5"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_6");
        });
          
      }
    }

    //Nivel 6 -----> nivel 7
    else if(nomeNivel=="E_nivel_6"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("E_nivel_7");
        });
          
      }
    }


    //Nivel 7 -----> FIM
    else if(nomeNivel=="E_nivel_7"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
          WriteJson.instance.guarda();
          fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
            SceneManager.LoadScene("Fim");
        });
          
      }
    }

    //OLHO ESQUERDO COM MENOS OPACIDADE
    ////////////////////////////////////


    //NIVEL 1a OLHO ESQUERDO com menos opacidade -----------------> nivel 1b
    if(nomeNivel=="E_nivel_1a_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1b");
        }); 
      }
    } 

    //NIVEL 1b OLHO ESQUERDO com menos opacidade -----------------> nivel 1c
    if(nomeNivel=="E_nivel_1b_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1c");
        }); 
      }
    } 


    //NIVEL 1c OLHO ESQUERDO com menos opacidade -----------------> nivel 1
    if(nomeNivel=="E_nivel_1c_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1");
        }); 
      }
    } 


    //NIVEL 1 OLHO ESQUERDO com menos opacidade -----------------> nivel 2
    if(nomeNivel=="E_nivel_1_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_2");
        }); 
      }
    } 


    //NIVEL 2 OLHO ESQUERDO com menos opacidade -----------------> nivel 3
    if(nomeNivel=="E_nivel_2_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_3");
        }); 
      }
    }


    //NIVEL 3 OLHO ESQUERDO com menos opacidade -----------------> nivel 4
    if(nomeNivel=="E_nivel_3_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_4");
        }); 
      }
    }

    //NIVEL 4 OLHO ESQUERDO com menos opacidade -----------------> nivel 5
    if(nomeNivel=="E_nivel_4_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_5");
        }); 
      }
    }

    //NIVEL 5 OLHO ESQUERDO com menos opacidade -----------------> nivel 6
    if(nomeNivel=="E_nivel_5_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_6");
        }); 
      }
    }
    

    //NIVEL 6 OLHO ESQUERDO com menos opacidade -----------------> nivel 7
    if(nomeNivel=="E_nivel_6_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_7");
        }); 
      }
    }

    //NIVEL 7 OLHO ESQUERDO com menos opacidade -----------------> nivel FIM
    if(nomeNivel=="E_nivel_7_opacity-10"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("Fim");
        }); 
      }
    }

   
  //OLHO ESQUERDO COM O MAXIMO DE OPACIDADE
  ////////////////////////////////////
    
  //NIVEL 1a OLHO ESQUERDO  -----------------> nivel 1b
    if(nomeNivel=="E_nivel_1a_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1b");
        }); 
      }
    } 

    //NIVEL 1b OLHO ESQUERDO  -----------------> nivel 1c
    if(nomeNivel=="E_nivel_1b_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1c");
        }); 
      }
    } 


    //NIVEL 1c OLHO ESQUERDO  -----------------> nivel 1
    if(nomeNivel=="E_nivel_1c_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_1");
        }); 
      }
    } 


    //NIVEL 1 OLHO ESQUERDO  -----------------> nivel 2
    if(nomeNivel=="E_nivel_1_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=50){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_2");
        }); 
      }
    } 


    //NIVEL 2 OLHO ESQUERDO  -----------------> nivel 3
    if(nomeNivel=="E_nivel_2_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=20){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_3");
        }); 
      }
    }


    //NIVEL 3 OLHO ESQUERDO  -----------------> nivel 4
    if(nomeNivel=="E_nivel_3_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_4");
        }); 
      }
    }

    //NIVEL 4 OLHO ESQUERDO  -----------------> nivel 5
    if(nomeNivel=="E_nivel_4_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=60){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_5");
        }); 
      }
    }

    //NIVEL 5 OLHO ESQUERDO  -----------------> nivel 6
    if(nomeNivel=="E_nivel_5_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=70){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_6");
        }); 
      }
    }
    

    //NIVEL 6 OLHO ESQUERDO  -----------------> nivel 7
    if(nomeNivel=="E_nivel_6_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=30){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("E_nivel_7");
        }); 
      }
    }

    //NIVEL 7 OLHO ESQUERDO  -----------------> nivel FIM
    if(nomeNivel=="E_nivel_7_MAX"){
      if(collision.gameObject.tag == "Player" &&  GameController.instance.scoreTotal>=40){
           WriteJson.instance.guarda();
           fade.gameObject.SetActive(true);
        LeanTween.scale (fade, Vector3.zero, 0f);
        LeanTween.scale (fade, new Vector3(1,1,1), 1.5f).setEase(LeanTweenType.easeInOutQuad).setOnComplete (() =>{
              SceneManager.LoadScene("Fim");
        }); 
      }
    }
    
  }
}
