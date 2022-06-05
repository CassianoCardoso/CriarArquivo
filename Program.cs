
//CRIAR ARQUIVO 
System.Console.WriteLine("Digite o nome do arquivo:");
var nome = Console.ReadLine();

nome = LimparNome(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

System.Console.WriteLine("Digite enter para finalizar...");
Console.ReadLine();

static string LimparNome(string nome)
{
  //TRATAR SE O NOME DO ARQUIVO É INVALIDO
  foreach (var @char in Path.GetInvalidFileNameChars())
  {
    nome = nome.Replace(@char, '-');
  }
  return nome;

}

// ESCREVER NO ARQUIVO
static void CriarArquivo(string path)
{
  try
  {
    using var sw = File.CreateText(path); // ESCREVE NO ARQUIVO 
    sw.WriteLine("Está é a linha 1 do arquivo");
    sw.WriteLine("Está é a linha 2 do arquivo");
    sw.WriteLine("Está é a linha 3 do arquivo");
    //sw.Flush(); //O FLUSH DESCARREGA O ARQUIVO QUE ESTA EM MEMÓRIA

  }
  catch
  {

    System.Console.WriteLine("O nome do arquivo está invalido!");
  }


}

