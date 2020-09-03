public interface IElectric
{
    int CurrentChargePercentage { get; }
    void ChargeBattery();
}