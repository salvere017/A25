using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;

namespace A25;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        InitDataBinding();
        DataSelect("");
    }

    private void InitDataBinding()
    {
        DataTable dataTable_gift = new DataTable();
        dataTable_gift.Columns.Add("GIFT_ID");
        dataTable_gift.Columns.Add("GIFT_NAME");
        DataTable dataTable_color = new DataTable();
        dataTable_color.Columns.Add("COLOR_EN");
        dataTable_color.Columns.Add("COLOR_JP");

        using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = " SELECT GIFT_ID, GIFT_NAME FROM ALL_GIFT_INFO_MST ";
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

            combo_gift.DataSource = dataTable_gift;
            // 表示用の列を設定
            combo_gift.DisplayMember = "GIFT_NAME";
            // データ用の列を設定
            combo_gift.ValueMember = "GIFT_ID";

            reader.Close();
            ///////////////////////////////////////////////////////////////////////////////////////
            var command2 = connection.CreateCommand();
            command2.CommandText = " SELECT COLOR_EN, COLOR_JP FROM ALL_COLOR_MST ";
            command2.ExecuteNonQuery();

            var reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                // DataTableにデータを追加
                DataRow row = dataTable_color.NewRow();
                row["COLOR_EN"] = reader2.GetString(0);
                row["COLOR_JP"] = reader2.GetString(1);
                dataTable_color.Rows.Add(row);
            }

            combo_color_left.DataSource = dataTable_color;
            // 表示用の列を設定
            combo_color_left.DisplayMember = "COLOR_JP";
            // データ用の列を設定
            combo_color_left.ValueMember = "COLOR_EN";

            combo_color_right.DataSource = dataTable_color.Copy();
            // 表示用の列を設定
            combo_color_right.DisplayMember = "COLOR_JP";
            // データ用の列を設定
            combo_color_right.ValueMember = "COLOR_EN";

            reader2.Close();

            ///////////////////////////////////////////////////////////////////////////////////////
            connection.Close();
        }
    }

    private void DataSelect(string checkbox_condition_sql)
    {
        using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
        {
            connection.Open();
            // SQLコマンド対象
            var command = connection.CreateCommand();

            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT T0.CHARACTER_CODE, ").AppendLine();
            sql.Append("        T0.CHARACTER, ").AppendLine();
            sql.Append("        T1.ATTRIBUTE, ").AppendLine();
            sql.Append("        T2.ROLE_NAME ").AppendLine();
            sql.Append(" FROM CHARA_BASE_INFO T0").AppendLine();
            sql.Append(" LEFT OUTER JOIN ALL_ATTRIBUTE_MST T1").AppendLine();
            sql.Append(" ON T1.ATTRIBUTE_CODE = T0.ATTRIBUTE").AppendLine();
            sql.Append(" LEFT OUTER JOIN ALL_ROLE_MST T2").AppendLine();
            sql.Append(" ON T2.ROLE_CODE = T0.ROLE ").AppendLine();
            sql.Append(checkbox_condition_sql).AppendLine();
            sql.Append(" ORDER BY T0.CHARACTER_CODE ASC");

            //SQL実行
            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();

            DataTable datatable_character_list = new DataTable();
            datatable_character_list.Columns.Add("キャラ番号", typeof(int));
            datatable_character_list.Columns.Add("キャラクター(フールネーム)", typeof(string));
            datatable_character_list.Columns.Add("属性", typeof(string));
            datatable_character_list.Columns.Add("ロール", typeof(string));

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // DataTableデータバインド
                    datatable_character_list.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
            }

            connection.Close();

            // DataGridViewデータバインド
            datagrid_character_list.DataSource = datatable_character_list;
            datagrid_character_list.Columns[0].Visible = false;
            datagrid_character_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }

    private void datagrid_character_list_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
    {
        CharacterDetail character_detail_form = new CharacterDetail((int)datagrid_character_list.CurrentRow.Cells[0].Value);
        character_detail_form.ShowDialog();
    }

    private void detail_info_button_Click(object sender, EventArgs e)
    {
        CharacterDetail character_detail_form = new CharacterDetail((int)datagrid_character_list.CurrentRow.Cells[0].Value);
        character_detail_form.ShowDialog();
    }

    private void memoria_button_Click(object sender, EventArgs e)
    {
        Memoria memoria_form = new Memoria();
        memoria_form.ShowDialog();
    }

    private void atelier_menu_button_Click(object sender, EventArgs e)
    {
        AtelierMenu atelier_menu = new AtelierMenu();
        atelier_menu.ShowDialog();
    }

    private void character_add_button_Click(object sender, EventArgs e)
    {
        using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
        {
            connection.Open();
            // SQLコマンド対象
            var command = connection.CreateCommand();

            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT MAX(T0.CHARACTER_CODE) + 1 AS CHARACTER_CODE");
            sql.Append(" FROM CHARA_BASE_INFO T0");

            //SQL実行
            command.CommandText = sql.ToString();
            command.ExecuteNonQuery();

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    int character_code = reader.GetInt32(0);
                    connection.Close();
                    CharacterDetailForAddOrEdit add_character_form = new CharacterDetailForAddOrEdit(character_code);
                    add_character_form.ShowDialog();
                }
            }
        }
    }

    private void research_result(object sender, EventArgs e)
    {
        StringBuilder condition_sql = new StringBuilder();
        condition_sql.Append(" WHERE 1 = 1 ").AppendLine();
        if (check_sex_female.Checked | check_sex_male.Checked | check_sex_other.Checked)
        {
            condition_sql.Append("AND (");
            string sex_condition = "";
            if (check_sex_female.Checked)
            {
                sex_condition += "T0.SEX = 0 OR ";
            }
            if (check_sex_male.Checked)
            {
                sex_condition += "T0.SEX = 1 OR ";
            }
            if (check_sex_other.Checked)
            {
                sex_condition += "T0.SEX = 2 OR ";
            }
            condition_sql.Append(sex_condition.Substring(0, sex_condition.Length - 3));
            condition_sql.Append(")").AppendLine();
        }

        if (check_role_a.Checked | check_role_b.Checked | check_role_d.Checked | check_role_s.Checked)
        {
            condition_sql.Append("AND (");
            string role_condition = "";
            if (check_role_a.Checked)
            {
                role_condition += "T0.ROLE = 1 OR ";
            }
            if (check_role_b.Checked)
            {
                role_condition += "T0.ROLE = 2 OR ";
            }
            if (check_role_d.Checked)
            {
                role_condition += "T0.ROLE = 3 OR ";
            }
            if (check_role_s.Checked)
            {
                role_condition += "T0.ROLE = 4 OR ";
            }
            condition_sql.Append(role_condition.Substring(0, role_condition.Length - 3));
            condition_sql.Append(")").AppendLine();
        }

        if (check_attr_1.Checked | check_attr_2.Checked | check_attr_3.Checked | check_attr_4.Checked |
            check_attr_5.Checked | check_attr_6.Checked | check_attr_7.Checked)
        {
            condition_sql.Append("AND (");
            string attribute_condition = "";
            if (check_attr_1.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 1 OR ";
            }
            if (check_attr_2.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 2 OR ";
            }
            if (check_attr_3.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 3 OR ";
            }
            if (check_attr_4.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 4 OR ";
            }
            if (check_attr_5.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 5 OR ";
            }
            if (check_attr_6.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 6 OR ";
            }
            if (check_attr_7.Checked)
            {
                attribute_condition += "T0.ATTRIBUTE = 7 OR ";
            }
            condition_sql.Append(attribute_condition.Substring(0, attribute_condition.Length - 3));
            condition_sql.Append(")").AppendLine();
        }

        if (check_gift.Checked)
        {
            condition_sql.Append(" AND EXISTS (");
            condition_sql.Append("             SELECT 1");
            condition_sql.Append("             FROM CHARA_GIFT_INFO T3");
            condition_sql.Append("             WHERE T3.CHARACTER_CODE = T0.CHARACTER_CODE");
            condition_sql.Append("             AND(  T3.GIFT1 = ").Append(combo_gift.SelectedValue);
            condition_sql.Append("                OR T3.GIFT2 = ").Append(combo_gift.SelectedValue);
            condition_sql.Append("                OR T3.GIFT3 = ").Append(combo_gift.SelectedValue);
            condition_sql.Append("                )");
            condition_sql.Append(" )").AppendLine();
        }

        if (check_left_color.Checked)
        {
            condition_sql.Append(" AND EXISTS (");
            condition_sql.Append("             SELECT 1");
            condition_sql.Append("             FROM CHARA_GIFT_INFO T3");
            condition_sql.Append("             WHERE T3.CHARACTER_CODE = T0.CHARACTER_CODE");
            condition_sql.Append("             AND   T3.LEFT_COLOR = '").Append(combo_color_left.SelectedValue).Append("'");
            condition_sql.Append(" )").AppendLine();
        }

        if (check_right_color.Checked)
        {
            condition_sql.Append(" AND EXISTS (");
            condition_sql.Append("             SELECT 1");
            condition_sql.Append("             FROM CHARA_GIFT_INFO T3");
            condition_sql.Append("             WHERE T3.CHARACTER_CODE = T0.CHARACTER_CODE");
            condition_sql.Append("             AND   T3.RIGHT_COLOR = '").Append(combo_color_right.SelectedValue).Append("'");
            condition_sql.Append(" )").AppendLine();
        }

        //データ再バインド
        DataSelect(condition_sql.ToString());
    }
    private void clear_button_button_Click(object sender, EventArgs e)
    {
        check_sex_male.Checked = false;
        check_sex_female.Checked = false;
        check_sex_other.Checked = false;
        check_role_a.Checked = false;
        check_role_b.Checked = false;
        check_role_d.Checked = false;
        check_role_s.Checked = false;
        check_attr_1.Checked = false;
        check_attr_2.Checked = false;
        check_attr_3.Checked = false;
        check_attr_4.Checked = false;
        check_attr_5.Checked = false;
        check_attr_6.Checked = false;
        check_attr_7.Checked = false;
    }

    private void all_select_button_button_Click(object sender, EventArgs e)
    {
        check_sex_male.Checked = true;
        check_sex_female.Checked = true;
        check_sex_other.Checked = true;
        check_role_a.Checked = true;
        check_role_b.Checked = true;
        check_role_d.Checked = true;
        check_role_s.Checked = true;
        check_attr_1.Checked = true;
        check_attr_2.Checked = true;
        check_attr_3.Checked = true;
        check_attr_4.Checked = true;
        check_attr_5.Checked = true;
        check_attr_6.Checked = true;
        check_attr_7.Checked = true;
    }

    private void gift_select_button_button_Click(object sender, EventArgs e)
    {
        if (check_gift.Checked & check_left_color.Checked & check_right_color.Checked)
        {
            check_gift.Checked = false;
            check_left_color.Checked = false;
            check_right_color.Checked = false;
        }
        else
        {
            check_gift.Checked = true;
            check_left_color.Checked = true;
            check_right_color.Checked = true;
        }
    }
}
