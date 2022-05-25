﻿
using System;


//namespace EDexamenT6a8


namespace DepositoExamen
{
    
    class DepositoExamen
    {
        /*<sumary>
            Cambios generales en espacios, tabulaciones y cambio del nombre de variables y funciones
        </sumary>
        <remarks>Se han cambiado todo el nombre a las variables comunes para toda la clase
        </remarks>
        <exception>
            Encaso de sobrepasar 5000kg en el pineso y de 10000l en agua, debiaria informar de un error no programado,
            para indicarlo y saber que no se puede hacer
        </exception>*/

        /*<param name="nvlAgua" > Variable de tipo decimal que nos dice el nivel de agua
        </param>
        <param name="nvlPienso" > Variable de tipo decimal que nos dice el nivel de pienso
        </param>
        <param name="cntdMxmAgua" > Variable de tipo decimal que nos dice el nivel maximo que podemos tener de agua
        </param>
        <param name="cntdMxmPienso" > Variable de tipo decimal que nos dice el nivel maximo que podemos tener de pienso
        </param>*/
            
        private decimal nvlAgua;
        private decimal nvlPienso;
        private decimal cntdMxmAgua;
        private decimal cntdMxmPienso;


        public decimal NvlAgua
        {
            get { return nvlAgua; }
        }

        public decimal NvlPienso
        {
            get { return nvlPienso; }
        }


        /*
        <metod>
            Las dos siguientes funciones, coimprueban que no sobrepasa el maximo de capacidad en el caso de agua de 10000 l y 
            en el de pienso de 5000 kg y comprueba que contenga algo , 
             si es asi, permite reponer
        </metod>
        */

        public void ReponerAgua(decimal cntdRepAgua)
        {
            cntdMxmAgua = cntdRepAgua + nvlAgua;

            if (ctdRepAgua > 0 && cntdMxmAgua < 10000);  //<param name="cntdMxmAgua"> Maximo pienso permitido es de 1000 l </param> 
            {
                nvlAgua = nvlAgua + cntdRepAgua;
            }
        }


        public void ReponerPienso(decimal cntdRepPienso)
        {
            cntdMxmPienso = cntdRPienso + nvlPienso;

            if (cntdRPienso > 0 && cntdMxmPienso < 5000)  //<param name="cntdMxmPienso"> Maximo pienso permitido es de 5000 kg </param> 
            {
                nvlPienso = nvlPienso + cntdRPienso;        
            }
        }


        /*<sumary>
            Funcion que calcula el consumo de agua 
        </sumary>
        <returns> 
            Devuelve la cantidad que ha sido consumida de agua
        </returns>
        */

        public decimal ConsumoAgua(decimal cntdRetAgua)
        {
            decimal cntRetirarA = 0; //<param name="cntRetirarA">Cantidad de agua que se retira </param>

            if (cntdRetAgua > 0 && cntdRetAgua <= nvlAgua)
            {   
                cntRetirarA = cntdRetAgua;
                nvlAgua = nvlAgua - cntdRetAgua;
            }

            return cntRetirarA;
        }


        /*
        <sumary>
            Funcion que calcula el consumo de agua 
        </sumary>
        <returns> 
            Devuelve la cantidad que ha sido consumida de pienso
        </returns>
        */

        public decimal ConsumoPienso(decimal cntdRetPienso)
        {
            decimal cntRetirarP = 0; //<param name="cntRetirarP">Cantidad de pienso que se retira </param>

            if (cntdRetPienso > 0 && cntdRetPienso <= nvlPienso)
            {   
                cntRetirarP = cntdRetPienso;
                nvlPienso = nvlPienso - cntdRetPienso;
            }
            return cntRetirarP;
        }

    }
}