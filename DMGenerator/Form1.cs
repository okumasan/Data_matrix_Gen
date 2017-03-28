using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using DataMatrix.net;

namespace DMGenerator
{
    public partial class DataMatrixGenerator : Form
    {
        EventWaitHandle exitEvent;

        bool working;

        public DataMatrixGenerator()
        {
            InitializeComponent();
            matrixSizeCB.SelectedIndex = 0;
            pointSizeCB.SelectedIndex = 0;
            working = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            exitEvent.Set();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            if (working)
            {
                cancelBtn_Click(sender, e);
                return;
            }

            //检查输入框
            if (!File.Exists(inputFileEdit.Text))
            {
                MessageBox.Show("输入文件错误", "错误");
                return;
            }

            if (!Directory.Exists(outputDirEdit.Text))
            {
                MessageBox.Show("目标目录错误", "错误");
                return;
            }

            DmtxImageEncoderOptions opt = new DmtxImageEncoderOptions();
            switch(int.Parse(matrixSizeCB.Text))
            {
                case 0: opt.SizeIdx = DmtxSymbolSize.DmtxSymbolSquareAuto; break;
                case 16: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol16x16; break;
                case 18: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol18x18; break;
                case 20: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol20x20; break;
                case 22: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol22x22; break;
                case 24: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol24x24; break;
                case 26: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol26x26; break;
                case 32: opt.SizeIdx = DmtxSymbolSize.DmtxSymbol16x16; break;
                default: MessageBox.Show("程序可能被改坏了", "错误"); return; break;
            }

            int pointSize = int.Parse(pointSizeCB.Text) * 2;
            string outputDir = outputDirEdit.Text;

            string[] inputDatas = null;

            try
            {
                inputDatas = File.ReadAllLines(inputFileEdit.Text);
            }
            catch
            {
                MessageBox.Show("读取输入文件错误", "错误");
                return;
            }

            progressBar1.Maximum = inputDatas.Length;
            progressBar1.Value = 0;

            exitEvent = new EventWaitHandle(false, EventResetMode.ManualReset);

            Action work = new Action(() =>
            {
                Action updateProgAction = new Action(() => progressBar1.Value = progressBar1.Value + 1);
                DmtxImageEncoder encoder = new DmtxImageEncoder();

                int dataLen = inputDatas.Length;
                for(int index = 0; index < dataLen; ++index)
                {
                    string text = inputDatas[index];
                    if (exitEvent.WaitOne(0))
                        break;

                    Invoke(updateProgAction);

                    string destFile = Path.Combine(outputDir,  (index + 1).ToString()) + ".png";
                    File.Delete(destFile);

                    bool[,] r = encoder.EncodeRawData(text, opt);

                    if (r == null)
                    {
                        object shouldCont = false;
                        Invoke(new Action(()=> {
                            if (MessageBox.Show("所选尺寸不足，无法处理第" + (index + 1).ToString() + "行数据。是否继续？", "错误", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                shouldCont = true;
                        }));

                        if (((bool)shouldCont) == false)
                            break;
                        else
                            continue;
                    }

                    int wc = r.GetLength(0);
                    int hc = r.GetLength(1);

                    int padding = 0;
                    pointSize += padding;

                    Bitmap bmp = new Bitmap(850,850);
                    Graphics g = Graphics.FromImage(bmp);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    g.FillRectangle(Brushes.White, Rectangle.FromLTRB(0, 0, 850,850));
                    
                    for(int j = 0; j < hc; ++j)
                        for(int i = 0; i < wc; ++i)
                            if (r[i, j])
                            {
                                Rectangle rect = Rectangle.FromLTRB(i * 45 + padding, j * 45 + padding, (i + 1) * 45 - 1, (j + 1) * 45 - 1);
                                g.DrawEllipse(Pens.Black, rect);
                                g.FillEllipse(Brushes.Black, rect);
                                //g.DrawRectangle(Pens.Black, rect);
                                //g.FillRectangle(Brushes.Black, rect);
                            }
                    g.Flush();
                    g.Dispose();

                    bmp.Save(destFile, System.Drawing.Imaging.ImageFormat.Png);
                }

                Invoke(new Action(() => { working = false; genBtn.Text = "生成"; }));
            });

            ThreadStart ts = new ThreadStart(work);
            Thread workThread = new Thread(ts);
            workThread.SetApartmentState(ApartmentState.STA);
            working = true;
            genBtn.Text = "取消";
            workThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (working)
            {
                MessageBox.Show("生成过程中无法退出，请先停止", "错误");
                e.Cancel = true;
            }
        }

        private void browseInputBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt";
            ofd.RestoreDirectory = true;
            try { ofd.InitialDirectory = Path.GetDirectoryName(inputFileEdit.Text); } catch { }
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                inputFileEdit.Text = ofd.FileName;
            }
        }

        private void browseOutputBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            try { fbd.SelectedPath = outputDirEdit.Text; } catch { }
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                outputDirEdit.Text = fbd.SelectedPath;
            }
        }
    }
}
