using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.BLL
{
    public static class ConexaoBD
    {
        public static NpgsqlConnection Conexao()
        {
            string sConexao = "";

            sConexao = "Server=" + BLL.Config_Sessao.host +
                        ";Port=" + BLL.Config_Sessao.port +
                        ";User Id=" + BLL.Config_Sessao.user +
                        ";Password=" + BLL.Config_Sessao.password +
                        ";Database=" + BLL.Config_Sessao.db +
                        ";CommandTimeout=5000";

            NpgsqlConnection psqlConn = new NpgsqlConnection(sConexao);

            return psqlConn;
        }

        public static NpgsqlConnection ConexaoParalela(string host, string port, string user, string password, string db, string schema)
        {
            string sConexao = "";

            sConexao = "Server=" + host +
                        ";Port=" + port +
                        ";User Id=" + user +
                        ";Password=" + password +
                        ";Database=" + db +
                        ";CommandTimeout=5000";

            NpgsqlConnection psqlConn = new NpgsqlConnection(sConexao);

            return psqlConn;
        }

        public static NpgsqlParameter[] AddArrayNpgsqlParameters<T>(this NpgsqlCommand cmd, IEnumerable<T> values, string paramNameRoot, int start = 1, string separator = ", ")
        {
            /* An array cannot be simply added as a parameter to a SqlCommand so we need to loop through things and add it manually. 
             * Each item in the array will end up being it's own SqlParameter so the return value for this must be used as part of the
             * IN statement in the CommandText.
             */
            var parameters = new List<NpgsqlParameter>();
            var parameterNames = new List<string>();
            var paramNbr = start;
            int ivalues = 0;

            foreach (var value in values)
            {
                ivalues++;
            }

            if (ivalues > 0)
            {
                foreach (var value in values)
                {
                    var paramName = string.Format("@{0}{1}", paramNameRoot, paramNbr++);
                    parameterNames.Add(paramName);
                    parameters.Add(cmd.Parameters.AddWithValue(paramName, value));
                }
            }
            else
            {
                var paramName = string.Format("@{0}{1}", paramNameRoot, paramNbr++);
                parameterNames.Add(paramName);
                parameters.Add(cmd.Parameters.AddWithValue(paramName, ""));
            }

            cmd.CommandText = cmd.CommandText.Replace("{" + paramNameRoot + "}", string.Join(separator, parameterNames));

            return parameters.ToArray();
        }
    }
}
