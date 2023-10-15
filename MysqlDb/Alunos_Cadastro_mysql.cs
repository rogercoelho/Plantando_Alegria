namespace Plantando_Alegria.MysqlDb
{
    public class Alunos_Cadastro_mysql
    {
        public string Alunos_Codigo { get; set; }
        public string Alunos_Nome { get; set; }
        public string Alunos_Endereco { get; set; }
        public string Alunos_Bairro { get; set; }
        public string Alunos_Cidade { get; set; }
        public string Alunos_CEP { get; set; }
        public string Alunos_Telefone { get; set; }
        public string Alunos_Email { get; set; }
        public string Alunos_Contato_Emergencia { get; set; }
        public string Alunos_Telefone_Emergencia_1 { get; set; }
        public string Alunos_Telefone_Emergencia_2 { get; set; }
        public string Criado_Em { get; set; }

        public Alunos_Cadastro_mysql(string alunos_Codigo, string alunos_Nome, string alunos_Endereco, string alunos_Bairro, 
                                     string alunos_Cidade, string alunos_CEP, string alunos_Telefone, string alunos_Email, 
                                     string alunos_Contato_Emergencia, string alunos_Telefone_Emergencia_1, 
                                     string alunos_Telefone_Emergencia_2)
        {
            Alunos_Codigo = alunos_Codigo;
            Alunos_Nome = alunos_Nome;
            Alunos_Endereco = alunos_Endereco;
            Alunos_Bairro = alunos_Bairro;
            Alunos_Cidade = alunos_Cidade;
            Alunos_CEP = alunos_CEP;
            Alunos_Telefone = alunos_Telefone;
            Alunos_Email = alunos_Email;
            Alunos_Contato_Emergencia = alunos_Contato_Emergencia;
            Alunos_Telefone_Emergencia_1 = alunos_Telefone_Emergencia_1;
            Alunos_Telefone_Emergencia_2 = alunos_Telefone_Emergencia_2;
        }


    }
}
