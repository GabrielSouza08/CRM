using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConexaoBanco;

namespace TransferenciaDados
{
    public class Lojas
    {
        public int ID;
        public string Codigo;
        public string CNPJ;
        public string NomeFantasia;
        public string RazaoSocial;
        public string CEP;
        public string Endereco;
        public string Numero;
        public string Complemento;
        public string Bairro;
        public string Municipio;
        public string UF;
        public string OBSAdicionais;
        public string Telefone;
        public string Email;




        //Metodos
        public Lojas CadastrarLoja(Lojas dados)
        {
            string strSQL = "Insert into Lojas(Codigo,NomeFantasia,RazaoSocial,CNPJ,Endereco,Numero,Bairro,Complemento,Municipio,UF,CEP,OBSAdicionais,Telefone,Email)";
            strSQL += "values (" + dados.Codigo + ",";
            strSQL += "'" + dados.NomeFantasia + "',";
            strSQL += "'" + dados.RazaoSocial + "',";
            strSQL += "'" + dados.CNPJ + "',";
            strSQL += "'" + dados.Endereco + "',";
            strSQL += "'" + dados.Numero + "',";
            strSQL += "'" + dados.Bairro + "',";
            strSQL += "'" + dados.Complemento + "',";
            strSQL += "'" + dados.Municipio + "',";
            strSQL += "'" + dados.UF + "',";
            strSQL += "'" + dados.CEP + "',";
            strSQL += "'" + dados.OBSAdicionais + "',";
            strSQL += "'" + dados.Telefone + "',";
            strSQL += "'" + dados.Email + "')";

            try
            {
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();



            }

            catch (SqlException e)
            {
                throw e;

            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            return dados;
        }


        public String VerSeCNPJExiste(String cnpj)
        {
            try
            {

                string strSQL = "Select TOP(1) * from Lojas where cnpj = '" + cnpj + "'";
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());

                int registro = Convert.ToInt32(cmd.ExecuteScalar());



                if (registro > 0)
                {

                    return cnpj;

                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            cnpj = "";
            return cnpj;

        }
        public String VerSeCodigoExiste(String codigo)
        {
            try
            {

                string strSQL = "Select TOP(1) * from Lojas where codigo = '" + codigo + "'";
                SqlCommand cmd = new SqlCommand(strSQL, ConexaoBD.obterConexao());

                int registro = Convert.ToInt32(cmd.ExecuteScalar());



                if (registro > 0)
                {

                    return codigo;

                }

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            codigo = "";
            return codigo;

        }


        public List<Lojas> ListaLojas = new List<Lojas>();
       // public DataTable LojasDataTable = new DataTable();


        public DataTable PesquisarLojaSemFiltro(DataTable LojasDataTable)
        {
            try
            {
                string strSQL = "Select ID,Codigo,NomeFantasia,RazaoSocial,CNPJ,Endereco,";
                strSQL += "Numero,Bairro,Complemento,Municipio,UF,CEP,Email from Lojas";

                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());

                //Prenncher o Datagrid
                da.Fill(LojasDataTable);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }


            return LojasDataTable;


        }

        public DataTable PesquisarcomfiltroCNPJouRazao(DataTable LojasDataTable, Lojas dados)
        {
            try
            {
                string strSQL = "Select ID,Codigo,NomeFantasia,RazaoSocial,CNPJ,Endereco,";
                strSQL += "Numero,Bairro,Complemento,Municipio,UF,CEP,Email from Lojas ";
                strSQL += "where CNPJ like '%" + dados.CNPJ + "%' and Razaosocial like '%" + dados.RazaoSocial + "%'";

                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());

                //Prenncher o Datagrid
                da.Fill(LojasDataTable);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            return LojasDataTable;
        }

        public DataTable PesquisarcomfiltroCodigo(DataTable LojasDataTable, Lojas dados)
        {
            try
            {
                string strSQL = "Select ID,Codigo,NomeFantasia,RazaoSocial,CNPJ,Endereco,";
                strSQL += "Numero,Bairro,Complemento,Municipio,UF,CEP,Email from Lojas ";
                strSQL += "where Codigo =" + dados.Codigo + "";

                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());

                //Prenncher o Datagrid
                da.Fill(LojasDataTable);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                ConexaoBD.fecharConexao();
            }

            return LojasDataTable;
        }
        public void PreencherCadastro(Lojas dados)
        {
            try
            {
                string strSQL = "Select  ID,Codigo,NomeFantasia,RazaoSocial,CNPJ,Endereco,Numero,Bairro,Complemento,Municipio,UF,CEP,OBSAdicionais,Telefone,Email from Lojas where id =" + dados.ID + "";
                string varTabela = "0";

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(strSQL, ConexaoBD.obterConexao());
                da.Fill(ds, varTabela);


                if (ds.Tables[0].Rows.Count != 0)
                {
                    dados.ID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                    dados.Codigo = Convert.ToString(ds.Tables[0].Rows[0]["Codigo"]);
                    dados.CNPJ = Convert.ToString(ds.Tables[0].Rows[0]["CNPJ"]);
                    dados.NomeFantasia = Convert.ToString(ds.Tables[0].Rows[0]["NomeFantasia"]);
                    dados.RazaoSocial = Convert.ToString(ds.Tables[0].Rows[0]["RazaoSocial"]);
                    dados.CEP = Convert.ToString(ds.Tables[0].Rows[0]["CEP"]);
                    dados.Endereco = Convert.ToString(ds.Tables[0].Rows[0]["Endereco"]);
                    dados.Numero = Convert.ToString(ds.Tables[0].Rows[0]["Numero"]);
                    dados.Bairro = Convert.ToString(ds.Tables[0].Rows[0]["Bairro"]);
                    dados.Bairro = Convert.ToString(ds.Tables[0].Rows[0]["Bairro"]);
                    dados.Municipio = Convert.ToString(ds.Tables[0].Rows[0]["Municipio"]);
                    dados.UF = Convert.ToString(ds.Tables[0].Rows[0]["UF"]);
                    dados.OBSAdicionais = Convert.ToString(ds.Tables[0].Rows[0]["OBSAdicionais"]);
                    dados.Telefone = Convert.ToString(ds.Tables[0].Rows[0]["Telefone"]);
                    dados.Email = Convert.ToString(ds.Tables[0].Rows[0]["Email"]);





                }


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
        public Lojas EdtarLojas(Lojas dados)
        {
            try
            {
                string strSQL = "update Lojas set ";
                strSQL += "codigo =" + dados.Codigo + ",";
                strSQL += "NomeFantasia ='" + dados.NomeFantasia + "',";
                strSQL += "RazaoSocial ='" + dados.RazaoSocial + "',";
                strSQL += "CNPJ='" + dados.CNPJ + "',";
                strSQL += "Endereco='" + dados.Endereco + "',";
                strSQL += "Numero=" + dados.Numero + ",";
                strSQL += "Bairro='" + dados.Bairro + "',";
                strSQL += "Complemento='" + dados.Complemento + "',";
                strSQL += "Municipio='" + dados.Municipio + "',";
                strSQL += "UF='" + dados.UF + "',";
                strSQL += "CEP='" + dados.CEP + "',";
                strSQL += "OBSAdicionais='" + dados.OBSAdicionais + "',";
                strSQL += "Telefone='" + dados.Telefone + "',";
                strSQL += "Email='" + dados.Email + "' ";
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

            return dados;
        }


        public void ApagarLoja(Lojas dados)
        {
            try
            {
                string strSQL = "delete from Lojas where ID = " + dados.ID + "";
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
