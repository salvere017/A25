using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;

namespace A25
{
    public partial class AtelierMenu : Form
    {
        public AtelierMenu()
        {
            InitializeComponent();
            DataSelect_Equipment("");
            DataSelect_Item("");
            DataSelect_Material("");
            DataSelect_Gift("");
            InitConditionArea("");
        }

        private void DataSelect_Equipment(string condition_sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT T0.ITEM_ID, ").AppendLine();
                sql.Append("        T0.RARE, ").AppendLine();
                sql.Append("        T0.ITEM_NAME, ").AppendLine();
                sql.Append("        T1.TYPE_NAME, ").AppendLine();
                sql.Append("        T0.HP, ").AppendLine();
                sql.Append("        T0.SPEED, ").AppendLine();
                sql.Append("        T0.PHYSICS_ATTACK, ").AppendLine();
                sql.Append("        T0.PHYSICS_DENFENCE, ").AppendLine();
                sql.Append("        T0.MAGIC_ATTACK, ").AppendLine();
                sql.Append("        T0.MAGIC_DENFENCE, ").AppendLine();
                sql.Append("        CASE WHEN T2.COLOR_JP IS NULL THEN '※データ欠' ELSE T2.COLOR_JP END AS COLOR1,").AppendLine();
                sql.Append("        CASE WHEN T3.COLOR_JP IS NULL THEN '※データ欠' ELSE T3.COLOR_JP END AS COLOR2,").AppendLine();
                sql.Append("        CASE WHEN T4.COLOR_JP IS NULL THEN '※データ欠' ELSE T4.COLOR_JP END AS COLOR3,").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR1 IS NULL THEN '-' ELSE T0.COLOR1 END AS COLOR_CODE1, ").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR2 IS NULL THEN '-' ELSE T0.COLOR2 END AS COLOR_CODE2, ").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR3 IS NULL THEN '-' ELSE T0.COLOR3 END AS COLOR_CODE3, ").AppendLine();
                sql.Append("        T0.ITEM_COMMENT, ").AppendLine();
                sql.Append("        T0.ITEM_TYPE ").AppendLine();
                sql.Append(" FROM ITEM_EQUIP_INFO T0").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_TYPE_MST T1").AppendLine();
                sql.Append(" ON T1.TYPE_ID = T0.ITEM_TYPE").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T2").AppendLine();
                sql.Append(" ON T2.COLOR_EN = T0.COLOR1 ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T3").AppendLine();
                sql.Append(" ON T3.COLOR_EN = T0.COLOR2 ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T4").AppendLine();
                sql.Append(" ON T4.COLOR_EN = T0.COLOR3 ").AppendLine();
                sql.Append(" WHERE 1 = 1 ").AppendLine();
                sql.Append(condition_sql).AppendLine();
                sql.Append(" ORDER BY T0.ITEM_ID ASC");

                //SQL実行
                command.CommandText = sql.ToString();
                command.ExecuteNonQuery();

                DataTable datatable_equip_list = new DataTable();
                datatable_equip_list.Columns.Add("装備品ID", typeof(int));
                datatable_equip_list.Columns.Add("レア度", typeof(string));
                datatable_equip_list.Columns.Add("装備品", typeof(string));
                datatable_equip_list.Columns.Add("装備類型", typeof(string));
                datatable_equip_list.Columns.Add("HP", typeof(string));
                datatable_equip_list.Columns.Add("素早", typeof(string));
                datatable_equip_list.Columns.Add("物攻", typeof(string));
                datatable_equip_list.Columns.Add("物防", typeof(string));
                datatable_equip_list.Columns.Add("魔攻", typeof(string));
                datatable_equip_list.Columns.Add("魔防", typeof(string));
                datatable_equip_list.Columns.Add("色①", typeof(string));
                datatable_equip_list.Columns.Add("色②", typeof(string));
                datatable_equip_list.Columns.Add("色③", typeof(string));
                datatable_equip_list.Columns.Add("リンク色①コード", typeof(string));
                datatable_equip_list.Columns.Add("リンク色②コード", typeof(string));
                datatable_equip_list.Columns.Add("リンク色③コード", typeof(string));
                datatable_equip_list.Columns.Add("装備効果詳細", typeof(string));
                datatable_equip_list.Columns.Add("TYPE", typeof(string));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // DataTableデータバインド
                        datatable_equip_list.Rows.Add(reader.GetString(0),
                                                     reader.GetString(1),
                                                     reader.GetString(2),
                                                     reader.GetString(3),
                                                     reader.GetString(4),
                                                     reader.GetString(5),
                                                     reader.GetString(6),
                                                     reader.GetString(7),
                                                     reader.GetString(8),
                                                     reader.GetString(9),
                                                     reader.GetString(10),
                                                     reader.GetString(11),
                                                     reader.GetString(12),
                                                     reader.GetString(13),
                                                     reader.GetString(14),
                                                     reader.GetString(15),
                                                     reader.GetString(16),
                                                     reader.GetString(17)
                                                    );
                    }
                }

                connection.Close();

                // DataGridViewデータバインド
                datagrid_equip_list.DataSource = datatable_equip_list;
                datagrid_equip_list.Columns[0].Visible = false;
                datagrid_equip_list.Columns[13].Visible = false;
                datagrid_equip_list.Columns[14].Visible = false;
                datagrid_equip_list.Columns[15].Visible = false;
                datagrid_equip_list.Columns[17].Visible = false;
                datagrid_equip_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_equip_list.Columns[1].FillWeight = 80;
                datagrid_equip_list.Columns[2].FillWeight = 130;
                datagrid_equip_list.Columns[3].FillWeight = 100;
                datagrid_equip_list.Columns[4].FillWeight = 60;
                datagrid_equip_list.Columns[5].FillWeight = 60;
                datagrid_equip_list.Columns[6].FillWeight = 60;
                datagrid_equip_list.Columns[7].FillWeight = 60;
                datagrid_equip_list.Columns[8].FillWeight = 60;
                datagrid_equip_list.Columns[9].FillWeight = 60;
                datagrid_equip_list.Columns[10].FillWeight = 60;
                datagrid_equip_list.Columns[11].FillWeight = 60;
                datagrid_equip_list.Columns[12].FillWeight = 60;
                datagrid_equip_list.Columns[16].FillWeight = 300;
                datagrid_equip_list.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_equip_list.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagrid_equip_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Datagrid_equip_list_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < datagrid_equip_list.Rows.Count; i++)
            {
                if (datagrid_equip_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Red")
                {
                    datagrid_equip_list.Rows[i].Cells["色①"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Green")
                {
                    datagrid_equip_list.Rows[i].Cells["色①"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Blue")
                {
                    datagrid_equip_list.Rows[i].Cells["色①"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Yellow")
                {
                    datagrid_equip_list.Rows[i].Cells["色①"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Purple")
                {
                    datagrid_equip_list.Rows[i].Cells["色①"].Style.BackColor = Color.Violet;
                }

                if (datagrid_equip_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Red")
                {
                    datagrid_equip_list.Rows[i].Cells["色②"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Green")
                {
                    datagrid_equip_list.Rows[i].Cells["色②"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Blue")
                {
                    datagrid_equip_list.Rows[i].Cells["色②"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Yellow")
                {
                    datagrid_equip_list.Rows[i].Cells["色②"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Purple")
                {
                    datagrid_equip_list.Rows[i].Cells["色②"].Style.BackColor = Color.Violet;
                }

                if (datagrid_equip_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Red")
                {
                    datagrid_equip_list.Rows[i].Cells["色③"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Green")
                {
                    datagrid_equip_list.Rows[i].Cells["色③"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Blue")
                {
                    datagrid_equip_list.Rows[i].Cells["色③"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Yellow")
                {
                    datagrid_equip_list.Rows[i].Cells["色③"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_equip_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Purple")
                {
                    datagrid_equip_list.Rows[i].Cells["色③"].Style.BackColor = Color.Violet;
                }
            }
        }

        private void datagrid_equip_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datagrid_equip_list.CurrentRow.Cells[13].Value.ToString().Equals("-") |
                    datagrid_equip_list.CurrentRow.Cells[14].Value.ToString().Equals("-") |
                    datagrid_equip_list.CurrentRow.Cells[15].Value.ToString().Equals("-") )
                {
                    MessageBox.Show("調合対象データ不足のため、調合対象になりません。\r\n\r\n他のアイテムを選択してください。");
                }
                else 
                {
                    // 錬金ルート検索
                    label_obj_code.Text = datagrid_equip_list.CurrentRow.Cells[0].Value.ToString();
                    label_obj_name.Text = datagrid_equip_list.CurrentRow.Cells[2].Value.ToString();
                    label_obj_type.Text = datagrid_equip_list.CurrentRow.Cells[17].Value.ToString();
                    // COMBOBOX再バインド
                    InitConditionArea(" WHERE GIFT_OBJ = 1 ");
                    MessageBox.Show("調合対象選択済み、調合条件を選択してください。");
                    tab.SelectTab(tabpage_gift);
                }
            }
            catch
            {
                MessageBox.Show("空データが存在する！");
            }
        }

        private void DataSelect_Item(string condition_sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT T0.ITEM_ID, ").AppendLine();
                sql.Append("        T0.ITEM_NAME, ").AppendLine();
                sql.Append("        T1.TYPE_NAME, ").AppendLine();
                sql.Append("        T0.RARE, ").AppendLine();
                sql.Append("        CASE WHEN T2.ATTRIBUTE IS NULL THEN '属性なし' ELSE T2.ATTRIBUTE END AS ATTRIBUTE, ").AppendLine();
                sql.Append("        T3.TARGET, ").AppendLine();
                sql.Append("        T0.USE_TIMES, ").AppendLine();
                sql.Append("        CASE WHEN T0.DH_VALUE IS NULL THEN 'なし' ELSE T0.DH_VALUE END AS DH_VALUE, ").AppendLine();
                sql.Append("        CASE WHEN T4.COLOR_JP IS NULL THEN '※データ欠' ELSE T4.COLOR_JP END AS COLOR1,").AppendLine();
                sql.Append("        CASE WHEN T5.COLOR_JP IS NULL THEN '※データ欠' ELSE T5.COLOR_JP END AS COLOR2,").AppendLine();
                sql.Append("        CASE WHEN T6.COLOR_JP IS NULL THEN '※データ欠' ELSE T6.COLOR_JP END AS COLOR3,").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR1 IS NULL THEN '-' ELSE T0.COLOR1 END AS COLOR_CODE1, ").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR2 IS NULL THEN '-' ELSE T0.COLOR2 END AS COLOR_CODE2, ").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR3 IS NULL THEN '-' ELSE T0.COLOR3 END AS COLOR_CODE3, ").AppendLine();
                sql.Append("        T0.ITEM_COMMENT, ").AppendLine();
                sql.Append("        T0.ITEM_TYPE ").AppendLine();
                sql.Append(" FROM ITEM_BATTLE_INFO T0").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_TYPE_MST T1").AppendLine();
                sql.Append(" ON T1.TYPE_ID = T0.ITEM_TYPE").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_ATTRIBUTE_MST T2").AppendLine();
                sql.Append(" ON T2.ATTRIBUTE_CODE = T0.ATTRIBUTE ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_TARGET_RANGE_MST T3").AppendLine();
                sql.Append(" ON T3.TARGET_OBJ_CODE = T0.RANGE ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T4").AppendLine();
                sql.Append(" ON T4.COLOR_EN = T0.COLOR1 ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T5").AppendLine();
                sql.Append(" ON T5.COLOR_EN = T0.COLOR2 ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T6").AppendLine();
                sql.Append(" ON T6.COLOR_EN = T0.COLOR3 ").AppendLine();
                sql.Append(" WHERE 1 = 1 ").AppendLine();
                sql.Append(condition_sql).AppendLine();
                sql.Append(" ORDER BY T0.ITEM_ID ASC");

                //SQL実行
                command.CommandText = sql.ToString();
                command.ExecuteNonQuery();

                DataTable datatable_item_list = new DataTable();
                datatable_item_list.Columns.Add("品ID", typeof(int));
                datatable_item_list.Columns.Add("アイテム", typeof(string));
                datatable_item_list.Columns.Add("類型", typeof(string));
                datatable_item_list.Columns.Add("レア度", typeof(string));
                datatable_item_list.Columns.Add("関連属性", typeof(string));
                datatable_item_list.Columns.Add("対象範囲", typeof(string));
                datatable_item_list.Columns.Add("使用回数", typeof(string));
                datatable_item_list.Columns.Add("数値", typeof(string));
                datatable_item_list.Columns.Add("色①", typeof(string));
                datatable_item_list.Columns.Add("色②", typeof(string));
                datatable_item_list.Columns.Add("色③", typeof(string));
                datatable_item_list.Columns.Add("リンク色①コード", typeof(string));
                datatable_item_list.Columns.Add("リンク色②コード", typeof(string));
                datatable_item_list.Columns.Add("リンク色③コード", typeof(string));
                datatable_item_list.Columns.Add("アイテム効果説明", typeof(string));
                datatable_item_list.Columns.Add("TYPE", typeof(string));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // DataTableデータバインド
                        datatable_item_list.Rows.Add(reader.GetString(0),
                                                     reader.GetString(1),
                                                     reader.GetString(2),
                                                     reader.GetString(3),
                                                     reader.GetString(4),
                                                     reader.GetString(5),
                                                     reader.GetString(6) + "回",
                                                     reader.GetString(7),
                                                     reader.GetString(8),
                                                     reader.GetString(9),
                                                     reader.GetString(10),
                                                     reader.GetString(11),
                                                     reader.GetString(12),
                                                     reader.GetString(13),
                                                     reader.GetString(14),
                                                     reader.GetString(15)
                                                    );
                    }
                }

                connection.Close();

                // DataGridViewデータバインド
                datagrid_item_list.DataSource = datatable_item_list;
                datagrid_item_list.Columns[0].Visible = false;
                datagrid_item_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[1].FillWeight = 120;
                datagrid_item_list.Columns[2].FillWeight = 80;
                datagrid_item_list.Columns[3].FillWeight = 80;
                datagrid_item_list.Columns[4].FillWeight = 100;
                datagrid_item_list.Columns[5].FillWeight = 100;
                datagrid_item_list.Columns[6].FillWeight = 100;
                datagrid_item_list.Columns[7].FillWeight = 60;
                datagrid_item_list.Columns[8].FillWeight = 60;
                datagrid_item_list.Columns[9].FillWeight = 60;
                datagrid_item_list.Columns[10].FillWeight = 60;
                datagrid_item_list.Columns[14].FillWeight = 300;
                datagrid_item_list.Columns[11].Visible = false;
                datagrid_item_list.Columns[12].Visible = false;
                datagrid_item_list.Columns[13].Visible = false;
                datagrid_item_list.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_item_list.Columns[15].Visible = false;
                datagrid_item_list.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagrid_item_list.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_item_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            }
        }

        private void Datagrid_item_list_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < datagrid_item_list.Rows.Count; i++)
            {
                if (datagrid_item_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Red")
                {
                    datagrid_item_list.Rows[i].Cells["色①"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Green")
                {
                    datagrid_item_list.Rows[i].Cells["色①"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Blue")
                {
                    datagrid_item_list.Rows[i].Cells["色①"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Yellow")
                {
                    datagrid_item_list.Rows[i].Cells["色①"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色①コード"].Value.ToString() == "Purple")
                {
                    datagrid_item_list.Rows[i].Cells["色①"].Style.BackColor = Color.Violet;
                }

                if (datagrid_item_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Red")
                {
                    datagrid_item_list.Rows[i].Cells["色②"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Green")
                {
                    datagrid_item_list.Rows[i].Cells["色②"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Blue")
                {
                    datagrid_item_list.Rows[i].Cells["色②"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Yellow")
                {
                    datagrid_item_list.Rows[i].Cells["色②"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色②コード"].Value.ToString() == "Purple")
                {
                    datagrid_item_list.Rows[i].Cells["色②"].Style.BackColor = Color.Violet;
                }

                if (datagrid_item_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Red")
                {
                    datagrid_item_list.Rows[i].Cells["色③"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Green")
                {
                    datagrid_item_list.Rows[i].Cells["色③"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Blue")
                {
                    datagrid_item_list.Rows[i].Cells["色③"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Yellow")
                {
                    datagrid_item_list.Rows[i].Cells["色③"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_item_list.Rows[i].Cells["リンク色③コード"].Value.ToString() == "Purple")
                {
                    datagrid_item_list.Rows[i].Cells["色③"].Style.BackColor = Color.Violet;
                }
            }
        }

        private void datagrid_item_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (datagrid_item_list.CurrentRow.Cells[11].Value.ToString().Equals("-") |
                    datagrid_item_list.CurrentRow.Cells[12].Value.ToString().Equals("-") |
                    datagrid_item_list.CurrentRow.Cells[13].Value.ToString().Equals("-"))
                {
                    MessageBox.Show("調合対象データ不足のため、調合対象になりません。\r\n\r\n他のアイテムを選択してください。");
                }
                else
                {
                    // 錬金ルート検索
                    label_obj_code.Text = datagrid_item_list.CurrentRow.Cells[0].Value.ToString();
                    label_obj_name.Text = datagrid_item_list.CurrentRow.Cells[1].Value.ToString();
                    label_obj_type.Text = datagrid_item_list.CurrentRow.Cells[15].Value.ToString();
                    // COMBOBOX再バインド
                    InitConditionArea(" WHERE GIFT_OBJ = 2 ");
                    MessageBox.Show("調合対象選択済み、調合条件を選択してください。");
                    tab.SelectTab(tabpage_gift);
                }
            }
            catch
            {
                MessageBox.Show("空データが存在する！");
            }
        }


        private void DataSelect_Material(string condition_sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT T0.MATERIAL_ID, ").AppendLine();
                sql.Append("        T0.RARE, ").AppendLine();
                sql.Append("        T0.MATERIAL, ").AppendLine();
                sql.Append("        T1.GIFT_NAME, ").AppendLine();
                sql.Append("        T1.GIFT_COMMENT, ").AppendLine();
                sql.Append("        T2.GIFT_NAME, ").AppendLine();
                sql.Append("        T2.GIFT_COMMENT, ").AppendLine();
                sql.Append("        CASE WHEN T0.COLOR IS NULL THEN 'NULL' ELSE T0.COLOR END AS COLOR_EN,").AppendLine();
                sql.Append("        CASE WHEN T3.COLOR_JP IS NULL THEN '※データ欠' ELSE T3.COLOR_JP END AS COLOR_JP").AppendLine();
                sql.Append(" FROM ITEM_MATERIAL_INFO T0").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_GIFT_INFO_MST T1").AppendLine();
                sql.Append(" ON T1.GIFT_ID = T0.PROPERTY1").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_GIFT_INFO_MST T2").AppendLine();
                sql.Append(" ON T2.GIFT_ID = T0.PROPERTY2 ").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_COLOR_MST T3").AppendLine();
                sql.Append(" ON T3.COLOR_EN = T0.COLOR ").AppendLine();
                sql.Append(" WHERE 1 = 1 ").AppendLine();
                sql.Append(condition_sql).AppendLine();
                sql.Append(" ORDER BY T0.MATERIAL_ID ASC");

                //SQL実行
                command.CommandText = sql.ToString();
                command.ExecuteNonQuery();

                DataTable datatable_material_list = new DataTable();
                datatable_material_list.Columns.Add("素材ID", typeof(int));
                datatable_material_list.Columns.Add("レア度", typeof(string));
                datatable_material_list.Columns.Add("素材", typeof(string));
                datatable_material_list.Columns.Add("ギフト①", typeof(string));
                datatable_material_list.Columns.Add("ギフト①効果", typeof(string));
                datatable_material_list.Columns.Add("ギフト②", typeof(string));
                datatable_material_list.Columns.Add("ギフト②効果", typeof(string));
                datatable_material_list.Columns.Add("COLOR", typeof(string));
                datatable_material_list.Columns.Add("色", typeof(string));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // DataTableデータバインド
                        datatable_material_list.Rows.Add(reader.GetString(0),
                                                         reader.GetString(1),
                                                         reader.GetString(2),
                                                         reader.GetString(3),
                                                         reader.GetString(4),
                                                         reader.GetString(5),
                                                         reader.GetString(6),
                                                         reader.GetString(7),
                                                         reader.GetString(8)
                                                        );
                    }
                }

                connection.Close();

                // DataGridViewデータバインド
                datagrid_material_list.DataSource = datatable_material_list;
                datagrid_material_list.Columns[0].Visible = false;//素材ID
                datagrid_material_list.Columns[7].Visible = false;//COLOR
                datagrid_material_list.Columns[8].Visible = false;//色
                datagrid_material_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_material_list.Columns[1].FillWeight = 100;
                datagrid_material_list.Columns[2].FillWeight = 150;
                datagrid_material_list.Columns[3].FillWeight = 180;
                datagrid_material_list.Columns[4].FillWeight = 500;
                datagrid_material_list.Columns[5].FillWeight = 180;
                datagrid_material_list.Columns[6].FillWeight = 500;
                datagrid_material_list.Columns[8].FillWeight = 60;
                datagrid_material_list.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_material_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Datagrid_material_list_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < datagrid_material_list.Rows.Count; i++)
            {
                if (datagrid_material_list.Rows[i].Cells["COLOR"].Value.ToString() == "Red")
                {
                    datagrid_material_list.Rows[i].Cells["素材"].Style.BackColor = Color.OrangeRed;
                }
                else if (datagrid_material_list.Rows[i].Cells["COLOR"].Value.ToString() == "Green")
                {
                    datagrid_material_list.Rows[i].Cells["素材"].Style.BackColor = Color.LimeGreen;
                }
                else if (datagrid_material_list.Rows[i].Cells["COLOR"].Value.ToString() == "Blue")
                {
                    datagrid_material_list.Rows[i].Cells["素材"].Style.BackColor = Color.DeepSkyBlue;
                }
                else if (datagrid_material_list.Rows[i].Cells["COLOR"].Value.ToString() == "Yellow")
                {
                    datagrid_material_list.Rows[i].Cells["素材"].Style.BackColor = Color.Gold;
                }
                else if (datagrid_material_list.Rows[i].Cells["COLOR"].Value.ToString() == "Purple")
                {
                    datagrid_material_list.Rows[i].Cells["素材"].Style.BackColor = Color.Violet;
                }
            }
        }

        private void DataSelect_Gift(string condition_sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT T0.GIFT_ID, ").AppendLine();
                sql.Append("        T0.GIFT_NAME, ").AppendLine();
                sql.Append("        T1.TYPE_NAME, ").AppendLine();
                sql.Append("        T2.GIFT_OBJ, ").AppendLine();
                sql.Append("        T0.GIFT_COMMENT").AppendLine();
                sql.Append(" FROM ALL_GIFT_INFO_MST T0").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_TYPE_MST T1").AppendLine();
                sql.Append(" ON T1.TYPE_ID = T0.GIFT_TYPE").AppendLine();
                sql.Append(" LEFT OUTER JOIN ALL_GIFT_OBJ_MST T2").AppendLine();
                sql.Append(" ON T2.GIFT_OBJ_CODE = T0.GIFT_OBJ ").AppendLine();
                sql.Append(" WHERE 1 = 1 ").AppendLine();
                sql.Append(condition_sql).AppendLine();
                sql.Append(" ORDER BY T0.GIFT_TYPE DESC, T0.GIFT_ID ASC");

                //SQL実行
                command.CommandText = sql.ToString();
                command.ExecuteNonQuery();

                DataTable datatable_gift_list = new DataTable();
                datatable_gift_list.Columns.Add("ギフトID", typeof(int));
                datatable_gift_list.Columns.Add("ギフト", typeof(string));
                datatable_gift_list.Columns.Add("効果類型", typeof(string));
                datatable_gift_list.Columns.Add("付与対象", typeof(string));
                datatable_gift_list.Columns.Add("ギフト効果説明", typeof(string));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // DataTableデータバインド
                        datatable_gift_list.Rows.Add(reader.GetString(0),
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        reader.GetString(4)
                                                       );
                    }
                }

                connection.Close();

                // DataGridViewデータバインド
                datagrid_gift_list.DataSource = datatable_gift_list;
                datagrid_gift_list.Columns[0].Visible = false;
                datagrid_gift_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_gift_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_gift_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_gift_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_gift_list.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagrid_gift_list.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_gift_list.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagrid_gift_list.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                datagrid_gift_list.Columns[1].FillWeight = 110;
                datagrid_gift_list.Columns[2].FillWeight = 80;
                datagrid_gift_list.Columns[3].FillWeight = 80;
                datagrid_gift_list.Columns[4].FillWeight = 250;
            }
        }

        private void InitConditionArea(string condition_sql)
        {
            //ComboBox DataBinding
            DataTable dataTable_gift = new DataTable();
            dataTable_gift.Columns.Add("GIFT_ID");
            dataTable_gift.Columns.Add("GIFT_NAME");
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = " SELECT GIFT_ID, GIFT_NAME FROM ALL_GIFT_INFO_MST " + condition_sql;
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_gift.NewRow();
                    row["GIFT_ID"] = reader.GetString(0);
                    row["GIFT_NAME"] = reader.GetString(1);
                    dataTable_gift.Rows.Add(row);
                }

                combo_gift1.DataSource = dataTable_gift;
                // 表示用の列を設定
                combo_gift1.DisplayMember = "GIFT_NAME";
                // データ用の列を設定
                combo_gift1.ValueMember = "GIFT_ID";

                combo_gift2.DataSource = dataTable_gift.Copy();
                // 表示用の列を設定
                combo_gift2.DisplayMember = "GIFT_NAME";
                // データ用の列を設定
                combo_gift2.ValueMember = "GIFT_ID";

                reader.Close();
                connection.Close();
            }
        }

        private void page1_checkbox_Click(object sender, EventArgs e)
        {
            StringBuilder condition_sql = new StringBuilder();
            if (check_type5.Checked | check_type6.Checked | check_type7.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_type5.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 5 OR ";
                }
                if (check_type6.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 6 OR ";
                }
                if (check_type7.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 7 OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            if (check_equip_rare_r.Checked | check_equip_rare_sr.Checked | check_equip_rare_ssr.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_equip_rare_r.Checked)
                {
                    attribute_condition += "T0.RARE = 'R' OR ";
                }
                if (check_equip_rare_sr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SR' OR ";
                }
                if (check_equip_rare_ssr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SSR' OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            DataSelect_Equipment(condition_sql.ToString());
        }

        private void page2_checkbox_Click(object sender, EventArgs e)
        {
            StringBuilder condition_sql = new StringBuilder();
            if (check_type1.Checked | check_type2.Checked | check_type3.Checked | check_type4.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_type1.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 1 OR ";
                }
                if (check_type2.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 2 OR ";
                }
                if (check_type3.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 3 OR ";
                }
                if (check_type4.Checked)
                {
                    attribute_condition += "T0.ITEM_TYPE = 4 OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            if (check_item_rare_r.Checked | check_item_rare_sr.Checked | check_item_rare_ssr.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_item_rare_r.Checked)
                {
                    attribute_condition += "T0.RARE = 'R' OR ";
                }
                if (check_item_rare_sr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SR' OR ";
                }
                if (check_item_rare_ssr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SSR' OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            DataSelect_Item(condition_sql.ToString());
        }

        private void page3_checkbox_Click(object sender, EventArgs e)
        {
            StringBuilder condition_sql = new StringBuilder();
            if (check_color_red.Checked | check_color_blue.Checked | check_color_purple.Checked | check_color_yellow.Checked | check_color_green.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_color_red.Checked)
                {
                    attribute_condition += "T0.COLOR = 'Red' OR ";
                }
                if (check_color_blue.Checked)
                {
                    attribute_condition += "T0.COLOR = 'Blue' OR ";
                }
                if (check_color_purple.Checked)
                {
                    attribute_condition += "T0.COLOR = 'Purple' OR ";
                }
                if (check_color_yellow.Checked)
                {
                    attribute_condition += "T0.COLOR = 'Yellow' OR ";
                }
                if (check_color_green.Checked)
                {
                    attribute_condition += "T0.COLOR = 'Green' OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            if (check_material_rare_r.Checked | check_material_rare_sr.Checked | check_material_rare_ssr.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_material_rare_r.Checked)
                {
                    attribute_condition += "T0.RARE = 'R' OR ";
                }
                if (check_material_rare_sr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SR' OR ";
                }
                if (check_material_rare_ssr.Checked)
                {
                    attribute_condition += "T0.RARE = 'SSR' OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            DataSelect_Material(condition_sql.ToString());
        }

        private void Confirm_button_Click(object sender, EventArgs e)
        {
            if (label_obj_code.Text.Equals("") | label_obj_type.Text.Equals(""))
            {
                MessageBox.Show("調合対象を選択してください。");
            }
            else
            {
                //結果表示
                RouteResult rs = new RouteResult(label_obj_code.Text, label_obj_type.Text, combo_gift1.SelectedValue.ToString(), combo_gift2.SelectedValue.ToString());
                //MessageBox.Show(label_obj_code.Text + label_obj_type.Text + combo_gift1.SelectedValue + combo_gift2.SelectedValue);
                rs.ShowDialog();
            }
        }
    }
}
