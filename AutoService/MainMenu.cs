﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCarsMenu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarsForm carsMenu = new CarsForm();
            carsMenu.ShowDialog();
            this.Show();
        }

        private void btnClientsMenu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsForm clientsMenu = new ClientsForm();
            clientsMenu.ShowDialog();
            this.Show();
        }
    }
}
