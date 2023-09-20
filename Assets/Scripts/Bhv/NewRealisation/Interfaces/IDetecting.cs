namespace Assets.Scripts.Bhv.NewRealisation.Interfaces
{
    public interface IDetecting
    {
        void SetDetected(IHit hit);

        IHit CurrentEnemy { get; }
        float DetectRange { get; }
    }
}
