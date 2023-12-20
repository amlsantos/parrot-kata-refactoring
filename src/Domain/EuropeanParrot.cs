namespace Domain;

public class EuropeanParrot : Parrot
{
    public EuropeanParrot(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed) 
        : base(type, numberOfCoconuts, voltage, isNailed) { }

    protected override ParrotTypes GetType() => ParrotTypes.European;

    public override double GetSpeed() => GetBaseSpeed();
}