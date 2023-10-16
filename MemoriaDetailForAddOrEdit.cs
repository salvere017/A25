using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A25
{
    public partial class MemoriaDetailForAddOrEdit : Form
    {
        public MemoriaDetailForAddOrEdit()
        {
            InitializeComponent();
            InitComboBox();
        }

        private void InitComboBox()
        {
            DataTable dataTable_rare = new DataTable();
            dataTable_rare.Columns.Add("RARE");

            DataRow row1 = dataTable_rare.NewRow();
            DataRow row2 = dataTable_rare.NewRow();
            DataRow row3 = dataTable_rare.NewRow();
            row1["RARE"] = "R";
            row2["RARE"] = "SR";
            row3["RARE"] = "SSR";
            dataTable_rare.Rows.Add(row1);
            dataTable_rare.Rows.Add(row2);
            dataTable_rare.Rows.Add(row3);

            combobox_rare.DataSource = dataTable_rare;
            // 表示用の列を設定
            combobox_rare.DisplayMember = "RARE";
            // データ用の列を設定
            combobox_rare.ValueMember = "RARE";
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    StringBuilder sql = new StringBuilder();

                    //基本データの登録
                    sql.Clear();
                    sql.Append(" INSERT INTO MEMORIA_INFO ").AppendLine();
                    sql.Append(" SELECT MAX(MEMORIA_ID) + 1 AS MEMORIA_ID, ").AppendLine();
                    sql.Append("        :RARE, ").AppendLine();
                    sql.Append("        :MEMORIA_NAME, ").AppendLine();
                    sql.Append("        REPLACE(:HP, '%', '') || '%' AS HP, ").AppendLine();
                    sql.Append("        REPLACE(:SPEED, '%', '') || '%' AS SPEED, ").AppendLine();
                    sql.Append("        REPLACE(:PHYSICS_ATTACK, '%', '') || '%' AS PHYSICS_ATTACK, ").AppendLine();
                    sql.Append("        REPLACE(:PHYSICS_DENFENCE, '%', '') || '%' AS PHYSICS_DENFENCE, ").AppendLine();
                    sql.Append("        REPLACE(:MAGIC_ATTACK, '%', '') || '%' AS MAGIC_ATTACK, ").AppendLine();
                    sql.Append("        REPLACE(:MAGIC_DENFENCE, '%', '') || '%' AS MAGIC_DENFENCE, ").AppendLine();
                    sql.Append("        :MEMORIA_EFFECT, ").AppendLine();
                    sql.Append("        :MEMORIA_EFFECT_INFO ").AppendLine();
                    sql.Append(" FROM MEMORIA_INFO ").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":RARE", combobox_rare.SelectedValue);
                    command.Parameters.AddWithValue(":MEMORIA_NAME", textbox_memoria_name.Text);
                    command.Parameters.AddWithValue(":HP", textbox_hp_value.Text);
                    command.Parameters.AddWithValue(":SPEED", textbox_speed_value.Text);
                    command.Parameters.AddWithValue(":PHYSICS_ATTACK", textbox_ph_attack_value.Text);
                    command.Parameters.AddWithValue(":PHYSICS_DENFENCE", textbox_ph_defend_value.Text);
                    command.Parameters.AddWithValue(":MAGIC_ATTACK", textbox_magic_atk_value.Text);
                    command.Parameters.AddWithValue(":MAGIC_DENFENCE", textbox_magic_defend_value.Text);
                    command.Parameters.AddWithValue(":MEMORIA_EFFECT", textbox_ability1_name.Text);
                    command.Parameters.AddWithValue(":MEMORIA_EFFECT_INFO", textbox_ability1_value.Text);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("登録完了!");
                Close();
            }
            else
            {
                MessageBox.Show("入力不正があります!");
            }
        }

        private Boolean CheckInput()
        {
            if (textbox_memoria_name.Text.Equals(""))
            {
                return false;
            }
            if (textbox_hp_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_speed_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_ph_attack_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_ph_defend_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_magic_atk_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_magic_defend_value.Text.Equals(""))
            {
                return false;
            }
            if (textbox_ability1_name.Text.Equals(""))
            {
                return false;
            }
            if (textbox_ability1_value.Text.Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}
