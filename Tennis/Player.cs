namespace Tennis
{
    public class Player : IPlayer
    {
        private string _name;
        private int _score;
        private string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public Player(string name, int score)
        {
            this._name = name;
            this._score = score;
        }

        public string Name { get => _name; set => _name = value; }
        public int Score { get => _score; set => _score = value; }

        public bool IsUnderScoreForty
        {
            get=> this._score < 4;
        }
    }
}