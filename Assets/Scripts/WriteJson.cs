using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class WriteJson : MonoBehaviour
{
    
    JsonData playerJson;
        public string nivel;
    public Jogada Player; 
    public Jogadas Jogadas;
    public static WriteJson instance;
    

    // Start is called before the first frame update
    void Start()
    {
       
       Player = new Jogada(nivel);
       instance = this;
    }


    //Função para guardar o registo das teclas em PlayerData.json
    public void guarda()
    {
        
        playerJson = JsonMapper.ToJson(Player);
        Debug.Log(playerJson); 
        using (StreamWriter sw = File.AppendText(Application.dataPath + "/PlayerData.json"))
        {
            sw.WriteLine(playerJson);                                                                   
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           Player.teclas.Add("a");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           Player.teclas.Add("d");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
           Player.teclas.Add("w");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           Player.teclas.Add("upArrow");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           Player.teclas.Add("LeftArrow");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           Player.teclas.Add("RightArrow");
        }
    }
 
}


    [System.Serializable]
    //Class do jogador
   public class Jogada{
        public string mapa;
        public List<string> teclas;
    

    public Jogada(string mapa, string []teclas){
        this.mapa = mapa;
        this.teclas = new List<string>();
    }


    public Jogada(string nivel){
        this.mapa=nivel;
        this.teclas = new List<string>();
    }

    }

    [System.Serializable]

    public class Jogadas{
        public List<Jogada> teclas;
    

    public Jogadas(string []teclas){
        this.teclas = new List<Jogada>();
    }


    public Jogadas(){
        this.teclas = new List<Jogada>();
    }


}

    
  

