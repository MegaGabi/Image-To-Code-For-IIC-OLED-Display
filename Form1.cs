using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteDrawer
{
    public partial class frm_DrawWindow : Form
    {
        const int maxAvailableH = 64, maxAvailableW = 128;
        int mHeight = 64, mWidth = 64;
        bool mPressed = false;

        int W, H;

        double PanelRatioX, PanelRatioY;

        int[,] values;

        int brithness = 50;

        public frm_DrawWindow()
        {
            InitializeComponent();

            PanelRatioX = pnl_DrawField.Size.Width / (double)Size.Width;
            PanelRatioY = pnl_DrawField.Size.Height / (double)Size.Height;

            nud_Cols.Maximum = maxAvailableW;
            nud_Pages.Maximum = maxAvailableH / 8;

            nud_Cols.Value = maxAvailableW;
            nud_Pages.Value = (maxAvailableH / 8);

            Init();
        }

        private void Init()
        {
            mWidth = ((int)nud_Cols.Value);
            mHeight = ((int)nud_Pages.Value * 8);

            values = new int[mHeight, mWidth];

            frm_DrawWindow_Resize(null, null);
        }

        private void pnl_DrawField_MouseMove(object sender, MouseEventArgs e)
        {
            if (mPressed)
            {
                Graphics g;
                g = pnl_DrawField.CreateGraphics();

                int X = e.X - e.X % W;
                int Y = e.Y - e.Y % H;

                int i = Y / H, j = X / W;

                if ((i >= mHeight || j >= mWidth)
                    ||
                    (i < 0 || j < 0))
                    return;

                lb_Position.Text = "Pos: (" + i + ", " + j + ")";

                Brush brsh = Brushes.Transparent;
                if (e.Button == MouseButtons.Left)
                {
                    brsh = new SolidBrush(Color.Cyan);

                    values[i, j] = 1;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    brsh = new SolidBrush(Color.Black);

                    values[i, j] = 0;
                }
                
                Rectangle r = new Rectangle(X + 1, Y + 1, W - 2, H - 2);
                g.FillRectangle(brsh, r);
            }
        }

        private void pnl_DrawField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = pnl_DrawField.CreateGraphics();
            g.Clear(Color.Black);

            Pen pen = Pens.Gray;

            for (int i = 0; i < mHeight; i++)
            {
                if (i % 8 == 0)
                    pen = Pens.Firebrick;
                g.DrawLine(pen, 0, i * H, (mWidth * W), i * H);
                pen = Pens.Gray;
            }

            for (int j = 0; j < mWidth; j++)
            {
                if (j % 8 == 0)
                    pen = Pens.Firebrick;
                g.DrawLine(pen, j * W, 0, j * W, (mHeight * H));
                pen = Pens.Gray;
            }

            Brush brsh = new SolidBrush(Color.Cyan);
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    if (values[i, j] == 1)
                    {
                        Rectangle r = new Rectangle((j*W)+1, (i*H)+1, W-2, H-2);
                        g.FillRectangle(brsh, r);
                    }
                }
            }
        }

        private void frm_DrawWindow_Resize(object sender, EventArgs e)
        {
            W = (int)(Size.Width*PanelRatioX) / mWidth;
            H = (int)(Size.Height*PanelRatioY) / mHeight;

            pnl_DrawField.Size = new Size(W * mWidth, H * mHeight);

            pnl_DrawField_Paint(sender, null);
        }

        private void btn_GenCode_Click(object sender, EventArgs e)
        {
            if (sender == btn_Clear)
            {
                ClearPanel(sender);
            }
            else if (sender == btn_GenCode)
            {
                GenCode();
            }
            else if (sender == btn_GenFromCode)
            {
                GenFromCode(sender);
            }
        }

        private void GenFromCode(object sender)
        {
            string code = tb_CodeOutput.Text;
            if (code.Length > 2)
            {
                code = code.Remove(0, 1);
                code = code.Remove(code.Length - 1, 1);
                var arr = code.Split(',');

                if (arr.Length > 2)
                {
                    int buf;

                    int.TryParse(arr[0], out buf);
                    int size = buf;

                    int.TryParse(arr[1], out buf);
                    int col = buf;

                    if (col > 0 && size > 0)
                    {
                        nud_Cols.Value = col;
                        nud_Pages.Value = (size / col);

                        values = new int[((size / col) * 8), col];

                        for (int i = 2; i < arr.Length; i++)
                        {
                            int.TryParse(arr[i], out buf);
                            for (int j = 0; j < 8; j++)
                            {
                                int res = (buf >> j) & 1;
                                int y = (((i - 2) / col) * 8) + j;
                                int x = (i - 2) % col;

                                values[y, x] = res;
                            }
                        }

                        frm_DrawWindow_Resize(sender, null);
                    }
                }
            }
        }

        private void GenCode()
        {
            int CodeSize = 0;

            int SmallestX = mWidth, BiggestX = 0;
            int SmallestPage = mHeight / 8, BiggestPage = 0;

            bool isNull = true;

            for (int y = 0; y < mHeight; y++)
            {
                for (int x = 0; x < mWidth; x++)
                {
                    if (values[y, x] != 0)
                    {
                        if (x < SmallestX)
                            SmallestX = x;
                        if (x > BiggestX)
                            BiggestX = x;

                        if ((y/8) < SmallestPage)
                            SmallestPage = (y / 8);
                        if ((y/8) > BiggestPage)
                            BiggestPage = (y / 8);

                        isNull = false;
                    }
                }
            }

            if (!isNull)
            {
                int Cols = (BiggestX - SmallestX) + 1;
                int Pages = (BiggestPage - SmallestPage) + 1;

                CodeSize = Cols * Pages;

                int[] ret = new int[CodeSize + 2];

                ret[0] = CodeSize;
                ret[1] = Cols;

                int ret_ind = 2;
                for (int y = (SmallestPage*8); y < ((SmallestPage + Pages )* 8); y += 8)
                {
                    for (int x = SmallestX; x < (SmallestX + Cols); x++)
                    {
                        int PageSegBin = 0;

                        for (int seg = 0; seg < 8; seg++)
                            PageSegBin += (values[y + seg, x] * (int)Math.Pow(2, seg));

                        ret[ret_ind] = PageSegBin;
                        ret_ind++;
                    }
                }

                string output = "{";
                for (int i = 0; i < ret.Length; i++)
                {
                    output += ret[i];
                    if (i != (ret.Length - 1))
                        output += ", ";
                }
                output += "}";

                tb_CodeOutput.Text = output;
            }
        }

        private void tsm_LoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) 
                    ||
                    ofd.FileName.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase))
                {
                    Bitmap b = new Bitmap(ofd.FileName);

                    if (b.Size.Width != 0)
                    {
                        double ratio = b.Size.Height / (double)b.Size.Width;

                        int w, h;

                        if (ratio <= (64 / 128.0))
                        {
                            w = 128;
                            h = (int)(128 * ratio);
                        }
                        else
                        {
                            w = (int)(64 / ratio);
                            h = 64;
                        }

                        Bitmap compute = new Bitmap(b, new Size(w, h));
                        pb_Pic.Image = new Bitmap(compute);

                        GenPick();
                    }
                }
            }
        }

        private void GenPick()
        {
            if (pb_Pic.Image != null)
            {
                Bitmap compute = (Bitmap)pb_Pic.Image;

                int w = compute.Width, h = compute.Height;

                double midBrightness = 0;
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        var col = compute.GetPixel(j, i);
                        midBrightness += (double)((col.R + col.G + col.B) / 3);
                        
                    }
                }

                midBrightness /= (w * h);

                Bitmap res = new Bitmap(w, h);

                int p = (h / 8);
                if(h%8 > 0)
                {
                    p++;
                }

                values = new int[(p*8), w];

                nud_Cols.Value = w;
                nud_Pages.Value = p;

                bool inversion = cb_Inverse.Checked;

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        var col = compute.GetPixel(j, i);
                        double bright = (double)((col.R + col.G + col.B) / 3);

                        bool b = (bright >= midBrightness * (2.1 - (brithness / 50.0)));

                        if (b && !inversion || (!b && inversion))
                        {
                            res.SetPixel(j, i, Color.Cyan);
                            values[i, j] = 1;
                        }
                    }
                }

                pb_BWres.Image = new Bitmap(res);
                frm_DrawWindow_Resize(null, null);
            }
        }

        private void tb_Bright_Scroll(object sender, EventArgs e)
        {
            brithness = (int)nud_Bright.Value;

            GenPick();
        }

        private void cb_Inverse_CheckedChanged(object sender, EventArgs e)
        {
            GenPick();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nud_Cols)
            {
                Init();
            }

            if (sender == nud_Pages)
            {
                Init();
            }
        }

        private void ClearPanel(object sender)
        {
            Graphics g = pnl_DrawField.CreateGraphics();

            Brush brsh = new SolidBrush(Color.Black);
            for (int i = 0; i < values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    values[i, j] = 0;
                }
            }

            frm_DrawWindow_Resize(sender, null);
        }

        private void pnl_DrawField_MouseUp(object sender, MouseEventArgs e)
        {
            mPressed = false;
        }

        private void pnl_DrawField_MouseClick(object sender, MouseEventArgs e)
        {
            mPressed = true;
            pnl_DrawField_MouseMove(sender, e);
        }
    }
}
