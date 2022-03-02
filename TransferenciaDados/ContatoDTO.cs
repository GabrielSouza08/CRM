using System;
using System.Collections.Generic;
using System.Text;
using ConexaoBanco;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace TransferenciaDados
{
   
   public class Contato
    {
        public int ID;
        public string Nome;
        public string Telefone;
        public string Email;
        public string Perfil;
        public int IDLoja;

        public void CadastrarContato(Contato dados)
        {
            try
            {
                string strSQL = "insert into Contato(Nome,Telefone,Email,Perfil,IDLoja) ";
                strSQL += "values ";
                strSQL += "('" + dados.Nome + "',";
                strSQL += "'" + dados.Telefone + "',";
                strSQL += "'" + dados.Email + "',";
                strSQL += "'" + dados.Perfil + "',";
                strSQL += "" + dados.IDLoja + ")";

                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }



        }
        // public DataTable ContatoDataTable = new DataTable();
        public DataTable PreencherGridContato(DataTable grid, Contato dados)
        {

            try
            {
                string strSQL = "select ID,Nome,Telefone,Email,Perfil from Contato where IDLoja =" + dados.IDLoja + "";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());
                da.Fill(grid);

            }
            catch (SqlException ex)
            {
                throw ex;
            }

            finally
            {
                ConexaoBD.fecharConexao();
            }

            return grid;
        }

        public void ExcluirContato(Contato dados)
        {
            try
            {
                string strSQL = "delete from contato where id = " + dados.ID + "";
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

        }


        public void AlterarContato(Contato dados)
        {
            try
            {
                string strSQL = "Update Contato set ";
                strSQL += "Nome = " + "'" + dados.Nome + "'" + ",";
                strSQL += "Telefone = " + "'" + dados.Telefone + "'" + ",";
                strSQL += "Email = " + "'" + dados.Email + "'" + ",";
                strSQL += "Perfil = " + "'" + dados.Perfil + "'";
                strSQL += "where ID = " + dados.ID + "";

                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

        }

    }

 
        


    

}
