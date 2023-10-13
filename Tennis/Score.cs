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
    }
}