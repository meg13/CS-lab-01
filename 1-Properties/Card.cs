namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string _seed;
        private readonly string _name;
        private readonly int _ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            _name = name;
            _ordinal = ordinal;
            _seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string GetSeed() => _seed;
        

        // TODO improve
        public string GetName() => _name;

        // TODO improve
        public int GetOrdinal() => _ordinal;
    

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString() => this.GetType() + " Name=" + _name + ", Seed=" + _seed + ", Ordinal=" + _ordinal;

        // TODO generate Equals(object obj)
        public bool Equals(Card other){
            return string.Equals(_seed, other._seed) 
                && string.Equals(_name, other._name) 
                && _ordinal == other._ordinal;
        }

        public override bool Equals(object obj) => obj is Card card && Equals(card);
    
        // TODO generate GetHashCode()
        public override int GetHashCode()
        {
            return HashCode.Combine(_seed, _name, _ordinal);
        }
    }
}
