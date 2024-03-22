using System.Diagnostics;

namespace lab_03;

public abstract class Container : IContainer
{
    public double CargoMass { get; set; }

    protected Container(double cargoMass)
    {
        CargoMass = cargoMass;
    }

    public void Unload()
    {
        throw new OverfillException();
    }

    public void Load(double cargoMass)
    {
        throw new OverfillException();
    }
}