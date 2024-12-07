using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetCalculator.Nodes;
using NetCalculator.Nodes.Arithmetic;
using NetCalculator.Nodes.Function;

namespace NetCalculator;

    public partial class CalculatorApp : Form
    {
        private StringBuilder _evalBoxBuilder = new StringBuilder();
        private ExpressionParser _expressionParser = new ExpressionParser();
        private const float DefaultFontSize = 48.0f;

        void UpdateEvalBox(string s)
        {
            _evalBoxBuilder.Append(s);
            evalBox.Text = _evalBoxBuilder.ToString();
            
            // calculate font scaling
            
            int sizeThreshold = 12;  
            float minFontSize = 20.0f;
            
            int textLength = _evalBoxBuilder.Length;
            float scaleFactor = Math.Max((float)sizeThreshold / textLength, minFontSize / DefaultFontSize);
            
            float newFontSize = DefaultFontSize * scaleFactor;
            
            newFontSize = Clamp(newFontSize, minFontSize, DefaultFontSize);

            // size font accordingly
            evalBox.Font = new Font(evalBox.Font.FontFamily, newFontSize);
        }

        float Clamp(float value, float min, float max)
        { // does not exist in this .net version and common font scaling algo relies on it
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
        
        public CalculatorApp()
        {
            InitializeComponent();
        }

        #region Calculator Functions
        private void clearBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.Reset();
            evalBox.Text = "0";
            _evalBoxBuilder.Clear();
            evalBox.Font = new Font(evalBox.Font.FontFamily, DefaultFontSize);
        }
        
        private void evalBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Math.Round(_expressionParser.Evaluate(), 4);

                _evalBoxBuilder.Clear();
                
                UpdateEvalBox(result.ToString()); // use updateevalbox for dynamic scaling

                _expressionParser.Reset();
                _evalBoxBuilder.Clear();
            }
            catch(Exception ex)
            {
                evalBox.Text = ex.Message;
                
                _expressionParser.Reset();
                _evalBoxBuilder.Clear();
            }
        }
        
        #endregion

        #region Numeric Buttons
        private void oneBtn_Click(object sender, EventArgs e)
        {
            string value = "1";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }
        
        private void twoBtn_Click(object sender, EventArgs e)
        {
            string value = "2";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            string value = "3";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            string value = "4";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            string value = "5";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            string value = "6";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            string value = "7";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            string value = "8";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            string value = "9";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            string value = "0";
            _expressionParser.Constant(value);
            UpdateEvalBox(value);
        }
#endregion

        #region Math Functions
        private void addBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Add);
            UpdateEvalBox("+");
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Sub);
            UpdateEvalBox("-");
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Mul);
            UpdateEvalBox("*");
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Div);
            UpdateEvalBox("/");
        }
        
        private void pwrBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Pwr);
            UpdateEvalBox("^");
        }

        private void rtBtn_Click(object sender, EventArgs e)
        {
            string lastConstant = _expressionParser.GetLastConstant();

            if (lastConstant == String.Empty)
            {
                evalBox.Text = "rt<arg1>(arg2)";
                _expressionParser.Reset();
                _evalBoxBuilder.Clear();
                return;
            }
            
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Rt);
            Console.WriteLine($"{_evalBoxBuilder.Length} - {lastConstant.Length}, {_evalBoxBuilder.Length}");
            _evalBoxBuilder.Remove(_evalBoxBuilder.Length - lastConstant.Length, lastConstant.Length); // remove previous element to switch here
            UpdateEvalBox($"rt<{lastConstant}>(");
            _expressionParser.OpenParenthesis();
        }

        private void ePwrXBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.Operation(OperationType.EpwrX);
            UpdateEvalBox("e^");
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string lastConstant = _expressionParser.GetLastConstant();

            if (lastConstant == String.Empty)
            {
                evalBox.Text = "log<arg1>(arg2)";
                _expressionParser.Reset();
                _evalBoxBuilder.Clear();
                return;
            }
            
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Log);
            _evalBoxBuilder.Remove(_evalBoxBuilder.Length - lastConstant.Length, _evalBoxBuilder.Length); // remove previous element to switch here
            UpdateEvalBox($"log<{lastConstant}>(");
            _expressionParser.OpenParenthesis();
        }

        private void lnBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.MarkEndConstant();

            _expressionParser.Operation(OperationType.Ln);
            UpdateEvalBox("ln(");
            _expressionParser.OpenParenthesis();
        }
        #endregion

        #region Parentheses
        private void lftParBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.OpenParenthesis();
            UpdateEvalBox("(");
        }

        private void rgtParBtn_Click(object sender, EventArgs e)
        {
            _expressionParser.CloseParenthesis();
            UpdateEvalBox(")");
        }
    #endregion

    private void decBtn_Click(object sender, EventArgs e)
    {
        _expressionParser.Constant(".");
        UpdateEvalBox(".");
    }
}
