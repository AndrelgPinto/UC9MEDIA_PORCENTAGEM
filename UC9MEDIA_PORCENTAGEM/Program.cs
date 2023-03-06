string[,] alunos = new string[5, 7];
int l, c;
l = 0;
c = 0;


for (l = 0; l <= 4; l++)
{
    Console.WriteLine("Nome do Aluno!");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Aulas Dadas");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Faltas do Aluno");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Notas da Prova 1");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Notas da Prova 2");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Notas da Prova 3");
    alunos[l, c++] = Console.ReadLine();

    Console.WriteLine("Nota do Trabalho");
    alunos[l, c++] = Console.ReadLine();


}




