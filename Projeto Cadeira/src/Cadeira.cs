using System;

namespace Projeto_Cadeira
{
    public class Cadeira
    {

        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Rodas { get; set; }
        public string Garantia { get; set; }

        public Cadeira()
        {
        }

        public Cadeira(string modelo, string cor, string rodas, string garantia)
        {
            Modelo = modelo;
            Cor = cor;
            Rodas = rodas;
            Garantia = garantia;

        }
        public override string ToString()
        {
            return $"Modelo: {Modelo};\n" +
                $"Cor: {Cor};\n" +
                $"Rodas: {Rodas};\n" +
                $"Garantia: {Garantia};\n";
        }
    }
}

