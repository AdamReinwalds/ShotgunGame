using InlämningsuppgiftShotgun;

namespace InlämningsuppgiftShotgun.Classes
{
    public sealed class Player : Shooter
    {
        public Player() 
        {
            BlockUse = false;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = false;
        }
        
        public override void Block()
        {
            Action = "You block";
            BlockUse = true;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = false;
        }

        public override void Reload()
        {
            Action = "You reload";
            Ammo += 1;
            BlockUse = false;
            ReloadUse = true;
            ShootUse = false;
            ShotgunUse = false;
        }      
        public override void Shoot()
        {
            Action = "You shoot";
            Ammo -= 1;
            BlockUse = false;
            ReloadUse = false;
            ShootUse = true;
            ShotgunUse = false;
        }

        public override void Shotgun()
        {
            Action = "You use shotgun";
            Ammo -= 3;
            BlockUse = false;
            ReloadUse = false;
            ShootUse = false;
            ShotgunUse = true;
        }
    }
}
