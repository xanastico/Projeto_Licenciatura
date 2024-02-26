using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolhaDoOlho : MonoBehaviour
{
    //Botão olho direito
    public void OlhoDireito(){
        SceneManager.LoadScene (14);
    }

    //Botão olho esquerdo
    public void OlhoEsquerdo(){
        SceneManager.LoadScene (1);
    }

    //Botoes aumenta e diminui opacidade
    //OLHO DIREITO -- PRIMEIROS 7 NIVEIS Nao da aumentar porque ja esta no maximo
    //Olho direito -- Primeiros 7 niveis - Diminuir 
    public void Diminui1a(){
        SceneManager.LoadScene ("D_nivel_1a_opacity-10");
    }
    public void Diminui1b(){
        SceneManager.LoadScene ("D_nivel_1b_opacity-10");
    }
    public void Diminui1c(){
        SceneManager.LoadScene ("D_nivel_1c_opacity-10");
    }
    public void Diminui1(){
        SceneManager.LoadScene ("D_nivel_1_opacity-10");
    }
    public void Diminui2(){
        SceneManager.LoadScene ("D_nivel_2_opacity-10");
    }
    public void Diminui3(){
        SceneManager.LoadScene ("D_nivel_3_opacity-10");
    }
    public void Diminui4(){
        SceneManager.LoadScene ("D_nivel_4_opacity-10");
    }
    public void Diminui5(){
        SceneManager.LoadScene ("D_nivel_5_opacity-10");
    }
    public void Diminui6(){
        SceneManager.LoadScene ("D_nivel_6_opacity-10");
    }
    public void Diminui7(){
        SceneManager.LoadScene ("D_nivel_7_opacity-10");
    }

    //Olho direito -- Segundos 7 niveis
    //AUMENTAR
    public void AumentaMeio1a(){
        SceneManager.LoadScene ("D_nivel_1a");
    }
    public void AumentaMeio1b(){
        SceneManager.LoadScene ("D_nivel_1b");
    }
    public void AumentaMeio1c(){
        SceneManager.LoadScene ("D_nivel_1c");
    }
    public void AumentaMeio1(){
        SceneManager.LoadScene ("D_nivel_1");
    }
    public void AumentaMeio2(){
        SceneManager.LoadScene ("D_nivel_2");
    }
    public void AumentaMeio3(){
        SceneManager.LoadScene ("D_nivel_3");
    }
    public void AumentaMeio4(){
        SceneManager.LoadScene ("D_nivel_4");
    }
    public void AumentaMeio5(){
        SceneManager.LoadScene ("D_nivel_5");
    }
    public void AumentaMeio6(){
        SceneManager.LoadScene ("D_nivel_6");
    }
    public void AumentaMeio7(){
        SceneManager.LoadScene ("D_nivel_7");
    }

    //DIMINUIR
    public void DiminuiMeio1a(){
        SceneManager.LoadScene ("D_nivel_1a_MAX");
    }
    public void DiminuiMeio1b(){
        SceneManager.LoadScene ("D_nivel_1b_MAX");
    }
    public void DiminuiMeio1c(){
        SceneManager.LoadScene ("D_nivel_1c_MAX");
    }
    public void DiminuiMeio1(){
        SceneManager.LoadScene ("D_nivel_1_MAX");
    }
    public void DiminuiMeio2(){
        SceneManager.LoadScene ("D_nivel_2_MAX");
    }
    public void DiminuiMeio3(){
        SceneManager.LoadScene ("D_nivel_3_MAX");
    }
    public void DiminuiMeio4(){
        SceneManager.LoadScene ("D_nivel_4_MAX");
    }
    public void DiminuiMeio5(){
        SceneManager.LoadScene ("D_nivel_5_MAX");
    }
    public void DiminuiMeio6(){
        SceneManager.LoadScene ("D_nivel_6_MAX");
    }
    public void DiminuiMeio7(){
        SceneManager.LoadScene ("D_nivel_7_MAX");
    }

    //Olho direito -- Terceiros 7 niveis
    //AUMENTAR
    public void AumentaFim1a(){
        SceneManager.LoadScene ("D_nivel_1a_opacity-10");
    }
    public void AumentaFim1b(){
        SceneManager.LoadScene ("D_nivel_1b_opacity-10");
    }
    public void AumentaFim1c(){
        SceneManager.LoadScene ("D_nivel_1c_opacity-10");
    }
    public void AumentaFim1(){
        SceneManager.LoadScene ("D_nivel_1_opacity-10");
    }
    public void AumentaFim2(){
        SceneManager.LoadScene ("D_nivel_2_opacity-10");
    }
    public void AumentaFim3(){
        SceneManager.LoadScene ("D_nivel_3_opacity-10");
    }
    public void AumentaFim4(){
        SceneManager.LoadScene ("D_nivel_4_opacity-10");
    }
    public void AumentaFim5(){
        SceneManager.LoadScene ("D_nivel_5_opacity-10");
    }
    public void AumentaFim6(){
        SceneManager.LoadScene ("D_nivel_6_opacity-10");
    }
    public void AumentaFim7(){
        SceneManager.LoadScene ("D_nivel_7_opacity-10");
    }





    //OLHO ESQUERDO -- PRIMEIROS 7 NIVEIS Nao da aumentar porque ja esta no maximo
    //Olho esquerdo -- Primeiros 7 niveis - Diminuir 
    //Olho esquerdo -- Primeiros 7 niveis - Diminuir 
    public void Diminui1aESQUERDO(){ 
        SceneManager.LoadScene ("E_nivel_1a_opacity-10");
    }
    public void Diminui1bESQUERDO(){
        SceneManager.LoadScene ("E_nivel_1b_opacity-10");
    }
    public void Diminui1cESQUERDO(){
        SceneManager.LoadScene ("E_nivel_1c_opacity-10");
    }
    public void Diminui1ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_1_opacity-10");
    }
    public void Diminui2ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_2_opacity-10");
    }
    public void Diminui3ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_3_opacity-10");
    }
    public void Diminui4ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_4_opacity-10");
    }
    public void Diminui5ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_5_opacity-10");
    }
    public void Diminui6ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_6_opacity-10");
    }
    public void Diminui7ESQUERDO(){
        SceneManager.LoadScene ("E_nivel_7_opacity-10");
    }

    //Olho esquerdo -- Segundos 7 niveis
    //AUMENTAR
    public void MEIOAumenta1a(){
        SceneManager.LoadScene ("E_nivel_1a");
    }
    public void MEIOAumenta1b(){
        SceneManager.LoadScene ("E_nivel_1b");
    }
    public void MEIOAumenta1c(){
        SceneManager.LoadScene ("E_nivel_1c");
    }
    public void MEIOAumenta1(){
        SceneManager.LoadScene ("E_nivel_1");
    }
    public void MEIOAumenta2(){
        SceneManager.LoadScene ("E_nivel_2");
    }
    public void MEIOAumenta3(){
        SceneManager.LoadScene ("E_nivel_3");
    }
    public void MEIOAumenta4(){
        SceneManager.LoadScene ("E_nivel_4");
    }
    public void MEIOAumenta5(){
        SceneManager.LoadScene ("E_nivel_5");
    }
    public void MEIOAumenta6(){
        SceneManager.LoadScene ("E_nivel_6");
    }
    public void MEIOAumenta7(){
        SceneManager.LoadScene ("E_nivel_7");
    }

    //DIMINUIR
    public void MEIODiminui1a(){
        SceneManager.LoadScene ("E_nivel_1a_MAX");
    }
    public void MEIODiminui1b(){
        SceneManager.LoadScene ("E_nivel_1b_MAX");
    }
    public void MEIODiminui1c(){
        SceneManager.LoadScene ("E_nivel_1c_MAX");
    }
    public void MEIODiminui1(){
        SceneManager.LoadScene ("E_nivel_1_MAX");
    }
    public void MEIODiminui2(){
        SceneManager.LoadScene ("E_nivel_2_MAX");
    }
    public void MEIODiminui3(){
        SceneManager.LoadScene ("E_nivel_3_MAX");
    }
    public void MEIODiminui4(){
        SceneManager.LoadScene ("E_nivel_4_MAX");
    }
    public void MEIODiminui5(){
        SceneManager.LoadScene ("E_nivel_5_MAX");
    }
    public void MEIODiminui6(){
        SceneManager.LoadScene ("E_nivel_6_MAX");
    }
    public void MEIODiminui7(){
        SceneManager.LoadScene ("E_nivel_7_MAX");
    }

    //Olho esquerdo -- Terceiros 7 niveis
    //AUMENTAR
    public void FIMAumenta1a(){
        SceneManager.LoadScene ("E_nivel_1a_opacity-10");
    }
    public void FIMAumenta1b(){
        SceneManager.LoadScene ("E_nivel_1b_opacity-10");
    }
    public void FIMAumenta1c(){
        SceneManager.LoadScene ("E_nivel_1c_opacity-10");
    }
    public void FIMAumenta1(){
        SceneManager.LoadScene ("E_nivel_1_opacity-10");
    }
    public void FIMAumenta2(){
        SceneManager.LoadScene ("E_nivel_2_opacity-10");
    }
    public void FIMAumenta3(){
        SceneManager.LoadScene ("E_nivel_3_opacity-10");
    }
    public void FIMAumenta4(){
        SceneManager.LoadScene ("E_nivel_4_opacity-10");
    }
    public void FIMAumenta5(){
        SceneManager.LoadScene ("E_nivel_5_opacity-10");
    }
    public void FIMAumenta6(){
        SceneManager.LoadScene ("E_nivel_6_opacity-10");
    }
    public void FIMAumenta7(){
        SceneManager.LoadScene ("E_nivel_7_opacity-10");
    }
}
