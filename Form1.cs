using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        private const int Rows = 15;
        private const int SeatsPerRow = 40;
        private char[,] seatingChart = new char[Rows, SeatsPerRow];
        private int[] rowPrices = { 50, 50, 50, 50, 50, 30, 30, 30, 30, 30, 15, 15, 15, 15, 15 };
        public Form1()
        {
            InitializeComponent();
            InitializeSeatingChart();
        }

        private void InitializeSeatingChart()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < SeatsPerRow; j++)
                {
                    seatingChart[i, j] = '.';
                }
            }
        }

        private void BotaoFinalizar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Botaoparareservar(object sender, EventArgs e)
        {
            int row, seat;
            if (int.TryParse(fileiraTextBox.Text, out row) && int.TryParse(poltronaTextBox.Text, out seat))
            {
                if (row >= 1 && row <= Rows && seat >= 1 && seat <= SeatsPerRow)
                {
                    row--; // Adjust for zero-based index
                    seat--;
                    if (seatingChart[row, seat] == '.')
                    {
                        seatingChart[row, seat] = '#';
                        MessageBox.Show("Reserva efetuada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Poltrona já ocupada!");
                    }
                }
                else
                {
                    MessageBox.Show("Número da fileira ou poltrona inválido.");
                }
            }
            else
            {
                MessageBox.Show("Digite números válidos.");
            }
        }

        private void BotaodoMapa(object sender, EventArgs e)
        {
            string map = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < SeatsPerRow; j++)
                {
                    map += seatingChart[i, j];
                }
                map += Environment.NewLine;
            }
            MessageBox.Show(map, "Mapa de Ocupação");
        }

        private void BotaoFaturamento(object sender, EventArgs e)
        {
            int occupiedSeats = 0;
            double totalRevenue = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < SeatsPerRow; j++)
                {
                    if (seatingChart[i, j] == '#')
                    {
                        occupiedSeats++;
                        totalRevenue += rowPrices[i];
                    }
                }
            }

            MessageBox.Show($"Qtde de lugares ocupados: {occupiedSeats}\nValor da bilheteira: R$ {totalRevenue:0.00}", "Faturamento");
        }

        private void BotaodeSalvar(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveSeatingChart(saveFileDialog.FileName);
                    MessageBox.Show("Disposição salva com sucesso!");
                }
            }
        }

        
        private void SaveSeatingChart(string filePath)
        {
            using (var writer = new System.IO.StreamWriter(filePath))
            {
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < SeatsPerRow; j++)
                    {
                        writer.Write(seatingChart[i, j]);
                    }
                    writer.WriteLine();
                }
            }
        }

        
    }
}
