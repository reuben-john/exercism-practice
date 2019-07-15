using System;
using System.Collections.Generic;

public class SpaceAge
{

    private double _seconds;
    private double _earthYearInSeconds;
    private Dictionary<string, double> _spaceFormulas;
    public SpaceAge(int seconds)
    {
        _seconds = seconds;
        _earthYearInSeconds = 31557600;
        _spaceFormulas = new Dictionary<string, double> {
            {"Earth", 1},
            {"Mercury", 0.2408467},
            {"Venus", 0.61519726},
            {"Mars", 1.8808158},
            {"Jupiter", 11.862615},
            {"Saturn", 29.447498},
            {"Uranus", 84.016846},
            {"Neptune", 164.79132}
        };
    }

    public double calculateSpaceAge(double seconds, double year, double formula)
    {
        return Math.Round(seconds / (year * formula), 2);
    }

    public double OnEarth()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Earth"]);
    }

    public double OnMercury()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Mercury"]);
    }

    public double OnVenus()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Venus"]);
    }

    public double OnMars()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Mars"]);
    }

    public double OnJupiter()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Jupiter"]);
    }

    public double OnSaturn()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Saturn"]);
    }

    public double OnUranus()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Uranus"]);
    }

    public double OnNeptune()
    {
        return calculateSpaceAge(_seconds, _earthYearInSeconds, _spaceFormulas["Neptune"]);
    }
}