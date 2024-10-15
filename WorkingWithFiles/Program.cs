string nomeArquivo = "eusouumarquivo.txt";
string relPath = Path.Combine("E:/TI/DotNET/Linguagem/C#/EstudoLibs/WorkingWithFiles/WorkingWithFiles/WorkingWithFiles/Testes", nomeArquivo);

Console.WriteLine(relPath);

string textoASerInserido = "Eu sou um texto novo";

if (File.Exists(relPath))
{
    Console.WriteLine("O Arquivo Existe");
    await File.AppendAllTextAsync(relPath, textoASerInserido);

    Console.WriteLine("Texto Inserido");

    string textoLido = await File.ReadAllTextAsync(relPath);

    Console.WriteLine(textoLido);
}
else
{
    Console.WriteLine("Arquivo Não Encontrado");
}