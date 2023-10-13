namespace Tennis
{
    public class Player : IPlayer
    {
        private string _name;
        private int _score;
        private string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public Player(string name)
        {
            this._name = name;
            this._score = 0;
        }

        public string Name { get => _name; set => _name = value; }
        public int Score { get => _score; set => _score = value; }

        public bool IsUnderScoreForty
        {
            get=> this._score < 4;
        }

        public string GetScore
        {
            get
            {
                if (this.Score >= this.scoreTerms.Length)
                {
                    throw new System.Exception($"Error when getting {this.Name} score of {this.Score}");
                }

                return this.scoreTerms[this.Score];
            }
        }
    }
}