namespace Aula10
{
    /// <summary>Esta classe representa um jogador num jogo</summary>
    public class Player : IHasWeight , IHasKarma
    {
        public float Karma
        {
            get
            {
                return BagOfStuff.Karma;
            }
        }
        /// <summary>Máximo de items na mochila (variável de classe, constante, implicitamente static)</summary>
        private const int maxBagItems = 5;

        /// <summary>Peso base do jogador (variável de instância, read-only) </summary>
        private readonly float baseWeight;

        /// <summary>Mochila de itens do jogador (variável de instância)</summary>
        public Bag BagOfStuff { get; }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight {
            get
            {
                // Peso do player + Peso do saco
                return baseWeight + BagOfStuff.Weight;
            }
        }

        /// <summary>Construtor, cria nova instância de jogador</summary>
        /// <param name="baseWeight">Peso base do jogador</param>
        public Player(float baseWeight)
        {
            this.baseWeight = baseWeight;
            BagOfStuff = new Bag(5);
        }

        public override string ToString()
        {
            string resultado = $"Player\n\tTotal Weight: {Weight:f2}" +
                $"\n\tNumber of items in bag: {BagOfStuff.Count:f0}" +
                $"\n\tPercentage of what weight is from the bag: {(BagOfStuff.Weight / Weight):p2}" +
                $"\n\tAverage Karma: {Karma:f2}";
            return resultado;
        }
    }
}
