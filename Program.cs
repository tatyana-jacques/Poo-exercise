using exercicio_classe_estudante;
var estudante = new Estudante (
    id: 3849502, 
    nome: "Carla Brisa", 
    exameMedico: "Taxas aceitáveis", 
    dataNascimento: new DateTime(1999, 12, 15));


Console.WriteLine(
    $"\t Id: {estudante.Id}\n" +
    $"\t Nome: {estudante.Nome}.\n" +
    $"\t Exame médico: {estudante.ExameMedico}\n" +
    $"\t Data de nascimento: {estudante.DataNascimento.ToString("dd/MM/yyyy")}.\n" +
    $"\t Status: {estudante.Status}");
