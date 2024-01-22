namespace ShadowrunDiceRollerBot.Models
{
    public class DiceRollParameters
    {
        /// <summary>
        /// The amount of dice to roll
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Should 6's explode?
        /// </summary>
        public bool Exploding { get; set; } = false;

        /// <summary>
        /// What Threshold are they trying to reach? Optional.
        /// </summary>
        public int? Threshold { get; set; }
    }
}