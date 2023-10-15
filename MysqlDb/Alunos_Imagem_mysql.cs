namespace Plantando_Alegria.MysqlDb
{
    public class Alunos_Imagem_mysql
    {
        public string Alunos_Codigo { get; set; }
        public string Imagem { get; set; }
        public string Criado_Em { get; set; }


        public Alunos_Imagem_mysql(string alunos_codigo)
        {
            Alunos_Codigo = alunos_codigo;
            // Alunos_Imagem = alunos_Imagem;
        }
    }

}
