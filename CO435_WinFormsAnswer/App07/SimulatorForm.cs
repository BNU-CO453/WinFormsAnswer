using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CO435_WinFormsAnswer.App07
{
    public partial class SimulatorForm : Form
    {
        private readonly Simulator simulator = new Simulator();

        private readonly FieldStats stats = new FieldStats();

        public SimulatorForm()
        {
            InitializeComponent();
            RunSimulator();

        }

        private void RunSimulator()
        {
            int lastStep = (int)stepsNumericUpDown.Value;

            for (int step = 1; step <= lastStep; step++)
            {
                simulator.SimulateOneStep();

                CountAnimals();
                string result = stats.GetPopulationDetails(simulator.Field);

                rabbitLabel.Text = "Rabbits: " + stats.GetAnimalCount("Rabbit");
                foxLabel.Text = "Foxes: " + stats.GetAnimalCount("Fox");
            }

            Refresh();

        }

        public void CountAnimals()
        {
            stats.Reset();

            Field field = simulator.Field;
            for (int row = 0; row < field.Depth; row++)
            {
                for (int column = 0; column < field.Width; column++)
                {
                    Object animal = field.GetAnimalAt(row, column);
                    if (animal != null)
                    {
                        stats.IncrementCount(animal.GetType().Name);
                    }
                }
            }

            stats.CountFinished();
        }

        private void SimulatorForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fieldPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 0, y = 0; int size = 10;

            for (int row = 0; row < simulator.Field.Depth; row++)
            {
                x = 0;

                for (int col = 0; col < simulator.Field.Width; col++)
                {
                    object animal = simulator.Field.GetAnimalAt(row, col);
                    g.FillRectangle(Brushes.Green, x, y, x + size, y + size);

                    if (animal is Fox)
                    {
                        g.FillRectangle(Brushes.Red, x+1, y+1, x + size-2, y + size-2);
                    }
                    else if (animal is Rabbit)
                    {
                        g.FillRectangle(Brushes.Yellow, x+1, y+1, x + size-2, y + size-2);
                    }

                    x += size;
                }

                y += size;
            }

        }

        private void stepButton_Click(object sender, EventArgs e)
        {
            RunSimulator();
        }
    }
}
