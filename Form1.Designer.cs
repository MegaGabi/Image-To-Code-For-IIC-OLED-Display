namespace SpriteDrawer
{
    partial class frm_DrawWindow
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
            this.pnl_DrawField = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_GenCode = new System.Windows.Forms.Button();
            this.lb_Position = new System.Windows.Forms.Label();
            this.nud_Cols = new System.Windows.Forms.NumericUpDown();
            this.nud_Pages = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CodeOutput = new System.Windows.Forms.TextBox();
            this.btn_GenFromCode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_LoadImg = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Pic = new System.Windows.Forms.PictureBox();
            this.pb_BWres = new System.Windows.Forms.PictureBox();
            this.nud_Bright = new System.Windows.Forms.NumericUpDown();
            this.cb_Inverse = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pages)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BWres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bright)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_DrawField
            // 
            this.pnl_DrawField.BackColor = System.Drawing.Color.Black;
            this.pnl_DrawField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_DrawField.Location = new System.Drawing.Point(12, 27);
            this.pnl_DrawField.Name = "pnl_DrawField";
            this.pnl_DrawField.Size = new System.Drawing.Size(620, 309);
            this.pnl_DrawField.TabIndex = 0;
            this.pnl_DrawField.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_DrawField_Paint);
            this.pnl_DrawField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_DrawField_MouseClick);
            this.pnl_DrawField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_DrawField_MouseMove);
            this.pnl_DrawField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_DrawField_MouseUp);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Clear.Location = new System.Drawing.Point(12, 342);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "Очистить";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_GenCode_Click);
            // 
            // btn_GenCode
            // 
            this.btn_GenCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GenCode.Location = new System.Drawing.Point(93, 342);
            this.btn_GenCode.Name = "btn_GenCode";
            this.btn_GenCode.Size = new System.Drawing.Size(121, 23);
            this.btn_GenCode.TabIndex = 2;
            this.btn_GenCode.Text = "Сгенерировать Код";
            this.btn_GenCode.UseVisualStyleBackColor = true;
            this.btn_GenCode.Click += new System.EventHandler(this.btn_GenCode_Click);
            // 
            // lb_Position
            // 
            this.lb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Position.AutoSize = true;
            this.lb_Position.Location = new System.Drawing.Point(672, 27);
            this.lb_Position.Name = "lb_Position";
            this.lb_Position.Size = new System.Drawing.Size(0, 13);
            this.lb_Position.TabIndex = 3;
            // 
            // nud_Cols
            // 
            this.nud_Cols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Cols.Location = new System.Drawing.Point(725, 82);
            this.nud_Cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cols.Name = "nud_Cols";
            this.nud_Cols.Size = new System.Drawing.Size(53, 20);
            this.nud_Cols.TabIndex = 4;
            this.nud_Cols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cols.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nud_Pages
            // 
            this.nud_Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Pages.Location = new System.Drawing.Point(725, 108);
            this.nud_Pages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pages.Name = "nud_Pages";
            this.nud_Pages.Size = new System.Drawing.Size(53, 20);
            this.nud_Pages.TabIndex = 5;
            this.nud_Pages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pages.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pages";
            // 
            // tb_CodeOutput
            // 
            this.tb_CodeOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CodeOutput.Location = new System.Drawing.Point(220, 344);
            this.tb_CodeOutput.Name = "tb_CodeOutput";
            this.tb_CodeOutput.Size = new System.Drawing.Size(391, 20);
            this.tb_CodeOutput.TabIndex = 8;
            // 
            // btn_GenFromCode
            // 
            this.btn_GenFromCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GenFromCode.Location = new System.Drawing.Point(619, 342);
            this.btn_GenFromCode.Name = "btn_GenFromCode";
            this.btn_GenFromCode.Size = new System.Drawing.Size(161, 23);
            this.btn_GenFromCode.TabIndex = 9;
            this.btn_GenFromCode.Text = "Сгенерировать из кода";
            this.btn_GenFromCode.UseVisualStyleBackColor = true;
            this.btn_GenFromCode.Click += new System.EventHandler(this.btn_GenCode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_LoadImg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_LoadImg
            // 
            this.tsm_LoadImg.Name = "tsm_LoadImg";
            this.tsm_LoadImg.Size = new System.Drawing.Size(150, 20);
            this.tsm_LoadImg.Text = "Загрузить изображение";
            this.tsm_LoadImg.Click += new System.EventHandler(this.tsm_LoadImg_Click);
            // 
            // pb_Pic
            // 
            this.pb_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Pic.BackColor = System.Drawing.Color.White;
            this.pb_Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Pic.Location = new System.Drawing.Point(650, 134);
            this.pb_Pic.Name = "pb_Pic";
            this.pb_Pic.Size = new System.Drawing.Size(128, 64);
            this.pb_Pic.TabIndex = 11;
            this.pb_Pic.TabStop = false;
            // 
            // pb_BWres
            // 
            this.pb_BWres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_BWres.BackColor = System.Drawing.Color.Black;
            this.pb_BWres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_BWres.Location = new System.Drawing.Point(650, 250);
            this.pb_BWres.Name = "pb_BWres";
            this.pb_BWres.Size = new System.Drawing.Size(128, 64);
            this.pb_BWres.TabIndex = 12;
            this.pb_BWres.TabStop = false;
            // 
            // nud_Bright
            // 
            this.nud_Bright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Bright.Location = new System.Drawing.Point(650, 204);
            this.nud_Bright.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Bright.Name = "nud_Bright";
            this.nud_Bright.Size = new System.Drawing.Size(120, 20);
            this.nud_Bright.TabIndex = 13;
            this.nud_Bright.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Bright.ValueChanged += new System.EventHandler(this.tb_Bright_Scroll);
            // 
            // cb_Inverse
            // 
            this.cb_Inverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Inverse.AutoSize = true;
            this.cb_Inverse.Location = new System.Drawing.Point(650, 230);
            this.cb_Inverse.Name = "cb_Inverse";
            this.cb_Inverse.Size = new System.Drawing.Size(76, 17);
            this.cb_Inverse.TabIndex = 14;
            this.cb_Inverse.Text = "Инверсия";
            this.cb_Inverse.UseVisualStyleBackColor = true;
            this.cb_Inverse.CheckedChanged += new System.EventHandler(this.cb_Inverse_CheckedChanged);
            // 
            // frm_DrawWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 377);
            this.Controls.Add(this.cb_Inverse);
            this.Controls.Add(this.nud_Bright);
            this.Controls.Add(this.pb_BWres);
            this.Controls.Add(this.pb_Pic);
            this.Controls.Add(this.btn_GenFromCode);
            this.Controls.Add(this.tb_CodeOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Pages);
            this.Controls.Add(this.nud_Cols);
            this.Controls.Add(this.lb_Position);
            this.Controls.Add(this.btn_GenCode);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pnl_DrawField);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_DrawWindow";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.frm_DrawWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pages)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BWres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Bright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_DrawField;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_GenCode;
        private System.Windows.Forms.Label lb_Position;
        private System.Windows.Forms.NumericUpDown nud_Cols;
        private System.Windows.Forms.NumericUpDown nud_Pages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CodeOutput;
        private System.Windows.Forms.Button btn_GenFromCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_LoadImg;
        private System.Windows.Forms.PictureBox pb_Pic;
        private System.Windows.Forms.PictureBox pb_BWres;
        private System.Windows.Forms.NumericUpDown nud_Bright;
        private System.Windows.Forms.CheckBox cb_Inverse;
    }
}

