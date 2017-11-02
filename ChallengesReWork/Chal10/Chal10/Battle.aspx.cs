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
        public class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMax { get; set; }
            public bool AttackBonus { get; set; }

            Random random = new Random();
            
            public int Attack()
            {
                int damage = random.Next(DamageMax);
                if (AttackBonus) damage += random.Next(5,10);
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

            int count = 0;

            while (monster.Health > 0 && hero.Health > 0)
            {
                count++;
                int damage = hero.Attack();
                monster.Defend(damage);

                displayRound(damage, hero.Name, monster.Name, monster.Health, count);

                count++;
                damage = monster.Attack();
                hero.Defend(damage);

                displayRound(damage, monster.Name, hero.Name, hero.Health, count);
            }
            if (monster.Health <= 0) resultLabel.Text += "<br><hr/>The hero wins!";
            else if (hero.Health <= 0) resultLabel.Text += "<br><hr/>The monster wins!";
            
                      
        }
    }
}