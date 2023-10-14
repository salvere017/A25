namespace A25
{
    partial class Memoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            datagrid_memoria_list = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagrid_memoria_list).BeginInit();
            SuspendLayout();
            //////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // datagrid_memoria_list
            //
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datagrid_memoria_list.AllowUserToAddRows = false;
            datagrid_memoria_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_memoria_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_memoria_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagrid_memoria_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_memoria_list.ColumnHeadersHeight = 40;
            datagrid_memoria_list.GridColor = Color.Black;
            datagrid_memoria_list.Location = new Point(0, 0);
            datagrid_memoria_list.MultiSelect = true;
            datagrid_memoria_list.Name = "datagrid_memoria_list";
            datagrid_memoria_list.ReadOnly = true;
            datagrid_memoria_list.RowHeadersVisible = false;
            datagrid_memoria_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_memoria_list.RowTemplate.Height = 33;
            datagrid_memoria_list.ScrollBars = ScrollBars.Both;
            datagrid_memoria_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_memoria_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datagrid_memoria_list.Size = new Size(1230, 810);
            datagrid_memoria_list.TabIndex = 0;
            //datagrid_memoria_list.CellDoubleClick += datagrid_memoria_list_CellDoubleClick;
            //
            // datagridviewPanel
            //
            datagridviewPanel.Controls.Add(datagrid_memoria_list);
            datagridviewPanel.Size = new Size(1230, 800);
            datagridviewPanel.Location = new Point(0, 0);
            //////////////////////////////////////////////////////////////////////////////////////////////
            //
            // add_button
            //
            add_button.Text = "新規メモリア追加";
            add_button.Location = new Point(20, 25);
            add_button.AutoSize = false;
            add_button.Size = new Size(100, 50);
            add_button.BackColor = Color.WhiteSmoke;
            add_button.Click += new EventHandler(add_button_Click);
            //////////////////////////////////////////////////////////////////////////////////////////////
            int label_attributes_length = 250;
            int x_length = 45;
            int y_length = 25;
            int y_point = 25;
            // 
            // label_attributes
            // 
            label_attributes.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_attributes.Location = new Point(160, y_point);
            label_attributes.Name = "label_attributes";
            label_attributes.AutoSize = true;
            label_attributes.Text = "属性傾向選択";
            label_attributes.ForeColor = Color.Black;
            // 
            // check_attr_1
            // 
            check_attr_1.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_1.Location = new Point(label_attributes_length + x_length, y_point);
            check_attr_1.Name = "check_attr_1";
            check_attr_1.AutoSize = true;
            check_attr_1.Text = "火";
            check_attr_1.ForeColor = Color.Black;
            check_attr_1.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_2
            // 
            check_attr_2.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_2.Location = new Point(label_attributes_length + x_length * 2, y_point);
            check_attr_2.Name = "check_attr_2";
            check_attr_2.AutoSize = true;
            check_attr_2.Text = "氷";
            check_attr_2.ForeColor = Color.Black;
            check_attr_2.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_3
            // 
            check_attr_3.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_3.Location = new Point(label_attributes_length + x_length * 3, y_point);
            check_attr_3.Name = "check_attr_3";
            check_attr_3.AutoSize = true;
            check_attr_3.Text = "雷";
            check_attr_3.ForeColor = Color.Black;
            check_attr_3.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_4
            // 
            check_attr_4.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_4.Location = new Point(label_attributes_length + x_length * 4, y_point);
            check_attr_4.Name = "check_attr_4";
            check_attr_4.AutoSize = true;
            check_attr_4.Text = "風";
            check_attr_4.ForeColor = Color.Black;
            check_attr_4.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_5
            // 
            check_attr_5.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_5.Location = new Point(label_attributes_length + x_length * 5, y_point);
            check_attr_5.Name = "check_attr_5";
            check_attr_5.AutoSize = true;
            check_attr_5.Text = "打";
            check_attr_5.ForeColor = Color.Black;
            check_attr_5.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_6
            // 
            check_attr_6.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_6.Location = new Point(label_attributes_length + x_length * 6, y_point);
            check_attr_6.Name = "check_attr_6";
            check_attr_6.AutoSize = true;
            check_attr_6.Text = "斬";
            check_attr_6.ForeColor = Color.Black;
            check_attr_6.Click += new EventHandler(checkbox_Click);
            // 
            // check_attr_7
            // 
            check_attr_7.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_attr_7.Location = new Point(label_attributes_length + x_length * 7, y_point);
            check_attr_7.Name = "check_attr_7";
            check_attr_7.AutoSize = true;
            check_attr_7.Text = "突";
            check_attr_7.ForeColor = Color.Black;
            check_attr_7.Click += new EventHandler(checkbox_Click);
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // label_atk_def_attributes
            // 
            label_atk_def_attributes.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_atk_def_attributes.Location = new Point(160, y_point + y_length);
            label_atk_def_attributes.Name = "label_atk_def_attributes";
            label_atk_def_attributes.AutoSize = true;
            label_atk_def_attributes.Text = "攻防傾向選択";
            label_atk_def_attributes.ForeColor = Color.Black;
            // 
            // check_ad_attr_1
            // 
            check_ad_attr_1.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_1.Location = new Point(label_attributes_length + x_length, y_point + y_length);
            check_ad_attr_1.Name = "check_ad_attr_1";
            check_ad_attr_1.AutoSize = true;
            check_ad_attr_1.Text = "ダメージアップ";
            check_ad_attr_1.ForeColor = Color.Black;
            check_ad_attr_1.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_2
            // 
            check_ad_attr_2.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_2.Location = new Point(label_attributes_length + 180, y_point + y_length);
            check_ad_attr_2.Name = "check_ad_attr_2";
            check_ad_attr_2.AutoSize = true;
            check_ad_attr_2.Text = "ブレイクアップ";
            check_ad_attr_2.ForeColor = Color.Black;
            check_ad_attr_2.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_3
            // 
            check_ad_attr_3.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_3.Location = new Point(label_attributes_length + 315, y_point + y_length);
            check_ad_attr_3.Name = "check_ad_attr_3";
            check_ad_attr_3.AutoSize = true;
            check_ad_attr_3.Text = "バーストアップ";
            check_ad_attr_3.ForeColor = Color.Black;
            check_ad_attr_3.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_4
            // 
            check_ad_attr_4.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_4.Location = new Point(label_attributes_length + 450, y_point + y_length);
            check_ad_attr_4.Name = "check_ad_attr_4";
            check_ad_attr_4.AutoSize = true;
            check_ad_attr_4.Text = "レジストダウン";
            check_ad_attr_4.ForeColor = Color.Black;
            check_ad_attr_4.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_5
            // 
            check_ad_attr_5.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_5.Location = new Point(label_attributes_length + 585, y_point + y_length);
            check_ad_attr_5.Name = "check_ad_attr_5";
            check_ad_attr_5.AutoSize = true;
            check_ad_attr_5.Text = "ドッジアップ";
            check_ad_attr_5.ForeColor = Color.Black;
            check_ad_attr_5.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_6
            // 
            check_ad_attr_6.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_6.Location = new Point(label_attributes_length + 705, y_point + y_length);
            check_ad_attr_6.Name = "check_ad_attr_6";
            check_ad_attr_6.AutoSize = true;
            check_ad_attr_6.Text = "ヒール";
            check_ad_attr_6.ForeColor = Color.Black;
            check_ad_attr_6.Click += new EventHandler(checkbox_Click);
            // 
            // check_ad_attr_7
            // 
            check_ad_attr_7.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_ad_attr_7.Location = new Point(label_attributes_length + 780, y_point + y_length);
            check_ad_attr_7.Name = "check_ad_attr_7";
            check_ad_attr_7.AutoSize = true;
            check_ad_attr_7.Text = "アイテム";
            check_ad_attr_7.ForeColor = Color.Black;
            check_ad_attr_7.Click += new EventHandler(checkbox_Click);
            //
            //datagridviewConditionPanel
            //
            datagridviewConditionPanel.Controls.Add(add_button);
            datagridviewConditionPanel.Controls.Add(label_attributes);
            datagridviewConditionPanel.Controls.Add(check_attr_1);
            datagridviewConditionPanel.Controls.Add(check_attr_2);
            datagridviewConditionPanel.Controls.Add(check_attr_3);
            datagridviewConditionPanel.Controls.Add(check_attr_4);
            datagridviewConditionPanel.Controls.Add(check_attr_5);
            datagridviewConditionPanel.Controls.Add(check_attr_6);
            datagridviewConditionPanel.Controls.Add(check_attr_7);
            datagridviewConditionPanel.Controls.Add(label_atk_def_attributes);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_1);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_2);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_3);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_4);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_5);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_6);
            datagridviewConditionPanel.Controls.Add(check_ad_attr_7);
            datagridviewConditionPanel.Location = new Point(0, 800);
            datagridviewConditionPanel.Size = new Size(1230, 100);
            //////////////////////////////////////////////////////////////////////////////////////////////

            this.Controls.Add(datagridviewPanel);
            this.Controls.Add(datagridviewConditionPanel);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 900);
            this.Text = "メモリア一覧";
            ((System.ComponentModel.ISupportInitialize)datagrid_memoria_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_memoria_list = new DataGridView();
        private Panel datagridviewPanel = new Panel();
        private Panel datagridviewConditionPanel = new Panel();
        private Button add_button = new Button();
        private Label label_attributes = new Label();
        private CheckBox check_attr_1 = new CheckBox();
        private CheckBox check_attr_2 = new CheckBox();
        private CheckBox check_attr_3 = new CheckBox();
        private CheckBox check_attr_4 = new CheckBox();
        private CheckBox check_attr_5 = new CheckBox();
        private CheckBox check_attr_6 = new CheckBox();
        private CheckBox check_attr_7 = new CheckBox();
        private Label label_atk_def_attributes = new Label();
        private CheckBox check_ad_attr_1 = new CheckBox();
        private CheckBox check_ad_attr_2 = new CheckBox();
        private CheckBox check_ad_attr_3 = new CheckBox();
        private CheckBox check_ad_attr_4 = new CheckBox();
        private CheckBox check_ad_attr_5 = new CheckBox();
        private CheckBox check_ad_attr_6 = new CheckBox();
        private CheckBox check_ad_attr_7 = new CheckBox();
    }
}