using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Veiculo_Pecas
    {

        public static void Insert(DTO.Veiculo_Pecas peca)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculo_pecas" +
                    " (veiculo,peca,data,km_rodados) " +
                    " values " +
                    " (@veiculo,@peca,@data,@km_rodados)" +
                    " returning codigo", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", peca.veiculo);
                cmd.Parameters.AddWithValue("@peca", peca.peca);
                cmd.Parameters.AddWithValue("@data", peca.data);
                cmd.Parameters.AddWithValue("@km_rodados", peca.km_rodados);
               



                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) peca.codigo = Convert.ToInt32(dr["codigo"]);
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

        public static DataTable RetornaTrocasPeca(int veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select v.codigo, v.peca, v.data, v.km_rodados, e.descricao from veiculo_pecas v " +
                    " inner join equipamentos e on e.codigo = v.peca " +
                    " where v.veiculo = @veiculo ", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", veiculo);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;



               
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

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from veiculo_pecas where codigo=@codigo", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

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

        public static void UpdateKM(int veiculo, int km)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update  veiculo_pecas set km_rodados = km_rodados + @km_rodados where veiculo=@veiculo  ", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", veiculo);
                cmd.Parameters.AddWithValue("@km_rodados", km);
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

        public static void Update(DTO.Veiculo_Pecas peca)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculo_pecas " +
                    " set km_rodados=@km_rodados, data=@data " +
                    " where codigo = @codigo", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", peca.codigo);
                cmd.Parameters.AddWithValue("@data", peca.data);
                cmd.Parameters.AddWithValue("@km_rodados", peca.km_rodados);

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


    }
}
