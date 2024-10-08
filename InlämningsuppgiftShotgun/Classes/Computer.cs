
using Microsoft.VisualBasic.Devices;

namespace InlämningsuppgiftShotgun.Classes
{
    public sealed class Computer : Shooter
    {
        public int computerChoice { get; set; }
        
        public Computer() 
        {
            BlockUse = false;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = false;
        }
        public override void Block()
        {
            //Om motspelaren skjuter förlorar endast motspelaren ett skott
            Action = "Computer blocks";
            BlockUse = true;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = false;
        }

        public override void Reload()
        {
            Action = "Computer reloads";
            Ammo += 1;
            BlockUse = false;
            ReloadUse = true;
            ShootUse = false;
            ShotgunUse = false;
        }

        public override void Shoot()
        {
            Action = "Computer shoots";
            Ammo -= 1;
            BlockUse = false;
            ReloadUse = false;
            ShootUse = true;
            ShotgunUse = false;
        }
        public override void Shotgun()
        {
            Action = "Computer uses shotgun";
            Ammo -= 3;
            BlockUse = false;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = true;
        }
    }
}
