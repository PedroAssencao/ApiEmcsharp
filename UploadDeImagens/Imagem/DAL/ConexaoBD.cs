using System.Data.SqlClient;

namespace UploadDeImagens.DAL
{
    public class ConexaoBD
    {
        private static SqlConnection banco;

        public static SqlConnection getConexao()
        {
            if (banco == null)
            {
                banco = new SqlConnection(@"Server=LAPTOP-M68K5TBC\SQLEXPRESS; Database=LoginDB; Integrated Security=True;");
            }

            return banco;
        }

    }
}
