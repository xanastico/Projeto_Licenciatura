using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaVoadora : MonoBehaviour
{

    public float tempoQueda;
    private TargetJoint2D target;
    private BoxCollider2D boxColl;



    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    //Se o personagem esta em cima, a plataforma cai depois de X seg
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            Invoke("Queda", tempoQueda);
        }
    }


    //A plataforma é destruida ao chegar ao chao
        void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.layer == 9){
            Destroy(gameObject);
        }
    }

    void Queda(){
        target.enabled = false;
        boxColl.isTrigger = true;
    }
}  
