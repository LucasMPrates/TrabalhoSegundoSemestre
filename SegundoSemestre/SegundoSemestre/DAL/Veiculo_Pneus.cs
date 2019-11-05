using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Veiculo_Pneus
    {

        public static void Insert(DTO.Veiculo_Pneus pneu)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculo_pneus " +
                    "(pneu,km_rodados,veiculo,estepe,sulco) " +
                    " values " +
                    "(@pneu,@km_rodados,@veiculo,@estepe,@sulco)" +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@pneu", pneu.pneu);
                cmd.Parameters.AddWithValue("@km_rodados", pneu.km_rodados);
                cmd.Parameters.AddWithValue("@veiculo", pneu.veiculo);
                cmd.Parameters.AddWithValue("@estepe", pneu.estepe);
                cmd.Parameters.AddWithValue("@sulco", pneu.sulco);

                NpgsqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) pneu.codigo = Convert.ToInt32(dr["codigo"]);
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
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from veiculo_pneus where codigo=@codigo", psqlConn);

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

                NpgsqlCommand cmd = new NpgsqlCommand(" update  veiculo_pneus set km_rodados= km_rodados + @km_rodados where veiculo=@veiculo and estepe = false ", psqlConn);

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


        public static void TrocarPneu(int codigo, int pneu)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from veiculo_pneus where codigo=@codigo", psqlConn);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();

                NpgsqlCommand cmd2 = new NpgsqlCommand("update veiculo_pneus set estepe = false where codigo = @pneu", psqlConn);
                cmd2.Parameters.AddWithValue("@pneu", pneu);
                cmd2.ExecuteNonQuery();
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

        public static void UpdateSulcos(int codigo ,double sulco)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update  veiculo_pneus set sulco=@sulco where codigo=@codigo", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@sulco", sulco);
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

        public static DataTable RetornaPneus(int veiculo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from veiculo_pneus where veiculo=@veiculo", psqlConn);

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

        public static DataTable RetornaPneusTrocar(int veiculo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select v.codigo, e.descricao || ' - ' || v.km_rodados || ' KM RODADOS' as display from veiculo_pneus v " +
                    " inner join equipamentos e on e.codigo=v.pneu " +
                    " where v.veiculo=@veiculo and v.estepe = false ", psqlConn);

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
    }
}
