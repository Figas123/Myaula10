using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : IStuff
    {
        public float Value
        {
            get
            {
                float totalValue = 0;
                foreach (IStuff s in stuff)
                {
                    if (s != null) {
                        totalValue += s.Value;
                    }
                }
                return totalValue;
            }
        }
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IStuff s in stuff)
                {
                    if (s != null)
                    {
                        totalWeight += s.Weight;
                    }
                }
                return totalWeight;
            }
        }

        /// <summary>Array que contém os itens da mochila</summary>
        private List<IStuff> stuff;

        /// <summary>Número de itens na mochila</summary>
        public int StuffCount { get { return stuff.Count; } }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize)
        {
            stuff = new List<IStuff>(bagSize);
        }

        /// <summary>Colocar um item na mochila</summary>
        /// <param name="aThing">Item a colocar na mochila</param>
        public void AddThing(IStuff aThing)
        {
            // Adicionar o item à mochila e depois incrementar o
            // número de coisas na mochila
            stuff.Add(aThing);
        }

        /// <summary>Observar um item da mochila sem o remover da mesma</summary>
        /// <param name="index">Local onde está o item a observar</param>
        /// <returns>Item a ser observado</returns>
        public IStuff GetThing(int index)
        {
            if (index > stuff.Count)
            {
                // Senão existir um item no local indicado, "lançar" uma exceção
                throw new InvalidOperationException("Bag doesn't have that much stuff!");
            }
            return stuff[index];
        }
        public override string ToString()
        {
            string resultado = "Bag\n\tNumber of Items: " + StuffCount.ToString() +
                "\n\tTotal Weight: " + Weight.ToString() + "\n\tTotal Value: " + Value.ToString();
            return resultado;
        }
    }
}
