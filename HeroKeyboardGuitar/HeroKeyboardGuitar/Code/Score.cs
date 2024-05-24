namespace HeroKeyboardGuitar;

/// <summary>
/// Holds the current score and streak of the player
/// </summary>
public class Score
{
    /// <summary>
    /// Amount of notes successfully hit
    /// </summary>
    public int Amount { get; private set; }

    /// <summary>
    /// Current streak, i.e. consecutive hit notes without a miss
    /// </summary>
    public int Streak { get; private set; }

    //Current HighScore saved
    public int HighScore { get; private set; }


    /// <summary>
    /// initializes amount, streak to 0, and HighScore to 0
    /// </summary>
    public Score()
    {
        Amount = 0;
        Streak = 0;
        HighScore = 0;
    }

    /// <summary>
    /// Used to check if the player has reached the point of receiving a reward.
    /// Currently not implemented
    /// </summary>
    public void CheckReward()
    {
        // TODO: possibly make this a dictionary mapping genres to reward maps
        //Game.GetRewardMap()
    }

    /// <summary>
    /// Add to the current score
    /// </summary>
    /// <param name="amount">Amount to add</param>
    public void Add(int amount)
    {
        Amount += amount;
        Streak += amount;
        HighScore += amount;
     
        if (Amount > HighScore)
        {
            HighScore = Amount;
        }
    }

    public int SaveHighScore() {
        return HighScore;
    }
    /// <summary>
    /// Resets streak back to 0
    /// </summary>
    public void Miss()
    {
        Streak = 0;
       
        HighScore = SaveHighScore();
    }
}