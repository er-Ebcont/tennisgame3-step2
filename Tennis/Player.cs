namespace Tennis
{
    public class Player
    {
        private string playerName1;
        private int playerScore1;

        public Player(string playerName1, int playerScore1)
        {
            this.playerName1 = playerName1;
            this.playerScore1 = playerScore1;
        }

        public string PlayerName1 { get => playerName1; set => playerName1 = value; }
        public int PlayerScore1 { get => playerScore1; set => playerScore1 = value; }
    }
}