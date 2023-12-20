namespace Domain;

public class AfricanParrot : Parrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(int numberOfCoconuts) => _numberOfCoconuts = numberOfCoconuts;

    protected override ParrotTypes GetType() => ParrotTypes.African;

    public override double GetSpeed() => Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);

    private double GetLoadFactor() => 9.0;
}