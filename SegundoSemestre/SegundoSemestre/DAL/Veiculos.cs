using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Veiculos
    {

        public static DataTable RetornaAnexos(int veiculo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * from veiculo_anexos where veiculo=@veiculo ", psqlConn);


                cmd.Parameters.AddWithValue("@veiculo", veiculo);


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


        public static void DeleteAnexo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from veiculo_anexos where codigo=@codigo ", psqlConn);

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


        public static byte[] RetornaArquivo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select imagem " +
                                                        " from veiculo_anexos " +
                                                        " where codigo=@codigo::int ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                byte[] arquivo = null;

                while (dr.Read())
                {
                    if (dr["imagem"] != DBNull.Value) arquivo = dr["imagem"] as byte[];
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

        public static void InsertAnexos(DTO.Veiculo_Anexos anexo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculo_anexos " +
                                                        " (descricao,imagem,veiculo) values " +
                                                        " (@descricao,@imagem,@veiculo) returning codigo", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", anexo.descricao);
                cmd.Parameters.AddWithValue("@imagem", anexo.imagem);
                cmd.Parameters.AddWithValue("@veiculo", anexo.veiculo);


                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) anexo.codigo = Convert.ToInt32(dr["codigo"]);
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




        /// <summary>
        /// este método retorna os veiculos ativos
        /// </summary>
        /// <returns></returns>
        public static DataTable RetornaVeiculos(string placa)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("select * from veiculos where case when @placa <> '' then placa=@placa else 1=1 END ", psqlConn);

                cmd.Parameters.AddWithValue("@placa", placa);
                

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

        /// <summary>
        /// este método retorna os tipos de combustiveis (tabela RENAVAM 2.0)
        /// </summary>
        /// <returns></returns>
        public static DataTable RetornaTipoCombustivel()
        {
            try
            {
                DataTable dtab = new DataTable();
                dtab.Columns.Add("codigo");
                dtab.Columns.Add("descricao");

                dtab.Rows.Add("1", "ALCOOL");
                dtab.Rows.Add("2", "GASOLINA");
                dtab.Rows.Add("3", "DIESEL");
                dtab.Rows.Add("4", "FLEX");
                


                return dtab;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// este método retorna os tipos de veiculos (tabela RENAVAM 2.0)
        /// </summary>
        /// <returns></returns>
        public static DataTable RetornaTipoVeiculo()
        {
            try
            {
                DataTable dtab = new DataTable();

                dtab.Columns.Add("codigo");
                dtab.Columns.Add("descricao");

                dtab.Rows.Add("01", "BICICLETA");
                dtab.Rows.Add("02", "CICLOMOTOR");
                dtab.Rows.Add("03", "MOTONETA");
                dtab.Rows.Add("04", "MOTOCICLETA");
                dtab.Rows.Add("05", "TRICICLO");
                dtab.Rows.Add("06", "AUTOMOVEL");
                dtab.Rows.Add("07", "MICROONIBUS");
                dtab.Rows.Add("08", "ONIBUS");
                dtab.Rows.Add("09", "BONDE");
                dtab.Rows.Add("10", "REBOQUE");
                dtab.Rows.Add("11", "SEMI - REBOQUE");
                dtab.Rows.Add("12", "CHARRETE");
                dtab.Rows.Add("13", "CAMIONETA");
                dtab.Rows.Add("14", "CAMINHAO");
                dtab.Rows.Add("15", "CARROCA");
                dtab.Rows.Add("16", "CARRO DE MAO");
                dtab.Rows.Add("17", "CAMINHAO TRATOR");
                dtab.Rows.Add("18", "TRATOR DE RODAS");
                dtab.Rows.Add("19", "TRATOR DE ESTEIRAS");
                dtab.Rows.Add("20", "TRATOR MISTO");
                dtab.Rows.Add("21", "QUADRICICLO");
                dtab.Rows.Add("22", "CHASSI / PLATAFORMA");
                dtab.Rows.Add("23", "CAMINHONETE");
                dtab.Rows.Add("24", "SIDE - CAR");
                dtab.Rows.Add("25", "UTILITARIO");
                dtab.Rows.Add("26", "MOTOR - CASA");


                return dtab;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// este método retorna as especies de veiculos (tabela RENAVAM 2.0)
        /// </summary>
        /// <returns></returns>
        public static DataTable RetornaEspecieVeiculo()
        {


            try
            {
                DataTable dtab = new DataTable();

                dtab.Columns.Add("codigo");
                dtab.Columns.Add("descricao");
                dtab.Rows.Add("1", "PASSAGEIRO");
                dtab.Rows.Add("2", "CARGA");
                dtab.Rows.Add("3", "MISTO");
                dtab.Rows.Add("7", "COLECAO");
                dtab.Rows.Add("4", "CORRIDA");
                dtab.Rows.Add("5", "TRACAO");
                dtab.Rows.Add("6", "ESPECIAL");
                dtab.Rows.Add("7", "COLECAO");


                return dtab;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// este método retorna os status de veiculos
        /// </summary>
        /// <returns></returns>
        public static DataTable RetornaStatus()
        {
            try
            {
                DataTable dtab = new DataTable();
                dtab.Columns.Add("codigo");
                dtab.Columns.Add("descricao");

                dtab.Rows.Add("1", "GARAGEM");
                dtab.Rows.Add("2", "EM CIRCULAÇÃO");
                dtab.Rows.Add("3", "EM MANUTENÇÃO");

                return dtab;


            }
            catch (Exception)
            {
                throw;

            }


        }

        public static void Insert(DTO.Veiculos veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into veiculos " +
                    " (placa, marca, modelo, tpcomb, status, ano_fabricacao, ano_modelo, media_consumo, km) " +
                    " values " +
                    " (@placa::varchar(8), @marca::varchar(50), @modelo::varchar(50), @tpcomb::varchar(1), @status::varchar(1), @ano_fabricacao::integer, @ano_modelo::integer, @media_consumo::numeric(4,2), @km::integer) " +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@placa", veiculo.placa);
                cmd.Parameters.AddWithValue("@marca", veiculo.marca);
                cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
                cmd.Parameters.AddWithValue("@tpcomb", veiculo.tpcomb);
                cmd.Parameters.AddWithValue("@status", veiculo.status);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculo.ano_fabricacao);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculo.ano_modelo);
                cmd.Parameters.AddWithValue("@media_consumo", veiculo.media_consumo);
                cmd.Parameters.AddWithValue("@km", veiculo.km);
               

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) veiculo.codigo = Convert.ToInt32(dr["codigo"]);
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

        public static void Update(DTO.Veiculos veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculos set " +
                    " placa=@placa::varchar(8), marca=@marca::varchar(50), modelo=@modelo::varchar(50), tpcomb=@tpcomb::varchar(1), status=@status::varchar(1), ano_fabricacao=@ano_fabricacao::integer, ano_modelo=@ano_modelo::integer, media_consumo=@media_consumo::numeric(4,2), km=@km::integer " +
                    " where codigo = @codigo::int ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", veiculo.codigo);
                cmd.Parameters.AddWithValue("@placa", veiculo.placa);
                cmd.Parameters.AddWithValue("@marca", veiculo.marca);
                cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
                cmd.Parameters.AddWithValue("@tpcomb", veiculo.tpcomb);
                cmd.Parameters.AddWithValue("@status", veiculo.status);
                cmd.Parameters.AddWithValue("@ano_fabricacao", veiculo.ano_fabricacao);
                cmd.Parameters.AddWithValue("@ano_modelo", veiculo.ano_modelo);
                cmd.Parameters.AddWithValue("@media_consumo", veiculo.media_consumo);
                cmd.Parameters.AddWithValue("@km", veiculo.km);
                

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

        public static void UpdateStatus(DTO.Veiculos veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculos set status=@status where codigo=@codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", veiculo.codigo);
                cmd.Parameters.AddWithValue("@status", veiculo.status);


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

        public static void UpdateKM(DTO.Veiculos veiculo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculos set km=@km where codigo=@codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", veiculo.codigo);
                cmd.Parameters.AddWithValue("@km", veiculo.km);


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

        public static DTO.Veiculos RetornaVeiculo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Veiculos veiculo = new DTO.Veiculos();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select * from veiculos where codigo=@codigo::int ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) veiculo.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["placa"] != DBNull.Value) veiculo.placa = Convert.ToString(dr["placa"]);
                    if (dr["marca"] != DBNull.Value) veiculo.marca = Convert.ToString(dr["marca"]);
                    if (dr["modelo"] != DBNull.Value) veiculo.modelo = Convert.ToString(dr["modelo"]);
                    if (dr["tpcomb"] != DBNull.Value) veiculo.tpcomb = Convert.ToString(dr["tpcomb"]);
                    if (dr["status"] != DBNull.Value) veiculo.status = Convert.ToString(dr["status"]);
                    if (dr["ano_fabricacao"] != DBNull.Value) veiculo.ano_fabricacao = Convert.ToInt32(dr["ano_fabricacao"]);
                    if (dr["ano_modelo"] != DBNull.Value) veiculo.ano_modelo = Convert.ToInt32(dr["ano_modelo"]);
                    if (dr["media_consumo"] != DBNull.Value) veiculo.media_consumo = Convert.ToDouble(dr["media_consumo"]);
                    if (dr["km"] != DBNull.Value) veiculo.km = Convert.ToInt32(dr["km"]);
                    
                }

                return veiculo;
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
                DTO.Veiculos veiculo = new DTO.Veiculos();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from veiculos where codigo=@codigo::int ", psqlConn);

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
    }

}
