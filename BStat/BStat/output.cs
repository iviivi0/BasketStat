public class Comp 
{
    //ID ����������
    public int id { get; set; }
    //��� ����������
    public string compType { get; set; }
    //������ �������� ����������
    public string name { get; set; }
    //���������� �������� ����������
  public string abcName { get; set; }
  public int level { get; set; }
    // �����. �������� ������� ����� ������ � ������� YYYY
  public int season { get; set; }
    //��� ����������
    public IList< undefined > tag { get; set; }
  public string logo { get; set; }
}

//��������� ������
public class Standings 
{
    // ����������������� ����� �������
  public int teamId { get; set; }
  public int start { get; set; }
    //������� �������/���������
  public bool isActive { get; set; }
    //�����
    public int place { get; set; }
    //������� ���������� ��������
    public string abcName { get; set; }
    //������ �������� �������
    public string name { get; set; }
    //������������ �������
    public string regionName { get; set; }
    //������� �������� �������
    public string shortName { get; set; }
    //����� � ����
  public IList< undefined > label { get; set; }
    //���������� �������� ���
    public IList< undefined > totalGames { get; set; }
    //���������� �����
    public IList< undefined > totalWin { get; set; }
    //����� ������
  public IList< undefined > totalDraw { get; set; }
    //����� ���������
  public IList< undefined > totalDefeat { get; set; }
    //���������
    public IList< undefined > totalForfeit { get; set; }
    //�������� ���������� �����
    public IList< undefined > totalPoints { get; set; }
  public IList< undefined > totalGoalPlus { get; set; }
  public IList< undefined > totalGoalMinus { get; set; }
  public IList< undefined > totalPenalty { get; set; }
    //������� �������
    public string logo { get; set; }
    //����
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
    //������� ����� ��������� � items
  public int totalCount { get; set; }
  public IList<Items> items { get; set; }
} 
