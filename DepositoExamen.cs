
using System;


//namespace EDexamenT6a8


namespace DepositoExamen
{
    /*Clase que representa la gestión de los depósitos de una granja.
     * Tiene dos depósitos: pienso y agua. 
     * La propiedad devuelve el nivel de agua y pienso. 
     * Los métodos permiten reponer o consumir tanto pienso como agua.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */
    class Deposito
    {
        //<param nvAgua = decimal >
        //</param>
        //<param nvlPienso = decimal >
        //</param>
        //<param cntdMxmAgua = decimal >
        //</param>
        //<param cntdMxmPienso = decimal >
        //</param>
        private decimal nvlAgua;
        private decimal nvlPienso;
        private decimal cntdMxmAgua;
        private decimal cntdMxmPienso;

        public decimal vlAgua
        {
            get { return nvlAgua; }
        }
        public decimal Niveldepienso
        {
            get { return niveldepienso; }
        }
        public void reponer1(decimal cantidadareponerdeagua)
        {
            cantidadmaxima=antidadareponerdeagua+nvlAgua;
            if (cantidadareponerdeagua > 0 && cantidadmaxima < 10000);  //Tamaño del depósito de pienso es de 1000 l.
            nvlAgua=nvlAgua+cantidadareponerdeagua;
              



        }
        public void reponer2(decimal cantidadareponerdepienso)
        {

            cantidadmaxima2=cantidadareponerdepienso+niveldepienso;
            if (cantidadareponerdepienso > 0 && cantidadmaxima2 < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
            niveldepienso=niveldepienso+cantidadareponerdepienso;        }


        public decimal consumo1(decimal cantidadaretirardeagua)
        {
            decimal retirado1 = 0; //Cantidad que se retira
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= nvlAgua)
            {   retirado1=cantidadaretirardeagua;
            nvlAgua=nvlAgua-cantidadaretirardeagua;}

            return retirado1;
        }
        public decimal consumo2(decimal cantidadaretirardepienso)
        {
            decimal retirado2=0; //Cantidad que se retira
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= niveldepienso)
            {   retirado2=cantidadaretirardepienso;
                niveldepienso=niveldepienso-cantidadaretirardepienso;}
            return retirado2;
        }








    }
}