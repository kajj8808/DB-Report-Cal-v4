using System.Diagnostics;
using static DB_REPORT_01_CAL.Program;

namespace DB_REPORT_01_CAL
{
    public partial class Form1 : Form
    {
        private string fristNum = "";
        private string secondNum = "";
        private string symbol = "";
        private string calResult = "";
        private string labelText = "";      

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Num_Input_Handler(int number) {
            if (symbol == "")
            { // 부호가 초기값이라면 첫번쨰 숫자 입력 아니라면 두번째 숫자입력.
                fristNum += number.ToString();
            }
            else {
                secondNum += number.ToString();
            }
        }

        private void Update_Label() {
            labelText = "";
            labelText += fristNum != "" ? fristNum : "";
            labelText += symbol != "" ? $" {symbol}" : "";
            labelText += secondNum != "" ? $" {secondNum}" : "";
            labelText += calResult != "" ? $" = {calResult}" : "";
                                                            
            result_label.Text = labelText;
        }
        
        private void Btn_On_Click_Handler( Buttons Btn ) {
            if (Btn == Buttons.Btn_equal && secondNum == "") return;
            if (symbol != "" && (Btn == Buttons.Btn_plus || Btn == Buttons.Btn_minus || Btn == Buttons.Btn_multiply || Btn == Buttons.Btn_divide)) return;
            switch (Btn) {
                case Buttons.Btn_0:
                    Num_Input_Handler(0);
                    break;
                case Buttons.Btn_1:
                    Num_Input_Handler(1);
                    break;
                case Buttons.Btn_2:
                    Num_Input_Handler(2);
                    break;
                case Buttons.Btn_3:
                    Num_Input_Handler(3);
                    break;
                case Buttons.Btn_4:
                    Num_Input_Handler(4);
                    break;
                case Buttons.Btn_5:
                    Num_Input_Handler(5);
                    break;
                case Buttons.Btn_6:
                    Num_Input_Handler(6);
                    break;
                case Buttons.Btn_7:
                    Num_Input_Handler(7);
                    break;
                case Buttons.Btn_8:
                    Num_Input_Handler(8);
                    break;
                case Buttons.Btn_9:
                    Num_Input_Handler(9);
                    break;
                case Buttons.Btn_plus:
                    Debug.WriteLine("Btn_plus");
                    symbol = "+";
                    break;
                case Buttons.Btn_minus:
                    Debug.WriteLine("Btn_,mi");
                    symbol = "-";
                    break;
                case Buttons.Btn_multiply:
                    symbol = "*";
                    break;
                case Buttons.Btn_divide:
                    symbol = "/";
                    break;
                case Buttons.Btn_equal:
                    int fristNumber = Int32.Parse(fristNum);
                    int secondNumber = Int32.Parse(secondNum);
                    switch (symbol) {
                        case "+":
                            calResult = (fristNumber + secondNumber).ToString();
                            break;
                        case "-":
                            calResult = (fristNumber - secondNumber).ToString();
                            break;
                        case "*":
                            calResult = (fristNumber * secondNumber).ToString();
                            break;
                        case "/":
                            calResult = (fristNumber / secondNumber).ToString();
                            break;
                    }
                    break;
                default:break;
            }
            Update_Label();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
   
        private void Btn_0_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_0);
        }
        private void Btn_1_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_1);
        }
        private void Btn_2_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_2);
        }
        private void Btn_3_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_3);
        }
        private void Btn_4_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_4);
        }
        private void Btn_5_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_5);
        }
        private void Btn_6_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_6);
        }
        private void Btn_7_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_7);
        }
        private void Btn_8_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_8);
        }
        private void Btn_9_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_9);
        }
        private void Btn_equal_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_equal);
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_plus);
        }
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_minus);
        }
        private void Btn_multiply_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_multiply);

        }
        private void Btn_divide_Click(object sender, EventArgs e)
        {
            Btn_On_Click_Handler(Buttons.Btn_divide);
        }
    }
}