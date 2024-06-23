using System.Data;

namespace Practice
{
    public partial class Form1 : Form
    {
        private string _currentInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void botZero_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("0");
        }

        private void botOne_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("1");
        }

        private void botTwo_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("2");
        }

        private void botThree_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("3");
        }

        private void botFour_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("4");
        }

        private void botFive_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("5");
        }

        private void botSix_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("6");
        }

        private void botSeven_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("7");
        }

        private void botEight_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("8");
        }

        private void botNine_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("9");
        }

        private void add_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("+");
        }

        private void minus_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("-");
        }

        private void multiply_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("*");
        }

        private void divide_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("/");
        }

        private void open_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput("(");
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput(")");
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            txtTest.Text = string.Empty;
            _currentInput = "";
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            CalculateResult();
        }

        private void UpdateInput(string value)
        {
         
            if (value == "." && _currentInput.EndsWith("."))
            {
                return;
            }

      
            if (value == "." && (string.IsNullOrEmpty(_currentInput) || !char.IsDigit(_currentInput[^1])))
            {
                value = "0."; 
            }

            if (value == "." && _currentInput.Contains("."))
            {
                var parts = _currentInput.Split(new[] { '+', '-', '*', '/' });
                if (parts.Length > 0 && parts[^1].Contains("."))
                {
                    return; 
                }
            }

            if (value == "(" && !string.IsNullOrEmpty(_currentInput) &&
                (char.IsDigit(_currentInput[^1]) || _currentInput[^1] == ')'))
            {
                _currentInput += "*";
                txtTest.Text += "*";
            }

            if (value == ")" && !string.IsNullOrEmpty(_currentInput) &&
                (_currentInput[^1] == '('))
            {
                
                return;
            }


            _currentInput += value;
            txtTest.Text += value;
        }

        private void CalculateResult()
        {
            try
            {
                var result = EvaluateExpression(_currentInput);
                lblTest.Text = result.ToString();
                _currentInput = ""; 
                txtTest.Clear();
            }
            catch (Exception)
            {
                lblTest.Text = "Error";
            }
        }

        private double EvaluateExpression(string expression)
        {
            var dataTable = new DataTable();
            var result = dataTable.Compute(expression, "");
            return Convert.ToDouble(result);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTest.Text.Length > 0)
            {
                txtTest.Text = txtTest.Text.Remove(txtTest.Text.Length - 1, 1);
                _currentInput = _currentInput.Remove(_currentInput.Length - 1, 1);
            }
        }

        private void decButton_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateInput(".");
        }
    }
}