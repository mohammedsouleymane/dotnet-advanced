using classlibrary;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Les5Oefenbundel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var players = from player in Players.GetPlayers()
                    where player.Id == 27 || player.Id == 44
                select new PlayerFine
                {
                    PlayerId = player.Id,
                    PlayerName = player.LastName,
                    PlayerInitials = player.Initials,
                    PlayerHouseNumber = player.Number,
                    PlayerLocation = player.City,
                    PlayerStreet = player.Street,
                    PlayerZipcode = player.ZipCode,
                    NumberOfFines = player.Fines.Count
                };
            dataGridView1.DataSource = players.ToList();
        }

    }
}
