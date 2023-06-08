using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
         
    {
        private double memory = 0;
        private string display = "0";
        private string currentOperator = "";
        private bool isCalculating = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDisplay("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            AppendToDisplay(number);
        }


        private void AppendToDisplay(string number)
        {
            //Mostrar numeros y peradores en pantalla
            if (display == "0")
            {
                display = number;
            }
            else
            {
                display += number;
            }
            textBox1.Text = display;
        }

        private void SetDisplay(string number)
        {
            display = number;
            textBox1.Text = display;
        }

      

        //Operadores

        private void divide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            AppendToDisplay(" " + operation + " ");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            AppendToDisplay(" " + operation + " ");
        }

        private void add_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            AppendToDisplay(" " + operation + " ");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            AppendToDisplay(" " + operation + " ");
        }

        //Boton igual
        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                //Datatable compute para evaluar la expresion matemetica
                DataTable dt = new DataTable();
                var result = dt.Compute(display, null);
                double parsedResult;
                if (double.TryParse(result.ToString(), out parsedResult))
                {
                    SetDisplay(parsedResult.ToString());
                }
                //no se puede convertir a doble
                else
                {
                    MessageBox.Show("Error al calcular el resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al calcular el resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Memoria
        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            display = "0";
            textBox1.Text = display;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (display.Length > 0)
            {
                display = display.Substring(0, display.Length - 1);
                textBox1.Text = display;
            }
        }

        private void clear_mem_btn_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void recall_memory_Click(object sender, EventArgs e)
        {
            SetDisplay(memory.ToString());
        }

        private void store_memory_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(display);
        }
    }



}
