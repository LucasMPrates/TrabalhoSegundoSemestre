using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
   public class Veiculo_Abastecimentos
    {
        public static byte[] RetornaArquivo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select anexo " +
                                                        " from veiculo_abastecimentos " +
                                                        " where codigo=@codigo::int ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                byte[] arquivo = null;

                while (dr.Read())
                {
                    if (dr["anexo"] != DBNull.Value) arquivo = dr["anexo"] as byte[];
                }

                return arquivo;
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

        public static DataTable RetornaAbastecimentos(int veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * " +
                                                        " from veiculo_abastecimentos " +
                                                        " where veiculo=@veiculo::int ", psqlConn);

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

        public static DataSet RetornaAbastecimentosReport(int veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataSet dt = new DataSet();
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * " +
                                                        " from veiculo_abastecimentos " +
                                                        " where veiculo = @veiculo ", psqlConn);

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

        public static void Insert(DTO.Veiculo_Abastecimentos abastecimento)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculo_abastecimentos " +
                                                        " (veiculo,litros,valor_litro,total,datahora,anexo) values " +
                                                        " (@veiculo,@litros,@valor_litro,@total,@datahora,@anexo)", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", abastecimento.veiculo);
                cmd.Parameters.AddWithValue("@litros", abastecimento.litros);
                cmd.Parameters.AddWithValue("@valor_litro", abastecimento.valor_litro);
                cmd.Parameters.AddWithValue("@total", abastecimento.total);
                cmd.Parameters.AddWithValue("@datahora", abastecimento.datahora);
                cmd.Parameters.AddWithValue("@anexo", abastecimento.anexo);

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
