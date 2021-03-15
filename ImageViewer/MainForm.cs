using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        private int lastX;
        private int lastY;
        private int mouseStartX;
        private int mouseStartY;
        private Bitmap bitpmapStarted = null;
        private bool mouseStarted = false;
        private Pen pen;
        Font font;
        private byte PenType = (byte)PenTypes.Brush;
        private enum PenTypes
        {
            Brush,
            Pencil,
            Line,
            Rectangle,
            Ellipse,
            Text

        }
        public MainForm()
        {
            InitializeComponent();
            MenuItemColor.ForeColor = Color.Black;
            //MenuItemColorCorrColor.ForeColor = MenuItemColor.ForeColor;
            pen = new Pen(MenuItemColor.ForeColor, 1);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            TextBoxThickness.Text = pen.Width.ToString();
            font = new Font("Calibri", 10);
            pictureSubBox.Image = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            // создаем стандартное диалогове окно открытия файла
            OpenFileDialog dialog = new OpenFileDialog();

            // назначаем фильтр файлов (типы файлов и их расширения)
            dialog.Filter = "Images Files (*.jpg *.png *bmp) | *.jpg;*.png;*.bmp | All Files (*.*) | *.*";

            // если пользователь выбрал файл...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(dialog.FileName);
                pictureBox.Refresh();
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void radioButtonStretchImage_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void radioButtonCenterImage_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void radioButtonZoom_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            // создаем справочную форму...
            AboutForm about = new AboutForm();

            // ...и отображаем ее на экране
            about.Show();
        }

        private void MenuItemDrawing_Click(object sender, EventArgs e){}

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (PenType == (byte)PenTypes.Brush)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox.CreateGraphics().DrawLine(pen, lastX, lastY, e.X, e.Y);
                }
            }
            else if (PenType == (byte)PenTypes.Pencil)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox.CreateGraphics().DrawLine(pen, lastX, lastY, e.X, e.Y);
                }
            }
            else if (PenType == (byte)PenTypes.Line)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!mouseStarted)
                    {
                        mouseStartX = e.X;
                        mouseStartY = e.Y;
                        mouseStarted = true;
                        bitpmapStarted = new Bitmap((Bitmap)pictureBox.Image);
                    }
                    return;
                    //TODO FIXME
                    pictureBox.Image = bitpmapStarted;
                    pictureBox.Invalidate();
                    //TODO если я смогу детектить нажатие шифта, то сделаю привязку на 90 градусов
                    pictureBox.CreateGraphics().DrawLine(pen, mouseStartX, mouseStartY, e.X, e.Y);

                }
                else
                {
                    if (mouseStarted)
                    {
                        //TODO если я смогу детектить нажатие шифта, то сделаю привязку на 90 градусов
                        pictureBox.CreateGraphics().DrawLine(pen, mouseStartX, mouseStartY, e.X, e.Y);
                    }
                    mouseStarted = false;
                }
            }
            else if (PenType == (byte)PenTypes.Rectangle)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!mouseStarted)
                    {
                        mouseStartX = e.X;
                        mouseStartY = e.Y;
                        mouseStarted = true;
                        bitpmapStarted = new Bitmap(pictureBox.Image);
                    }
                    return;
                    //TODO FIXME
                    pictureBox.Image = bitpmapStarted;
                    var g = pictureBox.CreateGraphics();
                    //TODO если я смогу детектить нажатие шифта, то сделаю привязку на квадрат
                    g.DrawLine(pen, mouseStartX, mouseStartY, mouseStartX, e.Y);
                    g.DrawLine(pen, mouseStartX, mouseStartY, e.X, mouseStartY);
                    g.DrawLine(pen, e.X, mouseStartY, e.X, e.Y);
                    g.DrawLine(pen, mouseStartX, e.Y, e.X, e.Y);

                }
                else
                {
                    if (mouseStarted)
                    {
                        var g = pictureBox.CreateGraphics();
                        //TODO если я смогу детектить нажатие шифта, то сделаю привязку на квадрат
                        g.DrawLine(pen, mouseStartX, mouseStartY, mouseStartX, e.Y);
                        g.DrawLine(pen, mouseStartX, mouseStartY, e.X, mouseStartY);
                        g.DrawLine(pen, e.X, mouseStartY, e.X, e.Y);
                        g.DrawLine(pen, mouseStartX, e.Y, e.X, e.Y);
                    }
                    mouseStarted = false;
                }
            }
            else if (PenType == (byte)PenTypes.Text)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pictureBox.CreateGraphics().DrawString(TextBoxText.Text, font, new SolidBrush(pen.Color), e.X, e.Y);
                }
            }
            else if (PenType == (byte)PenTypes.Ellipse)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!mouseStarted)
                    {
                        mouseStartX = e.X;
                        mouseStartY = e.Y;
                        mouseStarted = true;
                        bitpmapStarted = new Bitmap(pictureBox.Image);
                    }
                    return;
                    //TODO FIXME
                    pictureBox.Image = bitpmapStarted;
                    //TODO если я смогу детектить нажатие шифта, то сделаю привязку на квадрат
                    pictureBox.CreateGraphics().DrawEllipse(pen, mouseStartX, mouseStartY, e.X- mouseStartX, e.Y- mouseStartY);

                }
                else
                {
                    if (mouseStarted)
                    {
                        pictureBox.CreateGraphics().DrawEllipse(pen, mouseStartX, mouseStartY, e.X - mouseStartX, e.Y - mouseStartY);
                    }
                    mouseStarted = false;
                }
            }

            lastY = e.Y;
            lastX = e.X;
            //pictureBox.Refresh();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || mouseStarted) return;
            if (PenType == (byte)PenTypes.Brush)
            {
                pictureBox.CreateGraphics().FillEllipse(new SolidBrush(pen.Color), e.X-pen.Width/2, e.Y- pen.Width/2, pen.Width, pen.Width);
            }
            else if (PenType == (byte)PenTypes.Brush)
            {
                pictureBox.CreateGraphics().FillRectangle(new SolidBrush(pen.Color), e.X - pen.Width / 2, e.Y - pen.Width / 2, pen.Width, pen.Width);
            }
            else if (PenType == (byte)PenTypes.Line)
            {
                pictureBox.CreateGraphics().FillEllipse(new SolidBrush(pen.Color), e.X - pen.Width / 2, e.Y - pen.Width / 2, pen.Width, pen.Width);
            }
            else if (PenType == (byte)PenTypes.Rectangle)
            {
                pictureBox.CreateGraphics().FillEllipse(new SolidBrush(pen.Color), e.X - pen.Width / 2, e.Y - pen.Width / 2, pen.Width, pen.Width);
            }
            else if (PenType == (byte)PenTypes.Text)
            {
                pictureBox.CreateGraphics().DrawString(TextBoxText.Text, font, new SolidBrush(pen.Color), e.X, e.Y);
            }
            else if (PenType == (byte)PenTypes.Ellipse)
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, e.X,e.Y, pen.Width,pen.Width);
            }
        }

        private void MenuItemColor_Click(object sender, EventArgs e)
        {
            var MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = false;
            MyDialog.FullOpen = true;
            MyDialog.Color = MenuItemColor.ForeColor;
            // Sets the initial color select to the current text color.

            if (MyDialog.ShowDialog() == DialogResult.OK)
            { 
                MenuItemColor.ForeColor = MyDialog.Color;
                pen.Color = MenuItemColor.ForeColor;
                //MenuItemColorCorrColor.ForeColor = MenuItemColor.ForeColor;
            }
        }

        //TODO можно сделать вметсо текста TrackBar

        private void TextBoxThickness_KeyUp(object sender, KeyEventArgs e)
        {
            var textbox = (ToolStripTextBox)sender;
            uint res = 0;
            var success = uint.TryParse(textbox.Text, out res);
            if (!success) pen.Width = 1; else pen.Width = res;
            if (PenType == (byte)PenTypes.Pencil && pen.Width > 5) pen.Width = 5;
            textbox.Text = pen.Width.ToString();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            //radioButtonNormal.Checked = true;
        }


        //захардкодил, потому что немного элементов
        private void MenuItemBrush_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Brush;
            MenuItemBrush.Checked = true;
            MenuItemPencil.Checked = false;
            MenuItemLine.Checked = false;
            MenuItemRectangle.Checked = false;
            MenuItemText.Checked = false;
            MenuItemEllipse.Checked = false;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void MenuItemPencil_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Pencil;
            MenuItemBrush.Checked = false;
            MenuItemPencil.Checked = true;
            MenuItemLine.Checked = false;
            MenuItemRectangle.Checked = false;
            MenuItemText.Checked = false;
            MenuItemEllipse.Checked = false;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void MenuItemLine_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Line;
            MenuItemBrush.Checked = false;
            MenuItemPencil.Checked = false;
            MenuItemLine.Checked = true;
            MenuItemRectangle.Checked = false;
            MenuItemText.Checked = false;
            MenuItemEllipse.Checked = false;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void MenuItemRectangle_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Rectangle;
            MenuItemBrush.Checked = false;
            MenuItemPencil.Checked = false;
            MenuItemLine.Checked = false;
            MenuItemRectangle.Checked = true;
            MenuItemText.Checked = false;
            MenuItemEllipse.Checked = false;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void MenuItemText_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Text;
            MenuItemBrush.Checked = false;
            MenuItemPencil.Checked = false;
            MenuItemLine.Checked = false;
            MenuItemRectangle.Checked = false;
            MenuItemText.Checked = true;
            MenuItemEllipse.Checked = false;
        }

        private void MenuItemEllipse_Click(object sender, EventArgs e)
        {
            PenType = (byte)PenTypes.Ellipse;
            MenuItemBrush.Checked = false;
            MenuItemPencil.Checked = false;
            MenuItemLine.Checked = false;
            MenuItemRectangle.Checked = false;
            MenuItemText.Checked = false;
            MenuItemEllipse.Checked = true;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void MenuItemFont_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.ShowColor = false;
            //dialog.MinSize = (int)pen.Width;
            //dialog.MaxSize = (int)pen.Width;
            if (dialog.ShowDialog() == DialogResult.OK) font = dialog.Font;
        }

        private void MenuItemRotate_Click(object sender, EventArgs e)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
        }

        private bool IsCanProcessImage(in Bitmap bm, string str = "Выберите другое изображение")
        {
            try
            {
                var a = (Bitmap)bm.Clone();
                a.SetPixel(0, 0, Color.FromArgb(Math.Abs(0) > 255 ? 255 : Math.Abs(0), Math.Abs(0) > 255 ? 255 : Math.Abs(0), Math.Abs(0) > 255 ? 255 : Math.Abs(0)));
            }
            catch (Exception)
            {
                MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                menuItemOpen_Click(null, null);
                return false;
            }
            return true;
          
        }

        private void UpdateProgressBar(float curvalue, float maxvalue, byte progressStart, float progressPercent)
        {
            progressBar.Value = progressStart + (int)((curvalue / (maxvalue - 1)) * progressPercent);
        }

        private Bitmap useMatrix(Bitmap theBit, float[,] kernel, byte progressStart, byte progressPercent)
        {
            Bitmap aRes = (Bitmap)theBit.Clone();
            int sizeX = aRes.Width;
            int sizeY = aRes.Height;
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            for (int aX = 0; aX < sizeX; aX++)
            {
                UpdateProgressBar(aX, sizeX, progressStart, progressPercent);
                for (int aY = 0; aY < sizeY; aY++)
                {
                    Color aCol = theBit.GetPixel(aX, aY);
                    double aRed = aCol.R;
                    double aGreen = aCol.G;
                    double aBlue = aCol.B;

                    for (int i = -radiusY; i <= radiusY; i++)
                        for (int j = -radiusX; j <= radiusX; j++)
                        {
                            int aX2;
                            int aY2;
                            if (aX + j < 0) aX2 = 0;
                            else if (aX + j >= sizeX) aX2 = sizeX - 1;
                            else aX2 = aX + j;

                            if (aY + i < 0) aY2 = 0;
                            else if (aY + i >= sizeY) aY2 = sizeY - 1;
                            else aY2 = aY + i;

                            Color aCol2 = theBit.GetPixel(aX2, aY2);
                            double aRed2 = aCol2.R;
                            double aGreen2 = aCol2.G;
                            double aBlue2 = aCol2.B;

                            aRed += aRed2 * kernel[j + radiusX, i + radiusY];
                            aGreen += aGreen2 * kernel[j + radiusX, i + radiusY];
                            aBlue += aBlue2 * kernel[j + radiusX, i + radiusY];
                        }
                    if (aRed < 0) aRed = 0;
                    else if (aRed > 255) aRed = 255;
                    if (aGreen < 0) aGreen = 0;
                    else if (aGreen > 255) aGreen = 255;
                    if (aBlue < 0) aBlue = 0;
                    else if (aBlue > 255) aBlue = 255;
                    aRes.SetPixel(aX, aY, Color.FromArgb(Math.Abs((int)aRed) > 255 ? 255 : Math.Abs((int)aRed), Math.Abs((int)aGreen) > 255 ? 255 : Math.Abs((int)aGreen), Math.Abs((int)aBlue) > 255 ? 255 : Math.Abs((int)aBlue)));
                }
            }
            return aRes;

        }

        private void MenuItemSobel_Click(object sender, EventArgs e)
        {
            if (!IsCanProcessImage((Bitmap)pictureBox.Image)) return;
            progressBar.Value = 0;

            float[,] kernel = { {-1.0f, 0.0f, 1.0f},
                                {-2.0f, 0.0f, 2.0f},
                                {-1.0f, 0.0f, 1.0f} };

            var res = useMatrix((Bitmap)pictureBox.Image, kernel,0,100);


            progressBar.Value = 0;
            pictureBox.Image = res;
            pictureBox.Refresh();
        }


        private Color GetE(Bitmap theBitmap, byte progressStart, byte progressPercent)
        {
            double aRed = 0;
            double aGreen = 0;
            double aBlue = 0;

            int aSizeX = theBitmap.Width;
            int aSizeY = theBitmap.Height;

            for (int aX = 0; aX < aSizeX; aX++)
            {
                UpdateProgressBar(aX, aSizeX, progressStart, progressPercent);
                for (int aY = 0; aY < aSizeY; aY++)
                {
                    Color aCol = theBitmap.GetPixel(aX, aY);
                    aRed += (double)aCol.R / 255;
                    aGreen += (double)aCol.G / 255;
                    aBlue += (double)aCol.B / 255;
                }
            }

            aRed = aRed / (aSizeX * aSizeY);
            aGreen = aGreen / (aSizeX * aSizeY);
            aBlue = aBlue / (aSizeX * aSizeY);

            Color aResult = Color.FromArgb((int)(aRed * 255), (int)(aGreen * 255), (int)(aBlue * 255));

            return aResult;
        }

        private Color GetD(Bitmap theBitmap, Color theE, byte progressStart, byte progressPercent)
        {
            double aRed = 0;
            double aGreen = 0;
            double aBlue = 0;

            int aSizeX = theBitmap.Width;
            int aSizeY = theBitmap.Height;

            for (int aX = 0; aX < aSizeX; aX++)
            {
                UpdateProgressBar(aX, aSizeX, progressStart, progressPercent);
                for (int aY = 0; aY < aSizeY; aY++)
                {
                    Color aCol = theBitmap.GetPixel(aX, aY);
                    double aColR = (double)aCol.R / 255;
                    double aColG = (double)aCol.G / 255;
                    double aColB = (double)aCol.B / 255;
                    double aER = (double)theE.R / 255;
                    double aEG = (double)theE.G / 255;
                    double aEB = (double)theE.B / 255;
                    aRed += (aColR - aER) * (aColR - aER);
                    aGreen += (aColG - aEG) * (aColG - aEG);
                    aBlue += (aColB - aEB) * (aColB - aEB);
                }
            }

            aRed = aRed / (aSizeX * aSizeY);
            aGreen = aGreen / (aSizeX * aSizeY);
            aBlue = aBlue / (aSizeX * aSizeY);

            aRed = (Math.Sqrt(aRed));
            aGreen = (Math.Sqrt(aGreen));
            aBlue = (Math.Sqrt(aBlue));

            Color aResult = Color.FromArgb((int)(aRed * 255), (int)(aGreen * 255), (int)(aBlue * 255));

            return aResult;
        }

        private void MenuItemGrayWorld_Click(object sender, EventArgs e)
        {
            Bitmap aPicBox = (Bitmap)(pictureBox.Image).Clone();
            if (!IsCanProcessImage(aPicBox)) return;
            progressBar.Value = 0;
            aPicBox = (Bitmap)(pictureBox.Image).Clone();

            Color aE = GetE(aPicBox,0,30);
            var progressStart = progressBar.Value;

            double theArgv = (double)(aE.R + aE.G + aE.B) / 3.0;



            Bitmap aResult = aPicBox;

            double aRed;
            double aGreen;
            double aBlue;

            int aSizeX = aResult.Width;
            int aSizeY = aResult.Height;

            for (int aX = 0; aX < aSizeX; aX++)
            {
                UpdateProgressBar(aX, aSizeX, (byte)progressStart, 70);

                for (int aY = 0; aY < aSizeY; aY++)
                {
                    Color aColM = aResult.GetPixel(aX, aY);
                    aRed = (double)aColM.R;
                    aGreen = (double)aColM.G;
                    aBlue = (double)aColM.B;

                    aRed = aRed * (theArgv / (double)aE.R);
                    aGreen = aGreen * (theArgv / (double)aE.G);
                    aBlue = aBlue * (theArgv / (double)aE.B);

                    aResult.SetPixel(aX, aY, Color.FromArgb((int)aRed > 255 ? 255 : (int)aRed, (int)aGreen > 255 ? 255 : (int)aGreen, (int)aBlue > 255 ? 255 : (int)aBlue));
                }
            }
            progressBar.Value = 0;

            pictureBox.Image = aResult;
            pictureBox.Refresh();
        }

        private void MenuItemGauss_Click(object sender, EventArgs e)
        {
            if (!IsCanProcessImage((Bitmap)pictureBox.Image)) return;
            progressBar.Value = 0;

            double sigma = 2.0;
            int aSize = 2 * 3 + 1;
            float[,] kernel = new float[aSize, aSize];

            int aHalf = aSize / 2;

            float aNorm = 0;

            uint c = 0;
            for (int i = -aHalf; i <= aHalf; i++)
            {
                UpdateProgressBar(c, aHalf * 2, 0, 2);
                c++;
                for (int j = -aHalf; j <= aHalf; j++)
                {
                    kernel[i + aHalf, j + aHalf] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));

                    aNorm += kernel[i + aHalf, j + aHalf];
                }
            }

            var progressStart = progressBar.Value;

            for (int i = 0; i < aSize; i++)
            {
                UpdateProgressBar(i, aSize, (byte)progressStart, 1);
                for (int j = 0; j < aSize; j++)
                {
                    kernel[i, j] /= aNorm;
                }
            }

            progressStart = progressBar.Value;

            Bitmap aRes = useMatrix((Bitmap)pictureBox.Image, kernel, (byte)progressStart, (byte)(100-progressStart));

            progressBar.Value = 0;
            pictureBox.Image = aRes;
            pictureBox.Refresh();
        }

        private void MenuItemEmboss_Click(object sender, EventArgs e)
        {
            if (!IsCanProcessImage((Bitmap)pictureBox.Image)) return;
            progressBar.Value = 0;

            float[,] kernel = { {-1.0f, -1.0f, 0.0f},
                                {-1.0f,  0.0f, 1.0f},
                                { 0.0f,  1.0f, 1.0f} };

            Bitmap aRes = useMatrix((Bitmap)pictureBox.Image, kernel,0,100);


            progressBar.Value = 0;
            pictureBox.Image = aRes;
            pictureBox.Refresh();
        }

        private Bitmap GetColorCorr(Bitmap theBitmap, Color theESub, Color theDSub, Color theEMain, Color theDMain, byte progressStart, byte progressPercent)
        {
            Bitmap aResult = (Bitmap)theBitmap.Clone();

            double aRed;
            double aGreen;
            double aBlue;

            int aSizeX = aResult.Width;
            int aSizeY = aResult.Height;

            for (int aX = 0; aX < aSizeX; aX++)
            {
                UpdateProgressBar(aX, aSizeX, progressStart, progressPercent);
                for (int aY = 0; aY < aSizeY; aY++)
                {
                    Color aCol = aResult.GetPixel(aX, aY);
                    double aColR = (double)aCol.R / 255;
                    double aColG = (double)aCol.G / 255;
                    double aColB = (double)aCol.B / 255;

                    double aESubR = (double)theESub.R / 255;
                    double aESubG = (double)theESub.G / 255;
                    double aESubB = (double)theESub.B / 255;

                    double aEMainR = (double)theEMain.R / 255;
                    double aEMainG = (double)theEMain.G / 255;
                    double aEMainB = (double)theEMain.B / 255;

                    double aDSubR = (double)theDSub.R / 255;
                    double aDSubG = (double)theDSub.G / 255;
                    double aDSubB = (double)theDSub.B / 255;

                    double aDMainR = (double)theDMain.R / 255;
                    double aDMainG = (double)theDMain.G / 255;
                    double aDMainB = (double)theDMain.B / 255;

                    aRed = (aESubR + (aColR - aEMainR) * (aDSubR / (aDMainR == 0 ? 0.000001 : aDMainR)));
                    aGreen = (aESubG + (aColG - aEMainG) * (aDSubG / (aDMainG == 0 ? 0.000001 : aDMainG)));
                    aBlue = (aESubB + (aColB - aEMainB) * (aDSubB / (aDMainB == 0 ? 0.000001 : aDMainB)));
                    aResult.SetPixel(aX, aY, Color.FromArgb((int)((Math.Abs(aRed) > 1.0 ? 1.0 : Math.Abs(aRed)) * 255), (int)((Math.Abs(aGreen) > 1.0 ? 1.0 : Math.Abs(aGreen)) * 255), (int)((Math.Abs(aBlue) > 1.0 ? 1.0 : Math.Abs(aBlue)) * 255)));
                }
            }

            return aResult;
        }

        private void MenuItemColorCorr_Click(object sender, EventArgs e)
        {
            if (pictureSubBox.Image == null)
            {
                MessageBox.Show("Не выбрано изображение в качестве источника цвета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsCanProcessImage((Bitmap)pictureSubBox.Image,"Выберите другое изображение для источника цвета") || !IsCanProcessImage((Bitmap)pictureBox.Image))
                return;

            var aBitMap = (Bitmap)pictureSubBox.Image;

            progressBar.Value = 0;

            Color aESub = GetE(aBitMap,0,15);

            Color aDSub = GetD(aBitMap, aESub,15,15);

            var aBitMainMap = (Bitmap)(pictureBox.Image);

            Color aEMain = GetE(aBitMainMap,30,15);

            Color aDMAin = GetD(aBitMainMap, aEMain,45,15);

            Bitmap aResult = GetColorCorr(aBitMainMap, aESub, aDSub, aEMain, aDMAin,60,40);


            progressBar.Value = 0;

            pictureBox.Image = aResult;

            pictureBox.Refresh();
        }

        private void buttonChooseImageColorClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Images Files (*.jpg *.png *bmp) | *.jpg;*.png;*.bmp | All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureSubBox.Image = new Bitmap(dialog.FileName);
                pictureSubBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureSubBox.Refresh();
            }
        }

        private void морфологическийГрадиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsCanProcessImage((Bitmap)pictureBox.Image)) return;
            progressBar.Value = 0;

            float[,] kernel = { {-1.0f, -1.0f, -1.0f},
                                {-1.0f,  8.0f, -1.0f},
                                {-1.0f, -1.0f, -1.0f}
                              };

            Bitmap aRes = useMatrix((Bitmap)pictureBox.Image, kernel,0,100);

            pictureBox.Image = aRes;
            progressBar.Value = 0;
            pictureBox.Refresh();
        }
    }
}
