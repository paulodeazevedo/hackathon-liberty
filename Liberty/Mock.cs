using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liberty
{
    public class Mock
    {
        public string RetornaCorretor()
        {

            List<string> corretores = new List<string>();

            corretores.Add("Corretora Camila Santos");
            corretores.Add("Abajur Corretora Ltda");
            corretores.Add("Mapa Seg");
            corretores.Add("Lins Corretora");
            corretores.Add("Corretora Batega");
            corretores.Add("Batel");

            Random rnd = new Random();
            int index = rnd.Next(corretores.Count);
            return corretores[index];

        }
    }
}
