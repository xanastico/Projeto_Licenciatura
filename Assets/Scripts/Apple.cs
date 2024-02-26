using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    private SpriteRenderer sr;
    private CircleCollider2D circle;
    public GameObject collected;
    public int score;
    public float rateSpawn;
    public float currentRateSpawn;
    public GameObject prefab;
    public List<GameObject> maca;
    public float maxHeight;
    public float minHeight;
    public float minX;
    public float maxX;
    public int maxMaca;

 

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();

        for (int i = 0; i< maxMaca; i++){
            GameObject tempMaca = Instantiate (prefab) as GameObject;
            maca.Add(tempMaca);
            tempMaca.SetActive(false);
        }
    }

    void Update(){
        currentRateSpawn += Time.deltaTime;
        if(currentRateSpawn > rateSpawn){
            currentRateSpawn = 0;
            Spawn();
        }
    }



    //Destruir a maça
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            sr.enabled = false; 
            circle.enabled = false;
            collected.SetActive(true);

            GameController.instance.scoreTotal += score;
            GameController.instance.UpdateScoreText();
            
            //Destroy(gameObject, 0.25f); 
        }
    }

//Função para fazer as maças aparecer
    private void Spawn (){

        float randPosition = Random.Range (minHeight, maxHeight);
        float randXPosition = Random.Range (minX, maxX);
        GameObject tempMaca = null;

        for (int i = 0; i< maxMaca; i++){
            if(maca[i].activeSelf == false){
                tempMaca = maca[i];
                break;
            }
        }
        if(tempMaca  != null ){
            tempMaca.transform.position = new Vector3(randXPosition, randPosition, transform.position.z);
            tempMaca.SetActive(true);
        }
    }


}
