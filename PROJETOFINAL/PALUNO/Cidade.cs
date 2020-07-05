using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PALUNO
{
    class Cidade
    {
        private int idcidade;
        private string nomecidade;
        private string ufcidade;
        public int Idcidade
        {
            get
            {
                return idcidade;
            }
            set
            {
                idcidade = value;
            }
        }
        public string Nomecidade
        {
            get
            {
                return nomecidade;
            }
            set
            {
                nomecidade = value;
            }
        }

        public string Ufcidade
        {
            get
            {
                return ufcidade;
            }
            set
            {
                ufcidade = value;
            }
        }
        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM TBCIDADE", Form1.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;
                mycommand = new SqlCommand("INSERT INTO TBCIDADE VALUES (@NOME_CIDADE, @UF_CIDADE)", Form1.conexao);
               
                mycommand.Parameters.Add(new SqlParameter("@NOME_CIDADE",SqlDbType.VarChar)); ;
                mycommand.Parameters.Add(new SqlParameter("@UF_CIDADE",SqlDbType.VarChar));
                mycommand.Parameters["@NOME_CIDADE"].Value = nomecidade;
                mycommand.Parameters["@UF_CIDADE"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE TBCIDADE SET NOME_CIDADE = @NOME_CIDADE, UF_CIDADE = @UF_CIDADE WHERE ID_CIDADE = @ID_CIDADE", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@ID_CIDADE", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@NOME_CIDADE",
               SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@UF_CIDADE",
               SqlDbType.Char));
                mycommand.Parameters["@ID_CIDADE"].Value = idcidade;
                mycommand.Parameters["@NOME_CIDADE"].Value = nomecidade;
                mycommand.Parameters["@UF_CIDADE"].Value = ufcidade;
                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        public int Excluir()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM TBCIDADE WHERE ID_CIDADE = @ID_CIDADE", Form1.conexao);
               
                mycommand.Parameters.Add(new SqlParameter("@ID_CIDADE", SqlDbType.Int));
                mycommand.Parameters["@ID_CIDADE"].Value = Convert.ToInt16(idcidade);
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
