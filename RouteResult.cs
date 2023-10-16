using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace A25
{
    public partial class RouteResult : Form
    {
        public RouteResult(string item_id, string item_type, string gift1, string gift2)
        {
            InitializeComponent();
            ResultDisplay(item_id, item_type, gift1, gift2);
        }

        private void ResultDisplay(string item_id, string item_type, string gift1, string gift2)
        {
            DataTable datatable_result = new DataTable();
            datatable_result.Columns.Add("投入キャラクター①", typeof(string));
            datatable_result.Columns.Add("投入キャラクター②", typeof(string));
            datatable_result.Columns.Add("投入素材", typeof(string));
            StringBuilder sql = new StringBuilder();
            sql.Clear();
            sql.Append(" SELECT T7.CHARACTER, ").AppendLine();
            sql.Append("        T8.CHARACTER, ").AppendLine();
            sql.Append("        T9.MATERIAL, ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT1_1 IN (" + gift1 + ", " + gift2 + ") THEN T10.GIFT_NAME || ',' ELSE '' END || ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT1_2 IN (" + gift1 + ", " + gift2 + ") THEN T11.GIFT_NAME || ',' ELSE '' END || ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT1_3 IN (" + gift1 + ", " + gift2 + ") THEN T12.GIFT_NAME || ',' ELSE '' END AS CHARA1_GIFT, ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT2_1 IN (" + gift1 + ", " + gift2 + ") THEN T13.GIFT_NAME || ',' ELSE '' END || ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT2_2 IN (" + gift1 + ", " + gift2 + ") THEN T14.GIFT_NAME || ',' ELSE '' END || ").AppendLine();
            sql.Append("        CASE WHEN T.GIFT2_3 IN (" + gift1 + ", " + gift2 + ") THEN T15.GIFT_NAME || ',' ELSE '' END AS CHARA2_GIFT, ").AppendLine();
            sql.Append("        CASE WHEN T.PROPERTY1 IN (" + gift1 + ", " + gift2 + ") THEN T16.GIFT_NAME || ',' ELSE '' END || ").AppendLine();
            sql.Append("        CASE WHEN T.PROPERTY2 IN (" + gift1 + ", " + gift2 + ") THEN T17.GIFT_NAME || ',' ELSE '' END AS ITEM_GIFT ").AppendLine();
            sql.Append(" FROM ( ").AppendLine();
            sql.Append("       SELECT T5.CHARACTER_NO1, ").AppendLine();
            sql.Append("              T5.CHARACTER_NO2, ").AppendLine();
            sql.Append("              T5.GIFT1_1, ").AppendLine();
            sql.Append("              T5.GIFT1_2, ").AppendLine();
            sql.Append("              T5.GIFT1_3, ").AppendLine();
            sql.Append("              T5.GIFT2_1, ").AppendLine();
            sql.Append("              T5.GIFT2_2, ").AppendLine();
            sql.Append("              T5.GIFT2_3, ").AppendLine();
            sql.Append("              T6.MATERIAL_ID, ").AppendLine();
            sql.Append("              T6.PROPERTY1, ").AppendLine();
            sql.Append("              T6.PROPERTY2 ").AppendLine();
            sql.Append("       FROM ( ").AppendLine();
            sql.Append("             SELECT T3.CHARACTER_NO1, ").AppendLine();
            sql.Append("                    T3.GIFT1 AS GIFT1_1, ").AppendLine();
            sql.Append("                    T3.GIFT2 AS GIFT1_2, ").AppendLine();
            sql.Append("                    T3.GIFT3 AS GIFT1_3, ").AppendLine();
            sql.Append("                    T4.CHARACTER_CODE AS CHARACTER_NO2, ").AppendLine();
            sql.Append("                    T4.GIFT1 AS GIFT2_1, ").AppendLine();
            sql.Append("                    T4.GIFT2 AS GIFT2_2, ").AppendLine();
            sql.Append("                    T4.GIFT3 AS GIFT2_3, ").AppendLine();
            sql.Append("                    T4.RIGHT_COLOR AS ITEM_COLOR ").AppendLine();
            sql.Append("             FROM ( ").AppendLine();
            sql.Append("                    SELECT T1.CHARACTER_CODE AS CHARACTER_NO1, ").AppendLine();
            sql.Append("                           T1.RIGHT_COLOR, ").AppendLine();
            sql.Append("                           T1.GIFT1, ").AppendLine();
            sql.Append("                           T1.GIFT2, ").AppendLine();
            sql.Append("                           T1.GIFT3 ").AppendLine();
            sql.Append("                    FROM CHARA_GIFT_INFO T1 ").AppendLine();
            sql.Append("                    JOIN ( ").AppendLine();
            sql.Append("                          SELECT T0.COLOR1, ").AppendLine();
            sql.Append("                                 T0.COLOR2, ").AppendLine();
            sql.Append("                                 T0.COLOR3 ").AppendLine();
            if(item_type.Equals("1") | item_type.Equals("2") | item_type.Equals("3") | item_type.Equals("4"))
            {
                sql.Append("                    FROM ITEM_BATTLE_INFO T0 ").AppendLine();
            }
            else
            {
                sql.Append("                    FROM ITEM_EQUIP_INFO T0 ").AppendLine();
            }
            sql.Append("                          WHERE T0.ITEM_ID = " + item_id + " ").AppendLine();
            sql.Append("                         ) T2 ").AppendLine();
            sql.Append("                    ON T1.LEFT_COLOR IN (T2.COLOR1, T2.COLOR2, T2.COLOR3)  ").AppendLine();
            sql.Append("                  ) T3 ").AppendLine();
            sql.Append("             JOIN CHARA_GIFT_INFO T4 ").AppendLine();
            sql.Append("             ON T3.RIGHT_COLOR = T4.LEFT_COLOR ").AppendLine();
            sql.Append("            ) T5 ").AppendLine();
            sql.Append("       JOIN ITEM_MATERIAL_INFO T6 ").AppendLine();
            sql.Append("       ON T5.ITEM_COLOR = T6.COLOR ").AppendLine();
            sql.Append("       WHERE " + gift1 + " IN (T6.PROPERTY1, T6.PROPERTY2, T5.GIFT1_1, T5.GIFT1_2, T5.GIFT1_3, T5.GIFT2_1, T5.GIFT2_2, T5.GIFT2_3) AND ").AppendLine();
            sql.Append("             " + gift2 + " IN (T6.PROPERTY1, T6.PROPERTY2, T5.GIFT1_1, T5.GIFT1_2, T5.GIFT1_3, T5.GIFT2_1, T5.GIFT2_2, T5.GIFT2_3) ").AppendLine();
            sql.Append("      ) T ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" CHARA_BASE_INFO T7 ").AppendLine();
            sql.Append(" ON T.CHARACTER_NO1 = T7.CHARACTER_CODE ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" CHARA_BASE_INFO T8 ").AppendLine();
            sql.Append(" ON T.CHARACTER_NO2 = T8.CHARACTER_CODE ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ITEM_MATERIAL_INFO T9 ").AppendLine();
            sql.Append(" ON T.MATERIAL_ID = T9.MATERIAL_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T10 ").AppendLine();
            sql.Append(" ON T.GIFT1_1 = T10.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T11 ").AppendLine();
            sql.Append(" ON T.GIFT1_2 = T11.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T12 ").AppendLine();
            sql.Append(" ON T.GIFT1_3 = T12.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T13 ").AppendLine();
            sql.Append(" ON T.GIFT2_1 = T13.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T14 ").AppendLine();
            sql.Append(" ON T.GIFT2_2 = T14.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T15 ").AppendLine();
            sql.Append(" ON T.GIFT2_3 = T15.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T16 ").AppendLine();
            sql.Append(" ON T.PROPERTY1 = T16.GIFT_ID ").AppendLine();
            sql.Append(" LEFT OUTER JOIN ").AppendLine();
            sql.Append(" ALL_GIFT_INFO_MST T17 ").AppendLine();
            sql.Append(" ON T.PROPERTY2 = T17.GIFT_ID; ").AppendLine();

            //SQL実行
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();
                command.CommandText = sql.ToString();
                //command.Parameters.AddWithValue(":GIFT1", gift1);
                //command.Parameters.AddWithValue(":GIFT2", gift2);
                //command.Parameters.AddWithValue(":ITEM_ID", item_id);
                command.ExecuteNonQuery();

                using (var reader = command.ExecuteReader())
                {
                    string col1;
                    string col2;
                    string col3;
                    
                    

                    while (reader.Read())
                    {
                        try
                        {
                            string gift_string_link = reader.GetString(3) + reader.GetString(4) + reader.GetString(5);
                            string[] gift_list = gift_string_link.Substring(0, gift_string_link.Length - 1).Split(',');
                            //　有効ギフトは二つ以上の場合のみ結果有効
                            if (gift_list.Length > 1)
                            {
                                if (reader.GetString(3).Equals(""))
                                {
                                    col1 = reader.GetString(0) + "(色中継・ギフト継承対象外)";
                                }
                                else
                                {
                                    col1 = reader.GetString(0) + "(" + reader.GetString(3).Substring(0, reader.GetString(3).Length - 1) + ")";
                                }
                                if (reader.GetString(4).Equals(""))
                                {
                                    col2 = reader.GetString(1) + "(色中継・ギフト継承対象外)";
                                }
                                else
                                {
                                    col2 = reader.GetString(1) + "(" + reader.GetString(4).Substring(0, reader.GetString(4).Length - 1) + ")";
                                }
                                if (reader.GetString(5).Equals(""))
                                {
                                    col3 = reader.GetString(2) + "(色中継・ギフト継承対象外)";
                                }
                                else
                                {
                                    col3 = reader.GetString(2) + "(" + reader.GetString(5).Substring(0, reader.GetString(5).Length - 1) + ")";
                                }


                                datatable_result.Rows.Add(col1,
                                                          col2,
                                                          col3
                                                         );
                            }
                        }
                        catch
                        {
                            MessageBox.Show("結果取得中エラー発生");
                        }
                    }
                }

                connection.Close();
                //Common.SQLLogOutput(sql.ToString());
                //Common.SQLLogOutput(gift1);
                //Common.SQLLogOutput(gift2);
                //Common.SQLLogOutput(item_id);

                // DataGridViewデータバインド
                datagrid_result_list.DataSource = datatable_result;
                datagrid_result_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_result_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_result_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_result_list.Columns[0].FillWeight = 100;
                datagrid_result_list.Columns[1].FillWeight = 100;
                datagrid_result_list.Columns[2].FillWeight = 100;
            }
        }
    }
}
