namespace Domain;

public abstract class Parrot
{
    public static Parrot Create(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        if (type == ParrotTypes.European)
            return new EuropeanParrot();
        if (type == ParrotTypes.African)
            return new AfricanParrot(numberOfCoconuts);
        if (type == ParrotTypes.NorwegianBlue)
            return new NorwegianBlueParrot(voltage, isNailed);
        
        throw new ArgumentOutOfRangeException();
    }

    public abstract double GetSpeed();
    protected abstract ParrotTypes GetParrotType();
    public abstract string GetCry();
    
    protected double GetBaseSpeed() => 12.0;
}