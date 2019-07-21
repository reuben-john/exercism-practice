using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{

    private List<int> _highScores;
    public HighScores(List<int> list) => _highScores = new List<int>(list);


    public List<int> Scores() => _highScores;


    public int Latest() => _highScores.Last();


    public int PersonalBest() => _highScores.Max();


    public List<int> PersonalTopThree() => _highScores.OrderByDescending(score => score).Take(3).ToList();

}