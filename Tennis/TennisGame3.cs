namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private IPlayer player1;
        private IPlayer player2;
        private string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name, 0);
            this.player2 = new Player(player2Name, 0);
        }

        public string GetScore()
        {
            if ((this.player1.Score < 4 && this.player2.Score < 4) && (this.player1.Score + this.player2.Score < 6))
            {
                string scoreTermPlayer1 = scoreTerms[this.player1.Score];
                return (this.player1.Score == this.player2.Score) ? scoreTermPlayer1 + "-All" : scoreTermPlayer1 + "-" + scoreTerms[this.player2.Score];
            }

            if (this.player1.Score == this.player2.Score)
            {
                return "Deuce";
            }
                
            string winningPlayerName = this.player1.Score > this.player2.Score ? this.player1.Name : this.player2.Name;
            return ((this.player1.Score - this.player2.Score) * (this.player1.Score - this.player2.Score) == 1) ? "Advantage " + winningPlayerName : "Win for " + winningPlayerName;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this.player1.Name)
            {
                this.player1.Score += 1;
            }

            if (playerName == this.player2.Name)
            {
                this.player2.Score += 1;
            }
        }

    }
}