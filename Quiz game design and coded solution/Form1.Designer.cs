namespace Quiz_game_design_and_coded_solution
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textbox_Forname = new System.Windows.Forms.TextBox();
            this.textbox_Surname = new System.Windows.Forms.TextBox();
            this.textbox_Form = new System.Windows.Forms.TextBox();
            this.Textbox_DOB = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth_label = new System.Windows.Forms.Label();
            this.lblform_label = new System.Windows.Forms.Label();
            this.lblSurname_label = new System.Windows.Forms.Label();
            this.lblForname_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brentwood Trivia Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 143);
            this.button1.TabIndex = 3;
            this.button1.Text = "General knowledge";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 143);
            this.button2.TabIndex = 4;
            this.button2.Text = "Entertainment";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 143);
            this.button3.TabIndex = 5;
            this.button3.Text = "History";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(610, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 143);
            this.button4.TabIndex = 6;
            this.button4.Text = "Food and Drink";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please select a mode to play down below:";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(704, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(76, 29);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(773, 71);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 29);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(650, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 64);
            this.button5.TabIndex = 19;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textbox_Forname
            // 
            this.textbox_Forname.Location = new System.Drawing.Point(757, 113);
            this.textbox_Forname.Multiline = true;
            this.textbox_Forname.Name = "textbox_Forname";
            this.textbox_Forname.Size = new System.Drawing.Size(135, 20);
            this.textbox_Forname.TabIndex = 20;
            this.textbox_Forname.TextChanged += new System.EventHandler(this.textbox_Forname_TextChanged);
            // 
            // textbox_Surname
            // 
            this.textbox_Surname.Location = new System.Drawing.Point(757, 150);
            this.textbox_Surname.Multiline = true;
            this.textbox_Surname.Name = "textbox_Surname";
            this.textbox_Surname.Size = new System.Drawing.Size(135, 20);
            this.textbox_Surname.TabIndex = 21;
            this.textbox_Surname.TextChanged += new System.EventHandler(this.textbox_Surname_TextChanged);
            // 
            // textbox_Form
            // 
            this.textbox_Form.Location = new System.Drawing.Point(757, 187);
            this.textbox_Form.Multiline = true;
            this.textbox_Form.Name = "textbox_Form";
            this.textbox_Form.Size = new System.Drawing.Size(135, 20);
            this.textbox_Form.TabIndex = 22;
            this.textbox_Form.TextChanged += new System.EventHandler(this.textbox_Form_TextChanged);
            // 
            // Textbox_DOB
            // 
            this.Textbox_DOB.Location = new System.Drawing.Point(757, 226);
            this.Textbox_DOB.Multiline = true;
            this.Textbox_DOB.Name = "Textbox_DOB";
            this.Textbox_DOB.Size = new System.Drawing.Size(135, 20);
            this.Textbox_DOB.TabIndex = 23;
            this.Textbox_DOB.TextChanged += new System.EventHandler(this.Textbox_DOB_TextChanged);
            // 
            // lblDateOfBirth_label
            // 
            this.lblDateOfBirth_label.AutoSize = true;
            this.lblDateOfBirth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth_label.Location = new System.Drawing.Point(636, 226);
            this.lblDateOfBirth_label.Name = "lblDateOfBirth_label";
            this.lblDateOfBirth_label.Size = new System.Drawing.Size(121, 24);
            this.lblDateOfBirth_label.TabIndex = 17;
            this.lblDateOfBirth_label.Text = "DateOfBirth:";
            // 
            // lblform_label
            // 
            this.lblform_label.AutoSize = true;
            this.lblform_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblform_label.Location = new System.Drawing.Point(657, 183);
            this.lblform_label.Name = "lblform_label";
            this.lblform_label.Size = new System.Drawing.Size(65, 24);
            this.lblform_label.TabIndex = 16;
            this.lblform_label.Text = "Form:";
            // 
            // lblSurname_label
            // 
            this.lblSurname_label.AutoSize = true;
            this.lblSurname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname_label.Location = new System.Drawing.Point(657, 146);
            this.lblSurname_label.Name = "lblSurname_label";
            this.lblSurname_label.Size = new System.Drawing.Size(100, 24);
            this.lblSurname_label.TabIndex = 14;
            this.lblSurname_label.Text = "Surname:";
            // 
            // lblForname_label
            // 
            this.lblForname_label.AutoSize = true;
            this.lblForname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForname_label.Location = new System.Drawing.Point(657, 108);
            this.lblForname_label.Name = "lblForname_label";
            this.lblForname_label.Size = new System.Drawing.Size(100, 24);
            this.lblForname_label.TabIndex = 11;
            this.lblForname_label.Text = "Forname:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(936, 526);
            this.Controls.Add(this.Textbox_DOB);
            this.Controls.Add(this.textbox_Form);
            this.Controls.Add(this.textbox_Surname);
            this.Controls.Add(this.textbox_Forname);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblDateOfBirth_label);
            this.Controls.Add(this.lblform_label);
            this.Controls.Add(this.lblSurname_label);
            this.Controls.Add(this.lblForname_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Main Menu form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textbox_Forname;
        private System.Windows.Forms.TextBox textbox_Surname;
        private System.Windows.Forms.TextBox textbox_Form;
        private System.Windows.Forms.TextBox Textbox_DOB;
        private System.Windows.Forms.Label lblDateOfBirth_label;
        private System.Windows.Forms.Label lblform_label;
        private System.Windows.Forms.Label lblSurname_label;
        private System.Windows.Forms.Label lblForname_label;
    }
}

