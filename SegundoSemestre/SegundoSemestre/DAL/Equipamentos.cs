using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
   public class Equipamentos
    {

        public static void Insert(DTO.Equipamentos equipamento)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into equipamentos " +
                    " (descricao, pneu, peca) " +
                    " values " +
                    " (@descricao, @pneu, @peca) " +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", equipamento.descricao);
                cmd.Parameters.AddWithValue("@pneu", equipamento.pneu);
                cmd.Parameters.AddWithValue("@peca", equipamento.peca);


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) equipamento.codigo = Convert.ToInt32(dr["codigo"]);
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

        public static void Update(DTO.Equipamentos equipamento)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update equipamentos set descricao=@descricao, pneu=@pneu, peca=@peca where codigo=@codigo", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", equipamento.descricao);
                cmd.Parameters.AddWithValue("@pneu", equipamento.pneu);
                cmd.Parameters.AddWithValue("@peca", equipamento.peca);
                cmd.Parameters.AddWithValue("@codigo", equipamento.codigo);

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

        public static void Delete(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from equipamentos where codigo=@codigo ", psqlConn);

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

        public static DTO.Equipamentos RetornaEquipamento(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Equipamentos equipamento = new DTO.Equipamentos();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from equipamentos where codigo=@codigo", psqlConn);

                cmd.Parameters.AddWithValue("@codigo",codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) equipamento.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["descricao"] != DBNull.Value) equipamento.descricao = Convert.ToString(dr["descricao"]);
                    if (dr["pneu"] != DBNull.Value) equipamento.pneu = Convert.ToBoolean(dr["pneu"]);
                    if (dr["peca"] != DBNull.Value) equipamento.peca = Convert.ToBoolean(dr["peca"]);
                }
                

                return equipamento;
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



        public static DataTable RetornaEquipamentos(string descricao, bool pneu, bool peca)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from equipamentos where pneu=@pneu and peca=@peca and case when " +
                                                      " @descricao <> '' then descricao like @descricao else 1=1 end ", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                cmd.Parameters.AddWithValue("@pneu", pneu);
                cmd.Parameters.AddWithValue("@peca", peca);

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

        public static DataTable RetornaPneus()
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from equipamentos where pneu = true ", psqlConn);

                

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
