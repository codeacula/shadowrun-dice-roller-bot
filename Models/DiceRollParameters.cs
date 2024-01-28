namespace ShadowrunDiceRollerBot.Models
{
    public class DiceRollParameters
    {
        /// <summary>
        /// The amount of dice to roll
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// What should count as the dice threshold for exploding dice?
        /// </summary>
        public int ExplodeTheshold { get; set; } = 6;

        /// <summary>
        /// Should 6's explode?
        /// </summary>
        public bool Exploding { get; set; } = false;

        /// <summary>
        /// Determines what counts as a hit. Sometimes edge may be used to lower the threshold to 4
        /// </summary>
        public int HitThreshold { get; set; } = 5;

        /// <summary>
        /// What Threshold are they trying to reach? Optional.
        /// </summary>
        public int? Threshold { get; set; }
    }
}