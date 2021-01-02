namespace Zip
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles elListBoxSelectionStyles1 = new Klik.Windows.Forms.v1.EntryLib.ELListBoxSelectionStyles();
            Klik.Windows.Forms.v1.EntryLib.ELListBoxItem elListBoxItem1 = new Klik.Windows.Forms.v1.EntryLib.ELListBoxItem();
            Klik.Windows.Forms.v1.EntryLib.ELListBoxItem elListBoxItem2 = new Klik.Windows.Forms.v1.EntryLib.ELListBoxItem();
            Klik.Windows.Forms.v1.EntryLib.ELListBoxItem elListBoxItem3 = new Klik.Windows.Forms.v1.EntryLib.ELListBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.elButton1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_no = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NameArch = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.cb_Formato = new Klik.Windows.Forms.v1.EntryLib.ELComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_Destino = new System.Windows.Forms.PictureBox();
            this.tb_Destino = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.ptb_Ubicacion = new System.Windows.Forms.PictureBox();
            this.tb_Ubicacion = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdUbicacion = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NameArch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Formato)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Destino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Destino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ubicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.elButton1);
            this.panel1.Controls.Add(this.btn_no);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // elButton1
            // 
            this.elButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elButton1.BackgroundStyle.GradientAngle = 0F;
            this.elButton1.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.elButton1.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.elButton1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.BackgroundStyle.SolidColor = System.Drawing.Color.DimGray;
            this.elButton1.BorderStyle.SolidColor = System.Drawing.Color.DimGray;
            this.elButton1.DropDownArrowColor = System.Drawing.Color.White;
            this.elButton1.EnableThemes = false;
            this.elButton1.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.elButton1.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.elButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.elButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elButton1.Location = new System.Drawing.Point(12, 6);
            this.elButton1.Name = "elButton1";
            this.elButton1.Size = new System.Drawing.Size(104, 24);
            this.elButton1.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.OrangeRed;
            this.elButton1.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.OrangeRed;
            this.elButton1.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.OrangeRed;
            this.elButton1.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.OrangeRed;
            this.elButton1.TabIndex = 31;
            this.elButton1.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.elButton1.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elButton1.TextStyle.ForeColor = System.Drawing.Color.White;
            this.elButton1.TextStyle.Text = "Cancelar";
            this.elButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.elButton1.Click += new System.EventHandler(this.elButton1_Click);
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.BackgroundStyle.GradientAngle = 0F;
            this.btn_no.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_no.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_no.BorderStyle.SolidColor = System.Drawing.Color.Teal;
            this.btn_no.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_no.EnableThemes = false;
            this.btn_no.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_no.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_no.FlashStyle.SolidColor = System.Drawing.Color.OrangeRed;
            this.btn_no.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Location = new System.Drawing.Point(371, 6);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(91, 24);
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_no.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_no.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_no.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_no.TabIndex = 30;
            this.btn_no.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_no.TextStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_no.TextStyle.Text = "Crear";
            this.btn_no.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del archivo:";
            // 
            // tb_NameArch
            // 
            this.tb_NameArch.CaptionStyle.CaptionAlignment = Klik.Windows.Forms.v1.Common.SideAlignment.Right;
            this.tb_NameArch.CaptionStyle.CaptionSize = 0;
            this.tb_NameArch.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.tb_NameArch.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.tb_NameArch.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_NameArch.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameArch.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.tb_NameArch.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.tb_NameArch.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.tb_NameArch.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameArch.EditBoxStyle.ForeColor = System.Drawing.Color.Black;
            this.tb_NameArch.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_NameArch.Location = new System.Drawing.Point(32, 47);
            this.tb_NameArch.Name = "tb_NameArch";
            this.tb_NameArch.Size = new System.Drawing.Size(286, 38);
            this.tb_NameArch.TabIndex = 15;
            this.tb_NameArch.ValidationStyle.PasswordChar = '\0';
            this.tb_NameArch.Value = "";
            // 
            // cb_Formato
            // 
            // 
            // 
            // 
            this.cb_Formato.ButtonStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.cb_Formato.ButtonStyle.TextStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Formato.CaptionStyle.CaptionSize = 0;
            this.cb_Formato.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.cb_Formato.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.cb_Formato.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.cb_Formato.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.cb_Formato.CheckedDisplaySeparator = ',';
            this.cb_Formato.DropDownBackgroundStyle.GradientAngle = 45F;
            this.cb_Formato.DropDownBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.cb_Formato.DropDownBackgroundStyle.SolidColor = System.Drawing.SystemColors.Window;
            this.cb_Formato.DropDownBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.cb_Formato.DropDownDescriptionFont = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Formato.DropDownItemOffice2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            elListBoxSelectionStyles1.HotTrackStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            elListBoxSelectionStyles1.HotTrackStyle.BorderStyle.EdgeRadius = 4;
            elListBoxSelectionStyles1.SelectedStyle.BorderStyle.EdgeRadius = 4;
            this.cb_Formato.DropDownItemSelectionStyle = elListBoxSelectionStyles1;
            this.cb_Formato.DropDownShadowType = Klik.Windows.Forms.v1.Common.DropDownShadowTypes.Office2007;
            this.cb_Formato.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.cb_Formato.EditBoxStyle.FlashBackColor = System.Drawing.Color.Teal;
            this.cb_Formato.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Formato.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_Formato.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            elListBoxItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            elListBoxItem1.Selected = true;
            elListBoxItem1.Value = ".Zip";
            elListBoxItem2.Value = ".7z";
            elListBoxItem3.Value = ".Rar";
            this.cb_Formato.Items.Add(elListBoxItem1);
            this.cb_Formato.Items.Add(elListBoxItem2);
            this.cb_Formato.Items.Add(elListBoxItem3);
            this.cb_Formato.Location = new System.Drawing.Point(348, 47);
            this.cb_Formato.Name = "cb_Formato";
            this.cb_Formato.SelectedIndex = 0;
            this.cb_Formato.SelectedValue = ".Zip";
            this.cb_Formato.Size = new System.Drawing.Size(92, 38);
            this.cb_Formato.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ubicacion de archivo: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.ptb_Destino);
            this.panel2.Controls.Add(this.tb_Destino);
            this.panel2.Controls.Add(this.ptb_Ubicacion);
            this.panel2.Controls.Add(this.tb_Ubicacion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_Formato);
            this.panel2.Controls.Add(this.tb_NameArch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 263);
            this.panel2.TabIndex = 1;
            // 
            // ptb_Destino
            // 
            this.ptb_Destino.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Destino.Image")));
            this.ptb_Destino.Location = new System.Drawing.Point(399, 213);
            this.ptb_Destino.Name = "ptb_Destino";
            this.ptb_Destino.Size = new System.Drawing.Size(41, 35);
            this.ptb_Destino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Destino.TabIndex = 25;
            this.ptb_Destino.TabStop = false;
            this.ptb_Destino.Click += new System.EventHandler(this.ptb_Destino_Click);
            // 
            // tb_Destino
            // 
            this.tb_Destino.CaptionStyle.CaptionAlignment = Klik.Windows.Forms.v1.Common.SideAlignment.Right;
            this.tb_Destino.CaptionStyle.CaptionSize = 0;
            this.tb_Destino.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.tb_Destino.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.tb_Destino.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_Destino.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Destino.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.tb_Destino.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.tb_Destino.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.tb_Destino.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Destino.EditBoxStyle.ForeColor = System.Drawing.Color.Black;
            this.tb_Destino.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_Destino.Location = new System.Drawing.Point(32, 213);
            this.tb_Destino.Name = "tb_Destino";
            this.tb_Destino.Size = new System.Drawing.Size(359, 38);
            this.tb_Destino.TabIndex = 24;
            this.tb_Destino.ValidationStyle.PasswordChar = '\0';
            this.tb_Destino.Value = "";
            // 
            // ptb_Ubicacion
            // 
            this.ptb_Ubicacion.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Ubicacion.Image")));
            this.ptb_Ubicacion.Location = new System.Drawing.Point(399, 130);
            this.ptb_Ubicacion.Name = "ptb_Ubicacion";
            this.ptb_Ubicacion.Size = new System.Drawing.Size(41, 35);
            this.ptb_Ubicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Ubicacion.TabIndex = 23;
            this.ptb_Ubicacion.TabStop = false;
            this.ptb_Ubicacion.Click += new System.EventHandler(this.ptb_Ubicacion_Click);
            // 
            // tb_Ubicacion
            // 
            this.tb_Ubicacion.CaptionStyle.CaptionAlignment = Klik.Windows.Forms.v1.Common.SideAlignment.Right;
            this.tb_Ubicacion.CaptionStyle.CaptionSize = 0;
            this.tb_Ubicacion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.tb_Ubicacion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.tb_Ubicacion.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_Ubicacion.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ubicacion.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.tb_Ubicacion.CaptionStyle.TextStyle.Text = "elEntryBox1";
            this.tb_Ubicacion.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.tb_Ubicacion.EditBoxStyle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ubicacion.EditBoxStyle.ForeColor = System.Drawing.Color.Black;
            this.tb_Ubicacion.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.tb_Ubicacion.Location = new System.Drawing.Point(32, 130);
            this.tb_Ubicacion.Name = "tb_Ubicacion";
            this.tb_Ubicacion.Size = new System.Drawing.Size(359, 38);
            this.tb_Ubicacion.TabIndex = 22;
            this.tb_Ubicacion.ValidationStyle.PasswordChar = '\0';
            this.tb_Ubicacion.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Destino:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NameArch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Formato)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Destino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Destino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Ubicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_no;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Klik.Windows.Forms.v1.EntryLib.ELComboBox cb_Formato;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox tb_NameArch;
        private System.Windows.Forms.Label label2;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton elButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdUbicacion;
        private System.Windows.Forms.FolderBrowserDialog fbdDestino;
        private System.Windows.Forms.PictureBox ptb_Destino;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox tb_Destino;
        private System.Windows.Forms.PictureBox ptb_Ubicacion;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox tb_Ubicacion;
    }
}

