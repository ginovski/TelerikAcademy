namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Extended.Creatures;
    using ArmyOfCreatures.Logic.Creatures;

    public class ExtendedCreaturesFactory : CreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            try
            {
                return base.CreateCreature(name);
            }
            catch (Exception)
            {
                switch (name)
                {
                    case "AncientBehemoth":
                        return new AncientBehemoth();
                    case "CyclopsKing":
                        return new CyclopsKing();
                    case "Goblin":
                        return new Goblin();
                    case "Griffin":
                        return new Griffin();
                    case "WolfRaider":
                        return new WolfRaider();
                    default:
                        throw new ArgumentException(
                            string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
                }
            }
        }
    }
}
