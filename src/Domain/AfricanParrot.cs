namespace Domain;

public class AfricanParrot : Parrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed) : base(type, voltage, isNailed)
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    protected override ParrotTypes GetType() => ParrotTypes.African;

    public override double GetSpeed() => Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);

    private double GetLoadFactor() => 9.0;
}