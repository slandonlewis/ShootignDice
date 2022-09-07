using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public virtual string Taunt { get; set; }
        public override int Roll()
        {
            TalkTrash();
            return new Random().Next(DiceSize) + 1;
        }

        public void TalkTrash()
        {
            Console.WriteLine($"{Name} says {Taunt}");
        }
    }
}