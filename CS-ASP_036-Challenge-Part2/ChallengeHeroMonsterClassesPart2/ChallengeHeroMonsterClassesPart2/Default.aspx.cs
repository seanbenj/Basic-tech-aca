using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 100;
            hero.DamageMaximum = 35;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 100;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            Dice Hit = new Dice();
            Hit.sides = 35;
            Hit.rollDice();

            while (hero.Health > 0 && monster.Health > 0)
            {
                int damage = hero.Attack(Hit, hero.AttackBonus);
                monster.Defend(damage);

                damage = monster.Attack(Hit, monster.AttackBonus);
                hero.Defend(damage);


                printStats(hero);
                printStats(monster);
                displayWinnerAndLoser(hero.Health, monster.Health, hero.Name, monster.Name);
            }

        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("<p>Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}</p>",
                character.Name,
                character.Health,
                character.DamageMaximum.ToString(),
                character.AttackBonus.ToString());
        }

        private void displayWinnerAndLoser(int Hero, int Monster, string HN, string MN)
        {
            if (Hero > 0 && Monster <= 0)
                resultLabel.Text += String.Format("<p> {0} wins this battle and {1} loses </p>",
                HN, MN);
            else if (Monster > 0 && Hero <= 0)
                resultLabel.Text += String.Format("<p> {0} wins this battle and {1} loses </p>",
                MN, HN);
            else if (Monster <= 0 && Hero <= 0)
                resultLabel.Text += String.Format("<p> {0} and {1} both die, what the heck..so boring!",
                HN, MN);
        }

    }

    class Dice
    {
        public int sides { get; set; }

        Random shift = new Random();
        public int rollDice()
        { 
            int num = shift.Next(sides);
            return num;
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice H, bool bonus)
        {
            H.sides = DamageMaximum;
            int damage = H.rollDice();
            if (bonus == true) damage += damage/4;
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }
}