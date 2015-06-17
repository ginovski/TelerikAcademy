namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic;

    public class ExtendedBattleManager : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public ExtendedBattleManager(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            try
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
            catch (Exception)
            {
                if (creatureIdentifier.ArmyNumber == 3)
                {
                    this.thirdArmyCreatures.Add(creaturesInBattle);
                }
                else
                {
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", creatureIdentifier.ArmyNumber));
                }
            }
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            try
            {
                return base.GetByIdentifier(identifier);
            }
            catch (Exception)
            {
                if (identifier.ArmyNumber == 3)
                {
                    return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
                }

                throw new ArgumentException(
                    string.Format(CultureInfo.InvariantCulture, "Invalid ArmyNumber: {0}", identifier.ArmyNumber));
            }
        }
    }
}
