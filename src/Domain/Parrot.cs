namespace Domain;

public class Parrot
{
    private readonly bool _isNailed;
    private readonly ParrotTypes _type;
    private readonly double _voltage;

    public static Parrot Create(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        if (type == ParrotTypes.European)
            return new EuropeanParrot(type, numberOfCoconuts, voltage, isNailed);
        return new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public Parrot(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _type = type;
        _voltage = voltage;
        _isNailed = isNailed;
    }

    public virtual double GetSpeed()
    {
        switch (GetType())
        {
            case ParrotTypes.African:
                return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
            case ParrotTypes.NorwegianBlue:
                return _isNailed ? 0 : GetBaseSpeed(_voltage);
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private double GetBaseSpeed(double voltage)
    {
        return Math.Min(24.0, voltage * GetBaseSpeed());
    }

    protected double GetBaseSpeed() => 12.0;

    public string GetCry()
    {
        string value;
        switch (_type)
        {
            case ParrotTypes.European:
                value = "Sqoork!";
                break;
            case ParrotTypes.African:
                value = "Sqaark!";
                break;
            case ParrotTypes.NorwegianBlue:
                value = _voltage > 0 ? "Bzzzzzz" : "...";
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return value;
    }

    protected virtual ParrotTypes GetType() => _type;
}