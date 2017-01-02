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
using HandlingMixer.Controls.Datagrid;
using static HandlingMixer.Metadata;

namespace HnadlingMixer
{
    public partial class Form1 : Form
    {
        public string Apath;
        public string Bpath;

        public List<PropData> handlingProperties;

        public Form1()
        {
            InitializeComponent();

            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            handlingProperties = Metadata.getHandlingProperties();

            datagrid.AutoGenerateColumns = false;

            Propname.ValueType = typeof(String);
            Propname.ReadOnly = true;

            dataType.ValueType = typeof(HandlingDataType);
            dataType.DataSource = Enum.GetValues(typeof(HandlingDataType));
            dataType.ReadOnly = true;

            mixType.ValueType = typeof(MixType);
            mixType.DataSource = Enum.GetValues(typeof(MixType));
            mixType.ReadOnly = false;

            mixedValue.ValueType = typeof(float);
            mixedValue.ReadOnly = false;

            datagrid.DataSource = handlingProperties;
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
            var mixer = new HandlingXmlMixer(Apath, Bpath, handlingProperties);

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

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text))
            {
                datagrid.DataSource = handlingProperties;
            } else
            {
                var filter = textBox1.Text;

                datagrid.DataSource = handlingProperties.Where(p => p.propName.ToLowerInvariant().Contains(filter.ToLowerInvariant())).ToList();
            }
        }
    }
}
