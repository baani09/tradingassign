using System.Xml.Linq;

namespace assign3_rad
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
            BindData();
        }

        private void LoadPlayers()
        {
            // Initialize player data
            players = new List<Player>
        {
           new Player { Name = "Sunil Chhetri", Team = "India", PhotoPath = "images/sunil.jpeg", Goals = 80, Assists = 20, MatchesPlayed = 125, AverageRating = 8.9 },
new Player { Name = "Udanta Singh", Team = "India", PhotoPath = "images/udanta.jpeg", Goals = 25, Assists = 15, MatchesPlayed = 90, AverageRating = 7.8 },
new Player { Name = "Anirudh Thapa", Team = "India", PhotoPath = "images/thapa.jpeg", Goals = 10, Assists = 18, MatchesPlayed = 85, AverageRating = 7.5 },
new Player { Name = "Sandesh Jhingan", Team = "India", PhotoPath = "images/jhingan.jpeg", Goals = 5, Assists = 5, MatchesPlayed = 100, AverageRating = 8.1 },
new Player { Name = "Manvir Singh", Team = "India", PhotoPath = "images/manvir.jpeg", Goals = 15, Assists = 12, MatchesPlayed = 50, AverageRating = 7.9 },
new Player { Name = "Liston Colaco", Team = "India", PhotoPath = "images/colaco.jpeg", Goals = 20, Assists = 10, MatchesPlayed = 40, AverageRating = 8.0 },
new Player { Name = "Gurpreet Singh Sandhu", Team = "India", PhotoPath = "images/gurpreet.jpeg", Goals = 0, Assists = 1, MatchesPlayed = 110, AverageRating = 8.3 },
new Player { Name = "Sahal Abdul Samad", Team = "India", PhotoPath = "images/sahal.jpeg", Goals = 12, Assists = 15, MatchesPlayed = 75, AverageRating = 8.2 },
new Player { Name = "Rahim Ali", Team = "India", PhotoPath = "images/rahim.jpeg", Goals = 8, Assists = 5, MatchesPlayed = 40, AverageRating = 7.3 },
new Player { Name = "Pritam Kotal", Team = "India", PhotoPath = "images/kotal.jpeg", Goals = 3, Assists = 6, MatchesPlayed = 95, AverageRating = 7.6 },
new Player { Name = "Kaleemullah Khan", Team = "Pakistan", PhotoPath = "images/kaleemullah.jpeg", Goals = 20, Assists = 12, MatchesPlayed = 50, AverageRating = 8.1 },
new Player { Name = "Saadullah Khan", Team = "Pakistan", PhotoPath = "images/saadullah.jpeg", Goals = 8, Assists = 10, MatchesPlayed = 40, AverageRating = 7.5 },
new Player { Name = "Hassan Bashir", Team = "Pakistan", PhotoPath = "images/hassan.jpeg", Goals = 15, Assists = 8, MatchesPlayed = 45, AverageRating = 8.0 },
new Player { Name = "Muhammad Essa", Team = "Pakistan", PhotoPath = "images/essa.jpeg", Goals = 25, Assists = 18, MatchesPlayed = 55, AverageRating = 8.7 },
new Player { Name = "Zesh Rehman", Team = "Pakistan", PhotoPath = "images/zesh.jpeg", Goals = 5, Assists = 7, MatchesPlayed = 60, AverageRating = 7.8 },
new Player { Name = "Faisal Iqbal", Team = "Pakistan", PhotoPath = "images/faisal.jpeg", Goals = 10, Assists = 10, MatchesPlayed = 50, AverageRating = 7.9 },
new Player { Name = "Jaffar Khan", Team = "Pakistan", PhotoPath = "images/jaffar.jpeg", Goals = 0, Assists = 2, MatchesPlayed = 70, AverageRating = 8.4 },
new Player { Name = "Adnan Ahmed", Team = "Pakistan", PhotoPath = "images/adnan.jpeg", Goals = 12, Assists = 15, MatchesPlayed = 60, AverageRating = 8.2 },
new Player { Name = "Mehmood Khan", Team = "Pakistan", PhotoPath = "images/mehmood.jpeg", Goals = 18, Assists = 10, MatchesPlayed = 50, AverageRating = 8.3 },
new Player { Name = "Haidar Ali", Team = "Pakistan", PhotoPath = "images/haidar.jpeg", Goals = 7, Assists = 5, MatchesPlayed = 35, AverageRating = 7.4 },
new Player { Name = "Alphonso Davies", Team = "Canada", PhotoPath = "images/davies.jpeg", Goals = 30, Assists = 25, MatchesPlayed = 80, AverageRating = 9.4 },
new Player { Name = "Jonathan David", Team = "Canada", PhotoPath = "images/david.jpeg", Goals = 35, Assists = 20, MatchesPlayed = 75, AverageRating = 9.2 },
new Player { Name = "Cyle Larin", Team = "Canada", PhotoPath = "images/larin.jpeg", Goals = 28, Assists = 15, MatchesPlayed = 70, AverageRating = 8.9 },
new Player { Name = "Stephen Eustáquio", Team = "Canada", PhotoPath = "images/stephen.jpeg", Goals = 10, Assists = 18, MatchesPlayed = 60, AverageRating = 8.3 },
new Player { Name = "Atiba Hutchinson", Team = "Canada", PhotoPath = "images/atiba.jpeg", Goals = 5, Assists = 10, MatchesPlayed = 100, AverageRating = 8.7 },
new Player { Name = "Milan Borjan", Team = "Canada", PhotoPath = "images/milan.jpeg", Goals = 0, Assists = 0, MatchesPlayed = 95, AverageRating = 8.6 },
new Player { Name = "Junior Hoilett", Team = "Canada", PhotoPath = "images/hoilett.jpeg", Goals = 12, Assists = 10, MatchesPlayed = 65, AverageRating = 8.1 },
new Player { Name = "Sam Adekugbe", Team = "Canada", PhotoPath = "images/sam.jpeg", Goals = 7, Assists = 5, MatchesPlayed = 50, AverageRating = 8.0 },
new Player { Name = "Tajon Buchanan", Team = "Canada", PhotoPath = "images/tajon.jpeg", Goals = 20, Assists = 12, MatchesPlayed = 45, AverageRating = 8.8 },
new Player { Name = "Lucas Cavallini", Team = "Canada", PhotoPath = "images/lucas.jpeg", Goals = 15, Assists = 8, MatchesPlayed = 40, AverageRating = 7.7 },

        };
        }

        private void BindData()
        {
            // Bind player data to DataGridView
            dgvPlayers.DataSource = players.Select(p => new
            {
                p.Name,
                p.Team,
                p.Goals,
                p.Assists,
                p.MatchesPlayed,
                p.AverageRating
            }).ToList();

            dgvPlayers.SelectionChanged += DgvPlayers_SelectionChanged;
        }

        private void DgvPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow != null)
            {
                var selectedName = dgvPlayers.CurrentRow.Cells[0].Value.ToString();
                var player = players.FirstOrDefault(p => p.Name == selectedName);
                if (player != null)
                {
                    DisplayPlayerCard(player);
                }
            }
        }

        private void DisplayPlayerCard(Player player)
        {
            lblPlayerName.Text = player.Name;
            lblPlayerTeam.Text = $"Team: {player.Team}";
            lblPlayerGoals.Text = $"Goals: {player.Goals}";
            lblPlayerAssists.Text = $"Assists: {player.Assists}";
            lblPlayerMatches.Text = $"Matches Played: {player.MatchesPlayed}";
            lblPlayerRating.Text = $"Rating: {player.AverageRating}";

            pictureBoxPlayer.ImageLocation = player.PhotoPath;

            // Dynamic background color based on team
            panelCard.BackColor = player.Team switch
            {
                "India" => Color.Orange,
                "Pakistan" => Color.Green,
                "Canada" => Color.Red,
                _ => Color.Gray
            };

            // Highlight rating text based on value
            lblPlayerRating.ForeColor = player.AverageRating >= 8.5 ? Color.Green : Color.Red;
        }

        // Add Player Functionality
        private void addbtn_Click(object sender, EventArgs e)
        {
            var newPlayer = new Player
            {
                Name = lblPlayerName.Text,  // Displayed name in label
                Team = lblPlayerTeam.Text,  // Displayed team in label
                PhotoPath = lblPlayerRating.Text, // Update this logic if needed for photos
                Goals = int.TryParse(lblPlayerGoals.Text, out var goals) ? goals : 0,
                Assists = int.TryParse(lblPlayerAssists.Text, out var assists) ? assists : 0,
                MatchesPlayed = int.TryParse(lblPlayerMatches.Text, out var matches) ? matches : 0,
                AverageRating = double.TryParse(lblPlayerRating.Text, out var rating) ? rating : 0.0
            };

            if (!string.IsNullOrEmpty(newPlayer.Name))
            {
                players.Add(newPlayer);
                BindData();
                MessageBox.Show("Player added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter valid player details.");
            }
        }

        // Remove Player Functionality
        private void removebtn_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow != null)
            {
                var selectedName = dgvPlayers.CurrentRow.Cells[0].Value.ToString();
                var playerToRemove = players.FirstOrDefault(p => p.Name == selectedName);
                if (playerToRemove != null)
                {
                    players.Remove(playerToRemove);
                    BindData();
                    MessageBox.Show("Player removed successfully!");
                }
                else
                {
                    MessageBox.Show("Player not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a player to remove.");
            }
        }
    }
}