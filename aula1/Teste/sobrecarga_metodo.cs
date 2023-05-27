Note B = new Note(2);
Note CSharp = B + 2;

Console.WriteLine(CSharp.SemitonesFromA);     // 4

CSharp += 2;
Console.WriteLine(CSharp.SemitonesFromA);     // 6

public struct Note
{
  int value;
  public int SemitonesFromA => value;

  public Note (int semitonesFromA) { value = semitonesFromA; }  // Construtor

  public static Note operator + (Note x, int semitones)         // Sobrecarga do operador de soma
  {
    return new Note (x.value + semitones);
  }
  
}