using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serra : MonoBehaviour
{

    public float velocidadeSerra;
    public float moveTime;
    private bool dirRight = true;
    private float timer;



    // Update is called once per frame
    void Update()
    {
        if(dirRight){
            //Se o dirRight for true, a serra anda para a direita
            transform.Translate(Vector2.right * velocidadeSerra * Time.deltaTime);
        }else{
            //Else anda para esquerda
            transform.Translate(Vector2.left * velocidadeSerra * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if(timer >= moveTime){
            dirRight = !dirRight;
            timer = 0f;
        } 
    }

}
