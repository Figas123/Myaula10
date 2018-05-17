using System;
using System.Collections;

namespace Aula10
{
    /// <summary>Programa para testar o projeto</summary>
    public class Program
    {
        /// <summary>O programa começa aqui no Main</summary>
        /// <param name="args">Ignoramos os argumentos de linha de comandos neste programa</param>
        public static void Main(string[] args)
        {
            // Para poder adicionar caracters UNICODE <----
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Criar uma nova instância de Program e
            // invocar o método TestProjet na instância criada
            Program prog = new Program();
            prog.TestProject();

        }

        /// <summary>Método que testa este projeto</summary>
        private void TestProject()
        {
            // Instanciar um jogador com 70 quilos
            Player p = new Player(70.0f);

            Console.WriteLine("(Starting) " + p);

            Bag otherbag;
            //
            // Adicionar vários itens à mochila do jogador:
            //

            // Pão com 2 dias, 500 gramas
            p.BagOfStuff.Add(new Food(FoodType.Bread, 2, 0.500f));
            // 300 gramas de vegetais com 5 dias
            p.BagOfStuff.Add(new Food(FoodType.Vegetables, 5, 0.300f));
            // Pistola com 1.5kg + 50 gramas por bala, carregada com 10 balas, com um custo de 250€
            p.BagOfStuff.Add(new Gun(1.5f, 0.050f, 10, 250));
            // 200 gramas de fruta fresca
            p.BagOfStuff.Add(new Food(FoodType.Fruit, 0, 0.200f));

            Console.WriteLine("\n(Before second bag) " + p.BagOfStuff);

            // Novo bag
            otherbag = new Bag(5);
            // 1kg de fruta com 1 dia
            otherbag.Add(new Food(FoodType.Meat, 1, 1f));
            // 500 gramas de fruta com 2 dias
            otherbag.Add(new Food(FoodType.Vegetables, 2, 0.5f));

            // Adicionar o otherbag à bag do jogador
            p.BagOfStuff.Add(otherbag);
            
            Console.WriteLine(p);

            // Quantos itens tem o jogador na mochila?
            Console.WriteLine(p.BagOfStuff);
            // Percorrer itens na mochila e tentar "imprimir" cada um
            foreach (IStuff aThing in p.BagOfStuff)
            {
                Console.WriteLine("\n\t" + aThing);

                if (aThing is Gun)
                {
                    (aThing as Gun).Shoot();
                }
            }
            Console.WriteLine("\n(After shooting gun) " + p.BagOfStuff);
            Console.WriteLine("\n(After shooting gun) " + p);
            Console.WriteLine("\nBag has gun?" + p.BagOfStuff.ContainsItemOfType<Gun>() +
                "\nBag has food?" + p.BagOfStuff.ContainsItemOfType<Food>() +
                "\nBag has bag?" + p.BagOfStuff.ContainsItemOfType<Bag>() +
                "\nOtherBag has another bag?" + otherbag.ContainsItemOfType<Bag>());
        }
    }
}
