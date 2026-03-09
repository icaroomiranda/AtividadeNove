using System;

class Aluno
{
    public int Matricula;
    public string Nome;
    public int Idade;
}

class Professor
{
    public int Codigo;
    public string Nome;
    public string Formacao;
}

class Disciplina
{
    public int Codigo;
    public string Nome;
    public int CargaHoraria;
}

class Notas
{
    public double Nota1;
    public double Nota2;
    public double Nota3;
}

class Boletim
{
    public Aluno Aluno;
    public Professor Professor;
    public Disciplina Disciplina;
    public Notas Notas;
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        Professor professor = new Professor();
        Disciplina disciplina = new Disciplina();
        Notas notas = new Notas();
        Boletim boletim = new Boletim();

        Console.WriteLine("Digite o nome do aluno:");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Digite o nome do professor:");
        professor.Nome = Console.ReadLine();

        Console.WriteLine("Digite o nome da disciplina:");
        disciplina.Nome = Console.ReadLine();

        Console.WriteLine("Digite a nota 1:");
        notas.Nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2:");
        notas.Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3:");
        notas.Nota3 = double.Parse(Console.ReadLine());

        boletim.Aluno = aluno;
        boletim.Professor = professor;
        boletim.Disciplina = disciplina;
        boletim.Notas = notas;

        double media = (notas.Nota1 + notas.Nota2 + notas.Nota3) / 3;

        Console.WriteLine("\nAluno: " + aluno.Nome);
        Console.WriteLine("Disciplina: " + disciplina.Nome);
        Console.WriteLine("Professor: " + professor.Nome);

        Console.WriteLine("Nota 1: " + notas.Nota1);
        Console.WriteLine("Nota 2: " + notas.Nota2);
        Console.WriteLine("Nota 3: " + notas.Nota3);

        Console.WriteLine("Média: " + media);

        if (media >= 7)
            Console.WriteLine("Situação: Aprovado");
        else
            Console.WriteLine("Situação: Reprovado");
    }
}