namespace ArmAnal
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        private List<Panel> displayPanels;
        
        public Form1()
        {
            InitializeComponent();
            buttons = new List<Button> { };
            displayPanels = new List<Panel> { ForcesInputPanel, DimensionInputPanel };
        }

        private void clearDisplayPanels()
        {
            foreach (var panel in displayPanels)
            {
                panel.Visible = false;
            }
        }

        private void clearDisplayPanelsExcept(Panel exceptPanel)
        {
            foreach (var panel in displayPanels)
            {
                if (panel != exceptPanel)
                {
                    panel.Visible = false;
                }
            }
        }

        private void DarkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkModeCheckBox.Checked)
            {
                this.BackColor = Color.FromArgb(30, 30, 30); // Dark background
                this.ForeColor = Color.White; // Light text
            }
            else
            {
                this.BackColor = SystemColors.Control; // Default background
                this.ForeColor = SystemColors.ControlText; // Default text color
            }
        }

        private void DimensionsInputPanelButton_Click(object sender, EventArgs e)
        {
            clearDisplayPanelsExcept(DimensionInputPanel);
            DimensionInputPanel.Visible = !DimensionInputPanel.Visible;
        }

        private void ForcesInputPanelButton_Click(object sender, EventArgs e)
        {
            clearDisplayPanelsExcept(ForcesInputPanel);
            ForcesInputPanel.Visible = !ForcesInputPanel.Visible;
        }

        private void RunPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void DimensionInputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaxHeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinHeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_MinHeight_Click(object sender, EventArgs e)
        {

        }

        private void Label_MaxActuatorLength_Click(object sender, EventArgs e)
        {

        }

        private void ActuatorMaxLengthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActuatorMinLengthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Max_Height_Click(object sender, EventArgs e)
        {

        }

        private void ArmLengthFullInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_ArmLength_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label_ArmPercentConnect_Click(object sender, EventArgs e)
        {

        }

        private void ArmPercentConnectInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label_MaxActuatorForce_Click(object sender, EventArgs e)
        {

        }

        private void Label_ActuatorWeight_Click(object sender, EventArgs e)
        {

        }

        private void MaxActuatorForceInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActuatorWeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_AppliedForce_Click(object sender, EventArgs e)
        {

        }

        private void AppliedForeceInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_ArmWeight_Click(object sender, EventArgs e)
        {

        }

        private void ArmWeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequiredAccelerationInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Acceleration_Click(object sender, EventArgs e)
        {

        }

        private void ForcesInputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cwllthisbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
