namespace A25
{
    partial class RouteResult
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
            // 
            // datagrid_result_list
            //
            datagridview_style.BackColor = Color.Navy;
            datagridview_style.Font = new Font("Yu Gothic UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            datagridview_style.ForeColor = Color.White;
            datagridview_style.SelectionBackColor = SystemColors.Highlight;
            datagridview_style.SelectionForeColor = SystemColors.HighlightText;
            datagridview_style.WrapMode = DataGridViewTriState.True;
            datagridview_style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            datagrid_result_list.AllowUserToAddRows = false;
            datagrid_result_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_result_list.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid_result_list.ColumnHeadersDefaultCellStyle = datagridview_style;
            datagrid_result_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagrid_result_list.ColumnHeadersHeight = 40;
            datagrid_result_list.GridColor = Color.Black;
            datagrid_result_list.Location = new Point(0, 0);
            datagrid_result_list.MultiSelect = true;
            datagrid_result_list.Name = "datagrid_result_list";
            datagrid_result_list.ReadOnly = true;
            datagrid_result_list.RowHeadersVisible = false;
            datagrid_result_list.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            datagrid_result_list.RowTemplate.Height = 33;
            datagrid_result_list.ScrollBars = ScrollBars.Both;
            datagrid_result_list.SelectionMode = DataGridViewSelectionMode.CellSelect;
            datagrid_result_list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            datagrid_result_list.Size = new Size(1230, 475);
            datagrid_result_list.TabIndex = 0;
            
            this.Controls.Add(datagrid_result_list);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.BackColor = Color.White;
            this.Text = "錬成・調合ルート一覧";
        }

        #endregion

        private DataGridView datagrid_result_list = new DataGridView();
        private DataGridViewCellStyle datagridview_style = new DataGridViewCellStyle();
    }
}