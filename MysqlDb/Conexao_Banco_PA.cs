using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantando_Alegria.MysqlDb
{
    public class Conexao_Banco_PA
    {
        #region Parametros de conexao com o Banco.
        MySqlConnection conexao_db_pa = new MySqlConnection();  // Instanciando objeto para a classe MysqlConnection.

        public Conexao_Banco_PA()
        {

            conexao_db_pa.ConnectionString = "server=www.plantandoalegria.com.br;" +   // Determina a string de conexao com o site.
                                             "uid=goutechc_plantandoalegria;" +        
                                             "pwd=PlantandoAlegria021010; " +
                                             "database=goutechc_Plantando_Alegria";
        }
        #endregion

        #region Metodo para conectar ao banco.
        public MySqlConnection Conectar_DB()   // Como o metodo nao é void ele retorna o MysqlConnection.
        {
            if (conexao_db_pa.State == ConnectionState.Closed)
            {
                conexao_db_pa.Open();
            }
            return conexao_db_pa;               // Retorna a conexao_db_pa com os seus parametros.
        }

        #endregion

        #region Metodo para desconectar do Banco.
        public void Desconectar_DB()
        {
            if (conexao_db_pa.State == ConnectionState.Open)
            {
                conexao_db_pa.Close();
            }
        }
        #endregion

    }
}
