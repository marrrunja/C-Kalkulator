namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        String strDisplay;
        Double temp;
        String operasi;
        String tampungan;

        public Kalkulator()
        {
            InitializeComponent();
            strDisplay = "";
            temp = 0.0;
            operasi = "";
            tampungan = "";
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (strDisplay.StartsWith("-"))
            {
                // Jika sudah ada tanda minus, hapus
                strDisplay = strDisplay.Substring(1);
            }
            else
            {
                // Jika belum ada, tambahkan minus di depan
                strDisplay = "-" + strDisplay;
            }

            displayBox.Text = strDisplay;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            strDisplay += "0";
            displayBox.Text = strDisplay;
        }
        // method untuk mematikan dan mereset semua data
        private void resetSemuaData()
        {
            strDisplay = "";
            temp = 0.0;
            operasi = "";
            tampungan = "";
        }

        // method untuk mematikan semua tombol
        private void matikanSemuaTombol()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Name != "buttonOnOff")
                    {
                        btn.Enabled = false; // Ubah warna menjadi hijau
                    }

                }
            }
        }
        // method untuk menghidupkan semua tombol
        private void hidupkanSemuaTombol()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Name != "buttonOnOff")
                    {
                        btn.Enabled = true; // Ubah warna menjadi hijau
                    }

                }
            }
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            // buat variabel is on dengan tipe data bool, yang memeriksa apakah text nya bukan string kosong
            bool isOn = displayBox.Text != "";

            // jika true
            if (isOn)
            {

                matikanSemuaTombol();
                displayBox.Text = "";
                resetSemuaData();
            }
            // jika false
            else
            {
                displayBox.Text = "0";
                hidupkanSemuaTombol();
            }
              
        }
        private void resetDataIfHasilNol()
        {
            strDisplay = "0";
            temp = 0.0;
            operasi = "";
            tampungan = "";
            displayBox.Text = strDisplay;
        }
        private void clearData()
        {
            strDisplay = "";
            temp = 0.0;
            operasi = "";
            tampungan = "";
            displayBox.Text = "0";
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(displayBox.Text);
            operasi = "/";
            strDisplay = "";
            displayBox.Text = strDisplay;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            strDisplay += "1";
            displayBox.Text = strDisplay;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            strDisplay += "2";
            displayBox.Text = strDisplay;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            strDisplay += "3";
            displayBox.Text = strDisplay;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            strDisplay += "4";
            displayBox.Text = strDisplay;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            strDisplay += "5";
            displayBox.Text = strDisplay;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            strDisplay += "6";
            displayBox.Text = strDisplay;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            strDisplay += "7";
            displayBox.Text = strDisplay;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            strDisplay += "8";
            displayBox.Text = strDisplay;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            strDisplay += "9";
            displayBox.Text = strDisplay;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(displayBox.Text);
            operasi = "+";
            strDisplay = "";
            displayBox.Text = strDisplay;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            if (operasi == "+")
            {
                double display = Convert.ToDouble(displayBox.Text);
                hasil = temp + display;
                strDisplay = hasil.ToString();
                displayBox.Text = strDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(displayBox.Text);
                strDisplay = hasil.ToString();
                displayBox.Text = strDisplay;
            }
            else if (operasi == "*")
            {
                hasil = temp * Convert.ToDouble(displayBox.Text);
                strDisplay = hasil.ToString();
                displayBox.Text = strDisplay;
            }
            else if (operasi == "/")
            {
                hasil = temp / Convert.ToDouble(displayBox.Text);
                strDisplay = hasil.ToString();
                displayBox.Text = strDisplay;
            }
            // reset kembali semua display dan juga perhitungan, kecuali tampunga, karna itu untuk menghapus
            //strDisplay = "";
            if (hasil == 0.0)
            {
                resetDataIfHasilNol();
            }
        }

        private void buttonMines_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(displayBox.Text);
            operasi = "-";
            strDisplay = "";
            displayBox.Text = strDisplay;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(displayBox.Text);
            operasi = "*";
            strDisplay = "";
            displayBox.Text = strDisplay;
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            tampungan = strDisplay.ToString();
            if (tampungan.Length == 1)
            {
                strDisplay = "";
                displayBox.Text = "0";
            }
            if (strDisplay != "" && displayBox.Text != "0")
            {
                string result = tampungan.Substring(0, tampungan.Length - 1);
                strDisplay = result;
                displayBox.Text = strDisplay;
            }
        }

        // tekan tombol koma
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(strDisplay == "")
            {
                return;
            }
            strDisplay += ",";
            displayBox.Text = strDisplay;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}