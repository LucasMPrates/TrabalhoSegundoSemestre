using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Pessoas
    {

        public static byte[] RetornaArquivo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" select imagem " +
                                                        " from pessoa_anexos " +
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

        public static DataTable RetornaPessoas(string cpf , string nome)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT codigo, nome, cpf " +
                    " from pessoas where case when @nome <> '' then nome like @nome else 1=1 END and " +
                    "                    case when @cpf <> '' then cpf like @cpf else 1=1 END ", psqlConn);

                
                cmd.Parameters.AddWithValue("@cpf",  cpf );
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
               
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

        public static DataTable RetornaAnexos(int pessoa)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * from pessoa_anexos where pessoa=@pessoa ", psqlConn);


                cmd.Parameters.AddWithValue("@pessoa", pessoa);
               

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

        public static void InsertAnexos(DTO.Pessoa_Anexos anexo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into pessoa_anexos " +
                                                        " (descricao,imagem,pessoa) values " +
                                                        " (@descricao,@imagem,@pessoa) returning codigo", psqlConn);

                cmd.Parameters.AddWithValue("@descricao", anexo.descricao);
                cmd.Parameters.AddWithValue("@imagem", anexo.imagem);
                cmd.Parameters.AddWithValue("@pessoa", anexo.pessoa);


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

        public static DataTable RetornaPessoas()
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT codigo, nome, cpf " +
                    " from pessoas ", psqlConn);


               

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


        public static DataTable RetornaMotoristas()
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT codigo, nome " +
                    " from pessoas where motorista = true ", psqlConn);




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

        public static DTO.Pessoas RetornaPessoa(int codigo)
        {
            NpgsqlConnection psqlConn = SegundoSemestre.BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Pessoas pessoa = new DTO.Pessoas();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" SELECT * " +
                    " from pessoas where codigo = @codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) pessoa.codigo = Convert.ToInt32(dr["codigo"]);
                    if (dr["nome"] != DBNull.Value) pessoa.nome = Convert.ToString(dr["nome"]);
                    if (dr["nascimento"] != DBNull.Value) pessoa.nascimento = Convert.ToDateTime(dr["nascimento"]);
                    if (dr["cpf"] != DBNull.Value) pessoa.cpf = Convert.ToString(dr["cpf"]);
                    if (dr["endereco"] != DBNull.Value) pessoa.endereco = Convert.ToString(dr["endereco"]);
                    if (dr["numero"] != DBNull.Value) pessoa.numero = Convert.ToInt32(dr["numero"]);
                    if (dr["vila"] != DBNull.Value) pessoa.vila = Convert.ToString(dr["vila"]);
                    if (dr["cidade"] != DBNull.Value) pessoa.cidade = Convert.ToString(dr["cidade"]);
                    if (dr["estado"] != DBNull.Value) pessoa.estado = Convert.ToString(dr["estado"]);
                    if (dr["motorista"] != DBNull.Value) pessoa.motorista = Convert.ToBoolean(dr["motorista"]);
                    if (dr["sexo"] != DBNull.Value) pessoa.sexo = Convert.ToString(dr["sexo"]);
                    if (dr["telefone"] != DBNull.Value) pessoa.telefone = Convert.ToString(dr["telefone"]);
                    if (dr["cargo"] != DBNull.Value) pessoa.cargo = Convert.ToInt32(dr["cargo"]);

                }
                    return pessoa;
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
        public static DataTable RetornaSexo()
        {
            try
            {
                DataTable dtab = new DataTable();
                dtab.Columns.Add("codigo");
                dtab.Columns.Add("descricao");

                dtab.Rows.Add("M", "MASCULINO");
                dtab.Rows.Add("F", "FEMININO");


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

        public static void Insert(SegundoSemestre.DTO.Pessoas pessoa)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" insert into pessoas " +
                    " (nome, nascimento, cpf, endereco, numero, vila, cidade, estado, telefone, sexo , motorista, cargo) " +
                    " values " +
                    " (@nome::varchar(100), @nascimento::date, @cpf::varchar(14), @endereco::varchar(100), @numero::numeric, @vila::varchar(100), @cidade::varchar(100), @estado::varchar(2), @telefone::varchar(14), @sexo::varchar(1), @motorista::boolean, @cargo) " +
                    " returning codigo ", psqlConn);

                cmd.Parameters.AddWithValue("@nome", pessoa.nome);
                cmd.Parameters.AddWithValue("@nascimento", pessoa.nascimento);
                cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);
                cmd.Parameters.AddWithValue("@endereco", pessoa.endereco);
                cmd.Parameters.AddWithValue("@numero", pessoa.numero);
                cmd.Parameters.AddWithValue("@vila", pessoa.vila);
                cmd.Parameters.AddWithValue("@cidade", pessoa.cidade);
                cmd.Parameters.AddWithValue("@estado", pessoa.estado);
                cmd.Parameters.AddWithValue("@telefone", pessoa.telefone);
                cmd.Parameters.AddWithValue("@sexo", pessoa.sexo);
                cmd.Parameters.AddWithValue("@motorista", pessoa.motorista);
                cmd.Parameters.AddWithValue("@cargo", pessoa.cargo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["codigo"] != DBNull.Value) pessoa.codigo = Convert.ToInt32(dr["codigo"]);
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

        public static void Update(DTO.Pessoas pessoa)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update pessoas set " +
                    " nome=@nome::varchar(100), nascimento=@nascimento::date, cpf=@cpf::varchar(14), " +
                    " endereco=@endereco::varchar(100), numero=@numero::numeric, vila=@vila::varchar(100), " +
                    " cidade=@cidade::varchar(100), estado=@estado::varchar(2), sexo=@sexo::varchar(1), telefone=@telefone::varchar(14), motorista=@motorista::boolean, cargo=@cargo " +
                    " where codigo = @codigo::int ", psqlConn);

                cmd.Parameters.AddWithValue("@codigo", pessoa.codigo);
                cmd.Parameters.AddWithValue("@nascimento", pessoa.nascimento);
                cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);
                cmd.Parameters.AddWithValue("@endereco", pessoa.endereco);
                cmd.Parameters.AddWithValue("@numero", pessoa.numero);
                cmd.Parameters.AddWithValue("@vila", pessoa.vila);
                cmd.Parameters.AddWithValue("@estado", pessoa.estado);
                cmd.Parameters.AddWithValue("@cidade", pessoa.cidade);
                cmd.Parameters.AddWithValue("@nome", pessoa.nome);
                cmd.Parameters.AddWithValue("@motorista", pessoa.motorista);
                cmd.Parameters.AddWithValue("@sexo", pessoa.sexo);
                cmd.Parameters.AddWithValue("@telefone", pessoa.telefone);
                cmd.Parameters.AddWithValue("@cargo", pessoa.cargo);
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

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from pessoas where codigo=@codigo " , psqlConn);

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

        public static void DeleteAnexo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" delete from pessoa_anexos where codigo=@codigo ", psqlConn);

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


        /*    public static DTO.Veiculo RetornaVeiculo(int codigo)
            {
                NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

                try
                {
                    DTO.Veiculo veiculo = new DTO.Veiculo();

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
                        if (dr["espveic"] != DBNull.Value) veiculo.espveic = Convert.ToString(dr["espveic"]);
                        if (dr["tpveic"] != DBNull.Value) veiculo.tpveic = Convert.ToString(dr["tpveic"]);
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
            */


        /*public static void DesativarVeiculo(int codigo)
        {
            NpgsqlConnection psqlConn = BLL.ConexaoBD.Conexao();

            try
            {
                DTO.Veiculo veiculo = new DTO.Veiculo();

                psqlConn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(" update veiculos set ativo=false where codigo=@codigo::int ", psqlConn);

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
          */
    }

}
