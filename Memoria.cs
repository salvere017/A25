using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;

namespace A25
{
    public partial class Memoria : Form
    {
        public Memoria()
        {
            InitializeComponent();
            DataSelect("");
        }

        private void DataSelect(string condition_sql)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();
                // SQLコマンド対象
                var command = connection.CreateCommand();

                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT T0.MEMORIA_ID, ").AppendLine();
                sql.Append("        T0.RARE, ").AppendLine();
                sql.Append("        T0.MEMORIA_NAME, ").AppendLine();
                sql.Append("        T0.HP, ").AppendLine();
                sql.Append("        T0.SPEED, ").AppendLine();
                sql.Append("        T0.PHYSICS_ATTACK, ").AppendLine();
                sql.Append("        T0.PHYSICS_DENFENCE, ").AppendLine();
                sql.Append("        T0.MAGIC_ATTACK, ").AppendLine();
                sql.Append("        T0.MAGIC_DENFENCE, ").AppendLine();
                sql.Append("        T0.MEMORIA_EFFECT, ").AppendLine();
                sql.Append("        T0.MEMORIA_EFFECT_INFO ").AppendLine();
                sql.Append(" FROM MEMORIA_INFO T0").AppendLine();
                sql.Append(" WHERE 1 = 1 ").AppendLine();
                sql.Append(condition_sql).AppendLine();
                sql.Append(" ORDER BY T0.MEMORIA_ID ASC");

                //SQL実行
                command.CommandText = sql.ToString();
                command.ExecuteNonQuery();

                DataTable datatable_memoria_list = new DataTable();
                datatable_memoria_list.Columns.Add("メモリアID", typeof(int));
                datatable_memoria_list.Columns.Add("レア度", typeof(string));
                datatable_memoria_list.Columns.Add("メモリア", typeof(string));
                datatable_memoria_list.Columns.Add("HP", typeof(string));
                datatable_memoria_list.Columns.Add("素早", typeof(string));
                datatable_memoria_list.Columns.Add("物攻", typeof(string));
                datatable_memoria_list.Columns.Add("物防", typeof(string));
                datatable_memoria_list.Columns.Add("魔攻", typeof(string));
                datatable_memoria_list.Columns.Add("魔防", typeof(string));
                datatable_memoria_list.Columns.Add("付加効果名", typeof(string));
                datatable_memoria_list.Columns.Add("付加効果", typeof(string));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // DataTableデータバインド
                        datatable_memoria_list.Rows.Add(reader.GetString(0),
                                                        reader.GetString(1),
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        reader.GetString(4),
                                                        reader.GetString(5),
                                                        reader.GetString(6),
                                                        reader.GetString(7),
                                                        reader.GetString(8),
                                                        reader.GetString(9),
                                                        reader.GetString(10)
                                                       );
                    }
                }

                connection.Close();

                // DataGridViewデータバインド
                datagrid_memoria_list.DataSource = datatable_memoria_list;
                datagrid_memoria_list.Columns[0].Visible = false;
                datagrid_memoria_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                datagrid_memoria_list.Columns[1].FillWeight = 60;
                datagrid_memoria_list.Columns[2].FillWeight = 150;
                datagrid_memoria_list.Columns[3].FillWeight = 50;
                datagrid_memoria_list.Columns[4].FillWeight = 50;
                datagrid_memoria_list.Columns[5].FillWeight = 50;
                datagrid_memoria_list.Columns[6].FillWeight = 50;
                datagrid_memoria_list.Columns[7].FillWeight = 50;
                datagrid_memoria_list.Columns[8].FillWeight = 50;
                datagrid_memoria_list.Columns[9].FillWeight = 160;
                datagrid_memoria_list.Columns[10].FillWeight = 300;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            MemoriaDetailForAddOrEdit memoria_add_form = new MemoriaDetailForAddOrEdit();
            memoria_add_form.ShowDialog();
        }

        private void checkbox_Click(object sender, EventArgs e)
        {
            StringBuilder condition_sql = new StringBuilder();
            if (check_attr_1.Checked | check_attr_2.Checked | check_attr_3.Checked | check_attr_4.Checked |
            check_attr_5.Checked | check_attr_6.Checked | check_attr_7.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_attr_1.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '火') > 0 OR ";
                }
                if (check_attr_2.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '氷') > 0 OR ";
                }
                if (check_attr_3.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '雷') > 0 OR ";
                }
                if (check_attr_4.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '風') > 0 OR ";
                }
                if (check_attr_5.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '打') > 0 OR ";
                }
                if (check_attr_6.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '斬') > 0 OR ";
                }
                if (check_attr_7.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, '突') > 0 OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            if (check_ad_attr_1.Checked | check_ad_attr_2.Checked | check_ad_attr_3.Checked | check_ad_attr_4.Checked |
            check_ad_attr_5.Checked | check_ad_attr_6.Checked | check_ad_attr_7.Checked)
            {
                condition_sql.Append("AND (");
                string attribute_condition = "";
                if (check_ad_attr_1.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'ダメージアップ') > 0 OR ";
                }
                if (check_ad_attr_2.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'ブレイクアップ') > 0 OR ";
                }
                if (check_ad_attr_3.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'バーストアップ') > 0 OR ";
                }
                if (check_ad_attr_4.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'レジストダウン') > 0 OR ";
                }
                if (check_ad_attr_5.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'ドッジアップ') > 0 OR ";
                }
                if (check_ad_attr_6.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'ヒール') > 0 OR ";
                }
                if (check_ad_attr_7.Checked)
                {
                    attribute_condition += "INSTR(T0.MEMORIA_EFFECT, 'アイテム') > 0 OR ";
                }
                condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
                condition_sql.Append(")").AppendLine();
            }

            DataSelect(condition_sql.ToString());
        }
    }
}
