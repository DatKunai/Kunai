using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster_Fighter
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        List<Monster> monsters = new List<Monster>();
        List<Weapon> weapons = new List<Weapon>();
        List<Armour> armour = new List<Armour>();

        int playerDisplayed = 0;
        private void DisplayData()
        {
            textBoxPlayerName.Text = players[playerDisplayed].Name;
            textBoxPlayerScore.Text = players[playerDisplayed].Score.ToString();
            textBoxPlayerHealth.Text = players[playerDisplayed].Health.ToString();
            textBoxPlayerLives.Text = players[playerDisplayed].Lives.ToString();

            if (players[playerDisplayed].Weapon == null)
            {
                textBoxWeaponType.Text = "None";
                textBoxWeaponName.Text = "N/A";
                textBoxWeaponAttackPower.Text = "N/A";

            }
            else
            {
                textBoxWeaponType.Text = players[playerDisplayed].Weapon.Name;
                textBoxWeaponName.Text = players[playerDisplayed].Weapon.Type;
                textBoxWeaponAttackPower.Text = players[playerDisplayed].Weapon.AttackPower.ToString();
            }

            if (players[playerDisplayed].Armour == null)
            {
                textBoxArmourType.Text = "None";
                textBoxArmourName.Text = "N/A";
                textBoxArmourDefencePower.Text = "N/A";

            }
            else
            {
                textBoxArmourType.Text = players[playerDisplayed].Armour.Name;
                textBoxArmourName.Text = players[playerDisplayed].Armour.Type;
                textBoxArmourDefencePower.Text = players[playerDisplayed].Armour.DefencePower.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            players.Add(new Player("Araine", 0, 100, 2));
            players.Add(new Player("Ozan", 0, 100, 2));
            players.Add(new Player("Sir Owen", 0, 100, 2));
            players.Add(new Player("The Raptor", 0, 90, 3));
            players.Add(new Player("World Guardian", 0, 90, 4));

            monsters.Add(new Monster("Mole", "Giant Mole", 1000, 100, 1000));
            monsters.Add(new Monster("Bandosian General", "Graardor", 1500, 150, 1800));
            monsters.Add(new Monster("Armadylian General", "Kree Arra", 1500, 150, 1800));
            monsters.Add(new Monster("Zamorakian General", "K'ril", 1500, 150, 1800));
            monsters.Add(new Monster("Saradominist General", "Zilyana", 1500, 150, 1800));
            monsters.Add(new Monster("QBD", "Queen Black Dragon", 1800, 175, 1200));
            monsters.Add(new Monster("Seren's Champion", "Helwyr", 2000, 220, 2500));
            monsters.Add(new Monster("Zamorak's Champion", "The Twin Furies", 2000, 220, 2500));
            monsters.Add(new Monster("Sliske's Champion", "Gregorovic", 2000, 220, 2500));
            monsters.Add(new Monster("Zaros's Champion", "Vindicta & Gorvek", 2000, 220, 2500));
            monsters.Add(new Monster("The Araxyte", "Arraxor", 4500, 450, 4500));
            monsters.Add(new Monster("King of the Kalphites", "Kalphite King", 4500, 450, 4500));
            monsters.Add(new Monster("Of the Crossing", "The Magister", 5000, 500, 6000));
            monsters.Add(new Monster("The Warden", "Telos", 5000, 600, 7500));
            monsters.Add(new Monster("The Physical Incarnation", "Corporeal Beast", 5000, 600, 7500));
            monsters.Add(new Monster("The Earth's Soul", "Vorago", 5000, 600, 7500));
            monsters.Add(new Monster("Guardian of The Grove", "Solak", 7000, 700, 9000));
            monsters.Add(new Monster("Angel of Death", "Nex", 8000, 800, 10000));


            weapons.Add(new Weapon("Staff", "Mindspike", 10));
            weapons.Add(new Weapon("Staff", "Guthix Staff", 25));
            weapons.Add(new Weapon("Staff", "Ahrim's Staff", 30));
            weapons.Add(new Weapon("Wand and Orb", "Ahrim's Wand and Book", 30));
            weapons.Add(new Weapon("Staff", "Vanquish", 50));
            weapons.Add(new Weapon("Staff", "Sunspear (Magic)", 75));
            weapons.Add(new Weapon("Staff", "Staff of Sliske", 125));
            weapons.Add(new Weapon("Wand and Orb", "Wand and Orb of the Praesul", 125));

            armour.Add(new Armour("Robes", "Lunar Robes", 5));
            armour.Add(new Armour("Magic Armour", "Superior Skeletal Armour", 10));
            armour.Add(new Armour("Robes", "Virtus Robes", 15));
            armour.Add(new Armour("Robes", "Tectonic Robes", 20));


            DisplayData();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            playerDisplayed++;

            if (playerDisplayed == players.Count())
            {
                playerDisplayed = 0;
            }
            DisplayData();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            playerDisplayed--;

            if (playerDisplayed == -1)
            {
                playerDisplayed = players.Count() - 1;
            }
            DisplayData();

        }

        private void buttonIncreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = 100;
        }

        private void buttonDecreaseScore_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeScore = -100;
        }

        private void buttonAddLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = 1;
        }

        private void buttonRemLives_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].ChangeLives = -1;
        }

        private void buttonGenerateRandomWeapon_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomWeaponNumber = rnd.Next(0, weapons.Count());

            DialogResult result = MessageBox.Show(weapons[randomWeaponNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called the " + weapons[randomWeaponNumber].Name +
                Environment.NewLine + "\nAttack power " + weapons[randomWeaponNumber].AttackPower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Weapon Found", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Weapon = weapons[randomWeaponNumber];
            }
            DisplayData();
        }
        private void buttonGenerateRandomArmour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomArmourNumber = rnd.Next(0, armour.Count());

            DialogResult result = MessageBox.Show(armour[randomArmourNumber].Type + " found!" +
                Environment.NewLine + "\nIt's called the " + armour[randomArmourNumber].Name +
                Environment.NewLine + "\nDefence power " + armour[randomArmourNumber].DefencePower.ToString() + "!" +
                Environment.NewLine + "\nWould you like to Equip it?", "Armour Found", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                players[playerDisplayed].Armour = armour[randomArmourNumber];
            }
            DisplayData();
        }

        private void textBoxWeaponName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDropWeapon_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Weapon = null;

            DisplayData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDropArmour_Click(object sender, EventArgs e)
        {
            players[playerDisplayed].Armour = null;

            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
