using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace TesteSqlPrincipal.DAL
{
    public class CadastroDao
    {
        Conexao con = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public CadastroDao(String Nome, String Idade, String Email, Image Foto)
        {
            cmd.CommandText = "insert into Table (Nome, Idade, Email, Foto) values (@Nome, @Idade, @Email, @Foto)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Idade", Idade);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Email", Foto);
            try
            {
                cmd.Connection = con.Conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar";
            }

        }
    }
}
