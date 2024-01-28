namespace ShadowrunDiceRollerBot
{
    public class DiceRollResult
    {
        /// <summary>
        /// How many total hits did they get?
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// Did the roll result in a glitch?
        /// </summary>
        public bool Glitch { get; set; }

        /// <summary>
        /// Did the roll result in a critical glitch?
        /// </summary>
        public bool CriticalGlitch { get; set; }

        /// <summary>
        /// Full list of results to show the user
        /// </summary>
        public List<int> Results { get; set; } = [];

        /// <summary>
        /// Was the roll successful? Should only be provided if a threshold is given
        /// </summary>
        public bool? Success { get; set; }
    }
}