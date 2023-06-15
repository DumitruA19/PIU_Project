using CarDataStorage;
using CarLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Forms;

namespace AutoService
{
    public partial class CarsForm : Form
    {
        IDataStorageCars adminCars;

        ArrayList selectedOptions = new ArrayList();

        public CarsForm()
        {
            string fileNameCar = ConfigurationManager.AppSettings["FileNameCar"];
            string CarSolutionFileLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            //string CarCompleteFileLocation = Path.Combine(CarSolutionFileLocation, fileNameCar);
            adminCars = FactoryStorageCars.GetAdminStorageCar();
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private CarColor GetSelectedColor()
        {
            if (rdbBlack.Checked)
                return CarColor.Black;
            if (rdbWhite.Checked)
                return CarColor.White;
            if (rdbGray.Checked)
                return CarColor.Gray;
            if (rdbBlue.Checked)
                return CarColor.Blue;
            if (rdbBrown.Checked)
                return CarColor.Brown;
            if (rdbGreen.Checked)
                return CarColor.Green;
            if (rdbYellow.Checked)
                return CarColor.Yellow;
            if (rdbRed.Checked)
                return CarColor.Red;
            if (rdbSilver.Checked)
                return CarColor.Silver;

            return CarColor.Unknown;
        }
        private void CarsControlReset()
        {
            txtCarBrand.Text = txtCarModel.Text = txtCarYear.Text = txtCarCilindrical_Capacity.Text = string.Empty;

            rdbBlack.Checked = false;
            rdbBlue.Checked = false;
            rdbBrown.Checked = false;
            rdbGray.Checked = false;
            rdbGreen.Checked = false;
            rdbRed.Checked = false;
            rdbSilver.Checked = false;
            rdbWhite.Checked = false;
            rdbYellow.Checked = false;

            ckbSchimb_Frane.Checked = false;
            ckbSchimb_Ulei.Checked = false;
            ckbDistributie.Checked = false;
            ckbSchimb_Far.Checked = false;
            ckbVulcanizare.Checked = false;
            ckbPolish.Checked = false;

            selectedOptions.Clear();
        }

        private void button5_Click(object sender, EventArgs e)//backMenu button
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars car = new Cars(0, txtCarBrand.Text, txtCarModel.Text, txtCarYear.Text, txtCarCilindrical_Capacity.Text, true);

            car.IsAvailable = selectedOptions.Contains("Not Available") ? false : true;

            CarColor selectedColor = GetSelectedColor();
            car.Color = selectedColor;

            car.Options = new ArrayList();
            car.Options.AddRange(selectedOptions);

            adminCars.AddCar(car);

            CarsControlReset();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;

            string selectedOption = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                selectedOptions.Add(selectedOption);
            else
                selectedOptions.Remove(selectedOption);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayCar_Click(object sender, EventArgs e)
        {
            List<Cars> cars = adminCars.GetCars();
            DisplayCarsInControlDataGridView(cars);
        }
        private void DisplayCarsInControlDataGridView(List<Cars> cars)
        {
            dataGridCars.DataSource = null;
            dataGridCars.DataSource = cars;
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

            if (dataGridCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Cars selectedCar = (Cars)dataGridCars.SelectedRows[0].DataBoundItem;
            adminCars.DeleteCars(selectedCar.IdCar);

            // Refresh the DataGridView to show the updated list of cars
            List<Cars> cars = adminCars.GetCars();
            DisplayCarsInControlDataGridView(cars);

            MessageBox.Show("Car deleted successfully.");
        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridCars.Columns[e.ColumnIndex].Name == "IsAvailable")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool isAvailable = (bool)e.Value;
                    string displayText = isAvailable ? "Available" : "Not Available";

                    e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                    // Set the text color to white
                    using (Brush brush = new SolidBrush(Color.White))
                    {
                        // Center the text
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;
                        format.LineAlignment = StringAlignment.Center;

                        e.Graphics.DrawString(displayText, e.CellStyle.Font, brush, e.CellBounds, format);
                    }

                    e.Handled = true;
                }
            }
        }
    }
}
