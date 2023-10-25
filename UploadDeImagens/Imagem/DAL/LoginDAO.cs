using Dapper;
using Imagem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using UploadDeImagens.DAL;

namespace Imagem.DAL
{
    public class LoginDAO
    {
        public static SqlConnection _conexao;

        public LoginDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Login> getTodosLogin()
        {
            var sql = "select * from Login";
            var dados = (List<Login>)_conexao.Query<Login>(sql);
            return dados;
        }

        public void InserirConta(Login login)
        {
            try
            {
                string sql = "insert Login (user_name, user_password) values (@user_name, @user_password)";

                int qtdInserida = _conexao.Execute(sql, login);

            }
            catch (Exception)
            {
                
            }
        }

    }
}
