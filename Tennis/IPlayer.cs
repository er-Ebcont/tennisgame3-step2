namespace Tennis
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }

        bool IsUnderScoreForty
        {
            get;
        }

        string GetScore
        {
            get;
        }
    }
}