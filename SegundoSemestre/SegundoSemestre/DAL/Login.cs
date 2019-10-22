using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
   public class Login
    {
        public static void Insert(DTO.Login login)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into login " +
                    " (usuario, senha, pessoa) " +
                    " values " +
                    " (@usuario, @senha, @pessoa) " +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@usuario", login.usuario);
                cmd.Parameters.AddWithValue("@senha", login.senha);
                cmd.Parameters.AddWithValue("@pessoa", login.pessoa);


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) login.codigo = Convert.ToInt32(dr["codigo"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }

        public static void Delete(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from login where codigo=@codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo",codigo);



                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }

        public static void Update(DTO.Login login)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update login set " +
                    "usuario = @usuario , senha=@senha, pessoa=@pessoa", psqlConn);

                cmd.Parameters.AddWithValue("@usuario", login.usuario);
                cmd.Parameters.AddWithValue("@senha", login.senha);
                cmd.Parameters.AddWithValue("@pessoa", login.pessoa);
   
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }

        public static DataTable RetornaLogins()
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT l.codigo, l.usuario, p.nome " +
                    " from login l inner join pessoas p on p.codigo = l.pessoa  ", psqlConn);


                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                DataTable dtab = new DataTable();

                da.Fill(dtab);

                return dtab;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }

        public static DTO.Login RetornaLogin(int codigo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Login login = new DTO.Login();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from login where codigo = @codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) login.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["usuario"] != DBNull.Value) login.usuario = Convert.ToString(dr["usuario"]);
                    if (dr["senha"] != DBNull.Value) login.senha = Convert.ToString(dr["senha"]);
                    if (dr["pessoa"] != DBNull.Value) login.pessoa = Convert.ToInt32(dr["pessoa"]);

                }
                return login;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }

        public static DTO.Login RetornaLogin(string usuario)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Login login = new DTO.Login();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from login where usuario = @usuario ", psqlConn);

                cmd.Parameters.AddWithValue("@usuario", usuario);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) login.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["usuario"] != DBNull.Value) login.usuario = Convert.ToString(dr["usuario"]);
                    if (dr["senha"] != DBNull.Value) login.senha = Convert.ToString(dr["senha"]);
                    if (dr["pessoa"] != DBNull.Value) login.pessoa = Convert.ToInt32(dr["pessoa"]);

                }
                return login;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                psqlConn.Close();
            }
        }
    }
}
