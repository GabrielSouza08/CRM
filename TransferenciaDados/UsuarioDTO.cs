using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConexaoBanco;
using System.Security.Cryptography;
using System.Globalization;

namespace TransferenciaDados
{
    public class Usuario
    {
        public int ID;
        public string Nome;
        public string Senha;
        public string Perfil;



        public string CriptografarSenha(string value)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }

        public void CadastrarUsuario(Usuario dados)
        {

            string strSQL = "insert into Usuarios(Nome,Senha,Perfil)";
            strSQL += "values (";
            strSQL += "'" + dados.Nome + "'" + ",";
            strSQL += "'" + CriptografarSenha(dados.Senha) + "'" + ",";
            strSQL += "'" + dados.Perfil + "'" + ")";
          
            try
            {

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


        public void EditarUsuario(Usuario dados)
        {
             string strSQL = "update usuarios ";
                    strSQL += "set Nome =  "   + "'"      + dados.Nome   + "'" + ",";
                    strSQL += "set Perfil = "  + "'"      + dados.Perfil + "'" + ",";
                    strSQL += "where ID = "    + dados.ID + "";

            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

        }
        public void AlterarSenha(Usuario dados)
        {
            string strSQL =  "update usuarios set senha = " + "'"+ CriptografarSenha(dados.Senha) + "'" + " ";
                   strSQL += "where id = " + dados.ID;
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            
            catch(SqlException ex)
            {
                throw ex;
            }

            finally
            {
                ConexaoBD.fecharConexao();
            }
        }
        public void ExcluirUsuario(Usuario dados)
        {
            string strSQL = "delete from Usuarios where ID = " +dados.ID +  "";
            try
            {
                SqlCommand cmd = new SqlCommand(strSQL,ConexaoBD.obterConexao());
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

      
        public DataTable PesquisarUsuario(DataTable dt)
        {
            
            string strSQL = "Select ID,Nome, Perfil from Usuarios";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());
                da.Fill(dt);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            return dt;
        }
        public void PreencherUsuario(Usuario dados)
        {
            string strSQL = "select ID,Nome,Senha,Perfil from Usuarios where id = "+dados.ID + "";
            string varTabela = "0";

            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());

                da.Fill(ds, varTabela);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dados.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    dados.Nome = Convert.ToString(ds.Tables[0].Rows[0]["Nome"]);
                    dados.Senha = Convert.ToString(ds.Tables[0].Rows[0]["Senha"]);
                    dados.Perfil = Convert.ToString(ds.Tables[0].Rows[0]["Perfil"]);

                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }
           
        }
    }

    public class Login
    {
        
        public Usuario ValidarLogin(Usuario dados)
        {
            string varTabela = "0";
            string strSQL = null;
            strSQL = "select * from usuarios where nome = '" + dados.Nome + "'";
            strSQL += "and senha = '" + dados.Senha + "'";
            try
            {


                DataSet ds = new DataSet();
                
                
                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());
                da.Fill(ds, varTabela);
                
                if(ds.Tables[0].Rows.Count != 0)
                
  
                {
                    dados.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    dados.Nome = Convert.ToString(ds.Tables[0].Rows[0]["Nome"]);
                    dados.Senha = Convert.ToString(ds.Tables[0].Rows[0]["Senha"]);
                    dados.Perfil = Convert.ToString(ds.Tables[0].Rows[0]["Perfil"]);
                }
                
                else
                {
                    dados.Nome = "";
                }
                

            }

            catch (SqlException e)
            {
                throw e;

            } finally
            {
                ConexaoBD.fecharConexao();
            }
            return dados;
        }
    }
    

 

}

