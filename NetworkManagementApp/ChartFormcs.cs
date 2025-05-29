using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkManagementApp.Model;

namespace NetworkManagementApp
{
    public partial class ChartFormcs : Form
    {
        private List<Grup> grupuri;
        private List<Utilizator> utilizatori;
        public ChartFormcs(List<Grup> grupuri, List<Utilizator> utilizatori)
        {
            InitializeComponent();
            this.grupuri = grupuri;
            this.utilizatori = utilizatori;

        }

        private void ChartFormcs_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            int padding = 60;
            int nrEticheteY = 5;
            var font = new Font("Arial", 10);
            var fontBold = new Font("Arial", 10, FontStyle.Bold);
            var brushBar = new SolidBrush(Color.CornflowerBlue);
            var penAxis = new Pen(Color.Black, 2);

            e.Graphics.DrawString("Histograma: Numar drepturi per utilizator", fontBold, Brushes.Black, new PointF(50, 20));

            string labelX = "Numar drepturi";
            var sizeX = e.Graphics.MeasureString(labelX, font);
            e.Graphics.DrawString(labelX, font, Brushes.Black,
                new PointF((panelHistograma.Width - sizeX.Width) / 2, panelHistograma.Height - 20));

            string labelY = "Numar utilizatori";
            var sizeY = e.Graphics.MeasureString(labelY, font);
            g.TranslateTransform(10, (panelHistograma.Height + sizeY.Width) / 2);
            g.RotateTransform(-90);
            g.DrawString(labelY, font, Brushes.Black, 0, 0);
            g.ResetTransform();

            var histogramData = utilizatori
                .GroupBy(u => u.GetDrepturi().Count)
                .OrderBy(gp => gp.Key)
                .ToDictionary(gp => gp.Key, gp => gp.Count());

            int barCount = histogramData.Count;
            int barWidth = (panelHistograma.Width - 2 * padding) / barCount;
            int maxVal = histogramData.Values.Max();
            int maxHeight = panelHistograma.Height - 2 * padding;

            for (int j = 0; j <= nrEticheteY; j++)
            {
                int val = j * maxVal / nrEticheteY;
                float yEticheta = panelHistograma.Height - padding - ((float)val / maxVal * maxHeight);

                e.Graphics.DrawLine(Pens.Gray, padding - 5, yEticheta, padding, yEticheta);
                e.Graphics.DrawString(val.ToString(), font, Brushes.Black, padding - 35, yEticheta - 8);
            }

            int i = 0;
            foreach (var kvp in histogramData)
            {
                int drepturiCount = kvp.Key;
                int utilizatoriCount = kvp.Value;

                float height = (float)utilizatoriCount / maxVal * maxHeight;
                float x = padding + i * barWidth;
                float y = panelHistograma.Height - padding - height;

                g.FillRectangle(brushBar, x, y, barWidth, height);
                g.DrawString($"{drepturiCount}", font, Brushes.Black, x + barWidth / 3, panelHistograma.Height - padding + 5);
                g.DrawString($"{utilizatoriCount}", font, Brushes.Black, x + barWidth / 3, y - 20);

                i++;
            }

            g.DrawLine(penAxis, padding, panelHistograma.Height - padding, panelHistograma.Width - padding, panelHistograma.Height - padding);
            g.DrawLine(penAxis, padding, padding, padding, panelHistograma.Height - padding);
        }

        //private void panelHistograma_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}