using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Atividade
{
    internal class Produto
    {
        public string nome;
        public string descricao;
        public double preço;
        public int quantidade;
        public bool status;

        public void mostrar()
        {

            Console.WriteLine($"Produto: {nome}\nDescrição: {descricao}\nPreço: {preço}\nQuantidade: {quantidade}\n Status: {status}\n");


        }

        public void desativar()
        {
            string escolha;
            Console.WriteLine("\nDesativar produto? S/N\n");
            escolha = Console.ReadLine();
            if ( escolha == "S" )
            {
                status = false;
                quantidade = 0;
            }
            else
            {
                status = true;
            }
        }
    }
}
