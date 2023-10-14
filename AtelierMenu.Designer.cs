namespace A25
{
    partial class AtelierMenu
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
            datagridview_style.BackColor = Color.White;
            datagridview_style.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            datagridview_style.SelectionBackColor = SystemColors.Highlight;
            datagridview_style.SelectionForeColor = SystemColors.HighlightText;
            datagridview_style.WrapMode = DataGridViewTriState.True;
            datagridview_style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabpage_equip.Text = "装備一覧";
            //tabpage_equip.Size = new Size(800, 450);
            tabpage_equip.TabIndex = 0;
            tabpage_equip.BackColor = Color.White;

            tabpage_item.Text = "戦闘アイテム一覧";
            //tabpage_item.Size = new Size(800, 450);
            tabpage_item.TabIndex = 1;
            tabpage_item.BackColor = Color.White;

            tabpage_material.Text = "素材一覧";
            //tabpage_material.Size = new Size(800, 450);
            tabpage_material.TabIndex = 2;
            tabpage_material.BackColor = Color.White;

            tabpage_gift.Text = "模擬調合";
            //tabpage_gift.Size = new Size(800, 450);
            tabpage_gift.TabIndex = 3;
            tabpage_gift.BackColor = Color.White;

            //////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // datagrid_equip_list
            //
            datagrid_equip_list.AllowUserToAddRows = false;
            datagrid_equip_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_equip_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_equip_list.ColumnHeadersDefaultCellStyle = datagridview_style;
            datagrid_equip_list.ColumnHeadersHeight = 40;
            datagrid_equip_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_equip_list.GridColor = Color.Black;
            datagrid_equip_list.Location = new Point(0, 0);
            datagrid_equip_list.MultiSelect = false;
            datagrid_equip_list.Name = "datagrid_item_list";
            datagrid_equip_list.ReadOnly = true;
            datagrid_equip_list.RowPrePaint += Datagrid_equip_list_RowPrePaint;
            datagrid_equip_list.RowHeadersVisible = false;
            datagrid_equip_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_equip_list.RowTemplate.Height = 33;
            datagrid_equip_list.ScrollBars = ScrollBars.Vertical;
            datagrid_equip_list.AllowUserToResizeRows = false;
            datagrid_equip_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_equip_list.Size = new Size(1210, 710);
            datagrid_equip_list.TabIndex = 0;
            datagrid_equip_list.CellDoubleClick += datagrid_equip_list_CellDoubleClick;
            // panel_equip
            panel_equip.Controls.Add(datagrid_equip_list);
            panel_equip.Location = new Point(0, 0);
            panel_equip.Size = new Size(1200, 700);
            //
            // CheckBox Parts
            //
            int label_attributes_length = 100;
            int x_length = 100;
            int y_length = 25;
            int y_point = 10;
            // 
            // label_type
            // 
            label_type.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_type.Location = new Point(25, y_point);
            label_type.Name = "label_type";
            label_type.AutoSize = true;
            label_type.Text = "アイテム種類";
            label_type.ForeColor = Color.Black;
            // 
            // check_type5
            // 
            check_type5.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type5.Location = new Point(label_attributes_length + x_length, y_point);
            check_type5.Name = "check_type5";
            check_type5.AutoSize = true;
            check_type5.Text = "武器";
            check_type5.ForeColor = Color.Black;
            check_type5.Click += new EventHandler(page1_checkbox_Click);
            // 
            // check_type6
            // 
            check_type6.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type6.Location = new Point(label_attributes_length + x_length * 2, y_point);
            check_type6.Name = "check_type6";
            check_type6.AutoSize = true;
            check_type6.Text = "防具";
            check_type6.ForeColor = Color.Black;
            check_type6.Click += new EventHandler(page1_checkbox_Click);
            // 
            // check_type7
            // 
            check_type7.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type7.Location = new Point(label_attributes_length + x_length * 3, y_point);
            check_type7.Name = "check_type7";
            check_type7.AutoSize = true;
            check_type7.Text = "装飾品";
            check_type7.ForeColor = Color.Black;
            check_type7.Click += new EventHandler(page1_checkbox_Click);
            // 
            // label_equip_rare
            // 
            label_equip_rare.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_equip_rare.Location = new Point(25, y_point + y_length);
            label_equip_rare.Name = "label_equip_rare";
            label_equip_rare.AutoSize = true;
            label_equip_rare.Text = "レア度";
            label_equip_rare.ForeColor = Color.Black;
            // 
            // check_equip_rare_r
            // 
            check_equip_rare_r.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_equip_rare_r.Location = new Point(label_attributes_length + x_length, y_point + y_length);
            check_equip_rare_r.Name = "check_equip_rare_r";
            check_equip_rare_r.AutoSize = true;
            check_equip_rare_r.Text = "R";
            check_equip_rare_r.ForeColor = Color.Black;
            check_equip_rare_r.Click += new EventHandler(page1_checkbox_Click);
            // 
            // check_equip_rare_sr
            // 
            check_equip_rare_sr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_equip_rare_sr.Location = new Point(label_attributes_length + x_length * 2, y_point + y_length);
            check_equip_rare_sr.Name = "check_equip_rare_sr";
            check_equip_rare_sr.AutoSize = true;
            check_equip_rare_sr.Text = "SR";
            check_equip_rare_sr.ForeColor = Color.Black;
            check_equip_rare_sr.Click += new EventHandler(page1_checkbox_Click);
            // 
            // check_equip_rare_ssr
            // 
            check_equip_rare_ssr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_equip_rare_ssr.Location = new Point(label_attributes_length + x_length * 3, y_point + y_length);
            check_equip_rare_ssr.Name = "check_equip_rare_ssr";
            check_equip_rare_ssr.AutoSize = true;
            check_equip_rare_ssr.Text = "SSR";
            check_equip_rare_ssr.ForeColor = Color.Black;
            check_equip_rare_ssr.Click += new EventHandler(page1_checkbox_Click);
            // panel_equip2
            panel_equip2.Controls.Add(label_type);
            panel_equip2.Controls.Add(check_type5);
            panel_equip2.Controls.Add(check_type6);
            panel_equip2.Controls.Add(check_type7);
            panel_equip2.Controls.Add(label_equip_rare);
            panel_equip2.Controls.Add(check_equip_rare_r);
            panel_equip2.Controls.Add(check_equip_rare_sr);
            panel_equip2.Controls.Add(check_equip_rare_ssr);
            panel_equip2.Location = new Point(0, 700);
            panel_equip2.Size = new Size(1200, 100);
            // tabpage_equip
            tabpage_equip.Controls.Add(panel_equip);
            tabpage_equip.Controls.Add(panel_equip2);
            //////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // datagrid_item_list
            //
            datagrid_item_list.AllowUserToAddRows = false;
            datagrid_item_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_item_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_item_list.ColumnHeadersDefaultCellStyle = datagridview_style;
            datagrid_item_list.ColumnHeadersHeight = 40;
            datagrid_item_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_item_list.GridColor = Color.Black;
            datagrid_item_list.Location = new Point(0, 0);
            datagrid_item_list.MultiSelect = false;
            datagrid_item_list.Name = "datagrid_item_list";
            datagrid_item_list.ReadOnly = true;
            datagrid_item_list.RowPrePaint += Datagrid_item_list_RowPrePaint;
            datagrid_item_list.RowHeadersVisible = false;
            datagrid_item_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_item_list.RowTemplate.Height = 33;
            datagrid_item_list.ScrollBars = ScrollBars.Vertical;
            datagrid_item_list.AllowUserToResizeRows = false;
            datagrid_item_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_item_list.Size = new Size(1210, 710);
            datagrid_item_list.TabIndex = 1;
            datagrid_item_list.CellDoubleClick += datagrid_item_list_CellDoubleClick;
            // panel_item
            panel_item.Location = new Point(0, 0);
            panel_item.Size = new Size(1200, 700);
            panel_item.Controls.Add(datagrid_item_list);
            //
            // CheckBox Parts
            //
            //
            // label_type
            // 
            label_item_type.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_item_type.Location = new Point(25, y_point);
            label_item_type.Name = "label_type";
            label_item_type.AutoSize = true;
            label_item_type.Text = "アイテム種類";
            label_item_type.ForeColor = Color.Black;
            // 
            // check_type1
            // 
            check_type1.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type1.Location = new Point(label_attributes_length + x_length, y_point);
            check_type1.Name = "check_type1";
            check_type1.AutoSize = true;
            check_type1.Text = "回復";
            check_type1.ForeColor = Color.Black;
            check_type1.Click += new EventHandler(page2_checkbox_Click);
            // 
            // check_type2
            // 
            check_type2.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type2.Location = new Point(label_attributes_length + x_length * 2, y_point);
            check_type2.Name = "check_type2";
            check_type2.AutoSize = true;
            check_type2.Text = "弱体";
            check_type2.ForeColor = Color.Black;
            check_type2.Click += new EventHandler(page2_checkbox_Click);
            // 
            // check_type3
            // 
            check_type3.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type3.Location = new Point(label_attributes_length + x_length * 3, y_point);
            check_type3.Name = "check_type3";
            check_type3.AutoSize = true;
            check_type3.Text = "強化";
            check_type3.ForeColor = Color.Black;
            check_type3.Click += new EventHandler(page2_checkbox_Click);
            // 
            // check_type4
            // 
            check_type4.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_type4.Location = new Point(label_attributes_length + x_length * 4, y_point);
            check_type4.Name = "check_type4";
            check_type4.AutoSize = true;
            check_type4.Text = "攻撃";
            check_type4.ForeColor = Color.Black;
            check_type4.Click += new EventHandler(page2_checkbox_Click);
            // 
            // label_item_rare
            // 
            label_item_rare.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_item_rare.Location = new Point(25, y_point + y_length);
            label_item_rare.Name = "label_item_rare";
            label_item_rare.AutoSize = true;
            label_item_rare.Text = "レア度";
            label_item_rare.ForeColor = Color.Black;
            // 
            // check_item_rare_r
            // 
            check_item_rare_r.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_item_rare_r.Location = new Point(label_attributes_length + x_length, y_point + y_length);
            check_item_rare_r.Name = "check_item_rare_r";
            check_item_rare_r.AutoSize = true;
            check_item_rare_r.Text = "R";
            check_item_rare_r.ForeColor = Color.Black;
            check_item_rare_r.Click += new EventHandler(page2_checkbox_Click);
            // 
            // check_item_rare_sr
            // 
            check_item_rare_sr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_item_rare_sr.Location = new Point(label_attributes_length + x_length * 2, y_point + y_length);
            check_item_rare_sr.Name = "check_item_rare_sr";
            check_item_rare_sr.AutoSize = true;
            check_item_rare_sr.Text = "SR";
            check_item_rare_sr.ForeColor = Color.Black;
            check_item_rare_sr.Click += new EventHandler(page2_checkbox_Click);
            // 
            // check_item_rare_ssr
            // 
            check_item_rare_ssr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_item_rare_ssr.Location = new Point(label_attributes_length + x_length * 3, y_point + y_length);
            check_item_rare_ssr.Name = "check_item_rare_ssr";
            check_item_rare_ssr.AutoSize = true;
            check_item_rare_ssr.Text = "SSR";
            check_item_rare_ssr.ForeColor = Color.Black;
            check_item_rare_ssr.Click += new EventHandler(page2_checkbox_Click);
            // panel_item2
            panel_item2.Controls.Add(label_item_type);
            panel_item2.Controls.Add(check_type1);
            panel_item2.Controls.Add(check_type2);
            panel_item2.Controls.Add(check_type3);
            panel_item2.Controls.Add(check_type4);
            panel_item2.Controls.Add(label_item_rare);
            panel_item2.Controls.Add(check_item_rare_r);
            panel_item2.Controls.Add(check_item_rare_sr);
            panel_item2.Controls.Add(check_item_rare_ssr);
            panel_item2.Location = new Point(0, 700);
            panel_item2.Size = new Size(1200, 100);
            // tabpage_equip
            tabpage_item.Controls.Add(panel_item);
            tabpage_item.Controls.Add(panel_item2);
            //////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // datagrid_material_list
            //
            datagrid_material_list.AllowUserToAddRows = false;
            datagrid_material_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_material_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_material_list.ColumnHeadersDefaultCellStyle = datagridview_style;
            datagrid_material_list.ColumnHeadersHeight = 40;
            datagrid_material_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_material_list.GridColor = Color.Black;
            datagrid_material_list.Location = new Point(0, 0);
            datagrid_material_list.MultiSelect = false;
            datagrid_material_list.Name = "datagrid_material_list";
            datagrid_material_list.ReadOnly = true;
            datagrid_material_list.RowPrePaint += Datagrid_material_list_RowPrePaint;
            datagrid_material_list.RowHeadersVisible = false;
            datagrid_material_list.RowTemplate.Height = 33;
            datagrid_material_list.AllowUserToResizeRows = false;
            datagrid_material_list.ScrollBars = ScrollBars.Vertical;
            datagrid_material_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_material_list.Size = new Size(1210, 710);
            datagrid_material_list.TabIndex = 2;
            // panel_material
            panel_material.Location = new Point(0, 0);
            panel_material.Size = new Size(1200, 700);
            panel_material.Controls.Add(datagrid_material_list);
            //
            // CheckBox Parts
            //
            //
            x_length = 50;
            // label_material_color
            // 
            label_material_color.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_material_color.Location = new Point(25, y_point);
            label_material_color.Name = "label_material_color";
            label_material_color.AutoSize = true;
            label_material_color.Text = "素材の色";
            label_material_color.ForeColor = Color.Black;
            // 
            // check_color_red
            // 
            check_color_red.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_color_red.Location = new Point(label_attributes_length + x_length, y_point);
            check_color_red.Name = "check_color_red";
            check_color_red.AutoSize = true;
            check_color_red.Text = "紅";
            check_color_red.ForeColor = Color.Black;
            check_color_red.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_color_yellow
            // 
            check_color_yellow.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_color_yellow.Location = new Point(label_attributes_length + x_length * 2, y_point);
            check_color_yellow.Name = "check_color_yellow";
            check_color_yellow.AutoSize = true;
            check_color_yellow.Text = "黄";
            check_color_yellow.ForeColor = Color.Black;
            check_color_yellow.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_color_green
            // 
            check_color_green.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_color_green.Location = new Point(label_attributes_length + x_length * 3, y_point);
            check_color_green.Name = "check_color_green";
            check_color_green.AutoSize = true;
            check_color_green.Text = "緑";
            check_color_green.ForeColor = Color.Black;
            check_color_green.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_color_blue
            // 
            check_color_blue.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_color_blue.Location = new Point(label_attributes_length + x_length * 4, y_point);
            check_color_blue.Name = "check_color_blue";
            check_color_blue.AutoSize = true;
            check_color_blue.Text = "青";
            check_color_blue.ForeColor = Color.Black;
            check_color_blue.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_color_purple
            // 
            check_color_purple.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_color_purple.Location = new Point(label_attributes_length + x_length * 5, y_point);
            check_color_purple.Name = "check_color_purple";
            check_color_purple.AutoSize = true;
            check_color_purple.Text = "紫";
            check_color_purple.ForeColor = Color.Black;
            check_color_purple.Click += new EventHandler(page3_checkbox_Click);
            // 
            // label_material_rare
            // 
            label_material_rare.Font = new Font("メイリオ", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_material_rare.Location = new Point(25, y_point + y_length);
            label_material_rare.Name = "label_material_rare";
            label_material_rare.AutoSize = true;
            label_material_rare.Text = "レア度";
            label_material_rare.ForeColor = Color.Black;
            // 
            // check_material_rare_r
            // 
            check_material_rare_r.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_material_rare_r.Location = new Point(label_attributes_length + x_length, y_point + y_length);
            check_material_rare_r.Name = "check_material_rare_r";
            check_material_rare_r.AutoSize = true;
            check_material_rare_r.Text = "R";
            check_material_rare_r.ForeColor = Color.Black;
            check_material_rare_r.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_material_rare_sr
            // 
            check_material_rare_sr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_material_rare_sr.Location = new Point(label_attributes_length + x_length * 2, y_point + y_length);
            check_material_rare_sr.Name = "check_material_rare_sr";
            check_material_rare_sr.AutoSize = true;
            check_material_rare_sr.Text = "SR";
            check_material_rare_sr.ForeColor = Color.Black;
            check_material_rare_sr.Click += new EventHandler(page3_checkbox_Click);
            // 
            // check_material_rare_ssr
            // 
            check_material_rare_ssr.Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point);
            check_material_rare_ssr.Location = new Point(label_attributes_length + x_length * 3, y_point + y_length);
            check_material_rare_ssr.Name = "check_material_rare_ssr";
            check_material_rare_ssr.AutoSize = true;
            check_material_rare_ssr.Text = "SSR";
            check_material_rare_ssr.ForeColor = Color.Black;
            check_material_rare_ssr.Click += new EventHandler(page3_checkbox_Click);
            // panel_material2
            panel_material2.Controls.Add(label_material_color);
            panel_material2.Controls.Add(check_color_red);
            panel_material2.Controls.Add(check_color_yellow);
            panel_material2.Controls.Add(check_color_green);
            panel_material2.Controls.Add(check_color_blue);
            panel_material2.Controls.Add(check_color_purple);
            panel_material2.Controls.Add(label_material_rare);
            panel_material2.Controls.Add(check_material_rare_r);
            panel_material2.Controls.Add(check_material_rare_sr);
            panel_material2.Controls.Add(check_material_rare_ssr);
            panel_material2.Location = new Point(0, 700);
            panel_material2.Size = new Size(1200, 100);
            // tabpage_material
            tabpage_material.Controls.Add(panel_material);
            tabpage_material.Controls.Add(panel_material2);
            //////////////////////////////////////////////////////////////////////////////////////////////
            // 
            // datagrid_gift_list
            //
            datagrid_gift_list.AllowUserToAddRows = false;
            datagrid_gift_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_gift_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_gift_list.ColumnHeadersDefaultCellStyle = datagridview_style;
            datagrid_gift_list.ColumnHeadersHeight = 40;
            datagrid_gift_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_gift_list.GridColor = Color.Black;
            datagrid_gift_list.Location = new Point(0, 0);
            datagrid_gift_list.MultiSelect = false;
            datagrid_gift_list.Name = "datagrid_gift_list";
            datagrid_gift_list.ReadOnly = true;
            datagrid_gift_list.RowHeadersVisible = false;
            datagrid_gift_list.RowTemplate.Height = 33;
            datagrid_gift_list.ScrollBars = ScrollBars.Vertical;
            datagrid_gift_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_gift_list.AllowUserToResizeRows = false;
            datagrid_gift_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datagrid_gift_list.Size = new Size(717, 800);
            datagrid_gift_list.TabIndex = 3;
            // panel_gift
            panel_gift.Location = new Point(0, 0);
            panel_gift.Size = new Size(700, 800);
            panel_gift.Controls.Add(datagrid_gift_list);
            //
            // label_obj
            // 
            label_obj.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_obj.Location = new Point(50, 50);
            label_obj.Name = "label_obj";
            label_obj.AutoSize = true;
            label_obj.Text = "調合対象 : ";
            label_obj.ForeColor = Color.Black;
            //
            // label_obj_name
            // 
            label_obj_name.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_obj_name.Location = new Point(200, 50);
            label_obj_name.Name = "label_obj_name";
            label_obj_name.AutoSize = true;
            label_obj_name.ForeColor = Color.Black;
            //
            // label_obj_code
            // 
            label_obj_code.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_obj_code.Name = "label_obj_code";
            label_obj_code.Visible = false;
            //
            // label_obj_type
            //
            label_obj_type.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_obj_type.Name = "label_obj_type";
            label_obj_type.Visible = false;
            //
            // label_gift1
            // 
            label_gift1.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_gift1.Location = new Point(50, 120);
            label_gift1.Name = "label_gift1";
            label_gift1.AutoSize = true;
            label_gift1.Text = "目標特性① : ";
            label_gift1.ForeColor = Color.Black;
            // 
            // combo_gift1
            // 
            combo_gift1.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_gift1.Location = new Point(200, 120);
            combo_gift1.Name = "combo_gift1";
            combo_gift1.Size = new Size(200, 23);
            //
            // label_gift2
            // 
            label_gift2.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_gift2.Location = new Point(50, 190);
            label_gift2.Name = "label_gift2";
            label_gift2.AutoSize = true;
            label_gift2.Text = "目標特性② : ";
            label_gift2.ForeColor = Color.Black;
            // 
            // combo_gift2
            // 
            combo_gift2.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_gift2.Location = new Point(200, 190);
            combo_gift2.Name = "combo_gift2";
            combo_gift2.Size = new Size(200, 23);
            //
            // confirm_button
            //
            confirm_button.Font = new Font("メイリオ", 13F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_button.Location = new Point(130, 280);
            confirm_button.Name = "confirm_button";
            confirm_button.AutoSize = true;
            confirm_button.Text = "調合可能ルート検索";
            confirm_button.ForeColor = Color.Black;
            confirm_button.Click += Confirm_button_Click;
            // panel_gift
            panel_gift2.Controls.Add(label_obj);
            panel_gift2.Controls.Add(label_obj_name);
            panel_gift2.Controls.Add(label_gift1);
            panel_gift2.Controls.Add(label_gift2);
            panel_gift2.Controls.Add(combo_gift1);
            panel_gift2.Controls.Add(combo_gift2);
            panel_gift2.Controls.Add(confirm_button);
            panel_gift2.Location = new Point(700, 0);
            panel_gift2.Size = new Size(500, 793);
            // tabpage_gift
            tabpage_gift.Controls.Add(panel_gift);
            tabpage_gift.Controls.Add(panel_gift2);
            //////////////////////////////////////////////////////////////////////////////////////////////
            ///タブ対象容器
            tab.Controls.Add(this.tabpage_equip);
            tab.Controls.Add(this.tabpage_item);
            tab.Controls.Add(this.tabpage_material);
            tab.Controls.Add(this.tabpage_gift);
            tab.Size = new Size(1200, 793);
            tab.Multiline = false;
            //////////////////////////////////////////////////////////////////////////////////////////////
            this.Controls.Add(tab);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 793);
            this.Text = "アトリエメニュー";
        }

        #endregion

        private TabControl tab = new TabControl();
        private TabPage tabpage_equip = new TabPage();
        private TabPage tabpage_item = new TabPage();
        private TabPage tabpage_material = new TabPage();
        private TabPage tabpage_gift = new TabPage();
        private DataGridView datagrid_equip_list = new DataGridView();
        private Panel panel_equip = new Panel();
        private Panel panel_equip2 = new Panel();
        private DataGridView datagrid_item_list = new DataGridView();
        private Panel panel_item = new Panel();
        private Panel panel_item2 = new Panel();
        private DataGridView datagrid_material_list = new DataGridView();
        private Panel panel_material = new Panel();
        private Panel panel_material2 = new Panel();
        private DataGridView datagrid_gift_list = new DataGridView();
        private Panel panel_gift = new Panel();
        private Panel panel_gift2 = new Panel();
        private DataGridViewCellStyle datagridview_style = new DataGridViewCellStyle();
        private Label label_type = new Label();
        private Label label_equip_rare = new Label();
        private Label label_item_type = new Label();
        private Label label_item_rare = new Label();
        private Label label_material_color = new Label();
        private Label label_material_rare = new Label();
        private CheckBox check_type1 = new CheckBox();
        private CheckBox check_type2 = new CheckBox();
        private CheckBox check_type3 = new CheckBox();
        private CheckBox check_type4 = new CheckBox();
        private CheckBox check_type5 = new CheckBox();
        private CheckBox check_type6 = new CheckBox();
        private CheckBox check_type7 = new CheckBox();
        private CheckBox check_equip_rare_r = new CheckBox();
        private CheckBox check_equip_rare_sr = new CheckBox();
        private CheckBox check_equip_rare_ssr = new CheckBox();
        private CheckBox check_item_rare_r = new CheckBox();
        private CheckBox check_item_rare_sr = new CheckBox();
        private CheckBox check_item_rare_ssr = new CheckBox();
        private CheckBox check_material_rare_r = new CheckBox();
        private CheckBox check_material_rare_sr = new CheckBox();
        private CheckBox check_material_rare_ssr = new CheckBox();
        private CheckBox check_color_red = new CheckBox();
        private CheckBox check_color_green = new CheckBox();
        private CheckBox check_color_blue = new CheckBox();
        private CheckBox check_color_purple = new CheckBox();
        private CheckBox check_color_yellow = new CheckBox();
        private Label label_obj = new Label();
        private Label label_obj_name = new Label();
        private Label label_obj_code = new Label();
        private Label label_obj_type = new Label();
        private Label label_gift1 = new Label();
        private Label label_gift2 = new Label();
        private ComboBox combo_gift1 = new ComboBox();
        private ComboBox combo_gift2 = new ComboBox();
        private Button confirm_button = new Button();
    }
}