using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSqlPrincipal.DAL
{
    class LoginDaoComandos
    {
        public bool tem=false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from logins where usuario = @logar and senha = @senha";
            cmd.Parameters.AddWithValue("@logar", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }
            return tem;
        }
        public String cadastrar(String usuario, String senha, String confSenha)
        {
            if(senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@u,@s);";
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@s", senha);
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            cmd.CommandText = "";
            return mensagem;
        }
    }
}
