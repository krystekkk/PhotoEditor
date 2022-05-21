
namespace EdytorZdjec
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.righRotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftRotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalRotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalRotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonPixellate = new System.Windows.Forms.Button();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonGrayscale = new System.Windows.Forms.Button();
            this.buttonSepia = new System.Windows.Forms.Button();
            this.buttonMedianBlur = new System.Windows.Forms.Button();
            this.buttonTransparency = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelContrast = new System.Windows.Forms.Label();
            this.labelHue = new System.Windows.Forms.Label();
            this.buttonFinalCrop = new System.Windows.Forms.Button();
            this.buttonNormalFilter = new System.Windows.Forms.Button();
            this.buttonCutSelectedArea = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.buttonHighPass = new System.Windows.Forms.Button();
            this.buttonEdges = new System.Windows.Forms.Button();
            this.buttonEmboss = new System.Windows.Forms.Button();
            this.buttonMotionBlur = new System.Windows.Forms.Button();
            this.buttonCopyArea = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGToolStripMenuItem,
            this.jPGToolStripMenuItem,
            this.gIFToolStripMenuItem,
            this.bMPToolStripMenuItem,
            this.iCOToolStripMenuItem});
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportAsToolStripMenuItem.Text = "Export As";
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.AccessibleDescription = "";
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Tag = "";
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jPGToolStripMenuItem.Text = "JPG";
            // 
            // gIFToolStripMenuItem
            // 
            this.gIFToolStripMenuItem.Name = "gIFToolStripMenuItem";
            this.gIFToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.gIFToolStripMenuItem.Text = "GIF";
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            // 
            // iCOToolStripMenuItem
            // 
            this.iCOToolStripMenuItem.Name = "iCOToolStripMenuItem";
            this.iCOToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.iCOToolStripMenuItem.Text = "ICO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.righRotateToolStripMenuItem,
            this.leftRotateToolStripMenuItem,
            this.horizontalRotateToolStripMenuItem,
            this.verticalRotateToolStripMenuItem});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // righRotateToolStripMenuItem
            // 
            this.righRotateToolStripMenuItem.Name = "righRotateToolStripMenuItem";
            this.righRotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.righRotateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.righRotateToolStripMenuItem.Text = "Righ rotate";
            this.righRotateToolStripMenuItem.Click += new System.EventHandler(this.righRotateToolStripMenuItem_Click);
            // 
            // leftRotateToolStripMenuItem
            // 
            this.leftRotateToolStripMenuItem.Name = "leftRotateToolStripMenuItem";
            this.leftRotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.leftRotateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.leftRotateToolStripMenuItem.Text = "Left rotate";
            this.leftRotateToolStripMenuItem.Click += new System.EventHandler(this.leftRotateToolStripMenuItem_Click);
            // 
            // horizontalRotateToolStripMenuItem
            // 
            this.horizontalRotateToolStripMenuItem.Name = "horizontalRotateToolStripMenuItem";
            this.horizontalRotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.horizontalRotateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.horizontalRotateToolStripMenuItem.Text = "Horizontal rotate";
            this.horizontalRotateToolStripMenuItem.Click += new System.EventHandler(this.horizontalRotateToolStripMenuItem_Click);
            // 
            // verticalRotateToolStripMenuItem
            // 
            this.verticalRotateToolStripMenuItem.Name = "verticalRotateToolStripMenuItem";
            this.verticalRotateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.verticalRotateToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.verticalRotateToolStripMenuItem.Text = "Vertical rotate";
            this.verticalRotateToolStripMenuItem.Click += new System.EventHandler(this.verticalRotateToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Location = new System.Drawing.Point(54, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1732, 957);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonCrop
            // 
            this.buttonCrop.Image = ((System.Drawing.Image)(resources.GetObject("buttonCrop.Image")));
            this.buttonCrop.Location = new System.Drawing.Point(12, 116);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(36, 34);
            this.buttonCrop.TabIndex = 3;
            this.myToolTip.SetToolTip(this.buttonCrop, "Crop Tool");
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(12, 959);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(36, 34);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.Location = new System.Drawing.Point(12, 76);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(36, 34);
            this.buttonCopy.TabIndex = 9;
            this.myToolTip.SetToolTip(this.buttonCopy, "Select Tool");
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPixellate
            // 
            this.buttonPixellate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPixellate.ForeColor = System.Drawing.Color.White;
            this.buttonPixellate.Location = new System.Drawing.Point(12, 196);
            this.buttonPixellate.Name = "buttonPixellate";
            this.buttonPixellate.Size = new System.Drawing.Size(36, 34);
            this.buttonPixellate.TabIndex = 12;
            this.buttonPixellate.Text = "px";
            this.myToolTip.SetToolTip(this.buttonPixellate, "Pixelate Tool");
            this.buttonPixellate.UseVisualStyleBackColor = true;
            this.buttonPixellate.Click += new System.EventHandler(this.buttonPixellate_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotate.Image")));
            this.buttonRotate.Location = new System.Drawing.Point(12, 236);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(36, 34);
            this.buttonRotate.TabIndex = 13;
            this.myToolTip.SetToolTip(this.buttonRotate, "Classic Rotate");
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Image = ((System.Drawing.Image)(resources.GetObject("buttonReload.Image")));
            this.buttonReload.Location = new System.Drawing.Point(12, 36);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(36, 34);
            this.buttonReload.TabIndex = 14;
            this.myToolTip.SetToolTip(this.buttonReload, "Rotate");
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Image = ((System.Drawing.Image)(resources.GetObject("buttonFilter.Image")));
            this.buttonFilter.Location = new System.Drawing.Point(12, 316);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(36, 34);
            this.buttonFilter.TabIndex = 19;
            this.myToolTip.SetToolTip(this.buttonFilter, "Filter Tool");
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.Image = ((System.Drawing.Image)(resources.GetObject("buttonCut.Image")));
            this.buttonCut.Location = new System.Drawing.Point(12, 156);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(36, 34);
            this.buttonCut.TabIndex = 36;
            this.myToolTip.SetToolTip(this.buttonCut, "Cut");
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonGrayscale
            // 
            this.buttonGrayscale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGrayscale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGrayscale.Location = new System.Drawing.Point(1792, 36);
            this.buttonGrayscale.Name = "buttonGrayscale";
            this.buttonGrayscale.Size = new System.Drawing.Size(130, 34);
            this.buttonGrayscale.TabIndex = 15;
            this.buttonGrayscale.Text = "Grayscale";
            this.buttonGrayscale.UseVisualStyleBackColor = true;
            this.buttonGrayscale.Visible = false;
            this.buttonGrayscale.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // buttonSepia
            // 
            this.buttonSepia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSepia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSepia.Location = new System.Drawing.Point(1792, 76);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(130, 34);
            this.buttonSepia.TabIndex = 20;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = true;
            this.buttonSepia.Visible = false;
            this.buttonSepia.Click += new System.EventHandler(this.buttonSepia_Click);
            // 
            // buttonMedianBlur
            // 
            this.buttonMedianBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMedianBlur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMedianBlur.Location = new System.Drawing.Point(1792, 316);
            this.buttonMedianBlur.Name = "buttonMedianBlur";
            this.buttonMedianBlur.Size = new System.Drawing.Size(130, 34);
            this.buttonMedianBlur.TabIndex = 21;
            this.buttonMedianBlur.Text = "Mean Blur";
            this.buttonMedianBlur.UseVisualStyleBackColor = true;
            this.buttonMedianBlur.Visible = false;
            this.buttonMedianBlur.Click += new System.EventHandler(this.buttonMedianBlur_Click);
            // 
            // buttonTransparency
            // 
            this.buttonTransparency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransparency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTransparency.Location = new System.Drawing.Point(1792, 116);
            this.buttonTransparency.Name = "buttonTransparency";
            this.buttonTransparency.Size = new System.Drawing.Size(130, 34);
            this.buttonTransparency.TabIndex = 23;
            this.buttonTransparency.Text = "Transparency";
            this.buttonTransparency.UseVisualStyleBackColor = true;
            this.buttonTransparency.Visible = false;
            this.buttonTransparency.Click += new System.EventHandler(this.buttonTransparency_Click);
            // 
            // buttonNegative
            // 
            this.buttonNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNegative.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNegative.Location = new System.Drawing.Point(1792, 156);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(130, 34);
            this.buttonNegative.TabIndex = 24;
            this.buttonNegative.Text = "Negative";
            this.buttonNegative.UseVisualStyleBackColor = true;
            this.buttonNegative.Visible = false;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarContrast.Location = new System.Drawing.Point(1792, 767);
            this.trackBarContrast.Maximum = 20;
            this.trackBarContrast.Minimum = 1;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(130, 45);
            this.trackBarContrast.TabIndex = 25;
            this.trackBarContrast.Value = 10;
            this.trackBarContrast.Visible = false;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            // 
            // trackBarHue
            // 
            this.trackBarHue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarHue.Location = new System.Drawing.Point(1792, 835);
            this.trackBarHue.Maximum = 20;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(130, 45);
            this.trackBarHue.TabIndex = 26;
            this.trackBarHue.Value = 10;
            this.trackBarHue.Visible = false;
            this.trackBarHue.ValueChanged += new System.EventHandler(this.trackBarHue_ValueChanged);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBrightness.Location = new System.Drawing.Point(1792, 699);
            this.trackBarBrightness.Minimum = -10;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(130, 45);
            this.trackBarBrightness.TabIndex = 27;
            this.trackBarBrightness.Value = 1;
            this.trackBarBrightness.Visible = false;
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            // 
            // labelBrightness
            // 
            this.labelBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.labelBrightness.ForeColor = System.Drawing.Color.White;
            this.labelBrightness.Location = new System.Drawing.Point(1823, 679);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(70, 17);
            this.labelBrightness.TabIndex = 28;
            this.labelBrightness.Text = "Brightness";
            this.labelBrightness.Visible = false;
            // 
            // labelContrast
            // 
            this.labelContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrast.AutoSize = true;
            this.labelContrast.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.labelContrast.ForeColor = System.Drawing.Color.White;
            this.labelContrast.Location = new System.Drawing.Point(1823, 747);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(64, 17);
            this.labelContrast.TabIndex = 29;
            this.labelContrast.Text = "Contrast";
            this.labelContrast.Visible = false;
            // 
            // labelHue
            // 
            this.labelHue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHue.AutoSize = true;
            this.labelHue.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.labelHue.ForeColor = System.Drawing.Color.White;
            this.labelHue.Location = new System.Drawing.Point(1823, 815);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(74, 17);
            this.labelHue.TabIndex = 30;
            this.labelHue.Text = "Saturation";
            this.labelHue.Visible = false;
            // 
            // buttonFinalCrop
            // 
            this.buttonFinalCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinalCrop.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFinalCrop.Location = new System.Drawing.Point(1792, 36);
            this.buttonFinalCrop.Name = "buttonFinalCrop";
            this.buttonFinalCrop.Size = new System.Drawing.Size(130, 34);
            this.buttonFinalCrop.TabIndex = 31;
            this.buttonFinalCrop.Text = "Crop";
            this.buttonFinalCrop.UseVisualStyleBackColor = true;
            this.buttonFinalCrop.Visible = false;
            this.buttonFinalCrop.Click += new System.EventHandler(this.buttonFinalCrop_Click);
            // 
            // buttonNormalFilter
            // 
            this.buttonNormalFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNormalFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNormalFilter.Location = new System.Drawing.Point(1792, 600);
            this.buttonNormalFilter.Name = "buttonNormalFilter";
            this.buttonNormalFilter.Size = new System.Drawing.Size(130, 34);
            this.buttonNormalFilter.TabIndex = 33;
            this.buttonNormalFilter.Text = "Normal";
            this.buttonNormalFilter.UseVisualStyleBackColor = true;
            this.buttonNormalFilter.Visible = false;
            this.buttonNormalFilter.Click += new System.EventHandler(this.buttonNormalFilter_Click);
            // 
            // buttonCutSelectedArea
            // 
            this.buttonCutSelectedArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCutSelectedArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCutSelectedArea.Location = new System.Drawing.Point(1792, 36);
            this.buttonCutSelectedArea.Name = "buttonCutSelectedArea";
            this.buttonCutSelectedArea.Size = new System.Drawing.Size(130, 34);
            this.buttonCutSelectedArea.TabIndex = 37;
            this.buttonCutSelectedArea.Text = "Cut selected";
            this.buttonCutSelectedArea.UseVisualStyleBackColor = true;
            this.buttonCutSelectedArea.Visible = false;
            this.buttonCutSelectedArea.Click += new System.EventHandler(this.buttonCutSelectedArea_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRed.Location = new System.Drawing.Point(1792, 196);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(130, 34);
            this.buttonRed.TabIndex = 43;
            this.buttonRed.Text = "Red";
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Visible = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGreen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGreen.Location = new System.Drawing.Point(1792, 236);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(130, 34);
            this.buttonGreen.TabIndex = 44;
            this.buttonGreen.Text = "Green";
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Visible = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBlue.Location = new System.Drawing.Point(1792, 276);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(130, 34);
            this.buttonBlue.TabIndex = 45;
            this.buttonBlue.Text = "Blue";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Visible = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonBlur
            // 
            this.buttonBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBlur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBlur.Location = new System.Drawing.Point(1792, 356);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(130, 34);
            this.buttonBlur.TabIndex = 46;
            this.buttonBlur.Text = "Gaussian Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Visible = false;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // buttonHighPass
            // 
            this.buttonHighPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHighPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHighPass.Location = new System.Drawing.Point(1792, 436);
            this.buttonHighPass.Name = "buttonHighPass";
            this.buttonHighPass.Size = new System.Drawing.Size(130, 34);
            this.buttonHighPass.TabIndex = 47;
            this.buttonHighPass.Text = "High Pass";
            this.buttonHighPass.UseVisualStyleBackColor = true;
            this.buttonHighPass.Visible = false;
            this.buttonHighPass.Click += new System.EventHandler(this.buttonHighPass_Click);
            // 
            // buttonEdges
            // 
            this.buttonEdges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdges.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdges.Location = new System.Drawing.Point(1792, 476);
            this.buttonEdges.Name = "buttonEdges";
            this.buttonEdges.Size = new System.Drawing.Size(130, 34);
            this.buttonEdges.TabIndex = 48;
            this.buttonEdges.Text = "Egdes Detection";
            this.buttonEdges.UseVisualStyleBackColor = true;
            this.buttonEdges.Visible = false;
            this.buttonEdges.Click += new System.EventHandler(this.buttonEdges_Click);
            // 
            // buttonEmboss
            // 
            this.buttonEmboss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmboss.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEmboss.Location = new System.Drawing.Point(1792, 516);
            this.buttonEmboss.Name = "buttonEmboss";
            this.buttonEmboss.Size = new System.Drawing.Size(130, 34);
            this.buttonEmboss.TabIndex = 49;
            this.buttonEmboss.Text = "Emboss";
            this.buttonEmboss.UseVisualStyleBackColor = true;
            this.buttonEmboss.Visible = false;
            this.buttonEmboss.Click += new System.EventHandler(this.buttonEmboss_Click);
            // 
            // buttonMotionBlur
            // 
            this.buttonMotionBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMotionBlur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMotionBlur.Location = new System.Drawing.Point(1792, 396);
            this.buttonMotionBlur.Name = "buttonMotionBlur";
            this.buttonMotionBlur.Size = new System.Drawing.Size(130, 34);
            this.buttonMotionBlur.TabIndex = 50;
            this.buttonMotionBlur.Text = "Motion Blur";
            this.buttonMotionBlur.UseVisualStyleBackColor = true;
            this.buttonMotionBlur.Visible = false;
            this.buttonMotionBlur.Click += new System.EventHandler(this.buttonMotionBlur_Click);
            // 
            // buttonCopyArea
            // 
            this.buttonCopyArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCopyArea.Location = new System.Drawing.Point(1792, 36);
            this.buttonCopyArea.Name = "buttonCopyArea";
            this.buttonCopyArea.Size = new System.Drawing.Size(130, 34);
            this.buttonCopyArea.TabIndex = 51;
            this.buttonCopyArea.Text = "Copy selected";
            this.buttonCopyArea.UseVisualStyleBackColor = true;
            this.buttonCopyArea.Visible = false;
            this.buttonCopyArea.Click += new System.EventHandler(this.buttonCopyArea_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPaste.Location = new System.Drawing.Point(1792, 76);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(130, 34);
            this.buttonPaste.TabIndex = 52;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Visible = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1934, 1005);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCopyArea);
            this.Controls.Add(this.buttonMotionBlur);
            this.Controls.Add(this.buttonEmboss);
            this.Controls.Add(this.buttonEdges);
            this.Controls.Add(this.buttonHighPass);
            this.Controls.Add(this.buttonBlur);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonCutSelectedArea);
            this.Controls.Add(this.buttonCut);
            this.Controls.Add(this.buttonNormalFilter);
            this.Controls.Add(this.buttonFinalCrop);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.labelContrast);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.trackBarHue);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.buttonNegative);
            this.Controls.Add(this.buttonTransparency);
            this.Controls.Add(this.buttonMedianBlur);
            this.Controls.Add(this.buttonSepia);
            this.Controls.Add(this.buttonGrayscale);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonPixellate);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "Edytor zdjęć";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCOToolStripMenuItem;
        private System.Windows.Forms.Button buttonCrop;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem righRotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftRotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalRotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalRotateToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonPixellate;
        private System.Windows.Forms.ToolTip myToolTip;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonGrayscale;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSepia;
        private System.Windows.Forms.Button buttonMedianBlur;
        private System.Windows.Forms.Button buttonTransparency;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Button buttonFinalCrop;
        private System.Windows.Forms.Button buttonNormalFilter;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonCutSelectedArea;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.Button buttonHighPass;
        private System.Windows.Forms.Button buttonEdges;
        private System.Windows.Forms.Button buttonEmboss;
        private System.Windows.Forms.Button buttonMotionBlur;
        private System.Windows.Forms.Button buttonCopyArea;
        private System.Windows.Forms.Button buttonPaste;
    }
}

