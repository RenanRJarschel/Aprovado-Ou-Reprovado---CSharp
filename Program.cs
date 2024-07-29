using System;

class nota
{
    static void Main()
    {

        int nota1tri,nota2tri,nota3tri,res ;
        res=nota1tri=nota2tri=nota3tri=0;
        string resultado = "Reprovado";
        string nome;

        Console.Write("Seu nome: ");
        nome = Convert.ToString (Console.ReadLine());

        Console.Write("Digite sua nota do Primeiro Trimestre: ");
        nota1tri = int.Parse (Console.ReadLine());

        Console.Write("Digite sua nota do Segundo Trimestre: ");
        nota2tri = int.Parse (Console.ReadLine());

        Console.Write("Digite sua nota do Terceiro Trimestre: ");
        nota3tri = int.Parse (Console.ReadLine());

        res=nota1tri+nota2tri+nota3tri;

        if (res >= 180)
        {
            resultado = "Aprovado";
        }
        Console.WriteLine("Aluno: {0} --- Nota: {1}\n -------------------- \n Resultado:{2}", nome, res, resultado);
    }
}