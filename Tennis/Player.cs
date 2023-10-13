namespace Tennis
{
    public class Player : IPlayer
    {
        private string _name;
        private Score _score;
        private string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public Player(string name)
        {
            this._name = name;
            this._score = new Score(0);
        }

        public string Name { get => _name; set => _name = value; }
        public int Score { get => this._score.ScoreProp; set => this._score.ScoreProp = value; }

        public bool IsUnderScoreForty
        {
            get=> this._score.ScoreProp < 4;
        }

        public string GetScoreName
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

        public void Scored()
        {
            this.Score += 1;
        }
    }
}