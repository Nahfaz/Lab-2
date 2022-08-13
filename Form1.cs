namespace Semester_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public List<TextBox> inputTextBoxList = new List<TextBox>();
        public List<Label> outputLabelList = new List<Label>();
        public double averageNumber=0.0;
        public int week=1;
        public double thisSemesterNumber = 0.0;

        private void Form1_Load(object sender, EventArgs e)
        {
             //input text box list
            inputTextBoxList.Add(tb_Cn1);
            inputTextBoxList.Add(tb_Cn2);
            inputTextBoxList.Add(tb_Cn3);
            inputTextBoxList.Add(tb_Cn4);
            inputTextBoxList.Add(tb_Cn5);
            inputTextBoxList.Add(tb_Cn6);


            //output label list
            outputLabelList.Add(lblCourseOneGrade);
            outputLabelList.Add(lblCourseTwoGrade);
            outputLabelList.Add(lblCourseThreeGrade);
            outputLabelList.Add(lblCourseFourGrade);
            outputLabelList.Add(lblCourseFiveGrade);
            outputLabelList.Add(lblCourseSixGrade);

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_leave(object sender, EventArgs e)
        {
            for (int controlIndex = 0; controlIndex < inputTextBoxList.Count -1 ; controlIndex++)
            {
                double inputNumber = 0.0;

                if (double.TryParse(inputTextBoxList.ElementAt(controlIndex).Text, out inputNumber))
                {
                    double[] numberThresholds = { 0.0, 50.0, 55.0, 60.0, 65.0, 70.0, 75.0, 80.0, 85.0, 90.0 };
                    String[] numberDescription = { "F", "D", "D+", "C", "B-", "B", "B+", "A-", "A", "A+" };

                    for (int numberLevel = 0; numberLevel < numberDescription.Length - 1; numberLevel++)
                    {
                        if (inputNumber<0 || inputNumber>100)
                        {
                            MessageBox.Show("Enter a valid number between 0 and 100!");
                        }
                        else if (inputNumber >= numberThresholds[numberLevel])
                        {
                            outputLabelList.ElementAt(controlIndex).Text = numberDescription[numberLevel];

                        }
                    }



                }
            }

        }
    }
}