using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;


namespace EdytorZdjec
{
    public partial class Form1 : Form
    {
        // Zmienne dialogowe to otwierania i zapisywania zdjęć
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();

        // Obecne zdjęcie w programie
        Image image;

        // Zmienna do rysowania w GDI+
        Graphics graph;

        // Czy załadowano zdjęcie do programu
        bool isImageOpened = false;

        // Te wartości określają, która funkcja jest obecnie włączona
        bool cropping = false;
        bool cutting = false;
        bool copying = false;

        // Bitmapy używane w programie
        Bitmap currentBitmap = null;
        Bitmap originalBitmap = null;

        // Bitmapa używana do rotacji
        Bitmap rotatedImageBitmap = null;

        public Form1()
        {
            InitializeComponent();
            graph = pictureBox1.CreateGraphics();
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            buttonInitialization();

            AutoSize = false;
            AutoScaleMode = AutoScaleMode.Font;
        }
        
        private void loadImage()
        {
            // Setting OpenFile Dialog parameters like title of window and available formats
            openFile.Title = "Open Image";
            openFile.Filter = "All files (*.*)|*.*|JPEG (*.jpeg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|ICO (*.ico)|*.ico";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFile.FileName;
                isImageOpened = true;

                originalBitmap = new Bitmap(openFile.FileName);

                // Bitmap used in pixelate operation
                
                using (Bitmap pixellateBm = new Bitmap(openFile.FileName))
                {
                    currentBitmap = pixellateBm.Clone() as Bitmap;
                    pictureBox1.Image = pixellateBm.Clone() as Image;
                }
                
            }
        }

        private void saveImage()
        {
            if (isImageOpened)
            {
                // Ustaw wartości okna dialogowego
                saveFile.Title = "Save Image";
                saveFile.Filter = "JPEG (*.jpeg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|ICO (*.ico)|*.ico";

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFile.FileName);
                }
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. Please upload image first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        // Przeładuj zdjęcie
        void reload()
        {
            image = Image.FromFile(openFile.FileName);
            pictureBox1.Image = image;
        }


        // Ustaw domyślne wartości TrackBar
        private void resetTrackbars()
        {
            trackBarBrightness.Value = 1;
            trackBarContrast.Value = 10;
            trackBarHue.Value = 10;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        // Wyjdź z programu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool clicked = true;

            if (clicked)
            {
                string title = "Warning";
                string message = "Are you sure you want to exit?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                // Setting SaveFile Dialog parameters like title of window and available formats
                saveFile.Title = "Save Image";
                saveFile.Filter = "(*.png)|*.png";
                ImageFormat format = ImageFormat.Png;
                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFile.FileName, format);
                }
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. Please upload image first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        // Informacja o programie
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            string title = "Politechnika Poznańska";
            string message = "Image Editor in C# environment. This program was made by Krystian Śmigielski for Politechnika Poznańska. All rights reserved.";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button, MessageBoxIcon.Information);
        }

        // Ustaw domyślne parametry przycisków
        void buttonInitialization()
        {
            buttonCopy.BackColor = Color.FromArgb(70, 70, 70);
            buttonCopy.FlatStyle = FlatStyle.Flat;
            buttonCopy.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonCrop.BackColor = Color.FromArgb(70, 70, 70);
            buttonCrop.FlatStyle = FlatStyle.Flat;
            buttonCrop.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonInfo.BackColor = Color.FromArgb(70, 70, 70);
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonPixellate.BackColor = Color.FromArgb(70, 70, 70);
            buttonPixellate.FlatStyle = FlatStyle.Flat;
            buttonPixellate.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonRotate.BackColor = Color.FromArgb(70, 70, 70);
            buttonRotate.FlatStyle = FlatStyle.Flat;
            buttonRotate.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonReload.BackColor = Color.FromArgb(70, 70, 70);
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonFilter.BackColor = Color.FromArgb(70, 70, 70);
            buttonFilter.FlatStyle = FlatStyle.Flat;
            buttonFilter.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            buttonCut.BackColor = Color.FromArgb(70, 70, 70);
            buttonCut.FlatStyle = FlatStyle.Flat;
            buttonCut.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            //buttonRotateChange.BackColor = Color.FromArgb(70, 70, 70);
            //buttonRotateChange.FlatStyle = FlatStyle.Flat;
            //buttonRotateChange.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
        }


        // Funkcja skalująca obraz
        private void scaling(out int scalingFactorX, out int scalingFactorY, int x, int y)
        {
            int imageWidth = pictureBox1.Image.Width;
            int imageHeight = pictureBox1.Image.Height;

            int pictureBoxWidth = pictureBox1.Width;
            int pictureBoxHeight = pictureBox1.Height;

            if (pictureBoxWidth > imageWidth || pictureBoxWidth < imageWidth)
            {
                // Kiedy PictureBox jest szerszy lub krótszy od obrazu
                // Pozyskaj wartość Y
                scalingFactorY = y * imageHeight / pictureBoxHeight;

                float widthScaled = imageWidth * pictureBoxHeight / imageHeight;
                float xValue = (pictureBoxWidth - widthScaled) / 2;

                // Pozyskaj wartość X
                scalingFactorX = (int)((x - xValue) * imageHeight / pictureBoxHeight);
            }
            else
            {
                // Kiedy PictureBox jest wyższy lub cieńszy od obrazu
                // Pozyskaj wartość X
                scalingFactorX = imageWidth * x / pictureBoxWidth;

                float heightScaled = imageHeight * pictureBoxWidth / imageWidth;
                float yValue = (pictureBoxHeight - heightScaled) / 2;

                // Pozyskaj wartość Y
                scalingFactorY = (int)((y - yValue) * imageWidth / pictureBoxWidth);
            }
        }

        #region "CROP REGION"
        //----------------------------------------------------------------------------------------------------------
        //CROP IMAGE PART
        int cropX, cropY;

        int cropWidth, cropHeight;

        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;
        
        private void buttonCrop_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                setFilterToolsVisibility(false);
                buttonCutSelectedArea.Visible = false;
                //vScrollBarRotateAngle.Visible = false;
                //buttonResetRotate.Visible = false;
                //labelAngleValue.Visible = false;
                buttonCopyArea.Visible = false;
                buttonPaste.Visible = false;
                copying = false;
                cutting = false;

                cropping = true;
                buttonFinalCrop.Visible = true;
                buttonFinalCrop.Enabled = false;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to crop a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void cropImage()
        {
            if (cropHeight < 1 || cropWidth < 1)
            {
                return;
            }

            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            Bitmap originalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            currentBitmap = new Bitmap(cropWidth, cropHeight);

            Graphics graphics = Graphics.FromImage(currentBitmap);

            // Popraw jakość obrazu
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            graphics.DrawImage(originalImage, 0, 0, rect, GraphicsUnit.Pixel);

            pictureBox1.Image = currentBitmap;

            cropping = false;
            buttonFinalCrop.Enabled = false;
        }

        private void buttonFinalCrop_Click(object sender, EventArgs e)
        {
            cropImage();
        }
        //----------------------------------------------------------------------------------------------------------
        #endregion


        #region "PIXELATE"
        //----------------------------------------------------------------------------------------------------------
        // PIXELLATE PART
        private void buttonPixellate_Click(object sender, EventArgs e)
        {
            /*
            if (isImageOpened)
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);

                Filtering filteredBitmap = new Filtering(bitmap);

                
                int pixelWidth = 10;

                filteredBitmap.Pixellate(pixelWidth, false);

                
                pictureBox1.Image = bitmap;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to pixellate a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            */
        }
        //----------------------------------------------------------------------------------------------------------
        #endregion


        #region "Cut and copy"
        //----------------------------------------------------------------------------------------------------------
        // CUT AND COPY PART

        public Pen copyingPen;
        public Pen cuttingPen;

        public DashStyle cuttingDashStyle = DashStyle.DashDot;

        int X1, Y1, X2, Y2;
        private Graphics cutAndCopyGraphics = null;
        private Rectangle cutAndCopyRectangle;
        private Bitmap cutAndCopyBitmap = null;

        private void clipboard(Rectangle rectangle)
        {
            // Stwórz nową bitmapę wybranego obszaru
            Bitmap clipboardBitmap = new Bitmap(rectangle.Width, rectangle.Height);

            Graphics graphics = Graphics.FromImage(clipboardBitmap);

            Rectangle clipboardRectangle = new Rectangle(0, 0, rectangle.Width, rectangle.Height);
            graphics.DrawImage(originalBitmap, clipboardRectangle, rectangle, GraphicsUnit.Pixel);

            // Skopiuj wybrany obszar do schowka
            Clipboard.SetImage(clipboardBitmap);
        }

        private void copyFromImage()
        {
            clipboard(cutAndCopyRectangle);
        }

        private void cutFromImage()
        {
            clipboard(cutAndCopyRectangle);

            Graphics graphics = Graphics.FromImage(originalBitmap);

            SolidBrush solidBrush = new SolidBrush(Color.White);
            graphics.FillRectangle(solidBrush, cutAndCopyRectangle);

            cutAndCopyBitmap = new Bitmap(originalBitmap);
            pictureBox1.Image = cutAndCopyBitmap;

            cutAndCopyBitmap = null;
            cutAndCopyGraphics = null;
        }

        private void buttonCutSelectedArea_Click(object sender, EventArgs e)
        {
            cutFromImage();
            buttonCutSelectedArea.Enabled = false;

            pictureBox1.Refresh();
        }

        private void buttonCopyArea_Click(object sender, EventArgs e)
        {
            copyFromImage();
            buttonCopyArea.Enabled = false;

            pictureBox1.Refresh();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                setFilterToolsVisibility(false);
                buttonFinalCrop.Visible = false;
                //vScrollBarRotateAngle.Visible = false;
                //buttonResetRotate.Visible = false;
                //labelAngleValue.Visible = false;
                buttonCopyArea.Visible = false;
                buttonPaste.Visible = false;
                cropping = false;

                cutting = true;
                buttonCutSelectedArea.Visible = true;
                buttonCutSelectedArea.Enabled = false;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to cut a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                setFilterToolsVisibility(false);
                buttonFinalCrop.Visible = false;
                buttonCutSelectedArea.Visible = false;
                //vScrollBarRotateAngle.Visible = false;
                //buttonResetRotate.Visible = false;
                //labelAngleValue.Visible = false;
                buttonCutSelectedArea.Visible = false;

                copying = true;
                buttonCopyArea.Visible = true;
                buttonCopyArea.Enabled = false;

                buttonPaste.Visible = true;
                buttonPaste.Enabled = false;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to copy a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void pasteToTheImage()
        {
            if (Clipboard.ContainsImage() == false)
            {
                return;
            }

            Image clipboardImage = Clipboard.GetImage();

            int locationX = ((cutAndCopyRectangle.Width - clipboardImage.Width) / 2) + cutAndCopyRectangle.X;
            int locationY = ((cutAndCopyRectangle.Height - clipboardImage.Height) / 2) + cutAndCopyRectangle.Y;

            Rectangle pasteRectangle = new Rectangle(locationX, locationY, clipboardImage.Width, clipboardImage.Height);

            // Wklej obraz w narysowany prostokąt
            Graphics graphics = Graphics.FromImage(originalBitmap);
            
            graphics.DrawImage(clipboardImage, pasteRectangle);

            pictureBox1.Image = originalBitmap;
            pictureBox1.Refresh();
            cutAndCopyBitmap = null;
            cutAndCopyGraphics = null;
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            pasteToTheImage();
            Clipboard.Clear();
            buttonPaste.Enabled = false;
            buttonCopyArea.Enabled = true;
        }
        //----------------------------------------------------------------------------------------------------------
        #endregion


        private Rectangle createSelectRectangle(int x1, int y1, int x2, int y2)
        {
            Rectangle rectangle = new Rectangle(Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x1 - x2), Math.Abs(y1 - y2));

            return rectangle;
        }

        #region "PictureBox mouse events"
        //----------------------------------------------------------------------------------------------------------
        // PICTURE BOX MOUSE EVENTS
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Kadrowanie
            if (cropping)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Cursor = Cursors.Cross;
                    cropX = e.X;
                    cropY = e.Y;

                    cropPen = new Pen(Color.White, 1);
                    cropPen.DashStyle = DashStyle.DashDot;
                }
                pictureBox1.Refresh();
            }

            // Wycinanie
            if (cutting)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    scaling(out X1, out Y1, e.X, e.Y);

                    Cursor = Cursors.Cross;

                    cutAndCopyBitmap = new Bitmap(originalBitmap);
                    cutAndCopyGraphics = Graphics.FromImage(cutAndCopyBitmap);
                    pictureBox1.Image = cutAndCopyBitmap;

                    cuttingPen = new Pen(Color.White, 1);
                    cuttingPen.DashStyle = DashStyle.DashDot;
                }
                pictureBox1.Refresh();
            }

            // Kopiowanie
            if (copying)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    scaling(out X1, out Y1, e.X, e.Y);

                    Cursor = Cursors.Cross;

                    cutAndCopyBitmap = new Bitmap(originalBitmap);
                    cutAndCopyGraphics = Graphics.FromImage(cutAndCopyBitmap);
                    pictureBox1.Image = cutAndCopyBitmap;

                    copyingPen = new Pen(Color.White, 1);
                    copyingPen.DashStyle = DashStyle.DashDot;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Kadrowanie
            if (cropping)
            {
                buttonCrop.Enabled = true;

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    pictureBox1.Refresh();

                    Rectangle rect = new Rectangle(Math.Min(e.X, cropX),
                                                   Math.Min(e.Y, cropY),
                                                   Math.Abs(e.X - cropX),
                                                   Math.Abs(e.Y - cropY));

                    pictureBox1.CreateGraphics().DrawRectangle(cropPen, rect);

                    cropWidth = Math.Abs(e.X - cropX);
                    cropHeight = Math.Abs(e.Y - cropY);
                }
            }

            // Wycinanie
            if (cutting)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    scaling(out X2, out Y2, e.X, e.Y);

                    cutAndCopyGraphics.DrawImage(originalBitmap, 0, 0);
                    
                    using (Pen select_pen = new Pen(Color.Red))
                    {
                        select_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        Rectangle rect = createSelectRectangle(X1, Y1, X2, Y2);
                        cutAndCopyGraphics.DrawRectangle(select_pen, rect);
                    }
                    


                    pictureBox1.Refresh();
                }
            }

            // Kopiowanie
            if (copying)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    scaling(out X2, out Y2, e.X, e.Y);

                    cutAndCopyGraphics.DrawImage(originalBitmap, 0, 0);

                    using (Pen select_pen = new Pen(Color.White))
                    {
                        select_pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        select_pen.Width = 2;
                        Rectangle rect = createSelectRectangle(X1, Y1, X2, Y2);
                        cutAndCopyGraphics.DrawRectangle(select_pen, rect);
                    }

                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Kadrowanie
            if (cropping)
            {
                Cursor = Cursors.Default;
                buttonFinalCrop.Enabled = true;
            }

            // Wycinanie
            if (cutting)
            {
                cutAndCopyGraphics = null;

                cutAndCopyRectangle = createSelectRectangle(X1, Y1, X2, Y2);

                Cursor = Cursors.Default;
                buttonCutSelectedArea.Enabled = true;
            }

            // Kopiowanie
            if (copying)
            {
                cutAndCopyGraphics = null;

                cutAndCopyRectangle = createSelectRectangle(X1, Y1, X2, Y2);

                Cursor = Cursors.Default;
                buttonCopyArea.Enabled = true;
                buttonPaste.Enabled = true;
            }
        }
        //----------------------------------------------------------------------------------------------------------
        #endregion


        //----------------------------------------------------------------------------------------------------------
        //FLIP AND ROTATE PART
        private void righRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void leftRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void horizontalRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Refresh();
            }
        }

        private void verticalRotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBox1.Refresh();
            }
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);

                pictureBox1.Refresh();
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to rotate a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void buttonRotateChange_Click(object sender, EventArgs e)
        {
            /*
            if (isImageOpened)
            {
                setFilterToolsVisibility(false);
                buttonCutSelectedArea.Visible = false;
                buttonFinalCrop.Visible = false;
                buttonCopyArea.Visible = false;
                buttonPaste.Visible = false;

                vScrollBarRotateAngle.Visible = true;
                buttonResetRotate.Visible = true;
                labelAngleValue.Visible = true;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to rotate a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            */
        }

        private void vScrollBarRotateAngle_Scroll(object sender, ScrollEventArgs e)
        {
            // When scrolled value is changed then display rotated image
            //displayRotatedImage();
            //labelAngleValue.Text = "Angle = " + (vScrollBarRotateAngle.Value);
        }

        private void buttonResetRotate_Click(object sender, EventArgs e)
        {
            //vScrollBarRotateAngle.Value = 0;
            //labelAngleValue.Text = "Angle = " + (vScrollBarRotateAngle.Value);
            //displayRotatedImage();
        }
        //----------------------------------------------------------------------------------------------------------

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                string message = "Do you really want to reload a picture and lose all changes?";
                string title = "Warning";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    reload();
                    resetTrackbars();
                }
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to reload a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------------------
        // FILTERS PART
        void grayscale()
        {
            DateTime start = DateTime.Now;


            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{.3f, .3f, .3f, 0, 0},    
                new float[]{.59f, .59f, .59f, 0, 0},
                new float[]{.11f, .11f, .11f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();
            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Grayscale filter: " + totalTime.ToString() + Environment.NewLine);
        }

        private void sepia()
        {
            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{.393f, .349f, .272f, 0, 0},
                new float[]{.769f, .686f, .534f, 0, 0},
                new float[]{.189f, .168f, .131f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;
        }

        private void transparency()
        {
            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 0.3f, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;
        }

        private void negativeFilter()
        {
            DateTime start = DateTime.Now;

            
            image = pictureBox1.Image;

            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();

            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{-1, 0, 0, 0, 0},
                new float[]{0, -1, 0, 0, 0},
                new float[]{0, 0, -1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{1, 1, 1, 1, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);

            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            pictureBox1.Image = bitmapFiltered;


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();
            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Negative filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void redscale()
        {
            DateTime start = DateTime.Now;

            
            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;



            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();
            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Redscale filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void greenscale()
        {
            DateTime start = DateTime.Now;


            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Greenscale filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void bluescale()
        {
            DateTime start = DateTime.Now;


            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Bluescale filter: " + totalTime.ToString() + Environment.NewLine);
        }

        private void startFiltering(Filtering.FilterType filter)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            Filtering filteringBitmap = new Filtering(bitmap);

            // Uruchom filtrację
            Filtering newFilteringBitmap = filteringBitmap.launchFiltering(filter, false);

            pictureBox1.Image = newFilteringBitmap.Bitmap;
        }

        void blurGaussian()
        {
            DateTime start = DateTime.Now;


            startFiltering(Filtering.GaussianBlur5x5Filter);


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Gaussian blur filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void blurMotion()
        {
            DateTime start = DateTime.Now;


            startFiltering(Filtering.MotionBlur9x9Filter);


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            MessageBox.Show(totalTime + " seconds", "Time of executing this filter");
        }

        void edgeDetection()
        {
            DateTime start = DateTime.Now;


            startFiltering(Filtering.SobelVerticalFilter);


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Sobel filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void emboss()
        {
            DateTime start = DateTime.Now;


            startFiltering(Filtering.Emboss);


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Emboss filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void highPass()
        {
            DateTime start = DateTime.Now;


            startFiltering(Filtering.HighPassFilter3x3);


            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "High Pass filter: " + totalTime.ToString() + Environment.NewLine);
        }

        private void blurMedian()
        {
            DateTime start = DateTime.Now;

            startFiltering(Filtering.MeanBlur5x5Filter);

            DateTime stop = DateTime.Now;
            TimeSpan time = stop - start;
            string totalTime = time.TotalSeconds.ToString();

            //MessageBox.Show(totalTime + " seconds", "Time of executing this filter");

            File.AppendAllText("worsePhoto.txt", "Mean filter: " + totalTime.ToString() + Environment.NewLine);
        }

        void setFilterToolsVisibility(bool isVisible)
        {
            buttonGrayscale.Visible = isVisible;
            buttonSepia.Visible = isVisible;
            buttonMedianBlur.Visible = isVisible;
            buttonTransparency.Visible = isVisible;
            buttonNegative.Visible = isVisible;
            buttonRed.Visible = isVisible;
            buttonGreen.Visible = isVisible;
            buttonBlue.Visible = isVisible;
            buttonBlur.Visible = isVisible;
            buttonMotionBlur.Visible = isVisible;
            buttonHighPass.Visible = isVisible;
            buttonEdges.Visible = isVisible;
            buttonEmboss.Visible = isVisible;

            buttonNormalFilter.Visible = isVisible;

            trackBarBrightness.Visible = isVisible;
            labelBrightness.Visible = isVisible;

            trackBarContrast.Visible = isVisible;
            labelContrast.Visible = isVisible;

            trackBarHue.Visible = isVisible;
            labelHue.Visible = isVisible;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (isImageOpened)
            {
                setFilterToolsVisibility(true);

                buttonFinalCrop.Visible = false;
                buttonCutSelectedArea.Visible = false;
                //vScrollBarRotateAngle.Visible = false;
                //buttonResetRotate.Visible = false;
                //labelAngleValue.Visible = false;
                buttonCopyArea.Visible = false;
                buttonPaste.Visible = false;
            }
            else
            {
                string title = "No image";
                string message = "You have no image loaded. If you want to filter a picture you need to upload it first.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            grayscale();
        }

        private void buttonSepia_Click(object sender, EventArgs e)
        {
            sepia();
        }

        private void buttonMedianBlur_Click(object sender, EventArgs e)
        {
            reload();
            blurMedian();
        }

        private void buttonTransparency_Click(object sender, EventArgs e)
        {
            transparency();
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            negativeFilter();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            reload();
            redscale();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            reload();
            greenscale();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            reload();
            bluescale();
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            reload();
            blurGaussian();
        }

        private void buttonMotionBlur_Click(object sender, EventArgs e)
        {
            reload();
            blurMotion();
        }

        private void buttonHighPass_Click(object sender, EventArgs e)
        {
            highPass();
        }

        private void buttonEdges_Click(object sender, EventArgs e)
        {
            edgeDetection();
        }

        private void buttonEmboss_Click(object sender, EventArgs e)
        {
            emboss();
        }

        void brightness()
        {
            float changeBrightness = trackBarBrightness.Value * 0.1f;
            image = pictureBox1.Image;
            reload();

            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{1, 0, 0, 0, 0},
                new float[]{0, 1, 0, 0, 0},
                new float[]{0, 0, 1, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{changeBrightness, changeBrightness, changeBrightness, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;
        }

        private void contrast()
        {
            float changeContrast = trackBarContrast.Value * 0.1f;

            reload();

            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{changeContrast, 0, 0, 0, 0},
                new float[]{0, changeContrast, 0, 0, 0},
                new float[]{0, 0, changeContrast, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;
        }

        private void saturation()
        {
            float changeSaturation = trackBarHue.Value * 0.1f;

            float luminanceR = 0.2627f;
            float luminanceG = 0.678f;
            float luminanceB = 0.0593f;

            float saturationR = (1 - changeSaturation) * luminanceR;
            float saturationG = (1 - changeSaturation) * luminanceG;
            float saturationB = (1 - changeSaturation) * luminanceB;

            reload();

            image = pictureBox1.Image;
            Bitmap bitmapFiltered = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][] {
                new float[]{ saturationR + changeSaturation, saturationR, saturationR, 0, 0},
                new float[]{ saturationG, saturationG + changeSaturation, saturationG, 0, 0},
                new float[]{ saturationB, saturationB, saturationB + changeSaturation, 0, 0},
                new float[]{ 0, 0, 0, 1, 0},
                new float[]{ 0, 0, 0, 0, 1} });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapFiltered);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            pictureBox1.Image = bitmapFiltered;
        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            brightness();
        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            contrast();
        }

        private void trackBarHue_ValueChanged(object sender, EventArgs e)
        {
            saturation();
        }

        private void buttonNormalFilter_Click(object sender, EventArgs e)
        {
            reload();
        }
        //----------------------------------------------------------------------------------------------------------

    }

    public class Filtering
    {
        // Tablica z bitami obrazu
        public byte[] bytesOfPicture;

        // Odwołanie do bitmapy
        public Bitmap Bitmap;

        // Kiedy bitmapa jest zablokowana
        private bool locked = false;

        public bool getLockInfo()
        {
            return locked;
        }

        
        public Filtering(Bitmap bitmap)
        {
            Bitmap = bitmap;
        }

        
        private BitmapData bitmapData;

        public int getBitmapWidth()
        {
            return Bitmap.Width;
        }

        public int getBitmapHeight()
        {
            return Bitmap.Height;
        }

        public byte getRedColor(int x, int y)
        {
            int i = y * bitmapData.Stride + x * 4;
            return bytesOfPicture[i + 2];
        }

        public byte getGreenColor(int x, int y)
        {
            int i = y * bitmapData.Stride + x * 4;
            return bytesOfPicture[i + 1];
        }

        public byte getBlueColor(int x, int y)
        {
            int i = y * bitmapData.Stride + x * 4;
            return bytesOfPicture[i];
        }

        
        public void getPixelValue(int x, int y, out byte red, out byte green, out byte blue, out byte alpha)
        {
            int i = y * bitmapData.Stride + x * 4;
            blue = bytesOfPicture[i++];
            green = bytesOfPicture[i++];
            red = bytesOfPicture[i++];
            alpha = bytesOfPicture[i];
        }

        public void setPixelValue(int x, int y, byte red, byte green, byte blue, byte alpha)
        {
            int i = y * bitmapData.Stride + x * 4;
            bytesOfPicture[i++] = blue;
            bytesOfPicture[i++] = green;
            bytesOfPicture[i++] = red;
            bytesOfPicture[i] = alpha;
        }

        public byte getAlphaValue(int x, int y)
        {
            int i = y * bitmapData.Stride + x * 4;
            return bytesOfPicture[i + 3];
        }

        // Zablokuj
        public void lockedBits()
        {
            // Nie rób nic kiedy jest juz zablokowana
            if (getLockInfo()) {
                return;
            }

            // Zablokuj bitmape
            Rectangle rectangle = new Rectangle(0, 0, getBitmapWidth(), getBitmapHeight());
            bitmapData = Bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            // Stwórz miejsce na dane
            int size = bitmapData.Stride * bitmapData.Height;
            bytesOfPicture = new byte[size];

            // Skopiuj dane do tablicy bitów obrazu
            Marshal.Copy(bitmapData.Scan0, bytesOfPicture, 0, size);

            locked = true;
        }

        // Odblokuj
        public void unlockedBits()
        {
            // Nie rób nic kiedy jest odblokowana
            if (!getLockInfo()) return;

            // Skopiuj dane z powrotem do bitmapy
            int size = bitmapData.Stride * bitmapData.Height;
            Marshal.Copy(bytesOfPicture, 0, bitmapData.Scan0, size);

            // Odblokuj bitmapę
            Bitmap.UnlockBits(bitmapData);

            // Zwolnij zasoby
            bytesOfPicture = null;
            bitmapData = null;

            locked = false;
        }
        #region "Filters"

        // Klasa reprezentująca filtry
        public class FilterType
        {
            public float weightFactor, offsetValue;

            public float[,] mask;
            

            // Ustaw wagę filtru równą sumie wartości w masce
            public void normalize()
            {
                weightFactor = 0;

                for (int row = 0; row <= mask.GetUpperBound(0); row++)
                {
                    for (int col = 0; col <= mask.GetUpperBound(1); col++)
                    {
                        weightFactor += mask[row, col];
                    }
                }
            }
        }

        // Sklonuj obiekt
        public Filtering Clone()
        {
            // Zablokuj bitmapę
            lockedBits();

            Filtering filteringResult = (Filtering)MemberwiseClone();

            // Skopiuj bitmapę
            filteringResult.Bitmap = new Bitmap(Bitmap.Width, Bitmap.Height);
            filteringResult.locked = false;

            // Odblokuj kiedy zablokowane
            if (getLockInfo() == false)
            {
                unlockedBits();
            }

            return filteringResult;
        }

        // Filtr wytłaczający
        public static FilterType Emboss
        {
            get
            {
                return new FilterType()
                {
                    weightFactor = 1,
                    offsetValue = 127,   //Offset do reprezentacji w skali szarości
                    mask = new float[,]
                    {
                        {0, 0, -1},
                        {0, 0, 0},
                        {1, 0, 0},
                    }
                };
            }
        }

        // Filtr Gaussa 5x5
        public static FilterType GaussianBlur5x5Filter
        {
            get
            {
                FilterType filteringResult = new FilterType()
                {
                    mask = new float[,]
                    {
                        {  1, 4, 7, 4, 1 },
                        {  4, 16, 26, 16, 4 },
                        { 7, 26, 41, 26, 7 },
                        { 4, 16, 26, 16, 4 },
                        { 1, 4, 7, 4, 1 },
                    }
                };
                filteringResult.normalize();
                return filteringResult;
            }
        }

        // Filtr Motion Blur 9x9
        public static FilterType MotionBlur9x9Filter
        {
            get
            {
                FilterType filteringResult = new FilterType()
                {
                    weightFactor = 9,
                    offsetValue = 0,
                    mask = new float[,]
                    {
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, },
                        { 0, 1, 0, 0, 0, 0, 0, 0, 0, },
                        { 0, 0, 1, 0, 0, 0, 0, 0, 0, },
                        { 0, 0, 0, 1, 0, 0, 0, 0, 0, },
                        { 0, 0, 0, 0, 1, 0, 0, 0, 0, },
                        { 0, 0, 0, 0, 0, 1, 0, 0, 0, },
                        { 0, 0, 0, 0, 0, 0, 1, 0, 0, },
                        { 0, 0, 0, 0, 0, 0, 0, 1, 0, },
                        { 0, 0, 0, 0, 0, 0, 0, 0, 1, },
                    }
                };
                filteringResult.normalize();
                return filteringResult;
            }
        }

        // Filtr Mean Blur 5x5
        public static FilterType MeanBlur5x5Filter
        {
            get
            {
                FilterType filteringResult = new FilterType()
                {
                    offsetValue = 0,
                    mask = new float[,]
                    {
                        {  1, 1, 1, 1, 1 },
                        {  1, 1, 1, 1, 1 },
                        {  1, 1, 1, 1, 1 },
                        {  1, 1, 1, 1, 1 },
                        {  1, 1, 1, 1, 1 },
                    }
                };
                filteringResult.normalize();
                return filteringResult;
            }
        }

        // Pionowy filtr Sobela
        public static FilterType SobelVerticalFilter
        {
            get
            {
                return new FilterType()
                {
                    mask = new float[,]
                    {
                        { -1, 0, 1 },
                        { -2, 0, 2 },
                        { -1, 0, 1 },
                    },
                    weightFactor = 1
                };
            }
        }

        // Filtr z operatorem Laplace'a
        public static FilterType HighPassFilter3x3
        {
            get
            {
                return new FilterType()
                {
                    weightFactor = 16,
                    offsetValue = 127,
                    mask = new float[,]
                    {
                        {-1, -1, -1},
                        {-1, 8, -1},
                        {-1, -1, -1},
                    }
                };
            }
        }

        // Uruchom filtr
        public Filtering launchFiltering(FilterType filterType, bool isLock)
        {
            // Stwórz kopię bitmapy
            Filtering copyOfBitmap = Clone();

            // Zablokuj bitmapę
            lockedBits();
            copyOfBitmap.lockedBits();
            

            // Oblicz wartości offsetowe
            int maxLocationX = getBitmapWidth() - filterType.mask.GetUpperBound(1);
            int pixelOffsetX = (filterType.mask.GetUpperBound(1) / 2) * (-1);
            int minLocationX = pixelOffsetX * (-1);

            int maxLocationY = getBitmapHeight() - filterType.mask.GetUpperBound(0);
            int pixelOffsetY = (filterType.mask.GetUpperBound(0) / 2) * (-1);
            int minLocationY = pixelOffsetY * (-1);

            int maxRow = filterType.mask.GetUpperBound(0);
            int maxColumn = filterType.mask.GetUpperBound(1);

            for (int width = minLocationX; width <= maxLocationX; width++)
            {
                for (int height = minLocationY; height <= maxLocationY; height++)
                {
                    // Zmienna używana w sytuacji: ''Jeżeli piksel jest transparentny to go pomiń''
                    bool pointSkip = false;

                    double red = 0; 
                    double green = 0; 
                    double blue = 0;

                    for (int row = 0; row <= maxRow; row++)
                    {
                        for (int col = 0; col <= maxColumn; col++)
                        {
                            byte newRed, newGreen, newBlue, newAlpha;

                            int x = width + col + pixelOffsetX;
                            int y = height + row + pixelOffsetY;

                            getPixelValue(x, y, out newRed, out newGreen, out newBlue, out newAlpha);

                            // Jeżeli piksel jest transparentny to go pomiń
                            if (newAlpha == 0)
                            {
                                pointSkip = true;
                                break;
                            }

                            red += newRed * filterType.mask[row, col];
                            green += newGreen * filterType.mask[row, col];
                            blue += newBlue * filterType.mask[row, col];
                        }
                        if (pointSkip)
                        {
                            break;
                        }
                    }
                    if (pointSkip == false)
                    {
                        // Dzielenie przez wagę współczynnika
                        red = filterType.offsetValue + red / filterType.weightFactor;
                        if (red < 0) red = 0;
                        if (red > 255) red = 255;

                        green = filterType.offsetValue + green / filterType.weightFactor;
                        if (green < 0) green = 0;
                        if (green > 255) green = 255;

                        blue = filterType.offsetValue + blue / filterType.weightFactor;
                        if (blue < 0) blue = 0;
                        if (blue > 255) blue = 255;

                        // Zaktualizowana wartość piksela
                        copyOfBitmap.setPixelValue(width, height, (byte)red, (byte)green, (byte)blue, getAlphaValue(width, height));
                    }
                }
            }

            // Odblokuj bitmapę po filtracji
            if (getLockInfo() == false) unlockedBits();
            if (isLock == false) copyOfBitmap.unlockedBits();
            return copyOfBitmap;
        }
        #endregion
    }
}
