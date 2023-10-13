using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private IPlayer player1;
        private IPlayer player2;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if (this.player1.Score == this.player2.Score && (this.player1.Score + this.player2.Score >= 6))
            {
                return "Deuce";
            }

            if ((this.player1.IsUnderScoreForty && this.player2.IsUnderScoreForty) && (this.player1.Score + this.player2.Score < 6))
            {
                return ReturnGameState();
            }
  
            string winningPlayerName = this.player1.Score > this.player2.Score ? this.player1.Name : this.player2.Name;
            return (Math.Abs(this.player1.Score - this.player2.Score) == 1) ? $"Advantage {winningPlayerName}" : $"Win for {winningPlayerName}";
        }

        private bool IsDeuce()
        {
            return this.player1.Score == this.player2.Score && (this.player1.Score + this.player2.Score >= 6);
        }

        private string ReturnGameState()
        {
            string scoreTermPlayer1 = this.player1.GetScore;
            return (this.player1.Score == this.player2.Score) ? $"{scoreTermPlayer1}-All" : $"{scoreTermPlayer1}-{this.player2.GetScore}";
        }

        public void WonPoint(string playerName)
        {
            this.GetCorrectPlayerInstance(playerName).Scored();
        }

        private IPlayer GetCorrectPlayerInstance(string playerName)
        {
            if (playerName == this.player1.Name)
            {
                return this.player1;
            }

            if (playerName == this.player2.Name)
            {
                return this.player2;
            }

            throw new Exception($"Player with name {playerName} not found!");
        }

    }
}