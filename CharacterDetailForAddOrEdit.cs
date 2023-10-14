using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;

namespace A25
{
    public partial class CharacterDetailForAddOrEdit : Form
    {

        private int character_id;
        public CharacterDetailForAddOrEdit(int character_code)
        {
            character_id = character_code;
            InitializeComponent();
            InitComboBox();
            avater_img_load(0);
            lr_color_img_load(0);
        }

        private void Submit_button_Click(object sender, EventArgs e)
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
                    sql.Append(" INSERT INTO CHARA_BASE_INFO (").AppendLine();
                    sql.Append("     CHARACTER_CODE, ").AppendLine();
                    sql.Append("     CHARACTER, ").AppendLine();
                    sql.Append("     ATTRIBUTE, ").AppendLine();
                    sql.Append("     ROLE, ").AppendLine();
                    sql.Append("     SEX").AppendLine();
                    sql.Append(" )").AppendLine();
                    sql.Append(" VALUES (").AppendLine();
                    sql.Append("     :CHARACTER_CODE,").AppendLine();
                    sql.Append("     :CHARACTER,").AppendLine();
                    sql.Append("     :ATTRIBUTE,").AppendLine();
                    sql.Append("     :ROLE,").AppendLine();
                    sql.Append("     :SEX").AppendLine();
                    sql.Append(" )").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":CHARACTER_CODE", character_id);
                    command.Parameters.AddWithValue(":CHARACTER", textbox_character.Text);
                    command.Parameters.AddWithValue(":ATTRIBUTE", combobox_attribute_name.SelectedValue);
                    command.Parameters.AddWithValue(":ROLE", combobox_role_name.SelectedValue);
                    command.Parameters.AddWithValue(":SEX", comboBox_sex_value.SelectedValue);
                    command.ExecuteNonQuery();

                    //スキルデータの登録
                    sql.Clear();
                    sql.Append(" INSERT INTO CHARA_SKILL_INFO (").AppendLine();
                    sql.Append("     CHARACTER_CODE, ").AppendLine();
                    sql.Append("     SKILL1_NAME, ").AppendLine();
                    sql.Append("     SKILL1_TARGET_OBJ, ").AppendLine();
                    sql.Append("     SKILL1_DAMEGE, ").AppendLine();
                    sql.Append("     SKILL1_BREAK, ").AppendLine();
                    sql.Append("     SKILL1_RECOVERY, ").AppendLine();
                    sql.Append("     SKILL1_WEIGHT, ").AppendLine();
                    sql.Append("     SKILL1_COMMENT, ").AppendLine();
                    sql.Append("     SKILL2_NAME, ").AppendLine();
                    sql.Append("     SKILL2_TARGET_OBJ, ").AppendLine();
                    sql.Append("     SKILL2_DAMEGE, ").AppendLine();
                    sql.Append("     SKILL2_BREAK, ").AppendLine();
                    sql.Append("     SKILL2_RECOVERY, ").AppendLine();
                    sql.Append("     SKILL2_WEIGHT, ").AppendLine();
                    sql.Append("     SKILL2_COMMENT, ").AppendLine();
                    sql.Append("     SKILL3_NAME, ").AppendLine();
                    sql.Append("     SKILL3_TARGET_OBJ, ").AppendLine();
                    sql.Append("     SKILL3_DAMEGE, ").AppendLine();
                    sql.Append("     SKILL3_BREAK, ").AppendLine();
                    sql.Append("     SKILL3_RECOVERY, ").AppendLine();
                    sql.Append("     SKILL3_WEIGHT, ").AppendLine();
                    sql.Append("     SKILL3_COMMENT").AppendLine();
                    sql.Append(" )").AppendLine();
                    sql.Append(" VALUES (").AppendLine();
                    sql.Append("     :SQL1PARAM0,").AppendLine();
                    sql.Append("     :SQL1PARAM1,").AppendLine();
                    sql.Append("     :SQL1PARAM2,").AppendLine();
                    sql.Append("     :SQL1PARAM3,").AppendLine();
                    sql.Append("     :SQL1PARAM4,").AppendLine();
                    sql.Append("     :SQL1PARAM5,").AppendLine();
                    sql.Append("     :SQL1PARAM6,").AppendLine();
                    sql.Append("     :SQL1PARAM7,").AppendLine();
                    sql.Append("     :SQL1PARAM8,").AppendLine();
                    sql.Append("     :SQL1PARAM9,").AppendLine();
                    sql.Append("     :SQL1PARAM10,").AppendLine();
                    sql.Append("     :SQL1PARAM11,").AppendLine();
                    sql.Append("     :SQL1PARAM12,").AppendLine();
                    sql.Append("     :SQL1PARAM13,").AppendLine();
                    sql.Append("     :SQL1PARAM14,").AppendLine();
                    sql.Append("     :SQL1PARAM15,").AppendLine();
                    sql.Append("     :SQL1PARAM16,").AppendLine();
                    sql.Append("     :SQL1PARAM17,").AppendLine();
                    sql.Append("     :SQL1PARAM18,").AppendLine();
                    sql.Append("     :SQL1PARAM19,").AppendLine();
                    sql.Append("     :SQL1PARAM20,").AppendLine();
                    sql.Append("     :SQL1PARAM21").AppendLine();
                    sql.Append(" )").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":SQL1PARAM0", character_id);
                    command.Parameters.AddWithValue(":SQL1PARAM1", textbox_skill1.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM2", combobox_range1.SelectedValue);
                    command.Parameters.AddWithValue(":SQL1PARAM3", textbox_damage1_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM4", textbox_break1_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM5", textbox_recovery1_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM6", textbox_weight1_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM7", textbox_effect1_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM8", textbox_skill2.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM9", combobox_range2.SelectedValue);
                    command.Parameters.AddWithValue(":SQL1PARAM10", textbox_damage2_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM11", textbox_break2_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM12", textbox_recovery2_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM13", textbox_weight2_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM14", textbox_effect2_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM15", textbox_skill3.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM16", combobox_range3.SelectedValue);
                    command.Parameters.AddWithValue(":SQL1PARAM17", textbox_damage3_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM18", textbox_break3_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM19", textbox_recovery3_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM20", textbox_weight3_value.Text);
                    command.Parameters.AddWithValue(":SQL1PARAM21", textbox_effect3_value.Text);
                    command.ExecuteNonQuery();

                    //アビリティデータの登録
                    sql.Clear();
                    sql.Append(" INSERT INTO CHARA_ABILITY_INFO (").AppendLine();
                    sql.Append("     CHARACTER_CODE, ").AppendLine();
                    sql.Append("     ABILITY1, ").AppendLine();
                    sql.Append("     ABILITY1_COMMENT, ").AppendLine();
                    sql.Append("     ABILITY2, ").AppendLine();
                    sql.Append("     ABILITY2_COMMENT").AppendLine();
                    sql.Append(" )").AppendLine();
                    sql.Append(" VALUES (").AppendLine();
                    sql.Append("     :SQL2PARAM1,").AppendLine();
                    sql.Append("     :SQL2PARAM2,").AppendLine();
                    sql.Append("     :SQL2PARAM3,").AppendLine();
                    sql.Append("     :SQL2PARAM4,").AppendLine();
                    sql.Append("     :SQL2PARAM5").AppendLine();
                    sql.Append(" )").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":SQL2PARAM1", character_id);
                    command.Parameters.AddWithValue(":SQL2PARAM2", textbox_ability1_name.Text);
                    command.Parameters.AddWithValue(":SQL2PARAM3", textbox_ability1_value.Text);
                    command.Parameters.AddWithValue(":SQL2PARAM4", textbox_ability2_name.Text);
                    command.Parameters.AddWithValue(":SQL2PARAM5", textbox_ability2_value.Text);
                    command.ExecuteNonQuery();

                    //能力データの登録
                    sql.Clear();
                    sql.Append(" INSERT INTO CHARA_PROPERTIES (").AppendLine();
                    sql.Append("     CHARACTER_CODE, ").AppendLine();
                    sql.Append("     HP, ").AppendLine();
                    sql.Append("     PHYSICS_ATTACK, ").AppendLine();
                    sql.Append("     PHYSICS_DENFENCE, ").AppendLine();
                    sql.Append("     MAGIC_ATTACK, ").AppendLine();
                    sql.Append("     MAGIC_DENFENCE, ").AppendLine();
                    sql.Append("     SPEED").AppendLine();
                    sql.Append(" )").AppendLine();
                    sql.Append(" VALUES (").AppendLine();
                    sql.Append("     :SQL3PARAM1,").AppendLine();
                    sql.Append("     :SQL3PARAM2,").AppendLine();
                    sql.Append("     :SQL3PARAM3,").AppendLine();
                    sql.Append("     :SQL3PARAM4,").AppendLine();
                    sql.Append("     :SQL3PARAM5,").AppendLine();
                    sql.Append("     :SQL3PARAM6,").AppendLine();
                    sql.Append("     :SQL3PARAM7").AppendLine();
                    sql.Append(" )").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":SQL3PARAM1", character_id);
                    command.Parameters.AddWithValue(":SQL3PARAM2", textbox_hp_value.Text);
                    command.Parameters.AddWithValue(":SQL3PARAM3", textbox_ph_attack_value.Text);
                    command.Parameters.AddWithValue(":SQL3PARAM4", textbox_ph_defend_value.Text);
                    command.Parameters.AddWithValue(":SQL3PARAM5", textbox_magic_atk_value.Text);
                    command.Parameters.AddWithValue(":SQL3PARAM6", textbox_magic_defend_value.Text);
                    command.Parameters.AddWithValue(":SQL3PARAM7", textbox_speed_value.Text);
                    command.ExecuteNonQuery();

                    //ギフトデータの登録
                    sql.Clear();
                    sql.Append(" INSERT INTO CHARA_GIFT_INFO (").AppendLine();
                    sql.Append("     CHARACTER_CODE, ").AppendLine();
                    sql.Append("     GIFT1, ").AppendLine();
                    sql.Append("     GIFT2, ").AppendLine();
                    sql.Append("     GIFT3, ").AppendLine();
                    sql.Append("     LEFT_COLOR, ").AppendLine();
                    sql.Append("     RIGHT_COLOR").AppendLine();
                    sql.Append(" )").AppendLine();
                    sql.Append(" VALUES (").AppendLine();
                    sql.Append("     :SQL4PARAM1,").AppendLine();
                    sql.Append("     :SQL4PARAM2,").AppendLine();
                    sql.Append("     :SQL4PARAM3,").AppendLine();
                    sql.Append("     :SQL4PARAM4,").AppendLine();
                    sql.Append("     :SQL4PARAM5,").AppendLine();
                    sql.Append("     :SQL4PARAM6").AppendLine();
                    sql.Append(" )").AppendLine();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue(":SQL4PARAM1", character_id);
                    command.Parameters.AddWithValue(":SQL4PARAM2", combobox_gift1_name.SelectedValue);
                    command.Parameters.AddWithValue(":SQL4PARAM3", combobox_gift2_name.SelectedValue);
                    command.Parameters.AddWithValue(":SQL4PARAM4", combobox_gift3_name.SelectedValue);
                    command.Parameters.AddWithValue(":SQL4PARAM5", comboBox_left_color.SelectedValue);
                    command.Parameters.AddWithValue(":SQL4PARAM6", comboBox_right_color.SelectedValue);
                    command.ExecuteNonQuery();

                    connection.Close();
                }

                MessageBox.Show("登録完了!");
            }
            else
            {
                MessageBox.Show("入力不正があります!");
            }
        }

        private Boolean CheckInput()
        {
            //カードフールネーム
            if (textbox_character.Text.Equals(""))
            {
                return false;
            }
            ////
            //if (combobox_role_name.SelectedValue.ToString().Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            //if (textbox_character.Text.Equals(""))
            //{
            //    return false;
            //}
            return true;
        }

        private void InitComboBox()
        {
            // DataTableを作成
            DataTable dataTable_attr = new DataTable();
            dataTable_attr.Columns.Add("ATTRIBUTE_CODE");
            dataTable_attr.Columns.Add("ATTRIBUTE");

            DataTable dataTable_role = new DataTable();
            dataTable_role.Columns.Add("ROLE_CODE");
            dataTable_role.Columns.Add("ROLE_NAME");

            DataTable dataTable_gift = new DataTable();
            dataTable_gift.Columns.Add("GIFT_ID");
            dataTable_gift.Columns.Add("GIFT_NAME");

            DataTable dataTable_range = new DataTable();
            dataTable_range.Columns.Add("TARGET_OBJ_CODE");
            dataTable_range.Columns.Add("TARGET");

            DataTable dataTable_sex = new DataTable();
            dataTable_sex.Columns.Add("SEX_CODE");
            dataTable_sex.Columns.Add("SEX_NAME");

            DataTable dataTable_color = new DataTable();
            dataTable_color.Columns.Add("COLOR_EN");
            dataTable_color.Columns.Add("COLOR_JP");

            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT ATTRIBUTE_CODE, ATTRIBUTE FROM ALL_ATTRIBUTE_MST ";
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_attr.NewRow();
                    row["ATTRIBUTE_CODE"] = reader.GetString(0);
                    row["ATTRIBUTE"] = reader.GetString(1);
                    dataTable_attr.Rows.Add(row);
                }

                combobox_attribute_name.DataSource = dataTable_attr;
                // 表示用の列を設定
                combobox_attribute_name.DisplayMember = "ATTRIBUTE";
                // データ用の列を設定
                combobox_attribute_name.ValueMember = "ATTRIBUTE_CODE";

                reader.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT ROLE_CODE, ROLE_NAME FROM ALL_ROLE_MST ";
                command.ExecuteNonQuery();

                var reader2 = command.ExecuteReader();
                while (reader2.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_role.NewRow();
                    row["ROLE_CODE"] = reader2.GetString(0);
                    row["ROLE_NAME"] = reader2.GetString(1);
                    dataTable_role.Rows.Add(row);
                }

                combobox_role_name.DataSource = dataTable_role;
                // 表示用の列を設定
                combobox_role_name.DisplayMember = "ROLE_NAME";
                // データ用の列を設定
                combobox_role_name.ValueMember = "ROLE_CODE";

                reader2.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT GIFT_ID, GIFT_NAME FROM ALL_GIFT_INFO_MST ";
                command.ExecuteNonQuery();

                var reader3 = command.ExecuteReader();
                while (reader3.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_gift.NewRow();
                    row["GIFT_ID"] = reader3.GetString(0);
                    row["GIFT_NAME"] = reader3.GetString(1);
                    dataTable_gift.Rows.Add(row);
                }

                combobox_gift1_name.DataSource = dataTable_gift;
                // 表示用の列を設定
                combobox_gift1_name.DisplayMember = "GIFT_NAME";
                // データ用の列を設定
                combobox_gift1_name.ValueMember = "GIFT_ID";

                combobox_gift2_name.DataSource = dataTable_gift.Copy();
                // 表示用の列を設定
                combobox_gift2_name.DisplayMember = "GIFT_NAME";
                // データ用の列を設定
                combobox_gift2_name.ValueMember = "GIFT_ID";

                combobox_gift3_name.DataSource = dataTable_gift.Copy();
                // 表示用の列を設定
                combobox_gift3_name.DisplayMember = "GIFT_NAME";
                // データ用の列を設定
                combobox_gift3_name.ValueMember = "GIFT_ID";

                reader3.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT TARGET_OBJ_CODE, TARGET FROM ALL_TARGET_RANGE_MST ";
                command.ExecuteNonQuery();

                var reader4 = command.ExecuteReader();
                while (reader4.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_range.NewRow();
                    row["TARGET_OBJ_CODE"] = reader4.GetString(0);
                    row["TARGET"] = reader4.GetString(1);
                    dataTable_range.Rows.Add(row);
                }

                combobox_range1.DataSource = dataTable_range;
                // 表示用の列を設定
                combobox_range1.DisplayMember = "TARGET";
                // データ用の列を設定
                combobox_range1.ValueMember = "TARGET_OBJ_CODE";

                combobox_range2.DataSource = dataTable_range.Copy();
                // 表示用の列を設定
                combobox_range2.DisplayMember = "TARGET";
                // データ用の列を設定
                combobox_range2.ValueMember = "TARGET_OBJ_CODE";

                combobox_range3.DataSource = dataTable_range.Copy();
                // 表示用の列を設定
                combobox_range3.DisplayMember = "TARGET";
                // データ用の列を設定
                combobox_range3.ValueMember = "TARGET_OBJ_CODE";

                reader4.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT SEX_CODE, SEX_NAME FROM ALL_SEX_MST ";
                command.ExecuteNonQuery();

                var reader5 = command.ExecuteReader();
                while (reader5.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_sex.NewRow();
                    row["SEX_CODE"] = reader5.GetString(0);
                    row["SEX_NAME"] = reader5.GetString(1);
                    dataTable_sex.Rows.Add(row);
                }

                comboBox_sex_value.DataSource = dataTable_sex;
                // 表示用の列を設定
                comboBox_sex_value.DisplayMember = "SEX_NAME";
                // データ用の列を設定
                comboBox_sex_value.ValueMember = "SEX_CODE";

                reader5.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                command.CommandText = " SELECT COLOR_EN, COLOR_JP FROM ALL_COLOR_MST ";
                command.ExecuteNonQuery();

                var reader6 = command.ExecuteReader();
                while (reader6.Read())
                {
                    // DataTableにデータを追加
                    DataRow row = dataTable_color.NewRow();
                    row["COLOR_EN"] = reader6.GetString(0);
                    row["COLOR_JP"] = reader6.GetString(1);
                    dataTable_color.Rows.Add(row);
                }

                comboBox_left_color.DataSource = dataTable_color;
                // 表示用の列を設定
                comboBox_left_color.DisplayMember = "COLOR_JP";
                // データ用の列を設定
                comboBox_left_color.ValueMember = "COLOR_EN";

                comboBox_right_color.DataSource = dataTable_color.Copy();
                // 表示用の列を設定
                comboBox_right_color.DisplayMember = "COLOR_JP";
                // データ用の列を設定
                comboBox_right_color.ValueMember = "COLOR_EN";

                reader6.Close();

                ///////////////////////////////////////////////////////////////////////////////////////
                connection.Close();
            }

        }

        private void avater_img_load(int character_id)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = " SELECT AVATAR FROM CHARA_IMG WHERE CHARACTER_CODE = @ID ";
                command.Parameters.AddWithValue("@ID", character_id);
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    byte[] data1 = (byte[])reader["AVATAR"];
                    Bitmap bmp_avater1 = Common.ByteToImage(data1);

                    //ImageオブジェクトのGraphicsオブジェクトを作成する
                    Graphics graphics1 = pic_avater.CreateGraphics();

                    //PictureBoxのImageプロパティに設定する
                    pic_avater.Image = bmp_avater1;

                    //描画
                    graphics1.DrawImage(pic_avater.Image, pic_avater.Location);
                }

                connection.Close();
            }
        }

        private void lr_color_img_load(int character_id)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = " SELECT ITEM_COLOR_LR FROM CHARA_IMG WHERE CHARACTER_CODE = @ID ";
                command.Parameters.AddWithValue("@ID", character_id);
                command.ExecuteNonQuery();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    byte[] data2 = (byte[])reader["ITEM_COLOR_LR"];
                    Bitmap bmp_avater2 = Common.ByteToImage(data2);

                    //ImageオブジェクトのGraphicsオブジェクトを作成する
                    Graphics graphics2 = pic_color_lr.CreateGraphics();

                    //PictureBoxのImageプロパティに設定する
                    pic_color_lr.Image = bmp_avater2;

                    //描画
                    graphics2.DrawImage(pic_color_lr.Image, pic_color_lr.Location);
                }

                connection.Close();
            }
        }

        private void savePicture(int character_code, string img_avater, string img_lr_color)
        {
            using (var connection = new SqliteConnection(Common.DatabaseLocalPath))
            {
                connection.Open();

                var command = connection.CreateCommand();
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO CHARA_IMG ").AppendLine();
                if (!img_avater.Equals("") && img_lr_color.Equals(""))
                {

                    sql.Append(" VALUES($ID, @file, NULL ) ").AppendLine();
                    sql.Append(" ON CONFLICT(CHARACTER_CODE) ").AppendLine();
                    sql.Append(" DO UPDATE SET AVATAR =@file ").AppendLine();
                    FileStream fileStream = new FileStream(img_avater, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] fileBytes = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("$ID", character_code);
                    command.Parameters.AddWithValue("@file", fileBytes);
                    command.ExecuteNonQuery();
                    connection.Close();
                    avater_img_load(character_code);
                }
                else if (!img_lr_color.Equals("") && img_avater.Equals(""))
                {
                    sql.Append(" VALUES($ID, NULL, @file ) ").AppendLine();
                    sql.Append(" ON CONFLICT(CHARACTER_CODE) ").AppendLine();
                    sql.Append(" DO UPDATE SET ITEM_COLOR_LR = @file ").AppendLine();
                    FileStream fileStream = new FileStream(img_lr_color, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] fileBytes = binaryReader.ReadBytes((int)fileStream.Length);
                    binaryReader.Close();
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("$ID", character_code);
                    command.Parameters.AddWithValue("@file", fileBytes);
                    command.ExecuteNonQuery();
                    connection.Close();
                    lr_color_img_load(character_code);
                }
                else
                {
                    MessageBox.Show("イメージ読み取り失敗！");
                }
            }
        }

        private void pic_avater_Click(object sender, EventArgs e)
        {
            string path_avater = "";
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                path_avater = ofd.FileName;
            }

            savePicture(character_id, path_avater, "");
        }

        private void pic_color_lr_Click(object sender, EventArgs e)
        {
            string path_color_lr = "";
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                path_color_lr = ofd.FileName;
            }

            savePicture(character_id, "", path_color_lr);
        }
    }
}
