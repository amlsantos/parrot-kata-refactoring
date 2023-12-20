namespace Domain;

public class EuropeanParrot : Parrot
{
    protected override ParrotTypes GetType() => ParrotTypes.European;

    public override double GetSpeed() => GetBaseSpeed();

    public override string GetCry() => "Sqoork!";
}