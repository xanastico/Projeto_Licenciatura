using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    //Variaveis
    private Rigidbody2D rig;
    private Animator anim;
    public float speed;
    public Transform rightCol;
    public Transform leftCol;
    public Transform pontoCabeca;
    private bool colliding;
    public LayerMask layer;
    public BoxCollider2D boxCollider2;
    public CircleCollider2D circleCollider2D;



    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        //Movimento do inimigo sem alterar o eixo Y (rig.velocity.y)
        rig.velocity = new Vector2(speed, rig.velocity.y);

        colliding = Physics2D.Linecast(rightCol.position, leftCol.position, layer);

        if(colliding){
            //Quando bate numa parede, o inimigo roda 180 graus
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);
            speed *= -1f;
        }
    }



    bool playerDestroyed = false;
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Player"){

            //Verificar se o player toca na cabeça do Inimigo atraves da var pontoCabeca
            float altura = col.contacts[0].point.y - pontoCabeca.position.y;

            if(altura > 0 && !playerDestroyed){
                //Player dá um pulo para cima quando toca na cabeça do inimigo
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10, ForceMode2D.Impulse);
                speed = 0;
                anim.SetTrigger("morre");
                boxCollider2.enabled = false;
                circleCollider2D.enabled = false;
                rig.bodyType = RigidbodyType2D.Kinematic;
                Destroy(gameObject, 0.33f);
            }else
            {
                playerDestroyed = true;
                GameController.instance.ShowGameOver();
                Destroy(col.gameObject);
            }
        }
    }
}
