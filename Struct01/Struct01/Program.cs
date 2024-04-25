using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Struct01
{


    public struct Horario
    {
        public int Hora;
        public int Minuto;
        public int Segundo;
    }


    public struct Data
    {
        public int Dia;
        public int Mes;
        public int Ano;
        public int Seculo;
    }

    public struct Compromisso
    {
        public Data Data;
        public Horario Horario;
        public string Texto;
    }

    public class Funcoes
    {
        public string ImprimirData(Data data)
        {
            return $@"{data.Dia}/{data.Mes}/{data.Ano} do seculo {data.Seculo}";
        }
    }
}
