using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Cargos
    {

        public static void Insert(DTO.Cargos cargo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into cargos " +
                    " (descricao, salario) " +
                    " values " +
                    " (@descricao, @salario) " +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", cargo.descricao);
                cmd.Parameters.AddWithValue("@salario", cargo.salario);
               


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) cargo.codigo = Convert.ToInt32(dr["codigo"]);
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

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from cargos where codigo=@codigo ", psqlConn);

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

        public static void Update(DTO.Cargos cargo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update cargos set " +
                    "descricao = @descricao , salario=@salario ", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", cargo.descricao);
                cmd.Parameters.AddWithValue("@salario", cargo.salario);
                

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

        public static DTO.Cargos RetornaCargo(int codigo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Cargos cargo = new DTO.Cargos();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from cargos where codigo = @codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) cargo.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["descricao"] != DBNull.Value) cargo.descricao = Convert.ToString(dr["descricao"]);
                    if (dr["salario"] != DBNull.Value) cargo.salario = Convert.ToDouble(dr["salario"]);


                }
                return cargo;
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

        public static DataTable RetornaCargos()
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DataTable dt = new DataTable();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from cargos ", psqlConn);



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
