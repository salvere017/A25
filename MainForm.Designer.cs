namespace A25;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        datagrid_character_list = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)datagrid_character_list).BeginInit();
        SuspendLayout();
        // 
        // datagrid_character_list
        //
        dataGridViewCellStyle1.BackColor = Color.Navy;
        dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        datagrid_character_list.AllowUserToAddRows = false;
        //datagrid_character_list.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.;
        datagrid_character_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        datagrid_character_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        datagrid_character_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        datagrid_character_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        datagrid_character_list.AllowUserToResizeRows = false;
        datagrid_character_list.ColumnHeadersHeight = 40;
        datagrid_character_list.GridColor = Color.Black;
        datagrid_character_list.Location = new Point(0, 0);
        datagrid_character_list.MultiSelect = false;
        datagrid_character_list.Name = "datagrid_character_list";
        datagrid_character_list.ReadOnly = true;
        datagrid_character_list.RowHeadersVisible = false;
        datagrid_character_list.RowTemplate.Height = 33;
        datagrid_character_list.ScrollBars = ScrollBars.Vertical;
        datagrid_character_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        datagrid_character_list.Size = new Size(497, 720);
        datagrid_character_list.TabIndex = 0;
        datagrid_character_list.CellDoubleClick += datagrid_character_list_CellDoubleClick;
        //
        //datagridviewPanel
        //
        datagridviewPanel.Controls.Add(datagrid_character_list);
        datagridviewPanel.Size = new Size(480, 700);
        datagridviewPanel.Location = new Point(0, 0);
        //
        //detail_info_button
        //
        detail_info_button.Text = "キャラ詳細情報";
        detail_info_button.Location = new Point(10, 10);
        detail_info_button.AutoSize = false;
        detail_info_button.Size = new Size(100, 35);
        detail_info_button.Click += new EventHandler(detail_info_button_Click);
        //
        //character_add_button
        //
        character_add_button.Text = "新規キャラ追加";
        character_add_button.Location = new Point(120, 10);
        character_add_button.AutoSize = false;
        character_add_button.Size = new Size(100, 35);
        character_add_button.Click += new EventHandler(character_add_button_Click);
        //
        //atelier_menu_button
        //
        atelier_menu_button.Text = "ア ト リ エ";
        atelier_menu_button.Location = new Point(230, 10);
        atelier_menu_button.AutoSize = false;
        atelier_menu_button.Size = new Size(100, 35);
        atelier_menu_button.Click += new EventHandler(atelier_menu_button_Click);
        //
        //memoria_button
        //
        memoria_button.Text = "メモリア一覧";
        memoria_button.Location = new Point(340, 10);
        memoria_button.AutoSize = false;
        memoria_button.Size = new Size(100, 35);
        memoria_button.Click += new EventHandler(memoria_button_Click);
        //
        //buttonPanel
        //
        buttonPanel.Controls.Add(detail_info_button);
        buttonPanel.Controls.Add(character_add_button);
        buttonPanel.Controls.Add(atelier_menu_button);
        buttonPanel.Controls.Add(memoria_button);
        buttonPanel.Size = new Size(800, 50);
        buttonPanel.Location = new Point(0, 700);
        //////////////////////////////////////////////////////////////////////////////////////////////
        // 
        // label_conditions
        // 
        label_conditions.Font = new Font("メイリオ", 20F, FontStyle.Bold, GraphicsUnit.Point);
        label_conditions.Location = new Point(20, 20);
        label_conditions.TextAlign = ContentAlignment.MiddleLeft;
        label_conditions.Size = new Size(220,50);
        label_conditions.Name = "label_conditions";
        label_conditions.Text = "フィルター条件設定";
        label_conditions.ForeColor = Color.Black;
        //
        // clear_button
        //
        clear_button.Text = "条件クリア";
        clear_button.Location = new Point(20, 80);
        clear_button.AutoSize = false;
        clear_button.Size = new Size(100, 25);
        clear_button.BackColor = Color.WhiteSmoke;
        clear_button.Click += new EventHandler(clear_button_button_Click);
        //
        // all_select_button
        //
        all_select_button.Text = "全部選択";
        all_select_button.Location = new Point(160, 80);
        all_select_button.AutoSize = false;
        all_select_button.Size = new Size(100, 25);
        all_select_button.BackColor = Color.WhiteSmoke;
        all_select_button.Click += new EventHandler(all_select_button_button_Click);
        //////////////////////////////////////////////////////////////////////////////////////////////
        // 
        // label_sex
        // 
        label_sex.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        label_sex.Location = new Point(20, 140);
        label_sex.Name = "label_sex";
        label_sex.AutoSize = true;
        label_sex.Text = "性別";
        label_sex.ForeColor = Color.Black;
        // 
        // check_sex_male
        // 
        check_sex_male.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_sex_male.Location = new Point(100, 140);
        check_sex_male.Name = "check_sex_male";
        check_sex_male.AutoSize = true;
        check_sex_male.Text = "男";
        check_sex_male.ForeColor = Color.Black;
        check_sex_male.CheckedChanged += new EventHandler(research_result);
        // 
        // check_sex_female
        // 
        check_sex_female.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_sex_female.Location = new Point(170, 140);
        check_sex_female.Name = "check_sex_female";
        check_sex_female.AutoSize = true;
        check_sex_female.Text = "女";
        check_sex_female.ForeColor = Color.Black;
        check_sex_female.CheckedChanged += new EventHandler(research_result);
        // 
        // check_sex_other
        // 
        check_sex_other.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_sex_other.Location = new Point(240, 140);
        check_sex_other.Name = "check_sex_other";
        check_sex_other.AutoSize = true;
        check_sex_other.Text = "その他";
        check_sex_other.ForeColor = Color.Black;
        check_sex_other.CheckedChanged += new EventHandler(research_result);
        //////////////////////////////////////////////////////////////////////////////////////////////
        // 
        // label_role
        // 
        label_role.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        label_role.Location = new Point(20, 180);
        label_role.Name = "label_role";
        label_role.AutoSize = true;
        label_role.Text = "ロール";
        label_role.ForeColor = Color.Black;
        // 
        // check_role_a
        // 
        check_role_a.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_role_a.Location = new Point(100, 180);
        check_role_a.Name = "check_role_a";
        check_role_a.AutoSize = true;
        check_role_a.Text = "アタッカー";
        check_role_a.ForeColor = Color.Black;
        check_role_a.CheckedChanged += new EventHandler(research_result);
        // 
        // check_role_b
        // 
        check_role_b.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_role_b.Location = new Point(270, 180);
        check_role_b.Name = "check_role_b";
        check_role_b.AutoSize = true;
        check_role_b.Text = "ブレイカー";
        check_role_b.ForeColor = Color.Black;
        check_role_b.CheckedChanged += new EventHandler(research_result);
        // 
        // check_role_d
        // 
        check_role_d.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_role_d.Location = new Point(100, 210);
        check_role_d.Name = "check_role_d";
        check_role_d.AutoSize = true;
        check_role_d.Text = "ディフェンダー";
        check_role_d.ForeColor = Color.Black;
        check_role_d.CheckedChanged += new EventHandler(research_result);
        // 
        // check_role_s
        // 
        check_role_s.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_role_s.Location = new Point(270, 210);
        check_role_s.Name = "check_role_s";
        check_role_s.AutoSize = true;
        check_role_s.Text = "サポーター";
        check_role_s.ForeColor = Color.Black;
        check_role_s.CheckedChanged += new EventHandler(research_result);
        //////////////////////////////////////////////////////////////////////////////////////////////
        // 
        // label_attributes
        // 
        label_attributes.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        label_attributes.Location = new Point(20, 250);
        label_attributes.Name = "label_attributes";
        label_attributes.AutoSize = true;
        label_attributes.Text = "属性";
        label_attributes.ForeColor = Color.Black;
        // 
        // check_attr_1
        // 
        check_attr_1.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_1.Location = new Point(100, 250);
        check_attr_1.Name = "check_attr_1";
        check_attr_1.AutoSize = true;
        check_attr_1.Text = "火";
        check_attr_1.ForeColor = Color.Black;
        check_attr_1.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_2
        // 
        check_attr_2.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_2.Location = new Point(180, 250);
        check_attr_2.Name = "check_attr_2";
        check_attr_2.AutoSize = true;
        check_attr_2.Text = "氷";
        check_attr_2.ForeColor = Color.Black;
        check_attr_2.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_3
        // 
        check_attr_3.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_3.Location = new Point(260, 250);
        check_attr_3.Name = "check_attr_3";
        check_attr_3.AutoSize = true;
        check_attr_3.Text = "雷";
        check_attr_3.ForeColor = Color.Black;
        check_attr_3.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_4
        // 
        check_attr_4.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_4.Location = new Point(340, 250);
        check_attr_4.Name = "check_attr_4";
        check_attr_4.AutoSize = true;
        check_attr_4.Text = "風";
        check_attr_4.ForeColor = Color.Black;
        check_attr_4.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_5
        // 
        check_attr_5.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_5.Location = new Point(100, 280);
        check_attr_5.Name = "check_attr_5";
        check_attr_5.AutoSize = true;
        check_attr_5.Text = "打";
        check_attr_5.ForeColor = Color.Black;
        check_attr_5.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_6
        // 
        check_attr_6.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_6.Location = new Point(180, 280);
        check_attr_6.Name = "check_attr_6";
        check_attr_6.AutoSize = true;
        check_attr_6.Text = "斬";
        check_attr_6.ForeColor = Color.Black;
        check_attr_6.CheckedChanged += new EventHandler(research_result);
        // 
        // check_attr_7
        // 
        check_attr_7.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_attr_7.Location = new Point(260, 280);
        check_attr_7.Name = "check_attr_7";
        check_attr_7.AutoSize = true;
        check_attr_7.Text = "突";
        check_attr_7.ForeColor = Color.Black;
        check_attr_7.CheckedChanged += new EventHandler(research_result);
        //////////////////////////////////////////////////////////////////////////////////////////////
        // 
        // label_gift
        // 
        label_gift.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        label_gift.Location = new Point(20, 320);
        label_gift.Name = "label_gift";
        label_gift.AutoSize = true;
        label_gift.Text = "調合ギフトに関する設定";
        label_gift.ForeColor = Color.Black;
        //
        // all_select_button
        //
        gift_select_button.Text = "ギフト全選択/クリア";
        gift_select_button.Location = new Point(280, 320);
        gift_select_button.AutoSize = false;
        gift_select_button.Size = new Size(110, 25);
        gift_select_button.BackColor = Color.WhiteSmoke;
        gift_select_button.Click += new EventHandler(gift_select_button_button_Click);
        // 
        // check_gift
        // 
        check_gift.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        check_gift.Location = new Point(20, 350);
        check_gift.Name = "check_gift";
        check_gift.AutoSize = false;
        check_gift.Size = new Size(400, 90);
        check_gift.Text = "※調合時使用する特定ギフトを有するキャラを探す場合のみこのチェックボックスを選択する";
        check_gift.ForeColor = Color.Black;
        check_gift.CheckedChanged += new EventHandler(research_result);
        // 
        // combo_gift
        // 
        combo_gift.Location = new Point(40, 440);
        combo_gift.Name = "combo_gift";
        combo_gift.Size = new Size(350, 30);
        combo_gift.DropDownStyle = ComboBoxStyle.DropDownList;
        combo_gift.SelectedValueChanged += new EventHandler(research_result);
        // 
        // label_color
        // 
        label_color.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
        label_color.Location = new Point(20, 480);
        label_color.Name = "label_color";
        label_color.AutoSize = false;
        label_color.Size = new Size(400, 90);
        label_color.Text = "※調合時使用する特定カラーを条件としてキャラ探す場合のみ以下のチェックボックスを選択する";
        label_color.ForeColor = Color.Black;
        // 
        // check_left_color
        // 
        check_left_color.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        check_left_color.Location = new Point(20, 570);
        check_left_color.Name = "check_left_color";
        check_left_color.AutoSize = true;
        check_left_color.Text = "調合属性:左の色";
        check_left_color.ForeColor = Color.Black;
        check_left_color.CheckedChanged += new EventHandler(research_result);
        // 
        // combo_color_left
        // 
        combo_color_left.Location = new Point(40, 610);
        combo_color_left.Name = "combo_color_left";
        combo_color_left.Size = new Size(150, 25);
        combo_color_left.DropDownStyle = ComboBoxStyle.DropDownList;
        combo_color_left.SelectedValueChanged += new EventHandler(research_result);
        // 
        // check_right_color
        // 
        check_right_color.Font = new Font("メイリオ", 15F, FontStyle.Bold, GraphicsUnit.Point);
        check_right_color.Location = new Point(220, 570);
        check_right_color.Name = "check_right_color";
        check_right_color.AutoSize = true;
        check_right_color.Text = "調合属性:右の色";
        check_right_color.ForeColor = Color.Black;
        check_right_color.CheckedChanged += new EventHandler(research_result);
        // 
        // combo_color_right
        // 
        combo_color_right.Location = new Point(240, 610);
        combo_color_right.Name = "combo_color_right";
        combo_color_right.Size = new Size(150, 25);
        combo_color_right.DropDownStyle = ComboBoxStyle.DropDownList;
        combo_color_right.SelectedValueChanged += new EventHandler(research_result);
        //////////////////////////////////////////////////////////////////////////////////////////////
        //
        //datagridviewConditionPanel
        //
        datagridviewConditionPanel.Controls.Add(label_conditions);
        datagridviewConditionPanel.Controls.Add(clear_button);
        datagridviewConditionPanel.Controls.Add(all_select_button);
        datagridviewConditionPanel.Controls.Add(label_sex);
        datagridviewConditionPanel.Controls.Add(check_sex_male);
        datagridviewConditionPanel.Controls.Add(check_sex_female);
        datagridviewConditionPanel.Controls.Add(check_sex_other);
        datagridviewConditionPanel.Controls.Add(label_role);
        datagridviewConditionPanel.Controls.Add(check_role_a);
        datagridviewConditionPanel.Controls.Add(check_role_b);
        datagridviewConditionPanel.Controls.Add(check_role_d);
        datagridviewConditionPanel.Controls.Add(check_role_s);
        datagridviewConditionPanel.Controls.Add(label_attributes);
        datagridviewConditionPanel.Controls.Add(check_attr_1);
        datagridviewConditionPanel.Controls.Add(check_attr_2);
        datagridviewConditionPanel.Controls.Add(check_attr_3);
        datagridviewConditionPanel.Controls.Add(check_attr_4);
        datagridviewConditionPanel.Controls.Add(check_attr_5);
        datagridviewConditionPanel.Controls.Add(check_attr_6);
        datagridviewConditionPanel.Controls.Add(check_attr_7);
        datagridviewConditionPanel.Controls.Add(label_gift);
        datagridviewConditionPanel.Controls.Add(gift_select_button);
        datagridviewConditionPanel.Controls.Add(check_gift);
        datagridviewConditionPanel.Controls.Add(combo_gift);
        datagridviewConditionPanel.Controls.Add(label_color);
        datagridviewConditionPanel.Controls.Add(check_left_color);
        datagridviewConditionPanel.Controls.Add(combo_color_left);
        datagridviewConditionPanel.Controls.Add(check_right_color);
        datagridviewConditionPanel.Controls.Add(combo_color_right);
        datagridviewConditionPanel.Location = new Point(480, 0);
        datagridviewConditionPanel.Size = new Size(520, 750);
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1000, 750);
        Controls.Add(datagridviewPanel);
        Controls.Add(datagridviewConditionPanel);
        Controls.Add(buttonPanel);
        Name = "MainForm";
        Text = "レスレリアーナのアトリエ 資料データベース";
        ((System.ComponentModel.ISupportInitialize)datagrid_character_list).EndInit();
        ResumeLayout(false);
    }

    private void Check_sex_male_CheckedChanged(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion
    private DataGridView datagrid_character_list = new DataGridView();
    private Panel buttonPanel = new Panel();
    private Panel datagridviewPanel = new Panel();
    private Panel datagridviewConditionPanel = new Panel();
    private Button detail_info_button = new Button();
    private Button character_add_button = new Button();
    private Button atelier_menu_button = new Button();
    private Button memoria_button = new Button();
    private Label label_conditions = new Label();
    private Button clear_button = new Button();
    private Button all_select_button = new Button();
    private Label label_sex = new Label();
    private CheckBox check_sex_male = new CheckBox();
    private CheckBox check_sex_female = new CheckBox();
    private CheckBox check_sex_other = new CheckBox();
    private CheckBox check_role_a = new CheckBox();
    private CheckBox check_role_b = new CheckBox();
    private CheckBox check_role_d = new CheckBox();
    private CheckBox check_role_s = new CheckBox();
    private CheckBox check_attr_1 = new CheckBox();
    private CheckBox check_attr_2 = new CheckBox();
    private CheckBox check_attr_3 = new CheckBox();
    private CheckBox check_attr_4 = new CheckBox();
    private CheckBox check_attr_5 = new CheckBox();
    private CheckBox check_attr_6 = new CheckBox();
    private CheckBox check_attr_7 = new CheckBox();
    private Label label_gift = new Label();
    private Button gift_select_button = new Button();
    private CheckBox check_gift = new CheckBox();
    private Label label_role = new Label();
    private Label label_attributes = new Label();
    private ComboBox combo_gift = new ComboBox();
    private Label label_color = new Label();
    private CheckBox check_left_color = new CheckBox();
    private ComboBox combo_color_left = new ComboBox();
    private CheckBox check_right_color = new CheckBox();
    private ComboBox combo_color_right = new ComboBox();
}
