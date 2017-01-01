using HandlingMixer;
using HandlingMixer.Controls;
using HandlingMixer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HnadlingMixer
{
    public partial class Form1 : Form
    {
        public string Apath;
        public string Bpath;

        public Form1()
        {
            InitializeComponent();

            mixPanel.AutoScroll = true;
            mixPanel.FlowDirection = FlowDirection.TopDown;
            mixPanel.WrapContents = false;

            foreach(string handlingProp in Metadata.getHandlingProperties())
            {
                mixPanel.Controls.Add(new MixControl(handlingProp));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                
        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MixPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFileA_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Handling .meta files (*.meta)|*.meta";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                labelA.Text = path;
                Apath = path;
            }
        }

        private void btnFileB_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Handling .meta files (*.meta)|*.meta";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                labelB.Text = path;
                Bpath = path;
            }
        }

        private void MixBtn_Click(object sender, EventArgs e)
        {
            List<PropData> propList = new List<PropData>(mixPanel.Controls.Count);
            foreach(MixControl mc in mixPanel.Controls)
            {
                propList.Add(mc.toPropData());
            }

            var mixer = new HandlingXmlMixer(Apath, Bpath, propList);

            SaveFileDialog saveDlg = new SaveFileDialog();

            saveDlg.Filter = "Handling .meta files (*.meta)|*.meta";
            saveDlg.FileName = "handling.meta";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                var path = saveDlg.FileName;
                var resultXml = mixer.generateMixedHandling();

                File.WriteAllText(path, resultXml);
                MessageBox.Show("Done!");
            }
            
        }
    }
}
