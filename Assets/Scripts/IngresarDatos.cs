using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text;

public class IngresarDatos : MonoBehaviour
{
   
    public GameObject[] casillasReglas = new GameObject[6];
    
    public GameObject[] casillasiniciales = new GameObject[4];



 
    public TMP_Text[] resultadoFinal1 = new TMP_Text[6];
    public TMP_Text resultadoFinal2;


     //ARRAYS
            string[] iniciales = new string[] { "" };
            string[] reglasini = new string[] { "" };
            string[] derivacion = new string[] { "" };
     //Fin de arrays

     //contador
        public TMP_Text contador;
        public int contador_1;
        public TMP_Text contador2;
        public int contador_2;
    //fin contador

    
    //variables, primera parte
            string suma = "";
            string rondaF = "";
            int nIniciales = 0;
            int nReglas = 0;
 
    //fin variables, primera parte

     bool verificar = false;
            string comparar2 = "";
            string resultado = "";
            string comparar = "";
            int uno = 0;
            int dos = 0;
            bool otrobool = false;
            bool otrobool2 = false;

   


    
    void Start()
    {
        contador_1 = 1;
        contador_2 = 1;
    }

    void Update()
    {
        nIniciales = contador_2;
        nReglas = contador_1;

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
        contador.text = contador_1.ToString();
    }

}

    public void Restar1()
{
    if (contador_1 > 1)
    {
        contador_1--;
        contador.text = contador_1.ToString();
    }

}

    public void Sumar2()
{
    if (contador_2 < 4)
    {
        contador_2++;
        contador2.text = contador_2.ToString();
    }

}

    public void Restar2()
{
    if (contador_2 > 1)
    {
        contador_2--;
        contador2.text = contador_2.ToString();
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



 ////con esto comeinza la operacion, llamamos la funcion inicioxd
            

            //COMPARACIONES/// funcion de inicioxd//////////////////////////////////
            public void inicioxd()

            {
                
                

                for (int j = 0; j < nIniciales; j++)
                {
                    resultado = iniciales[j];  ////// vprimera inicial a variable resultado
                    
                    verificar = calculo(resultado); //mando esa var a COMPARAR SI ES MAYUS O NO TIENE MASYUCYLA

                    if (verificar == true) //SI  no e3sta esa variable en las reglas, 
                    {

                        suma += iniciales[j]; //la suma aqui, solo suma si no hay regla para esa var.
                        verificar = false;
                        
                    }
                    ////////////////////////////////////////fin de primera ronda
                    dos += 1;
                    //hace esto en la utima ronda del ciclo
                    if (dos == nIniciales)
                    {
                        dos = 0;//verificar
                        for (int v = 0; v < suma.Length; v++)
                        {
                            for (int i = 0; i < nReglas; i++) //verifiva si hay una regla mas que se pueda utilizar
                            {
                                if ((suma[v].ToString()) == reglasini[i])
                                {
                                    otrobool2 = true;
                                    break;
                                }
                            }
                        }

                        if (otrobool2 == true) //si encuentra una reglas mas qu4 se pueda utilizar, otra ronda
                        {
                            //for que solo muestra las reglas que quedan, no hace nada mas
                            for (int i = 0; i < nReglas; i++)
                            {
                                
                                Debug.Log("El resultado es: " + reglasini[i] + "");
                            }//ignorar

                            otrobool2 = false;
                            Console.WriteLine(suma);

                            //guarda la ultima respuesta 
                            rondaF = suma; //la lamacena aqui
                            nIniciales = rondaF.Length; ///agranda el tamaño de los num de iniciales

                            Array.Resize(ref iniciales, rondaF.Length); //agranda el tamayo del array, iniciales

                            //guarda la ultima respuesta en el array iniciales para otra ronda
                            for (int i = 0; i < rondaF.Length; i++)
                            {
                                iniciales[i] = rondaF.Substring(i, 1); ///separa la variable suma y almacena
                            }
                            //variables a 0
                            suma = "";
                            rondaF = "";
                            resultado = "";
                            inicioxd();//con esto da inicio a otra ronda
                        }
                        else // si no hay reglas que se puedan utilizar, aqui acaba
                        {
                            dos = 0;
                            
                            Debug.Log("El resultado es: " + suma + "");
                            resultadoFinal2.text = suma.ToString();
                            
                        }
                    }
                } 
           
            }
            ///fin del ciclo
            
            //funcion que hace la comparacion parte dos
           public bool calculo(string resultado)
            {
               //verifica si la inicial es mayuscula, si es minuscula, solo no la deriva
                for (int i = 0; i < nReglas; i++)
                {
                    
                    bool sustituto = false;
                    string res = resultado;
                   
                    for (int v = 0; v < res.Length; v++) //compara si hay masyucula
                    {
                        if (char.IsUpper(res[v]))
                        {
                            sustituto = true; //si hay mayus
                        }
                    }
                    //fin de la busqueda

                    //si es mayuscula, pasa adelante para derivar
                    if (sustituto == true)
                    { 
                        if (resultado == reglasini[i]) //verifica si esta esa inicial en las reglas
                        {
                            comparar = derivacion[i]; //guarda en una new var, la derivada
                            comparar2 = reglasini[i]; //y la reglas que es igual

                            /////////mira si hay mayusula, eso es prioridad
                            for (int v = 0; v < comparar.Length; v++) //compara si hay masyucula
                            {
                                if (char.IsUpper(comparar[v]))
                                {
                                    otrobool = true; //si hay mayus, true
                                    break;
                                }
                                else /// si no es mayuscula
                                {
                                    otrobool = false;  //no hay mayus
                                }
                            }
                            ////fin de la busqueda para ver si hay mayuscula

                            //////fi hay mayuscula
                            if (otrobool == true) // si hay mayuscula entonces
                            {
                                reglasini[i] = "";
                                derivacion[i] = "";
                                otrobool = false;
                                break; //ya no sigue buscando, termina el ciclo
                            }
                            else// de lo contrario, si no hay mayuscula,
                            {
                                continue; /// manda a que siga buscando, se queda con la ultima que guardo
                            }
                        }
                    }
                    else// si la inicial es minuscula, la elimina de las reglas para que no moleste
                    {
                        for (int h = 0; h < nReglas; h++)
                        {
                            if (res == reglasini[h])
                            {
                                reglasini[h] = "";
                                derivacion[h] = "";
                            }
                        }
                    }
                    uno += 1; //se usa esto cuando es la ultima ronda del ciclo 
                }
                // si uno es igual a numero de reglas, es por que no hay regla para esa inicial
                if (uno == nReglas)
                {
                    verificar = true; //manda esto para la primera funcion si no hay regla para la inicial 
                    comparar2 = "";
                    comparar = "";
                    uno = 0;
                }
                else //si hay una regla para derivar la inicial
                {
                    suma += comparar; //la agrega aqui

                    for (int h = 0; h < nReglas; h++) //elimina las reglas que ya se usaron 
                    {
                        if (comparar == derivacion[h] && comparar2 == reglasini[h])
                        {
                            reglasini[h] = "";
                            derivacion[h] = ""; 
                        }
                    }////////////////////////fin de eliminar las reglas usadas

                    verificar = false; // coloca las variables a 0 
                    comparar = "";
                    comparar2 = "";
                    uno = 0;
                }

                return verificar;
            }/////////////////////////////////////////////////////////////////////


           
}
    



   





