using System;

namespace InlämningsuppgiftShotgun.Classes
{
    public class Game
    {
        public Computer computer { get; set; }
        public Player player { get; set; }

        public bool isGameOver { get; set; } = false; 
        public string resultMessage { get; set; }
        public string resultLabel { get; set; }

        public Game()
        {

            //Fråga om ex nedanstående kod ska skrivas i properties ist och helt ta bort constructorn
            computer = new Computer();
            player = new Player();
            player.Ammo = 0;
            computer.Ammo = 0;
            player.Action = "";
            computer.Action = "";

        }

        public void PlayerShoot()
        {
            player.Shoot();

            if (computer.ReloadUse == true)
            {
                EndGame();
                resultMessage = "You win! ";
                resultLabel = "Winner";
            }
            else if (computer.ShotgunUse == true)
            {
                EndGame();
                resultMessage = "You loose! ";
                resultLabel = "Looser";
            }
            else
            {
                isGameOver = false;
            }
        }

        public void PlayerReload()
        {
            player.Reload();
            if (computer.ShootUse == true || computer.ShotgunUse == true)
            {
                EndGame();
                resultMessage = "You loose! ";
                resultLabel = "Looser";
            }
            else
            {
                isGameOver = false;
            }

        }

        public void PlayerBlock()
        {
            player.Block();
            if (computer.ShotgunUse == true)
            {
                EndGame();
                resultMessage = "You loose! ";
                resultLabel = "Looser";
            }
            else
            {
                isGameOver = false;
            }
        }

        public void PlayerShotgun()
        {
            player.Shotgun();
            if (computer.ShotgunUse == false)
            {
                EndGame();
                resultMessage = "You win! ";
                resultLabel = "Winner";
            }
            else
            {
                isGameOver = false;
            }
        }

        // shoot = 0, block = 1 reload = 2, shotgun = 3
        public void ComputerAction()
        {
            Random rnd = new Random();

            if (computer.Ammo == 0 && player.Ammo == 0)
            {
                computer.computerChoice = 1;
            }
            else if (computer.Ammo < 2 && player.Ammo == 2)
            {
                computer.computerChoice = rnd.Next(0, 3);
                while (computer.computerChoice == 1)
                {
                    computer.computerChoice = rnd.Next(0, 3);
                }
            }
            else if (computer.Ammo == 2 && player.Ammo == 0)
            {
                computer.computerChoice = 1;
            }
            else if (computer.Ammo == 0)
            {
                computer.computerChoice = rnd.Next(1, 3);
            }
            else if (player.Ammo == 0)
            {
                computer.computerChoice = rnd.Next(0, 2);
            }
            else if (computer.Ammo == 3)
            {
                computer.computerChoice = 3;
            }
            else
            {
                computer.computerChoice = rnd.Next(0, 3);
            }

            switch (computer.computerChoice)
            {
                case 0:
                    computer.Shoot();
                    break;
                case 1:
                    computer.Reload();
                    break;
                case 2:
                    computer.Block();
                    break;
                case 3:
                    computer.Shotgun();
                    if (player.ShotgunUse == false)
                    {
                        EndGame();
                        resultMessage = "You loose! ";
                        resultLabel = "Looser";
                    }
                    break;
            }
        }

        private void EndGame()
        {
            isGameOver = true;
        }
    }
}


