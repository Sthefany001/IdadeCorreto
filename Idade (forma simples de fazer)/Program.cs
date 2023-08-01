Console.Write("Informe a data de nascimento: ");
DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());
DateTime dataAtual = DateTime.Now;

int idade = dataAtual.Year - dataNasc.Year;

if(dataAtual.Month < dataNasc.Month)
{
    idade--;
}
else if(dataAtual.Month == dataNasc.Month)
{
    if(dataAtual.Day < dataNasc.Day)
    {
        idade--;   
    }
}

Console.WriteLine($"\nIDADE = {idade}");