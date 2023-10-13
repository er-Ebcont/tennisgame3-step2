namespace Tennis
{
    public class Score
    {
        private int _score;
        private string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public Score(int score)
        {
            _score = score;
        }

        public int ScoreProp { get => _score; set => _score = value; }

        public string GetScoreName
        {
            get
            {
                if (this._score >= this.scoreTerms.Length)
                {
                    throw new System.Exception($"Score not valid {this._score}");
                }

                return this.scoreTerms[this._score];
            }
        }
    }
}