using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
   public class Viajens
    {
        public static DataTable VerificaMotoristaViagem(int codigo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from viajens where motorista=@codigo and status = 'A' ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);


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

        public static void Insert(DTO.Viajens viagem)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into viajens " +
                    "(motorista,destino,km_rodados,status,veiculo,obs1,obs2,data_ida) " +
                    " values " +
                    "(@motorista,@destino,@km_rodados,@status,@veiculo,@obs1,@obs2, current_date)", psqlConn);

                cmd.Parameters.AddWithValue("@motorista", viagem.motorista);
                cmd.Parameters.AddWithValue("@destino", viagem.destino);
                cmd.Parameters.AddWithValue("@km_rodados", viagem.km_rodados);
                cmd.Parameters.AddWithValue("@status", viagem.status);
                cmd.Parameters.AddWithValue("@veiculo", viagem.veiculo);
                cmd.Parameters.AddWithValue("@obs1", viagem.obs1);
                cmd.Parameters.AddWithValue("@obs2", viagem.obs2);


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

        public static void Update(DTO.Viajens viagem)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update viajens set status = 'B' , obs2=@obs2, data_retorno = current_date, km_rodados=@km_rodados", psqlConn);

                cmd.Parameters.AddWithValue("@motorista", viagem.motorista);
                cmd.Parameters.AddWithValue("@destino", viagem.destino);
                cmd.Parameters.AddWithValue("@km_rodados", viagem.km_rodados);
                cmd.Parameters.AddWithValue("@status", viagem.status);
                cmd.Parameters.AddWithValue("@veiculo", viagem.veiculo);
                cmd.Parameters.AddWithValue("@obs1", viagem.obs1);
                cmd.Parameters.AddWithValue("@obs2", viagem.obs2);


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



        public static DTO.Viajens RetornaViagemAberto(int veiculo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Viajens viagem = new DTO.Viajens();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from viajens where veiculo=@veiculo and status = 'A' ", psqlConn);

                cmd.Parameters.AddWithValue("@veiculo", veiculo);


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) viagem.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["destino"] != DBNull.Value) viagem.destino = Convert.ToString(dr["destino"]);
                    if (dr["km_rodados"] != DBNull.Value) viagem.km_rodados = Convert.ToInt32(dr["km_rodados"]);
                    if (dr["motorista"] != DBNull.Value) viagem.motorista = Convert.ToInt32(dr["motorista"]);
                    if (dr["veiculo"] != DBNull.Value) viagem.veiculo = Convert.ToInt32(dr["veiculo"]);
                    if (dr["obs1"] != DBNull.Value) viagem.obs1 = Convert.ToString(dr["obs1"]);
                    if (dr["obs2"] != DBNull.Value) viagem.obs2 = Convert.ToString(dr["obs2"]);
                    if (dr["status"] != DBNull.Value) viagem.status = Convert.ToString(dr["status"]);
                    
                }

                return viagem;
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
