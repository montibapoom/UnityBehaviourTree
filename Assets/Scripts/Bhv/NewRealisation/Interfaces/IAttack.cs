namespace Assets.Scripts.Bhv.NewRealisation.Interfaces
{
    public interface IAttack
    {
        int ShotTimes { get; }
        void Reload();
        void Attack(IHit hittable);
    }
}
