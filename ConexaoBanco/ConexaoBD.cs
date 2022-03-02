using System;
using System.Data.SqlClient;
using System.Text;


namespace ConexaoBanco
{

    public class ConexaoBD
    {
        public static String enderecoServidor;
        public static String dbServidor;
        public static String userServidor = "sa";
        public static String senhaServidor;

        private static SqlConnection conn = null;
        private static String erro = null;
        public static SqlConnection obterConexao()
        {
            string Conexao = "Data Source=" + enderecoServidor
                        + ";Initial Catalog=" + dbServidor
                        + ";User id=" + userServidor
                        + ";Password=" + senhaServidor + "";
            conn = new SqlConnection(Conexao);
            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                conn = null;
                throw e;

            }

            return conn;
        }

        public static string testeConexao()
        {
            string conexao = "A conexão com banco de dados está OK!";
            string Conexao = "Data Source=" + enderecoServidor
                        + ";Initial Catalog=" + dbServidor
                        + ";User id=" + userServidor
                        + ";Password=" + senhaServidor + "";
            SqlConnection connect = new SqlConnection(Conexao);


            try
            {

                connect.Open();


            }
            catch (SqlException e)
            {
                conn = null;
                conexao = e.Message;

            }
            finally
            {
                connect.Close();
            }
            return conexao;

        }

        public static void fecharConexao()
        {

            if (conn != null)
            {
                conn.Close();
            }
        }


    }
}


