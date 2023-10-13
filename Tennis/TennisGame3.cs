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
            if (this.IsDeuce())
            {
                return "Deuce";
            }

            if (ArePlayerScoresEqual())
            {
                return $"{this.player1.GetScore}-All"; ;
            }

            if (IsEarlyGame())
            {
                return $"{this.player1.GetScore}-{this.player2.GetScore}";
            }

            string winningPlayerName = GetWinningPlayerName();
            return HasAdvantage() ? $"Advantage {winningPlayerName}" : $"Win for {winningPlayerName}";
        }

        private bool HasAdvantage()
        {
            return (Math.Abs(this.player1.Score - this.player2.Score) == 1);
        }

        private string GetWinningPlayerName()
        {
            return this.player1.Score > this.player2.Score ? this.player1.Name : this.player2.Name;
        }

        private bool IsEarlyGame()
        {
            return (this.player1.IsUnderScoreForty && this.player2.IsUnderScoreForty) && (this.player1.Score + this.player2.Score < 6);
        }

        private bool ArePlayerScoresEqual()
        {
            return (this.player1.IsUnderScoreForty && this.player2.IsUnderScoreForty) && (this.player1.Score + this.player2.Score < 6) && (this.player1.Score == this.player2.Score);
        }

        private bool IsDeuce()
        {
            return this.player1.Score == this.player2.Score && (this.player1.Score + this.player2.Score >= 6);
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