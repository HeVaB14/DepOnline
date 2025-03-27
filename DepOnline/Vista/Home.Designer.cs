namespace DepOnline.Vista
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.pnlSubmenu = new System.Windows.Forms.Panel();
            this.btnnodis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCuartotal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsalir = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCuarto = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barratitulo = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.name = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlper = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAyuda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuVertical.SuspendLayout();
            this.pnlSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.pnlSubmenu);
            this.MenuVertical.Controls.Add(this.btnsalir);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.btnCuarto);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(244, 650);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // pnlSubmenu
            // 
            this.pnlSubmenu.Controls.Add(this.btnnodis);
            this.pnlSubmenu.Controls.Add(this.btnDis);
            this.pnlSubmenu.Controls.Add(this.btnCuartotal);
            this.pnlSubmenu.Location = new System.Drawing.Point(41, 393);
            this.pnlSubmenu.Name = "pnlSubmenu";
            this.pnlSubmenu.Size = new System.Drawing.Size(200, 119);
            this.pnlSubmenu.TabIndex = 29;
            this.pnlSubmenu.Visible = false;
            // 
            // btnnodis
            // 
            this.btnnodis.ActiveBorderThickness = 1;
            this.btnnodis.ActiveCornerRadius = 20;
            this.btnnodis.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnnodis.ActiveForecolor = System.Drawing.Color.White;
            this.btnnodis.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnnodis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnodis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnodis.BackgroundImage")));
            this.btnnodis.ButtonText = "Cuartos No disponibles";
            this.btnnodis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnodis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnodis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnnodis.IdleBorderThickness = 1;
            this.btnnodis.IdleCornerRadius = 20;
            this.btnnodis.IdleFillColor = System.Drawing.Color.White;
            this.btnnodis.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnnodis.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnnodis.Location = new System.Drawing.Point(5, 78);
            this.btnnodis.Margin = new System.Windows.Forms.Padding(5);
            this.btnnodis.Name = "btnnodis";
            this.btnnodis.Size = new System.Drawing.Size(195, 41);
            this.btnnodis.TabIndex = 3;
            this.btnnodis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnnodis, "¡Genera el total de Cuartos que tiene en renta!");
            this.btnnodis.Click += new System.EventHandler(this.btnnodis_Click);
            // 
            // btnDis
            // 
            this.btnDis.ActiveBorderThickness = 1;
            this.btnDis.ActiveCornerRadius = 20;
            this.btnDis.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDis.ActiveForecolor = System.Drawing.Color.White;
            this.btnDis.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDis.BackgroundImage")));
            this.btnDis.ButtonText = "Cuartos disponibles";
            this.btnDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDis.IdleBorderThickness = 1;
            this.btnDis.IdleCornerRadius = 20;
            this.btnDis.IdleFillColor = System.Drawing.Color.White;
            this.btnDis.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDis.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDis.Location = new System.Drawing.Point(5, 39);
            this.btnDis.Margin = new System.Windows.Forms.Padding(5);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(195, 41);
            this.btnDis.TabIndex = 1;
            this.btnDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnDis, "!Genere el total de cuartos disponibles!");
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnCuartotal
            // 
            this.btnCuartotal.ActiveBorderThickness = 1;
            this.btnCuartotal.ActiveCornerRadius = 20;
            this.btnCuartotal.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCuartotal.ActiveForecolor = System.Drawing.Color.White;
            this.btnCuartotal.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCuartotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuartotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuartotal.BackgroundImage")));
            this.btnCuartotal.ButtonText = "Total de Cuartos";
            this.btnCuartotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuartotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuartotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCuartotal.IdleBorderThickness = 1;
            this.btnCuartotal.IdleCornerRadius = 20;
            this.btnCuartotal.IdleFillColor = System.Drawing.Color.White;
            this.btnCuartotal.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCuartotal.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCuartotal.Location = new System.Drawing.Point(5, 2);
            this.btnCuartotal.Margin = new System.Windows.Forms.Padding(5);
            this.btnCuartotal.Name = "btnCuartotal";
            this.btnCuartotal.Size = new System.Drawing.Size(195, 41);
            this.btnCuartotal.TabIndex = 0;
            this.btnCuartotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnCuartotal, "¡Genera el total de Cuartos que tiene en el sistema!");
            this.btnCuartotal.Click += new System.EventHandler(this.btnCuartotal_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsalir.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsalir.colorActive = System.Drawing.Color.SeaGreen;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImagePosition = 20;
            this.btnsalir.ImageZoom = 50;
            this.btnsalir.LabelPosition = 41;
            this.btnsalir.LabelText = "Salir";
            this.btnsalir.Location = new System.Drawing.Point(41, 521);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(128, 123);
            this.btnsalir.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnsalir, "Salir del sistema");
            this.btnsalir.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportes.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReportes.colorActive = System.Drawing.Color.SeaGreen;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImagePosition = 20;
            this.btnReportes.ImageZoom = 50;
            this.btnReportes.LabelPosition = 41;
            this.btnReportes.LabelText = "Reportes";
            this.btnReportes.Location = new System.Drawing.Point(41, 255);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(6);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(128, 129);
            this.btnReportes.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnReportes, "¡Aqui se podra generar los reportes: para saber sobre la información de los cuart" +
        "os.!");
            this.btnReportes.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btnCuarto
            // 
            this.btnCuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuarto.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCuarto.colorActive = System.Drawing.Color.SeaGreen;
            this.btnCuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuarto.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCuarto.ForeColor = System.Drawing.Color.White;
            this.btnCuarto.Image = ((System.Drawing.Image)(resources.GetObject("btnCuarto.Image")));
            this.btnCuarto.ImagePosition = 20;
            this.btnCuarto.ImageZoom = 50;
            this.btnCuarto.LabelPosition = 41;
            this.btnCuarto.LabelText = " Cuartos";
            this.btnCuarto.Location = new System.Drawing.Point(41, 114);
            this.btnCuarto.Margin = new System.Windows.Forms.Padding(6);
            this.btnCuarto.Name = "btnCuarto";
            this.btnCuarto.Size = new System.Drawing.Size(128, 129);
            this.btnCuarto.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnCuarto, "¡Aqui Podra agregar los cuartos que desee publicar!");
            this.btnCuarto.Click += new System.EventHandler(this.btnCuarto_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // barratitulo
            // 
            this.barratitulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barratitulo.BackColor = System.Drawing.Color.SeaGreen;
            this.barratitulo.Controls.Add(this.pictureBox7);
            this.barratitulo.Controls.Add(this.name);
            this.barratitulo.Controls.Add(this.pnlper);
            this.barratitulo.Controls.Add(this.btnAyuda);
            this.barratitulo.Controls.Add(this.btnMinimizar);
            this.barratitulo.Controls.Add(this.pictureBox8);
            this.barratitulo.Controls.Add(this.btnCerrar);
            this.barratitulo.Controls.Add(this.pictureBox3);
            this.barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barratitulo.Location = new System.Drawing.Point(244, 0);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1056, 49);
            this.barratitulo.TabIndex = 1;
            this.barratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barratitulo_Paint);
            this.barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barratitulo_MouseDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(961, 6);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // name
            // 
            this.name.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.name.BorderRadius = 0;
            this.name.ButtonText = "Perfil";
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.DisabledColor = System.Drawing.Color.Gray;
            this.name.Iconcolor = System.Drawing.Color.Transparent;
            this.name.Iconimage = ((System.Drawing.Image)(resources.GetObject("name.Iconimage")));
            this.name.Iconimage_right = null;
            this.name.Iconimage_right_Selected = null;
            this.name.Iconimage_Selected = null;
            this.name.IconMarginLeft = 0;
            this.name.IconMarginRight = 0;
            this.name.IconRightVisible = true;
            this.name.IconRightZoom = 0D;
            this.name.IconVisible = true;
            this.name.IconZoom = 90D;
            this.name.IsTab = false;
            this.name.Location = new System.Drawing.Point(157, 1);
            this.name.Name = "name";
            this.name.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.name.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.name.OnHoverTextColor = System.Drawing.Color.White;
            this.name.selected = false;
            this.name.Size = new System.Drawing.Size(140, 48);
            this.name.TabIndex = 7;
            this.name.Text = "Perfil";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Textcolor = System.Drawing.Color.White;
            this.name.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip2.SetToolTip(this.name, "dep");
            this.toolTip1.SetToolTip(this.name, "Acerca De DepOnline");
            this.name.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // pnlper
            // 
            this.pnlper.Controls.Add(this.bunifuFlatButton4);
            this.pnlper.Controls.Add(this.bunifuFlatButton2);
            this.pnlper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlper.Location = new System.Drawing.Point(303, 1);
            this.pnlper.Name = "pnlper";
            this.pnlper.Size = new System.Drawing.Size(306, 48);
            this.pnlper.TabIndex = 8;
            this.pnlper.Visible = false;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Cerrar Sesión";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(163, -1);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(140, 48);
            this.bunifuFlatButton4.TabIndex = 9;
            this.bunifuFlatButton4.Text = "Cerrar Sesión";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip2.SetToolTip(this.bunifuFlatButton4, "dep");
            this.toolTip1.SetToolTip(this.bunifuFlatButton4, "Acerca De DepOnline");
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Editar Perfil";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(154, 48);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Editar Perfil";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip2.SetToolTip(this.bunifuFlatButton2, "dep");
            this.toolTip1.SetToolTip(this.bunifuFlatButton2, "Acerca De DepOnline");
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.BorderRadius = 0;
            this.btnAyuda.ButtonText = "Ayuda";
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.DisabledColor = System.Drawing.Color.Gray;
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAyuda.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAyuda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Iconimage")));
            this.btnAyuda.Iconimage_right = null;
            this.btnAyuda.Iconimage_right_Selected = null;
            this.btnAyuda.Iconimage_Selected = null;
            this.btnAyuda.IconMarginLeft = 0;
            this.btnAyuda.IconMarginRight = 0;
            this.btnAyuda.IconRightVisible = true;
            this.btnAyuda.IconRightZoom = 0D;
            this.btnAyuda.IconVisible = true;
            this.btnAyuda.IconZoom = 90D;
            this.btnAyuda.IsTab = false;
            this.btnAyuda.Location = new System.Drawing.Point(0, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAyuda.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnAyuda.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAyuda.selected = false;
            this.btnAyuda.Size = new System.Drawing.Size(140, 48);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Textcolor = System.Drawing.Color.White;
            this.btnAyuda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip2.SetToolTip(this.btnAyuda, "dep");
            this.toolTip1.SetToolTip(this.btnAyuda, "Acerca De DepOnline");
            this.btnAyuda.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Teal;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(912, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DepOnline.Properties.Resources.icon_minimizar;
            this.pictureBox8.Location = new System.Drawing.Point(912, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(43, 40);
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Teal;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1010, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 40);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1007, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 40);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.panelcontenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelcontenedor.Location = new System.Drawing.Point(244, 46);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1056, 604);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelcontenedor_Paint);
            this.panelcontenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcontenedor_MouseDown);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.toolTip2.ToolTipTitle = "Ayuda";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.barratitulo);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.panelcontenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MenuVertical.ResumeLayout(false);
            this.pnlSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel barratitulo;
        public System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuTileButton btnCuarto;
        private Bunifu.Framework.UI.BunifuTileButton btnReportes;
        private Bunifu.Framework.UI.BunifuTileButton btnsalir;
        private System.Windows.Forms.Panel pnlSubmenu;
        private Bunifu.Framework.UI.BunifuThinButton2 btnnodis;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDis;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCuartotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnAyuda;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Panel pnlper;
        private Bunifu.Framework.UI.BunifuFlatButton name;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}