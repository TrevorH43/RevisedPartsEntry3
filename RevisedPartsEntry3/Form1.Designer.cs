namespace RevisedPartsEntry3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.partDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemClassTextBox = new System.Windows.Forms.TextBox();
            this.unitsOnHandTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Part Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Units On Hand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit Price";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(277, 68);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.partNumberTextBox.TabIndex = 9;
            this.partNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partNumberTextBox_Validating);
            // 
            // partDescriptionTextBox
            // 
            this.partDescriptionTextBox.Location = new System.Drawing.Point(277, 109);
            this.partDescriptionTextBox.Name = "partDescriptionTextBox";
            this.partDescriptionTextBox.Size = new System.Drawing.Size(174, 23);
            this.partDescriptionTextBox.TabIndex = 11;
            this.partDescriptionTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.partDescriptionTextBox_Validating);
            // 
            // itemClassTextBox
            // 
            this.itemClassTextBox.Location = new System.Drawing.Point(277, 161);
            this.itemClassTextBox.Name = "itemClassTextBox";
            this.itemClassTextBox.Size = new System.Drawing.Size(100, 23);
            this.itemClassTextBox.TabIndex = 13;
            this.itemClassTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.itemClassTextBox_Validating);
            // 
            // unitsOnHandTextBox
            // 
            this.unitsOnHandTextBox.Location = new System.Drawing.Point(277, 206);
            this.unitsOnHandTextBox.Name = "unitsOnHandTextBox";
            this.unitsOnHandTextBox.Size = new System.Drawing.Size(100, 23);
            this.unitsOnHandTextBox.TabIndex = 15;
            this.unitsOnHandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitsOnHandTextBox_Validating);
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(276, 251);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.unitPriceTextBox.TabIndex = 17;
            this.unitPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.unitPriceTextBox_Validating);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(239, 362);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(332, 362);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(434, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.unitsOnHandTextBox);
            this.Controls.Add(this.itemClassTextBox);
            this.Controls.Add(this.partDescriptionTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox partNumberTextBox;
        private TextBox partDescriptionTextBox;
        private TextBox itemClassTextBox;
        private TextBox unitsOnHandTextBox;
        private TextBox unitPriceTextBox;
        private Button submitButton;
        private Button clearButton;
        private Button exitButton;
        private ErrorProvider errorProvider;
    }
}