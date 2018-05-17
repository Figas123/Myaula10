using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : List<IStuff>, IStuff
    {
        public float Value
        {
            get
            {
                float totalValue = 0;
                foreach (IStuff s in this)
                {
                    totalValue += s.Value;
                }
                return totalValue;
            }
        }
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IStuff s in this)
                {
                    totalWeight += s.Weight;
                }
                return totalWeight;
            }
        }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize) : base(bagSize)
        {

        }
        
        public override string ToString()
        {
            string resultado = $"Bag\n\tNumber of Items: {Count:f0}" +
                $"\n\tTotal Weight: {Weight:f2}\n\tTotal Value: {Value:c2}";
            return resultado;
        }
    }
}
