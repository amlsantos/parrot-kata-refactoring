namespace Domain;

public class NorwegianBlueParrot : Parrot
{
    private readonly bool _isNailed;
    private readonly double _voltage;
    
    public NorwegianBlueParrot(double voltage, bool isNailed)
    {
        _voltage = voltage;
        _isNailed = isNailed;
    }

    protected override ParrotTypes GetParrotType() => ParrotTypes.NorwegianBlue;

    public override double GetSpeed() => _isNailed ? 0 : GetBaseSpeed(_voltage);

    private double GetBaseSpeed(double voltage) => Math.Min(24.0, voltage * GetBaseSpeed());

    public override string GetCry() => _voltage > 0 ? "Bzzzzzz" : "...";
}