namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int playerScore2;
        private int playerScore1;
        private string playerName1;
        private string playerName2;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.playerName1 = player1Name;
            this.playerName2 = player2Name;
        }

        public string GetScore()
        {
            string s;
            if ((playerScore1 < 4 && playerScore2 < 4) && (playerScore1 + playerScore2 < 6))
            {
                string[] scoreTerms = { "Love", "Fifteen", "Thirty", "Forty" };
                s = scoreTerms[playerScore1];
                return (playerScore1 == playerScore2) ? s + "-All" : s + "-" + scoreTerms[playerScore2];
            }

            if (playerScore1 == playerScore2)
                return "Deuce";
            s = playerScore1 > playerScore2 ? playerName1 : playerName2;
            return ((playerScore1 - playerScore2) * (playerScore1 - playerScore2) == 1) ? "Advantage " + s : "Win for " + s;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.playerScore1 += 1;
            else
                this.playerScore2 += 1;
        }

    }
}