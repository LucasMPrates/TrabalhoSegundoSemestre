using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoSemestre.DAL
{
    public class Report
    {
        /// <summary>
        /// Crio o banco usado para Reports, o banco sempre é criado em C:\Windows\Temp\report.mdb
        /// </summary>
        /// <param name="iQtdeString">Qtde de campos string disponíveis</param>
        /// <param name="iQtdeNumber">Qtde de campos number disponíveis</param>
        /// <param name="iQtdeDate">Qtde de campos date disponíveis</param>
        public static void CriarDBReport(int iQtdeString = 20, int iQtdeNumber = 20, int iQtdeDate = 20)
        {
            try
            {
                bool bExiste = File.Exists(@"C:\Windows\Temp\report.mdb");

                ADOX.Catalog cat = new ADOX.Catalog();

                if (bExiste)
                {
                    if (ExcluirArquivoBD())
                    {
                        cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Windows\\Temp\\report.mdb; Jet OLEDB:Engine Type=5");
                        CriarTabelas(cat, iQtdeString, iQtdeNumber, iQtdeDate);
                    }
                }
                else
                {
                    cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Windows\\Temp\\report.mdb; Jet OLEDB:Engine Type=5");
                    CriarTabelas(cat, iQtdeString, iQtdeNumber, iQtdeDate);
                }

                //Depois do Banco Criado, preciso zerar as tabelas
                OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Windows\Temp\report.mdb;Persist Security Info=True");

                cnn.Open();

                OleDbCommand cmd = new OleDbCommand("delete from dados_string ", cnn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("delete from dados_text ", cnn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("delete from dados_number ", cnn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("delete from dados_date ", cnn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("delete from dados_image ", cnn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("delete from dados ", cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool ExcluirArquivoBD()
        {
            try
            {
                File.Delete(@"C:\Windows\Temp\report.mdb");

                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CriarTabelas(ADOX.Catalog cat, int iQtdeString = 20, int iQtdeNumber = 20, int iQtdeDate = 20)
        {
            try
            {
                ADOX.Table table = new ADOX.Table();

                //Create the table and it's fields. 
                table.Name = "dados";
                table.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table.Keys.Append("fk_dados_id", ADOX.KeyTypeEnum.adKeyPrimary, "id");

                cat.Tables.Append(table);

                //Crio a tabela das string's 
                ADOX.Table table2 = new ADOX.Table();
                table2.Name = "dados_string";
                table2.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table2.Keys.Append("fk_dados_string_id", ADOX.KeyTypeEnum.adKeyForeign, "id", "dados", "id");

                for (int i = 1; i <= iQtdeString; i++)
                {
                    ADOX.Column column = new ADOX.Column();

                    column.Name = ("string" + i.ToString().PadLeft(2, '0'));
                    column.Type = ADOX.DataTypeEnum.adVarWChar;
                    column.Attributes = ADOX.ColumnAttributesEnum.adColNullable;

                    table2.Columns.Append(column);
                }

                cat.Tables.Append(table2);

                //Crio a tabela das text's 
                ADOX.Table table6 = new ADOX.Table();
                table6.Name = "dados_text";
                table6.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table6.Keys.Append("fk_dados_text_id", ADOX.KeyTypeEnum.adKeyForeign, "id", "dados", "id");

                for (int i = 1; i <= iQtdeString; i++)
                {
                    ADOX.Column column = new ADOX.Column();

                    column.Name = ("text" + i.ToString().PadLeft(2, '0'));
                    column.Type = ADOX.DataTypeEnum.adLongVarWChar;
                    column.Attributes = ADOX.ColumnAttributesEnum.adColNullable;

                    table6.Columns.Append(column);
                }

                cat.Tables.Append(table6);


                //Crio a tabela dos numeros
                ADOX.Table table3 = new ADOX.Table();
                table3.Name = "dados_number";
                table3.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table3.Keys.Append("fk_dados_number_id", ADOX.KeyTypeEnum.adKeyForeign, "id", "dados", "id");

                for (int i = 1; i <= iQtdeNumber; i++)
                {
                    ADOX.Column column = new ADOX.Column();

                    column.Name = ("number" + i.ToString().PadLeft(2, '0'));
                    column.Type = ADOX.DataTypeEnum.adDouble;
                    column.Attributes = ADOX.ColumnAttributesEnum.adColNullable;

                    table3.Columns.Append(column);
                }
                cat.Tables.Append(table3);


                //Crio a tabela das dates
                ADOX.Table table4 = new ADOX.Table();
                table4.Name = "dados_date";
                table4.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table4.Keys.Append("fk_dados_date_id", ADOX.KeyTypeEnum.adKeyForeign, "id", "dados", "id");

                for (int i = 1; i <= iQtdeDate; i++)
                {
                    ADOX.Column column = new ADOX.Column();

                    column.Name = ("date" + i.ToString().PadLeft(2, '0'));
                    column.Type = ADOX.DataTypeEnum.adDate;
                    column.Attributes = ADOX.ColumnAttributesEnum.adColNullable;

                    table4.Columns.Append(column);
                }
                cat.Tables.Append(table4);


                //Crio a tabela das dates
                ADOX.Table table5 = new ADOX.Table();
                table5.Name = "dados_image";
                table5.Columns.Append("id", ADOX.DataTypeEnum.adInteger);
                table5.Keys.Append("fk_dados_image_id", ADOX.KeyTypeEnum.adKeyForeign, "id", "dados", "id");

                for (int i = 1; i <= iQtdeDate; i++)
                {
                    ADOX.Column column = new ADOX.Column();

                    column.Name = ("img" + i.ToString().PadLeft(2, '0'));
                    column.Type = ADOX.DataTypeEnum.adLongVarBinary;
                    column.Attributes = ADOX.ColumnAttributesEnum.adColNullable;

                    table5.Columns.Append(column);
                }
                cat.Tables.Append(table5);

                //Vejo se a conexão ainda está aberta 
                //se estiver, fecho para poder inserir dados posteriormente
                OleDbConnection con = cat.ActiveConnection as OleDbConnection;
                if (con != null) con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Inserir(DTO.Report report)
        {
            try
            {
                OleDbConnection cnn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Windows\Temp\report.mdb;Persist Security Info=True");

                cnn.Open();

                //Cabeçalho
                OleDbCommand cmd = new OleDbCommand("insert into dados (id) values (@id) ", cnn);
                cmd.Parameters.AddWithValue("@id", report.id);

                cmd.ExecuteNonQuery();

                //Strings
                cmd = new OleDbCommand(" insert into dados_string " +
                                        " (id, string01, string02, string03, string04, string05, " +
                                        " string06, string07, string08, string09, string10, " +
                                        " string11, string12, string13, string14, string15, " +
                                        " string16, string17, string18, string19, string20) " +
                                        " values " +
                                        " (@id, @string01, @string02, @string03, @string04, @string05, " +
                                        " @string06, @string07, @string08, @string09, @string10, " +
                                        " @string11, @string12, @string13, @string14, @string15, " +
                                        " @string16, @string17, @string18, @string19, @string20) ", cnn);

                cmd.Parameters.AddWithValue("@id", report.id);

                cmd.Parameters.AddWithValue("@string01", report.string01);
                cmd.Parameters.AddWithValue("@string02", report.string02);
                cmd.Parameters.AddWithValue("@string03", report.string03);
                cmd.Parameters.AddWithValue("@string04", report.string04);
                cmd.Parameters.AddWithValue("@string05", report.string05);

                cmd.Parameters.AddWithValue("@string06", report.string06);
                cmd.Parameters.AddWithValue("@string07", report.string07);
                cmd.Parameters.AddWithValue("@string08", report.string08);
                cmd.Parameters.AddWithValue("@string09", report.string09);
                cmd.Parameters.AddWithValue("@string10", report.string10);

                cmd.Parameters.AddWithValue("@string11", report.string11);
                cmd.Parameters.AddWithValue("@string12", report.string12);
                cmd.Parameters.AddWithValue("@string13", report.string13);
                cmd.Parameters.AddWithValue("@string14", report.string14);
                cmd.Parameters.AddWithValue("@string15", report.string15);

                cmd.Parameters.AddWithValue("@string16", report.string16);
                cmd.Parameters.AddWithValue("@string17", report.string17);
                cmd.Parameters.AddWithValue("@string18", report.string18);
                cmd.Parameters.AddWithValue("@string19", report.string19);
                cmd.Parameters.AddWithValue("@string20", report.string20);

                cmd.ExecuteNonQuery();


                //Texts
                cmd = new OleDbCommand(" insert into dados_text " +
                                        " (id, text01, text02, text03, text04, text05, " +
                                        " text06, text07, text08, text09, text10, " +
                                        " text11, text12, text13, text14, text15, " +
                                        " text16, text17, text18, text19, text20) " +
                                        " values " +
                                        " (@id, @text01, @text02, @text03, @text04, @text05, " +
                                        " @text06, @text07, @text08, @text09, @text10, " +
                                        " @text11, @text12, @text13, @text14, @text15, " +
                                        " @text16, @text17, @text18, @text19, @text20) ", cnn);

                cmd.Parameters.AddWithValue("@id", report.id);

                cmd.Parameters.AddWithValue("@text01", report.text01);
                cmd.Parameters.AddWithValue("@text02", report.text02);
                cmd.Parameters.AddWithValue("@text03", report.text03);
                cmd.Parameters.AddWithValue("@text04", report.text04);
                cmd.Parameters.AddWithValue("@text05", report.text05);

                cmd.Parameters.AddWithValue("@text06", report.text06);
                cmd.Parameters.AddWithValue("@text07", report.text07);
                cmd.Parameters.AddWithValue("@text08", report.text08);
                cmd.Parameters.AddWithValue("@text09", report.text09);
                cmd.Parameters.AddWithValue("@text10", report.text10);

                cmd.Parameters.AddWithValue("@text11", report.text11);
                cmd.Parameters.AddWithValue("@text12", report.text12);
                cmd.Parameters.AddWithValue("@text13", report.text13);
                cmd.Parameters.AddWithValue("@text14", report.text14);
                cmd.Parameters.AddWithValue("@text15", report.text15);

                cmd.Parameters.AddWithValue("@text16", report.text16);
                cmd.Parameters.AddWithValue("@text17", report.text17);
                cmd.Parameters.AddWithValue("@text18", report.text18);
                cmd.Parameters.AddWithValue("@text19", report.text19);
                cmd.Parameters.AddWithValue("@text20", report.text20);

                cmd.ExecuteNonQuery();

                //Números
                cmd = new OleDbCommand(" insert into dados_number " +
                                        " (id, number01, number02, number03, number04, number05, " +
                                        " number06, number07, number08, number09, number10, " +
                                        " number11, number12, number13, number14, number15, " +
                                        " number16, number17, number18, number19, number20) " +
                                        " values " +
                                        " (@id, @number01, @number02, @number03, @number04, @number05, " +
                                        " @number06, @number07, @number08, @number09, @number10, " +
                                        " @number11, @number12, @number13, @number14, @number15, " +
                                        " @number16, @number17, @number18, @number19, @number20) ", cnn);

                cmd.Parameters.AddWithValue("@id", report.id);

                cmd.Parameters.AddWithValue("@number01", report.number01);
                cmd.Parameters.AddWithValue("@number02", report.number02);
                cmd.Parameters.AddWithValue("@number03", report.number03);
                cmd.Parameters.AddWithValue("@number04", report.number04);
                cmd.Parameters.AddWithValue("@number05", report.number05);

                cmd.Parameters.AddWithValue("@number06", report.number06);
                cmd.Parameters.AddWithValue("@number07", report.number07);
                cmd.Parameters.AddWithValue("@number08", report.number08);
                cmd.Parameters.AddWithValue("@number09", report.number09);
                cmd.Parameters.AddWithValue("@number10", report.number10);

                cmd.Parameters.AddWithValue("@number11", report.number11);
                cmd.Parameters.AddWithValue("@number12", report.number12);
                cmd.Parameters.AddWithValue("@number13", report.number13);
                cmd.Parameters.AddWithValue("@number14", report.number14);
                cmd.Parameters.AddWithValue("@number15", report.number15);

                cmd.Parameters.AddWithValue("@number16", report.number16);
                cmd.Parameters.AddWithValue("@number17", report.number17);
                cmd.Parameters.AddWithValue("@number18", report.number18);
                cmd.Parameters.AddWithValue("@number19", report.number19);
                cmd.Parameters.AddWithValue("@number20", report.number20);

                cmd.ExecuteNonQuery();


                //Datas
                cmd = new OleDbCommand(" insert into dados_date " +
                                        " (id, date01, date02, date03, date04, date05, " +
                                        " date06, date07, date08, date09, date10, " +
                                        " date11, date12, date13, date14, date15, " +
                                        " date16, date17, date18, date19, date20) " +
                                        " values " +
                                        " (@id, @date01, @date02, @date03, @date04, @date05, " +
                                        " @date06, @date07, @date08, @date09, @date10, " +
                                        " @date11, @date12, @date13, @date14, @date15, " +
                                        " @date16, @date17, @date18, @date19, @date20) ", cnn);

                cmd.Parameters.AddWithValue("@id", report.id);

                cmd.Parameters.AddWithValue("@date01", report.date01);
                cmd.Parameters.AddWithValue("@date02", report.date02);
                cmd.Parameters.AddWithValue("@date03", report.date03);
                cmd.Parameters.AddWithValue("@date04", report.date04);
                cmd.Parameters.AddWithValue("@date05", report.date05);

                cmd.Parameters.AddWithValue("@date06", report.date06);
                cmd.Parameters.AddWithValue("@date07", report.date07);
                cmd.Parameters.AddWithValue("@date08", report.date08);
                cmd.Parameters.AddWithValue("@date09", report.date09);
                cmd.Parameters.AddWithValue("@date10", report.date10);

                cmd.Parameters.AddWithValue("@date11", report.date11);
                cmd.Parameters.AddWithValue("@date12", report.date12);
                cmd.Parameters.AddWithValue("@date13", report.date13);
                cmd.Parameters.AddWithValue("@date14", report.date14);
                cmd.Parameters.AddWithValue("@date15", report.date15);

                cmd.Parameters.AddWithValue("@date16", report.date16);
                cmd.Parameters.AddWithValue("@date17", report.date17);
                cmd.Parameters.AddWithValue("@date18", report.date18);
                cmd.Parameters.AddWithValue("@date19", report.date19);
                cmd.Parameters.AddWithValue("@date20", report.date20);

                cmd.ExecuteNonQuery();

                //cmd = new OleDbCommand(" insert into dados_date (id, date01) values (@id, @date01) ", cnn);
                //
                //cmd.Parameters.AddWithValue("@id",      report.id);
                //cmd.Parameters.AddWithValue("@date01",  report.date01);
                //
                //cmd.ExecuteNonQuery();

                if (report.id == 1 && report.img01 != null)
                {
                    cmd = new OleDbCommand(" insert into dados_image (id, img01) values (@id, @img01) ", cnn);


                    cmd.Parameters.AddWithValue("@id", report.id);
                    cmd.Parameters.AddWithValue("@img01", report.img01);

                    cmd.ExecuteNonQuery();
                }

                cnn.Close();

                cnn.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
