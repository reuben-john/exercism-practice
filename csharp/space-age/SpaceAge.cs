using System;
using System.Collections.Generic;

public class SpaceAge
{

    private double _seconds;
    private double earthYearInSeconds = 31_557_600;

    public SpaceAge(int seconds) => _seconds = seconds;


    public double calculateSpaceAge(double seconds, double year, double formula) => Math.Round(seconds / (year * formula), 2);

    public double OnEarth() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Earth);

    public double OnMercury() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Mercury);

    public double OnVenus() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Venus);

    public double OnMars() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Mars);

    public double OnJupiter() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Jupiter);

    public double OnSaturn() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Saturn);

    public double OnUranus() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Uranus);

    public double OnNeptune() => calculateSpaceAge(_seconds, earthYearInSeconds, SpaceFormulas.Neptune);

    private class SpaceFormulas
    {
        public const double Earth = 1;
        public const double Mercury = 0.2408467;
        public const double Venus = 0.61519726;
        public const double Mars = 1.8808158;
        public const double Jupiter = 11.862615;
        public const double Saturn = 29.447498;
        public const double Uranus = 84.016846;
        public const double Neptune = 164.79132;
    }
}