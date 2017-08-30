using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassPart1
{
    public partial class heroVSMonster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Hero myHero = new Hero();
            myHero.Name = "Elf";
            myHero.Health = 100;
            myHero.DamageMaximum = 20;
            myHero.AttackBonus = 5;

            Monster myMonster = new Monster();
            myMonster.Name = "Goblin";
            myMonster.Health = 100;
            myMonster.DamageMaximum = 35;
            myMonster.AttackBonus = 0;

            int HeroAttack = myHero.heroAttack(myHero.DamageMaximum, myHero.AttackBonus);
            int monsterDefendResult = myMonster.monsterDefend(HeroAttack, myMonster.Health);
            myMonster.Health = monsterDefendResult;

            int MonsterAttack = myMonster.monsterAttack(myMonster.DamageMaximum, myMonster.AttackBonus);
            int heroDefendResult = myHero.heroDefend(MonsterAttack, myHero.Health);
            myHero.Health = heroDefendResult;

            resultLabel.Text =
            displayResult(myHero.Name, HeroAttack, monsterDefendResult, myMonster.Name, MonsterAttack, monsterDefendResult);

        }

        // creating a hero class

        class Hero
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public int AttackBonus { get; set; }

            // setting attack method parameters plus equation/result

            public int heroAttack(
            int attackerDamageMax,
            int attackerBonus = 0)
            {
                Random Damage = new Random();

                int heroAttackResult = Damage.Next(1, attackerDamageMax) + attackerBonus;

                return heroAttackResult;
            }

            // setting defender method parameters plus equation/result

            public int heroDefend(
            int damageDone,
            int defenderHealth)
            {
                int heroDefendResult = defenderHealth - damageDone;

                return heroDefendResult;
            }

            // creating a monster class

        }
        class Monster
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public int AttackBonus { get; set; }

            // setting attack method parameters plus equation/result

            public int monsterAttack(
            int attackerDamageMax,
            int attackerBonus = 0)
            {
                Random Damage = new Random();

                int monsterAttackResult = Damage.Next(1, attackerDamageMax) + attackerBonus;

                return monsterAttackResult;
            }

            // setting defender method parameters plus equation/result

            public int monsterDefend(
            int damageDone,
            int defenderHealth)
            {
                int monsterdefendResult = defenderHealth - damageDone;

                return monsterdefendResult;

            }
        }
        public string displayResult(string HName,
               int HAttack,
               int MHealth,
               string MName,
               int MAttack,
               int HHealth)
        {
            string battleDisplay =
            string.Format(
                "ROUND 1!" + "<br />" +
                "The {0}(You) attacked the {1} and did {2} damage leaving {3} with {4} health" +
             "<br />" + "You we're attacked by the {5} which did {6} damage to you, leaving you with {7} health"
             , HName, MName, HAttack, MName, MHealth, MName, MAttack, HHealth);

            return battleDisplay;
        }
    }
}