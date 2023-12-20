namespace Domain;

public class Parrot
{
    private readonly bool _isNailed;
    private readonly int _numberOfCoconuts;
    private readonly ParrotTypes _type;
    private readonly double _voltage;

    public static Parrot Create(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        return new Parrot(type, numberOfCoconuts, voltage, isNailed);
    }

    public Parrot(ParrotTypes type, int numberOfCoconuts, double voltage, bool isNailed)
    {
        _type = type;
        _numberOfCoconuts = numberOfCoconuts;
        _voltage = voltage;
        _isNailed = isNailed;
    }

    public double GetSpeed()
    {
        switch (_type)
        {
            case ParrotTypes.European:
                return GetBaseSpeed();
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

    private double GetLoadFactor()
    {
        return 9.0;
    }

    private double GetBaseSpeed()
    {
        return 12.0;
    }

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
}