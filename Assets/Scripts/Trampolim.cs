using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolim : MonoBehaviour
{

    //___________________Animação do trampolim__________________
    private Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
    }

 
    //________________________Força do salto_______________________
    public float jumpForce;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            anim.SetTrigger("jump");
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}
