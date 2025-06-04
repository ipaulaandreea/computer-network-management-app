using NetworkManagementApp.Model;

namespace NetworkManagementApp
{
    public partial class ChartForm : Form
    {
        private List<Utilizator> utilizatori;
        private List<Grup> grupuri;

        private Panel panelLineChart;

        public ChartForm(List<Grup> grupuri, List<Utilizator> utilizatori)
        {
            InitializeComponent();
            this.utilizatori = utilizatori;
            this.grupuri = grupuri;
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            panelLineChart = new Panel();
            panelLineChart.Dock = DockStyle.Fill;
            panelLineChart.BackColor = Color.White;
            panelLineChart.Paint += ChartFormcs_Paint;
            this.Controls.Add(panelLineChart);
        }

        private void ChartFormcs_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            var font = new Font("Arial", 7);
            var fontBold = new Font("Arial", 8, FontStyle.Bold);
            var brushBar = new SolidBrush(Color.DeepSkyBlue);
            var penAxis = new Pen(Color.Black, 2);

            var data = grupuri
                .Select(gp => new { Name = gp.Nume, Count = gp.Drepturi.Count })
                .OrderBy(g => g.Count)
                .ToList();

            if (data.Count == 0) return;

            int maxLabelWidth = data.Max(d => (int)g.MeasureString(d.Name, font).Width);

            int barHeight = 10;
            int barSpacing = 7;
            int maxBarLength = 200; 
            int paddingLeft = maxLabelWidth + 30;
            int paddingTop = 60;
            int maxVal = Math.Max(1, data.Max(d => d.Count));

            g.DrawString("Drepturi pe grup", fontBold, Brushes.Black, paddingLeft, 25);

            for (int i = 0; i < data.Count; i++)
            {
                var group = data[i];
                float y = paddingTop + i * (barHeight + barSpacing);
                float barLength = group.Count * maxBarLength / (float)maxVal;

                g.DrawString(group.Name, font, Brushes.Black,
                    new RectangleF(0, y, paddingLeft - 10, barHeight),
                    new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center });

                g.FillRectangle(brushBar, paddingLeft, y, barLength, barHeight);

                g.DrawString(group.Count.ToString(), font, Brushes.Black,
                    new PointF(paddingLeft + barLength + 5, y));
            }

            float axaY = paddingTop + data.Count * (barHeight + barSpacing);
            g.DrawLine(penAxis, paddingLeft, axaY, paddingLeft + maxBarLength, axaY);

            int nrEtichete = 5;
            for (int j = 0; j <= nrEtichete; j++)
            {
                int val = j * maxVal / nrEtichete;
                float x = paddingLeft + val * maxBarLength / (float)maxVal;

                g.DrawLine(Pens.Gray, x, axaY, x, axaY + 5);
                g.DrawString(val.ToString(), font, Brushes.Black, new PointF(x - 10, axaY + 10));
            }

            g.DrawString("Număr drepturi", font, Brushes.Black,
                new PointF(paddingLeft + maxBarLength / 2 - 40, axaY + 30));
        }
    }
}
