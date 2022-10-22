using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text;

public class Respuestas : MonoBehaviour
{
    
    public GameObject[] casillasReglas = new GameObject[6];
    
    public GameObject[] casillasiniciales = new GameObject[4];

    public TMP_Text[] resultadoini = new TMP_Text[4];
    public TMP_Text[] resultadoCabeza = new TMP_Text[6];
    public TMP_Text[] resultadoDerivacion = new TMP_Text[6];

       public TMP_Text resultadoSumaIni;
        string resultadoSumaIni1;

  


     //ARRAYS
            string[] iniciales = new string[] { "" };
            string[] reglasini = new string[] { "" };
            string[] derivacion = new string[] { "" };
     //Fin de arrays

     //contador
    
        public int contador_1;
        
        public int contador_2;
    //fin contador



   


    
    void Start()
    {
        contador_1 = 1;
        contador_2 = 1;
    }

    void Update()
    {
        

        Array.Resize(ref iniciales, contador_2);
        Array.Resize(ref reglasini, contador_1);
        Array.Resize(ref derivacion, contador_1);
        
        if (contador_1 == 1)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(false);
            casillasReglas[2].SetActive(false);
            casillasReglas[3].SetActive(false);
            casillasReglas[4].SetActive(false);
            casillasReglas[5].SetActive(false);

            

        }
        if (contador_1 == 2)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(true);
            casillasReglas[2].SetActive(false);
            casillasReglas[3].SetActive(false);
            casillasReglas[4].SetActive(false);
            casillasReglas[5].SetActive(false);
        }
         
        if (contador_1 == 3)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(true);
            casillasReglas[2].SetActive(true);
            casillasReglas[3].SetActive(false);
            casillasReglas[4].SetActive(false);
            casillasReglas[5].SetActive(false);

            
        }
        if (contador_1 == 4)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(true);
            casillasReglas[2].SetActive(true);
            casillasReglas[3].SetActive(true);
            casillasReglas[4].SetActive(false);
            casillasReglas[5].SetActive(false);

           


        }
        if (contador_1 == 5)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(true);
            casillasReglas[2].SetActive(true);
            casillasReglas[3].SetActive(true);
            casillasReglas[4].SetActive(true);
            casillasReglas[5].SetActive(false);

           


        }
        if (contador_1 == 6)
        {
            casillasReglas[0].SetActive(true);
            casillasReglas[1].SetActive(true);
            casillasReglas[2].SetActive(true);
            casillasReglas[3].SetActive(true);
            casillasReglas[4].SetActive(true);
            casillasReglas[5].SetActive(true);

           

        }

        if (contador_2 == 1)
        {
            casillasiniciales[0].SetActive(true);
            casillasiniciales[1].SetActive(false);
            casillasiniciales[2].SetActive(false);
            casillasiniciales[3].SetActive(false);
        }

        if (contador_2 == 2)
        {
            casillasiniciales[0].SetActive(true);
            casillasiniciales[1].SetActive(true);
            casillasiniciales[2].SetActive(false);
            casillasiniciales[3].SetActive(false);
        }

        if (contador_2 == 3)
        {
            casillasiniciales[0].SetActive(true);
            casillasiniciales[1].SetActive(true);
            casillasiniciales[2].SetActive(true);
            casillasiniciales[3].SetActive(false);
        }

        if (contador_2 == 4)
        {
            casillasiniciales[0].SetActive(true);
            casillasiniciales[1].SetActive(true);
            casillasiniciales[2].SetActive(true);
            casillasiniciales[3].SetActive(true);
        }
            

    }
    
        

    public void Sumar1()
{
    if (contador_1 < 6)
    {
        contador_1++;
       
    }

}

    public void Restar1()
{
    if (contador_1 > 1)
    {
        contador_1--;
       
    }

}

    public void Sumar2()
{
    if (contador_2 < 4)
    {
        contador_2++;
        
    }

}

    public void Restar2()
{
    if (contador_2 > 1)
    {
        contador_2--;
        
    }

}


    public void cabezas1(string tcabezas)
    {
    reglasini[0] =tcabezas;
    //Debug.Log(reglasini[0]);
    }
    
    public void cabezas2(string tcabezas)
    {
    reglasini[1] = tcabezas;
   // Debug.Log(reglasini[1]);
    }

    public void cabezas3(string tcabezas)
    {
    reglasini[2] = tcabezas;
    //Debug.Log(reglasini[2]);
    }

    public void cabezas4(string tcabezas)
    {
    reglasini[3] = tcabezas;
   // Debug.Log(reglasini[3]);
    }

    public void cabezas5(string tcabezas)
    {
    reglasini[4] = tcabezas;
    //Debug.Log(reglasini[4]);
    }

    public void cabezas6(string tcabezas)
    {
    reglasini[5] = tcabezas;
    //Debug.Log(reglasini[5]);
    }

    public void iniciales1(string tiniciales)
    {
    iniciales[0] = tiniciales;
  
    //Debug.Log(iniciales[0]);
    }

    public void iniciales2(string tiniciales)
    {
    iniciales[1] = tiniciales;
    //Debug.Log(iniciales[1]);
    }

    public void iniciales3(string tiniciales)
    {
    iniciales[2] = tiniciales;
    //Debug.Log(tiniciales1[2]);
    }

    public void iniciales4(string tiniciales)
    {
    iniciales[3] = tiniciales;
    //Debug.Log(tiniciales1[3]);
    }

    public void derivacion1(string tderivacion)
    {
    derivacion[0] =tderivacion;
    //Debug.Logtcabezas[0]);
    }
    
    public void derivacion2(string tderivacion)
    {
    derivacion[1] = tderivacion;
    //Debug.Logtcabezas[1]);
    }

    public void derivacion3(string tderivacion)
    {
    derivacion[2] = tderivacion;
    //Debug.Log(derivacion[2]);
    }

    public void derivacion4(string tderivacion)
    {
    derivacion[3] = tderivacion;
    //Debug.Logtcabezas[3]);
    }

    public void derivacion5(string tderivacion)
    {
    derivacion[4] = tderivacion;
    //Debug.Logtcabezas[4]);
    }

    public void derivacion6(string tderivacion)
    {
    derivacion[5] = tderivacion;
    //Debug.Logtcabezas[5]);
    }

 public void resultadoIniciales()
            {
               
               for (int i = 0; i < contador_2; i++)
                {
                    resultadoini[i].text = iniciales[i];
                    resultadoSumaIni1 = resultadoSumaIni1 + (""+ iniciales[i] + " ");
                    
                }

                for (int i = 0; i < contador_1; i++)
                {
                  resultadoCabeza[i].text = reglasini[i];
                  resultadoDerivacion[i].text = derivacion[i];  

                } 

                resultadoSumaIni.text = resultadoSumaIni1;
               
                


                
            }


}
