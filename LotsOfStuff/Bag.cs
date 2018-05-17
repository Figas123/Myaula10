using System;
using System.Collections.Generic;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag : List<IStuff>, IStuff, IHasKarma
    {
        public bool ContainsItemOfType<T>() where T : IStuff
        {
            foreach (IStuff thing in this)
            {
                if (thing is T)
                {
                    return true;
                }
            }
            return false;
        }
        public float Karma
        {
            get
            {
                int CountKarma = 0;
                float total = 0;

                foreach (IStuff thing in this)
                {
                    if (thing is IHasKarma)
                    {
                        total += (thing as IHasKarma).Karma;
                        CountKarma++;
                    }
                }
                return total / CountKarma;
            }
        }

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
                $"\n\tTotal Weight: {Weight:f2}\n\tTotal Value: {Value:c2}" +
                $"\n\tAverage Karma: {Karma:f2}";
            return resultado;
        }
    }
}
