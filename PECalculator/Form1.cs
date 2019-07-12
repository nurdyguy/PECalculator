using ProblemService.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PECalculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void problemNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;

                if (!int.TryParse(problemNumberInput.Text, out var probNum))
                    throw null;

                int.TryParse(xInput.Text, out var x);
                int.TryParse(yInput.Text, out var y);
                int.TryParse(zInput.Text, out var z);

                var watch = new Stopwatch();
                var timers = new List<double>();
                watch.Start();

                var epBase = typeof(Problem).AssemblyQualifiedName.Split(',');
                epBase[0] = $"{epBase[0]}_{probNum}";
                var probType = Type.GetType(string.Join(",", epBase));

                if (probType == null)
                    throw new NotImplementedException("Invalid problem number.");

                var prob = (Problem)Activator.CreateInstance(probType);
                var result = prob.RunProblem(x, y, z);

                timers.Add(watch.ElapsedMilliseconds / 1000.0);
                watch.Stop();

                AddResultLabel(result, timers);
            }
            catch(Exception ex)
            {
                errorLabel.Text = $"Error: {ex.Message}";
                errorLabel.Visible = true;
            }


        }

        private void AddResultLabel(object result, List<double> timers)
        {
            var l = new Label()
            {
                Text = result.ToString(),
                Font = new Font("Microsoft Sans Serif", 16.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(25, 25),
                Name = "newResultLabel",
                Size = new Size(231, 31)
            };

            this.resultsGroup.Controls.Add(l);
        }

    }
}
