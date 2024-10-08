
namespace InlämningsuppgiftShotgun.Classes
{
    public abstract class Shooter
    {
        public int Ammo { get; set; }
        public string Action { get; set; }
        public bool ShootUse { get; set; }
        public bool BlockUse { get; set; }
        public bool ReloadUse { get; set; }
        public bool ShotgunUse { get; set; }

        public abstract void Shoot();
        public abstract void Reload();
        public abstract void Block();
        public abstract void Shotgun();
    }    
}
