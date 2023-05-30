public class Aluno
{
   public string nome;
    public string email;
    public double notafinal;
    public double notafinal2;

    public void calcularMedia(double nota1,double nota2)
    {
        double media = (notafinal + notafinal2)/2;
        Console.WriteLine($"A média é {media}");

        if (media < 6)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("REPROVADO");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASSOU");
            Console.ResetColor();
        }
    }
    // dkfjklfjskljf
    // commit git e github

}
