using System;

public class Inputs
{
    public Inputs()
    {
    }

    private double _emptyW;
    private string _matDesc;
    private double _matYield;
    private double _llHeight;
    private double _llThk;
    private double _llHoleDia;
    private double _llSCArcRad;
    private double _llBottToHoleDist;
    private double _llODOffToHole;
    private double _forceAX;
    private double _forceN;
    private double _forceT;
    private double _impactFac;

    public double EmptyW { get => _emptyW; set => _emptyW = value; }
    public string MatDesc { get => _matDesc; set => _matDesc = value; }
    public double MatYield { get => _matYield; set => _matYield = value; }
    public double LlHeight { get => _llHeight; set => _llHeight = value; }
    public double LlThk { get => _llThk; set => _llThk = value; }
    public double LlHoleDia { get => _llHoleDia; set => _llHoleDia = value; }
    public double LlSCArcRad { get => _llSCArcRad; set => _llSCArcRad = value; }
    public double LlBottToHoleDist { get => _llBottToHoleDist; set => _llBottToHoleDist = value; }
    public double LlODOffToHole { get => _llODOffToHole; set => _llODOffToHole = value; }
    public double ForceAX { get => _forceAX; set => _forceAX = value; }
    public double ForceN { get => _forceN; set => _forceN = value; }
    public double ForceT { get => _forceT; set => _forceT = value; }
    public double ImpactFac { get => _impactFac; set => _impactFac = value; }
}
