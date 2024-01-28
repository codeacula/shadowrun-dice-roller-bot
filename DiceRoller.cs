namespace ShadowrunDiceRollerBot;

public class DiceRoller
{
            static readonly Random Rnd = new();

        static List<int> GetRolls(int amount)
        {
            List<int> results = [];

            for (int i = 0; i < amount; i++)
            {
                results.Add(Rnd.Next(1, 7));
            }

            return results;
        }

        static DiceRollResult RollDice(DiceRollParameters parameters)
        {
            var result = GetRolls(parameters.Amount);

            if (parameters.Exploding) {
                var tempResult = result;

                while (tempResult.Any(x => x == parameters.ExplodeTheshold)) {
                    var subresult = GetRolls(tempResult.Count(x => x == parameters.ExplodeTheshold));
                    result.AddRange(subresult);
                    tempResult = subresult;
                }
            }

            var diceResult = new DiceRollResult
            {
                Hits = result.Count(x => x >= parameters.HitThreshold),
                Results = result
            };

            if (parameters.Threshold.HasValue) {
                diceResult.Success = diceResult.Hits >= parameters.Threshold.Value;
            }

            int ones = result.Count(x => x == 1);
            int halfDice = (int)Math.Floor((decimal)diceResult.Results.Count / 2);

            diceResult.Glitch = result.Count(x => x == 1) > diceResult.Hits;
            diceResult.CriticalGlitch = ones >= halfDice;

            return diceResult;
        }
}