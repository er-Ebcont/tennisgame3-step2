namespace Tennis
{
    public class Player : IPlayer
    {
        private string _name;
        private Score _score;

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
                return this._score.GetScoreName;
            }
        }

        public void Scored()
        {
            this.Score += 1;
        }
    }
}