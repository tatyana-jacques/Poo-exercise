namespace exercicio_classe_estudante
{
    public class Estudante
    {
        private int _id;
        private string _nome;
        private string _exameMedico;
        private DateTime _dataNascimento;
        private bool _status;

        public int Id
        {
            get { return _id; }
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string ExameMedico
        {
            get { return _exameMedico; }
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
        }
        public bool Status
        {
            get { return _status; }
        }

        public Estudante(int id, string nome, string exameMedico, DateTime dataNascimento)
        {
            _id = id;
            _nome = nome;
            _exameMedico = exameMedico;
            _dataNascimento = dataNascimento;
            _status = true;
        }

    }
}