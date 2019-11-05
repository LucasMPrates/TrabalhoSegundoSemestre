using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
   public class Veiculo_Manutencoes
    {
        public static void Insert(DTO.Veiculo_Manutencoes manutencao)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculo_manutencoes" +
                    " (veiculo,descricao,data,km_rodados,proxima_manutencao) " +
                    " values " +
                    " (@veiculo,@descricao,@data,@km_rodados,@proxima_manutencao)" +
                    " returning codigo", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", manutencao.veiculo);
                cmd.Parameters.AddWithValue("@descricao", manutencao.descricao);
                cmd.Parameters.AddWithValue("@data", manutencao.data);
                cmd.Parameters.AddWithValue("@km_rodados", manutencao.km_rodados);
                cmd.Parameters.AddWithValue("@proxima_manutencao", manutencao.proxima_manutencao);
                


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) manutencao.codigo = Convert.ToInt32(dr["codigo"]);
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

        public static void Delete(int manutencao)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from  veiculo_manutencoes " +
                    " where codigo = @manutencao", psqlConn);

                cmd.Parameters.AddWithValue("@manutencao", manutencao);

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

        public static void Update(DTO.Veiculo_Manutencoes manutencao)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculo_manutencoes " +
                    " set km_rodados=@km_rodados, data=@data " +
                    " where codigo = @codigo", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", manutencao.codigo);
                cmd.Parameters.AddWithValue("@data", manutencao.data);
                cmd.Parameters.AddWithValue("@km_rodados", manutencao.km_rodados);

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

        public static DataTable RetornaManutencoes(int veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from veiculo_manutencoes " +
                    " where veiculo = @veiculo", psqlConn);

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

        public static void UpdateKM(int veiculo, int km)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update  veiculo_manutencoes set km_rodados = km_rodados + @km_rodados where veiculo=@veiculo  ", psqlConn);

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


    }
}
