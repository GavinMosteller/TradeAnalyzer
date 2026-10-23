namespace TradeAnalyzer.Models;

public class WaiverViewModel
{
    public int Id {get; set;}
    public string Name {get; set;} = "";
    public string Position {get; set;} = "";
    public string Team {get; set;} = "";
    public double Points {get; set;}
    public double GainOverCurrent {get; set;}
}