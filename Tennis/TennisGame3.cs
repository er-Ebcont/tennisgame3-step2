namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int playerScore2;
        private int playerScore1;
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
            if ((playerScore1 < 4 && playerScore2 < 4) && (playerScore1 + playerScore2 < 6))
            {
                string scoreTermPlayer1 = scoreTerms[playerScore1];
                return (playerScore1 == playerScore2) ? scoreTermPlayer1 + "-All" : scoreTermPlayer1 + "-" + scoreTerms[playerScore2];
            }

            if (playerScore1 == playerScore2)
            {
                return "Deuce";
            }
                
            string winningPlayerName = playerScore1 > playerScore2 ? this.player1.Name : this.player2.Name;
            return ((playerScore1 - playerScore2) * (playerScore1 - playerScore2) == 1) ? "Advantage " + winningPlayerName : "Win for " + winningPlayerName;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this.player1.Name)
            {
                this.playerScore1 += 1;
            }

            if (playerName == this.player2.Name)
            {
                this.playerScore2 += 1;
            }
        }

    }
}