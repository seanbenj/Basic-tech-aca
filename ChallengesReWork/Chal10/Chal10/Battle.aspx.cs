using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chal10
{
    public partial class Battle : System.Web.UI.Page
    {
       
        public class Dice
        {
            public int Sides { get; set; }
            Random random = new Random();
            public int Roll()
            {
                int roll = random.Next(Sides);
                return roll;
            }
        }

        public class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack(Dice dice)
            {
                dice.Sides = this.DamageMax;
                int damage = dice.Roll();
                if (AttackBonus) damage += dice.Roll() / 5;
                return damage;
            }

            public void Defend(int damage)
            {
                this.Health -= damage;
            }
        }

        private void displayRound(int damage,
            string attackerName,
            string defenderName,
            int defenderHealth, int roundCount)
        {
            string result;
            result =
            string.Format("<br>ROUND {0}<hr/>The {1} attacks the {2} and does {3} damage leaving the {4} with {5} health",
            roundCount, attackerName, defenderName, damage, defenderName, defenderHealth);
            resultLabel.Text += result;
        }

        private void displayWinner(Character character1, Character character2)
        {
            if (character2.Health <= 0) resultLabel.Text += "<br><hr/>The hero wins!";
            else if (character1.Health <= 0) resultLabel.Text += "<br><hr/>The monster wins!";
            else if (character1.Health <= 0 && character2.Health <= 0) resultLabel.Text += "<br><hr/>They both died!";
        }

        private void displayBattle(Dice dice, Character character1, Character character2)
        {
            int count = 0;
            
            do
            {
                count++;
                int damage = character1.Attack(dice);
                character2.Defend(damage);

                displayRound(damage, character1.Name, character2.Name, character2.Health, count);

                count++;
                damage = character2.Attack(dice);
                character1.Defend(damage);

                displayRound(damage, character2.Name, character1.Name, character1.Health, count);
            } while (character2.Health > 0 && character1.Health > 0);

            displayWinner(character1, character2);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character()
            {
                Name = "Elf",
                Health = 50,
                DamageMax = 30,
                AttackBonus = true
            };

            Character monster = new Character()
            {
                Name = "Goblin",
                Health = 60,
                DamageMax = 35,
                AttackBonus = false
            };

            Dice dice = new Dice();

            displayBattle(dice, hero, monster);                    
        }
    }
}