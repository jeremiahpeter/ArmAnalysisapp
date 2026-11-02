namespace ArmAnal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DarkModeCheckBox = new CheckBox();
            DimensionsInputPanelButton = new Button();
            ForcesInputPanelButton = new Button();
            RunPanelButton = new Button();
            DimensionInputPanel = new Panel();
            Label_ArmPercentConnect = new Label();
            ArmPercentConnectInput = new TextBox();
            Label_ArmLength = new Label();
            ArmLengthFullInput = new TextBox();
            ActuatorMinLengthInput = new TextBox();
            Label_MinHeight = new Label();
            Label_MaxActuatorLength = new Label();
            MinHeightInput = new TextBox();
            Label_ActuatorMinLength = new Label();
            ActuatorMaxLengthInput = new TextBox();
            Label_Max_Height = new Label();
            MaxHeightInput = new TextBox();
            ForcesInputPanel = new Panel();
            label1 = new Label();
            Label_Acceleration = new Label();
            RequiredAccelerationInput = new TextBox();
            ArmWeightInput = new TextBox();
            Label_ActuatorWeight = new Label();
            Label_AppliedForce = new Label();
            AppliedForeceInput = new TextBox();
            Label_ArmWeight = new Label();
            ActuatorWeightInput = new TextBox();
            Label_MaxActuatorForce = new Label();
            MaxActuatorForceInput = new TextBox();
            DimensionInputPanel.SuspendLayout();
            ForcesInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DarkModeCheckBox
            // 
            DarkModeCheckBox.AutoSize = true;
            DarkModeCheckBox.Location = new Point(12, 724);
            DarkModeCheckBox.Name = "DarkModeCheckBox";
            DarkModeCheckBox.Size = new Size(81, 19);
            DarkModeCheckBox.TabIndex = 0;
            DarkModeCheckBox.Text = "DarkMode";
            DarkModeCheckBox.UseVisualStyleBackColor = true;
            DarkModeCheckBox.CheckedChanged += DarkModeCheckBox_CheckedChanged;
            // 
            // DimensionsInputPanelButton
            // 
            DimensionsInputPanelButton.Location = new Point(12, 12);
            DimensionsInputPanelButton.Name = "DimensionsInputPanelButton";
            DimensionsInputPanelButton.Size = new Size(81, 23);
            DimensionsInputPanelButton.TabIndex = 1;
            DimensionsInputPanelButton.Text = "Dimensions";
            DimensionsInputPanelButton.UseVisualStyleBackColor = true;
            DimensionsInputPanelButton.Click += DimensionsInputPanelButton_Click;
            // 
            // ForcesInputPanelButton
            // 
            ForcesInputPanelButton.Location = new Point(99, 12);
            ForcesInputPanelButton.Name = "ForcesInputPanelButton";
            ForcesInputPanelButton.Size = new Size(81, 23);
            ForcesInputPanelButton.TabIndex = 2;
            ForcesInputPanelButton.Text = "Forces";
            ForcesInputPanelButton.UseVisualStyleBackColor = true;
            ForcesInputPanelButton.Click += ForcesInputPanelButton_Click;
            // 
            // RunPanelButton
            // 
            RunPanelButton.Location = new Point(186, 12);
            RunPanelButton.Name = "RunPanelButton";
            RunPanelButton.Size = new Size(81, 23);
            RunPanelButton.TabIndex = 3;
            RunPanelButton.Text = "Run";
            RunPanelButton.UseVisualStyleBackColor = true;
            RunPanelButton.Click += RunPanelButton_Click;
            // 
            // DimensionInputPanel
            // 
            DimensionInputPanel.BackColor = SystemColors.ActiveCaption;
            DimensionInputPanel.Controls.Add(Label_ArmPercentConnect);
            DimensionInputPanel.Controls.Add(ArmPercentConnectInput);
            DimensionInputPanel.Controls.Add(Label_ArmLength);
            DimensionInputPanel.Controls.Add(ArmLengthFullInput);
            DimensionInputPanel.Controls.Add(ActuatorMinLengthInput);
            DimensionInputPanel.Controls.Add(Label_MinHeight);
            DimensionInputPanel.Controls.Add(Label_MaxActuatorLength);
            DimensionInputPanel.Controls.Add(MinHeightInput);
            DimensionInputPanel.Controls.Add(Label_ActuatorMinLength);
            DimensionInputPanel.Controls.Add(ActuatorMaxLengthInput);
            DimensionInputPanel.Controls.Add(Label_Max_Height);
            DimensionInputPanel.Controls.Add(MaxHeightInput);
            DimensionInputPanel.Location = new Point(12, 42);
            DimensionInputPanel.Name = "DimensionInputPanel";
            DimensionInputPanel.Size = new Size(255, 149);
            DimensionInputPanel.TabIndex = 4;
            DimensionInputPanel.Visible = false;
            DimensionInputPanel.Paint += DimensionInputPanel_Paint;
            // 
            // Label_ArmPercentConnect
            // 
            Label_ArmPercentConnect.AutoSize = true;
            Label_ArmPercentConnect.Location = new Point(25, 123);
            Label_ArmPercentConnect.Name = "Label_ArmPercentConnect";
            Label_ArmPercentConnect.Size = new Size(121, 15);
            Label_ArmPercentConnect.TabIndex = 11;
            Label_ArmPercentConnect.Text = "Arm Percent Connect";
            Label_ArmPercentConnect.Click += Label_ArmPercentConnect_Click;
            // 
            // ArmPercentConnectInput
            // 
            ArmPercentConnectInput.Location = new Point(152, 123);
            ArmPercentConnectInput.Name = "ArmPercentConnectInput";
            ArmPercentConnectInput.Size = new Size(100, 23);
            ArmPercentConnectInput.TabIndex = 10;
            ArmPercentConnectInput.TextChanged += ArmPercentConnectInput_TextChanged;
            // 
            // Label_ArmLength
            // 
            Label_ArmLength.AutoSize = true;
            Label_ArmLength.Location = new Point(54, 102);
            Label_ArmLength.Name = "Label_ArmLength";
            Label_ArmLength.Size = new Size(92, 15);
            Label_ArmLength.TabIndex = 9;
            Label_ArmLength.Text = "Full Arm Length";
            Label_ArmLength.Click += Label_ArmLength_Click;
            // 
            // ArmLengthFullInput
            // 
            ArmLengthFullInput.Location = new Point(152, 99);
            ArmLengthFullInput.Name = "ArmLengthFullInput";
            ArmLengthFullInput.Size = new Size(100, 23);
            ArmLengthFullInput.TabIndex = 8;
            ArmLengthFullInput.TextChanged += ArmLengthFullInput_TextChanged;
            // 
            // ActuatorMinLengthInput
            // 
            ActuatorMinLengthInput.Location = new Point(152, 75);
            ActuatorMinLengthInput.Name = "ActuatorMinLengthInput";
            ActuatorMinLengthInput.Size = new Size(100, 23);
            ActuatorMinLengthInput.TabIndex = 7;
            ActuatorMinLengthInput.TextChanged += ActuatorMinLengthInput_TextChanged;
            // 
            // Label_MinHeight
            // 
            Label_MinHeight.AutoSize = true;
            Label_MinHeight.Location = new Point(59, 30);
            Label_MinHeight.Name = "Label_MinHeight";
            Label_MinHeight.Size = new Size(87, 15);
            Label_MinHeight.TabIndex = 4;
            Label_MinHeight.Text = "Min Bar Height";
            Label_MinHeight.Click += Label_MinHeight_Click;
            // 
            // Label_MaxActuatorLength
            // 
            Label_MaxActuatorLength.AutoSize = true;
            Label_MaxActuatorLength.Location = new Point(28, 54);
            Label_MaxActuatorLength.Name = "Label_MaxActuatorLength";
            Label_MaxActuatorLength.Size = new Size(118, 15);
            Label_MaxActuatorLength.TabIndex = 5;
            Label_MaxActuatorLength.Text = "Max Actuator Length";
            Label_MaxActuatorLength.Click += Label_MaxActuatorLength_Click;
            // 
            // MinHeightInput
            // 
            MinHeightInput.Location = new Point(152, 51);
            MinHeightInput.Name = "MinHeightInput";
            MinHeightInput.Size = new Size(100, 23);
            MinHeightInput.TabIndex = 1;
            MinHeightInput.TextChanged += MinHeightInput_TextChanged;
            // 
            // Label_ActuatorMinLength
            // 
            Label_ActuatorMinLength.AutoSize = true;
            Label_ActuatorMinLength.Location = new Point(29, 78);
            Label_ActuatorMinLength.Name = "Label_ActuatorMinLength";
            Label_ActuatorMinLength.Size = new Size(117, 15);
            Label_ActuatorMinLength.TabIndex = 6;
            Label_ActuatorMinLength.Text = "Min Actuator Length";
            // 
            // ActuatorMaxLengthInput
            // 
            ActuatorMaxLengthInput.Location = new Point(152, 27);
            ActuatorMaxLengthInput.Name = "ActuatorMaxLengthInput";
            ActuatorMaxLengthInput.Size = new Size(100, 23);
            ActuatorMaxLengthInput.TabIndex = 2;
            ActuatorMaxLengthInput.TextChanged += ActuatorMaxLengthInput_TextChanged;
            // 
            // Label_Max_Height
            // 
            Label_Max_Height.AutoSize = true;
            Label_Max_Height.Location = new Point(58, 6);
            Label_Max_Height.Name = "Label_Max_Height";
            Label_Max_Height.Size = new Size(88, 15);
            Label_Max_Height.TabIndex = 3;
            Label_Max_Height.Text = "Max Bar Height";
            Label_Max_Height.Click += Label_Max_Height_Click;
            // 
            // MaxHeightInput
            // 
            MaxHeightInput.Location = new Point(152, 3);
            MaxHeightInput.Name = "MaxHeightInput";
            MaxHeightInput.Size = new Size(100, 23);
            MaxHeightInput.TabIndex = 0;
            MaxHeightInput.TextChanged += MaxHeightInput_TextChanged;
            // 
            // ForcesInputPanel
            // 
            ForcesInputPanel.BackColor = SystemColors.GradientActiveCaption;
            ForcesInputPanel.Controls.Add(label1);
            ForcesInputPanel.Controls.Add(Label_Acceleration);
            ForcesInputPanel.Controls.Add(RequiredAccelerationInput);
            ForcesInputPanel.Controls.Add(ArmWeightInput);
            ForcesInputPanel.Controls.Add(Label_ActuatorWeight);
            ForcesInputPanel.Controls.Add(Label_AppliedForce);
            ForcesInputPanel.Controls.Add(AppliedForeceInput);
            ForcesInputPanel.Controls.Add(Label_ArmWeight);
            ForcesInputPanel.Controls.Add(ActuatorWeightInput);
            ForcesInputPanel.Controls.Add(Label_MaxActuatorForce);
            ForcesInputPanel.Controls.Add(MaxActuatorForceInput);
            ForcesInputPanel.Location = new Point(12, 41);
            ForcesInputPanel.Name = "ForcesInputPanel";
            ForcesInputPanel.Size = new Size(255, 125);
            ForcesInputPanel.TabIndex = 12;
            ForcesInputPanel.Visible = false;
            ForcesInputPanel.Paint += ForcesInputPanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 123);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // Label_Acceleration
            // 
            Label_Acceleration.AutoSize = true;
            Label_Acceleration.Location = new Point(23, 102);
            Label_Acceleration.Name = "Label_Acceleration";
            Label_Acceleration.Size = new Size(123, 15);
            Label_Acceleration.TabIndex = 9;
            Label_Acceleration.Text = "Required Acceleration";
            Label_Acceleration.Click += Label_Acceleration_Click;
            // 
            // RequiredAccelerationInput
            // 
            RequiredAccelerationInput.Location = new Point(152, 99);
            RequiredAccelerationInput.Name = "RequiredAccelerationInput";
            RequiredAccelerationInput.Size = new Size(100, 23);
            RequiredAccelerationInput.TabIndex = 8;
            RequiredAccelerationInput.TextChanged += RequiredAccelerationInput_TextChanged;
            // 
            // ArmWeightInput
            // 
            ArmWeightInput.Location = new Point(152, 75);
            ArmWeightInput.Name = "ArmWeightInput";
            ArmWeightInput.Size = new Size(100, 23);
            ArmWeightInput.TabIndex = 7;
            ArmWeightInput.TextChanged += ArmWeightInput_TextChanged;
            // 
            // Label_ActuatorWeight
            // 
            Label_ActuatorWeight.AutoSize = true;
            Label_ActuatorWeight.Location = new Point(52, 30);
            Label_ActuatorWeight.Name = "Label_ActuatorWeight";
            Label_ActuatorWeight.Size = new Size(94, 15);
            Label_ActuatorWeight.TabIndex = 4;
            Label_ActuatorWeight.Text = "Actuator Weight";
            Label_ActuatorWeight.Click += Label_ActuatorWeight_Click;
            // 
            // Label_AppliedForce
            // 
            Label_AppliedForce.AutoSize = true;
            Label_AppliedForce.Location = new Point(69, 54);
            Label_AppliedForce.Name = "Label_AppliedForce";
            Label_AppliedForce.Size = new Size(77, 15);
            Label_AppliedForce.TabIndex = 5;
            Label_AppliedForce.Text = "AppliedForce";
            Label_AppliedForce.Click += Label_AppliedForce_Click;
            // 
            // AppliedForeceInput
            // 
            AppliedForeceInput.Location = new Point(152, 51);
            AppliedForeceInput.Name = "AppliedForeceInput";
            AppliedForeceInput.Size = new Size(100, 23);
            AppliedForeceInput.TabIndex = 1;
            AppliedForeceInput.TextChanged += AppliedForeceInput_TextChanged;
            // 
            // Label_ArmWeight
            // 
            Label_ArmWeight.AutoSize = true;
            Label_ArmWeight.Location = new Point(75, 78);
            Label_ArmWeight.Name = "Label_ArmWeight";
            Label_ArmWeight.Size = new Size(71, 15);
            Label_ArmWeight.TabIndex = 6;
            Label_ArmWeight.Text = "Arm Weight";
            Label_ArmWeight.Click += Label_ArmWeight_Click;
            // 
            // ActuatorWeightInput
            // 
            ActuatorWeightInput.Location = new Point(152, 27);
            ActuatorWeightInput.Name = "ActuatorWeightInput";
            ActuatorWeightInput.Size = new Size(100, 23);
            ActuatorWeightInput.TabIndex = 2;
            ActuatorWeightInput.TextChanged += ActuatorWeightInput_TextChanged;
            // 
            // Label_MaxActuatorForce
            // 
            Label_MaxActuatorForce.AutoSize = true;
            Label_MaxActuatorForce.Location = new Point(36, 6);
            Label_MaxActuatorForce.Name = "Label_MaxActuatorForce";
            Label_MaxActuatorForce.Size = new Size(110, 15);
            Label_MaxActuatorForce.TabIndex = 3;
            Label_MaxActuatorForce.Text = "Max Actuator Force";
            Label_MaxActuatorForce.Click += Label_MaxActuatorForce_Click;
            // 
            // MaxActuatorForceInput
            // 
            MaxActuatorForceInput.Location = new Point(152, 3);
            MaxActuatorForceInput.Name = "MaxActuatorForceInput";
            MaxActuatorForceInput.Size = new Size(100, 23);
            MaxActuatorForceInput.TabIndex = 0;
            MaxActuatorForceInput.TextChanged += MaxActuatorForceInput_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 755);
            Controls.Add(ForcesInputPanel);
            Controls.Add(DimensionInputPanel);
            Controls.Add(RunPanelButton);
            Controls.Add(ForcesInputPanelButton);
            Controls.Add(DimensionsInputPanelButton);
            Controls.Add(DarkModeCheckBox);
            Name = "Form1";
            Text = "ActuatorAnalysis™ (URC-AA)";
            Load += Form1_Load;
            DimensionInputPanel.ResumeLayout(false);
            DimensionInputPanel.PerformLayout();
            ForcesInputPanel.ResumeLayout(false);
            ForcesInputPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox DarkModeCheckBox;
        private Button DimensionsInputPanelButton;
        private Button ForcesInputPanelButton;
        private Button RunPanelButton;
        private Panel DimensionInputPanel;
        private TextBox ActuatorMaxLengthInput;
        private TextBox MinHeightInput;
        private TextBox MaxHeightInput;
        private Label Label_Max_Height;
        private Label Label_MinHeight;
        private Label Label_MaxActuatorLength;
        private TextBox ActuatorMinLengthInput;
        private Label Label_ActuatorMinLength;
        private Label Label_ArmLength;
        private TextBox ArmLengthFullInput;
        private TextBox ArmPercentConnectInput;
        private Label Label_ArmPercentConnect;
        private Panel ForcesInputPanel;
        private Label label1;
        private TextBox textBox1;
        private Label Label_Acceleration;
        private TextBox RequiredAccelerationInput;
        private TextBox ArmWeightInput;
        private Label Label_ActuatorWeight;
        private Label Label_AppliedForce;
        private TextBox AppliedForeceInput;
        private Label Label_ArmWeight;
        private TextBox ActuatorWeightInput;
        private Label Label_MaxActuatorForce;
        private TextBox MaxActuatorForceInput;
    }
}
