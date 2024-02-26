using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personagem : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJump;
    private Rigidbody2D rig;
    //private Animator anim;

    //Ventoinhas
    bool aVoar;



    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }



    //Função de movimento
    void Move (){
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //-----------Move a personagem numa posição - Não usa fisica---------------
        //transform.position += movement * Time.deltaTime * Speed;

        float movement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement * Speed, rig.velocity.y);

        //move para a direita
        if(movement > 0f){
            //anim.SetBool("Andar", true);
            transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        //move para a esquerda
        if(movement < 0f){
            //anim.SetBool("Andar", true);
            transform.eulerAngles = new Vector3(0f,180f,0f);
        }
        //parado
        if(movement == 0f){
            //anim.SetBool("Andar", false);
        }
    }



    //Função para saltar
    void Jump (){
        if(Input.GetButtonDown("Jump") && !aVoar){
            if(!isJumping){
                rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
                //anim.SetBool("Salto", true);
            }
            else{
                if(doubleJump){
                    rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
        }
    }


    //Função que deteta sempre que a personagem toca em algo
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            isJumping = false;
            //anim.SetBool("Salto", false);
        }

        if(collision.gameObject.tag == "Picos"){
           GameController.instance.ShowGameOver();
           Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Serra"){
           GameController.instance.ShowGameOver();
           Destroy(gameObject);
        }
    }


    //Função para ver se para de tocar em algo
    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            isJumping = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider){
        if(collider.gameObject.layer == 11){
           aVoar = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider){
        if(collider.gameObject.layer == 11){
           aVoar = false;
        }
    }



}
