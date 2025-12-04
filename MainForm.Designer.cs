namespace SS_OpenCV
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negative2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationInverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resize2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPonderadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transicaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarizacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoProjecçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLetrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageApl = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BasedeDados = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageApl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.identificarMatriculaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.transformsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.autoZoomToolStripMenuItem,
            this.histogramaToolStripMenuItem,
            this.binarizacaoToolStripMenuItem,
            this.funçõesMatriculaToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.negative2ToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // convertToToolStripMenuItem
            // 
            this.convertToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem,
            this.bWToolStripMenuItem});
            this.convertToToolStripMenuItem.Name = "convertToToolStripMenuItem";
            this.convertToToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.convertToToolStripMenuItem.Text = "Convert To";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // bWToolStripMenuItem
            // 
            this.bWToolStripMenuItem.Name = "bWToolStripMenuItem";
            this.bWToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.bWToolStripMenuItem.Text = "B&W";
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // negative2ToolStripMenuItem
            // 
            this.negative2ToolStripMenuItem.Name = "negative2ToolStripMenuItem";
            this.negative2ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.negative2ToolStripMenuItem.Text = "Negative2";
            this.negative2ToolStripMenuItem.Click += new System.EventHandler(this.negative2ToolStripMenuItem_Click);
            // 
            // transformsToolStripMenuItem
            // 
            this.transformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.rotationInverseToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.resize2ToolStripMenuItem});
            this.transformsToolStripMenuItem.Name = "transformsToolStripMenuItem";
            this.transformsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.transformsToolStripMenuItem.Text = "Transforms";
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.translationToolStripMenuItem.Text = "Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // rotationInverseToolStripMenuItem
            // 
            this.rotationInverseToolStripMenuItem.Name = "rotationInverseToolStripMenuItem";
            this.rotationInverseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.rotationInverseToolStripMenuItem.Text = "Rotation (Inverse)";
            this.rotationInverseToolStripMenuItem.Click += new System.EventHandler(this.rotationInverseToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // resize2ToolStripMenuItem
            // 
            this.resize2ToolStripMenuItem.Name = "resize2ToolStripMenuItem";
            this.resize2ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.resize2ToolStripMenuItem.Text = "Resize2";
            this.resize2ToolStripMenuItem.Click += new System.EventHandler(this.resize2ToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.mediaPonderadaToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.transicaoToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mediaToolStripMenuItem.Text = "Media";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click_1);
            // 
            // mediaPonderadaToolStripMenuItem
            // 
            this.mediaPonderadaToolStripMenuItem.Name = "mediaPonderadaToolStripMenuItem";
            this.mediaPonderadaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mediaPonderadaToolStripMenuItem.Text = "Media Ponderada";
            this.mediaPonderadaToolStripMenuItem.Click += new System.EventHandler(this.mediaPonderadaToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // transicaoToolStripMenuItem
            // 
            this.transicaoToolStripMenuItem.Name = "transicaoToolStripMenuItem";
            this.transicaoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.transicaoToolStripMenuItem.Text = "Transicao";
            this.transicaoToolStripMenuItem.Click += new System.EventHandler(this.transicaoToolStripMenuItem_Click);
            // 
            // autoZoomToolStripMenuItem
            // 
            this.autoZoomToolStripMenuItem.CheckOnClick = true;
            this.autoZoomToolStripMenuItem.Name = "autoZoomToolStripMenuItem";
            this.autoZoomToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.autoZoomToolStripMenuItem.Text = "Auto Zoom";
            this.autoZoomToolStripMenuItem.Click += new System.EventHandler(this.autoZoomToolStripMenuItem_Click);
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            this.histogramaToolStripMenuItem.Click += new System.EventHandler(this.histogramaToolStripMenuItem_Click);
            // 
            // binarizacaoToolStripMenuItem
            // 
            this.binarizacaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otsuToolStripMenuItem,
            this.automáticaToolStripMenuItem,
            this.escolherValorToolStripMenuItem});
            this.binarizacaoToolStripMenuItem.Name = "binarizacaoToolStripMenuItem";
            this.binarizacaoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.binarizacaoToolStripMenuItem.Text = "Binarizacao";
            this.binarizacaoToolStripMenuItem.Click += new System.EventHandler(this.binarizacaoToolStripMenuItem_Click_1);
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.otsuToolStripMenuItem.Text = "Otsu";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // automáticaToolStripMenuItem
            // 
            this.automáticaToolStripMenuItem.Name = "automáticaToolStripMenuItem";
            this.automáticaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.automáticaToolStripMenuItem.Text = "Valor Predefinido";
            this.automáticaToolStripMenuItem.Click += new System.EventHandler(this.automáticaToolStripMenuItem_Click);
            // 
            // escolherValorToolStripMenuItem
            // 
            this.escolherValorToolStripMenuItem.Name = "escolherValorToolStripMenuItem";
            this.escolherValorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.escolherValorToolStripMenuItem.Text = "Escolher Valor";
            this.escolherValorToolStripMenuItem.Click += new System.EventHandler(this.escolherValorToolStripMenuItem_Click);
            // 
            // funçõesMatriculaToolStripMenuItem
            // 
            this.funçõesMatriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.graficoProjecçõesToolStripMenuItem,
            this.buscarLetrasToolStripMenuItem});
            this.funçõesMatriculaToolStripMenuItem.Name = "funçõesMatriculaToolStripMenuItem";
            this.funçõesMatriculaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.funçõesMatriculaToolStripMenuItem.Text = "Tratamento de Matricula";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // graficoProjecçõesToolStripMenuItem
            // 
            this.graficoProjecçõesToolStripMenuItem.Name = "graficoProjecçõesToolStripMenuItem";
            this.graficoProjecçõesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.graficoProjecçõesToolStripMenuItem.Text = "Grafico Projecções";
            this.graficoProjecçõesToolStripMenuItem.Click += new System.EventHandler(this.graficoProjecçõesToolStripMenuItem_Click);
            // 
            // buscarLetrasToolStripMenuItem
            // 
            this.buscarLetrasToolStripMenuItem.Name = "buscarLetrasToolStripMenuItem";
            this.buscarLetrasToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.buscarLetrasToolStripMenuItem.Text = "Buscar Letras";
            this.buscarLetrasToolStripMenuItem.Click += new System.EventHandler(this.buscarLetrasToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.autoresToolStripMenuItem.Text = "Autores...";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // identificarMatriculaToolStripMenuItem
            // 
            this.identificarMatriculaToolStripMenuItem.Name = "identificarMatriculaToolStripMenuItem";
            this.identificarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.identificarMatriculaToolStripMenuItem.Text = "Identificar Matricula";
            this.identificarMatriculaToolStripMenuItem.Click += new System.EventHandler(this.identificarMatriculaToolStripMenuItem_Click);
            // 
            // ImageApl
            // 
            this.ImageApl.Location = new System.Drawing.Point(3, 3);
            this.ImageApl.Name = "ImageApl";
            this.ImageApl.Size = new System.Drawing.Size(576, 427);
            this.ImageApl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageApl.TabIndex = 6;
            this.ImageApl.TabStop = false;
            this.ImageApl.Click += new System.EventHandler(this.ImageApl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 516);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BasedeDados
            // 
            this.BasedeDados.FormattingEnabled = true;
            this.BasedeDados.Location = new System.Drawing.Point(661, 367);
            this.BasedeDados.Name = "BasedeDados";
            this.BasedeDados.Size = new System.Drawing.Size(47, 121);
            this.BasedeDados.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(405, 516);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(469, 516);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 58);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(533, 516);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 58);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(597, 516);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 58);
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(661, 516);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 58);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Matricula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Letras Retiradas da Matricula";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(54, 516);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 58);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BasedeDados);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ImageApl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 624);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Matricula Retirada Binarizada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistemas Sensoriais 2012/2013 - Image processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageApl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negative2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationInverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaPonderadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarizacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transicaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funçõesMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoProjecçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLetrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolherValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resize2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificarMatriculaToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImageApl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox BasedeDados;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

