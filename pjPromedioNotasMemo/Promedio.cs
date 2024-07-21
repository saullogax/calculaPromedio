using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pjPromedioNotasMemo
{
    class Promedio
    {
        //ATRIBUTOS PUBLICOS DE LA CLASE
        public string alumno;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;
        
        //METODOS DE LA CLASE
        public int MasBaja()
        {
            int menor = int.MaxValue;
            if (nota1 < nota2) menor = nota1; else menor = nota2;
            if (nota3 < menor) menor = nota3;
            if (nota4 < menor) menor = nota4;

            return menor; //Se necesita para que retorne el masBaja y muestre un valor
        }

        public Double CalcularPromedio()
        {
           
            return (nota1 + nota2 + nota3 + nota4) / (4);
        }

        public string AsignaCondicion()
        {
            Double Promedio = CalcularPromedio();
            if (Promedio < 60)
                return alumno + " Estás liquidado, suerte para la proxima";
            else
                return alumno + " ¡FELICIDADES! Estás probado, sigue así.";
        }


    }
}
