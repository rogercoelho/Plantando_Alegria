namespace Plantando_Alegria.MysqlDb
{
    public class Alunos_Imagem_mysql
    {
        public int Alunos_Codigo { get; set; }
        public string Alunos_Imagem { get; set; }
        public string Criado_Em { get; set; }


        public Alunos_Imagem_mysql(int alunos_codigo)
        {
            Alunos_Codigo = alunos_codigo;
            // Alunos_Imagem = alunos_Imagem;
        }
    }

}
