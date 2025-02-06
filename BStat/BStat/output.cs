public class Comp 
{
    //ID ×ÅÌÏÈÎÍÀÒÀ
    public int id { get; set; }
    //ÒÈÏ ×ÅÌÏÈÎÍÀÒÀ
    public string compType { get; set; }
    //ÏÎËÍÎÅ ÍÀÇÂÀÍÈÅ ×ÅÌÏÈÎÍÀÒÀ
    public string name { get; set; }
    //ÂÍÓÒĞÅÍÍÅÅ ÍÀÇÂÀÍÈÅ ×ÅÌÏÈÎÍÀÒÀ
  public string abcName { get; set; }
  public int level { get; set; }
    // Ñåçîí. Çàäàåòñÿ êğàéíèì ãîäîì ñåçîíà â ôîğìàòå YYYY
  public int season { get; set; }
    //ÒİÃ ×ÅÌÏÈÎÍÀÒÀ
    public IList< undefined > tag { get; set; }
  public string logo { get; set; }
}

//ÏÎËÎÆÅÍÈÅ ÊÎÌÀÍÄ
public class Standings 
{
    // Èäåíòèôèêàöèîííûé íîìåğ êîìàíäû
  public int teamId { get; set; }
  public int start { get; set; }
    //êîìàíäà àêòèâíà/íåàêòèâíà
  public bool isActive { get; set; }
    //ÌÅÑÒÎ
    public int place { get; set; }
    //ÊĞÀÒÊÎÅ ÂÍÓÒĞÅÍÍÅÅ ÍÀÇÂÀÍÈÅ
    public string abcName { get; set; }
    //ÏÎËÍÎÅ ÍÀÇÂÀÍÈÅ ÊÎÌÀÍÄÛ
    public string name { get; set; }
    //ÍÀÈÌÅÍÎÂÀÍÈÅ ĞÅÃÈÎÍÀ
    public string regionName { get; set; }
    //ÊĞÀÒÊÎÅ ÍÀÇÂÀÍÈÅ ÊÎÌÀÍÄÛ
    public string shortName { get; set; }
    //ÌÅÒÊÀ Â ÁÀÇÅ
  public IList< undefined > label { get; set; }
    //ÊÎËÈ×ÅÑÒÂÎ ÑÛÃĞÀÍÛÕ ÈÃĞ
    public IList< undefined > totalGames { get; set; }
    //ÊÎËÈ×ÅÑÒÂÎ ÏÎÁÅÄ
    public IList< undefined > totalWin { get; set; }
    //âñåãî íè÷üèõ
  public IList< undefined > totalDraw { get; set; }
    //âñåãî ïîğàæåíèé
  public IList< undefined > totalDefeat { get; set; }
    //ÍÅÓÑÒÎÉÊÀ
    public IList< undefined > totalForfeit { get; set; }
    //ÈÒÎÃÎÂÎÅ ÊÎËÈ×ÅÑÒÂÎ Î×ÊÎÂ
    public IList< undefined > totalPoints { get; set; }
  public IList< undefined > totalGoalPlus { get; set; }
  public IList< undefined > totalGoalMinus { get; set; }
  public IList< undefined > totalPenalty { get; set; }
    //ËÎÃÎÒÈÏ ÊÎÌÀÍÄÛ
    public string logo { get; set; }
    //Ñ×ÅÒ
  public IList<undefined> scores { get; set; }
}

public class Items 
{
  public Comp comp { get; set; } 
  public IList<Standings> standings { get; set; }
  public IList<undefined> playoffPairs { get; set; }
}

public class Application {
  public string status { get; set; }
  public IList< undefined > message { get; set; }
    //ñêîëüêî âñåãî ıëåìåíòîâ â items
  public int totalCount { get; set; }
  public IList<Items> items { get; set; }
} 
