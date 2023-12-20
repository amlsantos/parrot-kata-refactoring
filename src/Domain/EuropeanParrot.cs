namespace Domain;

public class EuropeanParrot : Parrot
{
    protected override ParrotTypes GetParrotType() => ParrotTypes.European;

    public override double GetSpeed() => GetBaseSpeed();

    public override string GetCry() => "Sqoork!";
}