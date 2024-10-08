using InlämningsuppgiftShotgun.Classes;

namespace InlämningsuppgiftShotgun
{
    public partial class ShotgunForm : Form
    {
        //Game game = new Game();
        private Game game { get; set; }
        public ShotgunForm()
        {
            InitializeComponent();
            game = new Game();
            UpdateUI();
            CheckGameOver();
        }

        private async void buttonShoot_Click(object sender, EventArgs e)
        {
            await TextboxFeedback();

            game.ComputerAction();
            game.PlayerShoot();
            UpdateUI();
            CheckGameOver();
        }

        private async void buttonReload_Click(object sender, EventArgs e)
        {
            await TextboxFeedback();

            game.ComputerAction();
            game.PlayerReload();
            UpdateUI();
            CheckGameOver();
        }

        private async void buttonBlock_Click(object sender, EventArgs e)
        {
            await TextboxFeedback();

            game.ComputerAction();
            game.PlayerBlock();
            UpdateUI();
            CheckGameOver();
        }
        private async void buttonShotgun_Click(object sender, EventArgs e)
        {
            await TextboxFeedback();

            game.ComputerAction();
            game.PlayerShotgun();
            UpdateUI();
            CheckGameOver();
        }

        private async Task TextboxFeedback()
        {
            textBoxPlayerAction.Text = "";
            textBoxComputerAction.Text = "";
            await Task.Delay(30);
        }

        private void CheckGameOver()
        {
            if (game.isGameOver)
            {
                DialogResult result = MessageBox.Show(game.resultMessage + "Do you wanna play again?",
                                        game.resultLabel, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Application.Restart();
                    game = new Game();
                    UpdateUI();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void UpdateUI()
        {
            textBoxPlayerAmmo.Text = game.player.Ammo.ToString();
            textBoxPlayerAction.Text = game.player.Action.ToString();

            textBoxComputerAmmo.Text = game.computer.Ammo.ToString();
            textBoxComputerAction.Text = game.computer.Action.ToString();

            buttonShoot.Enabled = false;
            buttonShotgun.Enabled = false;

            if (game.player.Ammo < 1)
            {
                buttonShoot.Enabled = false;
            }
            else
            {
                buttonShoot.Enabled = true;
            }

            if (game.player.Ammo >= 3)
            {
                buttonShotgun.Enabled = true;
            }
            else
            {
                buttonShotgun.Enabled = false;
            }

            //Shotgun ammo design. Skapar två separata arrays för pictureboxes som
            //loopas igenom med hjälp av UpdateAmmoDisplay metoden och tömmer respektive fyller på
            //pictureboxes
            string imagePath = System.IO.Path.Combine(Application.StartupPath, "Pictures", "shotgunshell.png");
            PictureBox[] playerPicktureBoxes = { pictureBox1, pictureBox2, pictureBox3 };
            PictureBox[] computerPicktureBoxes = { pictureBox4, pictureBox5, pictureBox6 };
            if (game.player.Ammo <= 3)
            {
                UpdateAmmoDisplay(playerPicktureBoxes, game.player.Ammo, imagePath);
            }
            if (game.computer.Ammo <= 3)
            {
                UpdateAmmoDisplay(computerPicktureBoxes, game.computer.Ammo, imagePath);
            }
    
        }    

        private void UpdateAmmoDisplay(PictureBox[] pictureBoxes, int ammo, string imagePath)
        {
            for(int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Image = null;
            }
            for (int i = 0; i < ammo; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(imagePath);
            }
        }

    }
}