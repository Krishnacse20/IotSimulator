namespace IoTSimulator
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
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.topicTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.publish_button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_detail = new System.Windows.Forms.Label();
            this.textR1 = new System.Windows.Forms.TextBox();
            this.textR2 = new System.Windows.Forms.TextBox();
            this.textR3 = new System.Windows.Forms.TextBox();
            this.textR4 = new System.Windows.Forms.TextBox();
            this.textR5 = new System.Windows.Forms.TextBox();
            this.textR6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textR1_ = new System.Windows.Forms.TextBox();
            this.textR2_ = new System.Windows.Forms.TextBox();
            this.textR3_ = new System.Windows.Forms.TextBox();
            this.textR4_ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textR5_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textR6_ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.Enabled = false;
            this.textResult.Location = new System.Drawing.Point(233, 236);
            this.textResult.MaxLength = 2;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(95, 20);
            this.textResult.TabIndex = 7;
            this.textResult.Text = "00 ";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(112, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Publish  in :";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DarkGreen;
            this.StartButton.FlatAppearance.BorderSize = 3;
            this.StartButton.Location = new System.Drawing.Point(419, 234);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopButton.FlatAppearance.BorderSize = 3;
            this.StopButton.Location = new System.Drawing.Point(502, 234);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(56, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter the Data :";
            // 
            // displayBox
            // 
            this.displayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.displayBox.Location = new System.Drawing.Point(30, 291);
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.Size = new System.Drawing.Size(713, 173);
            this.displayBox.TabIndex = 11;
            this.displayBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Topic  :";
            // 
            // topicTextbox
            // 
            this.topicTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicTextbox.Location = new System.Drawing.Point(112, 27);
            this.topicTextbox.MaxLength = 240;
            this.topicTextbox.Name = "topicTextbox";
            this.topicTextbox.Size = new System.Drawing.Size(631, 20);
            this.topicTextbox.TabIndex = 0;
            this.topicTextbox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(30, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Connection History :";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // publish_button
            // 
            this.publish_button.BackColor = System.Drawing.Color.Yellow;
            this.publish_button.FlatAppearance.BorderSize = 3;
            this.publish_button.Location = new System.Drawing.Point(579, 234);
            this.publish_button.Name = "publish_button";
            this.publish_button.Size = new System.Drawing.Size(56, 23);
            this.publish_button.TabIndex = 10;
            this.publish_button.Text = "Publish";
            this.publish_button.UseVisualStyleBackColor = false;
            this.publish_button.Click += new System.EventHandler(this.publish_button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // error_detail
            // 
            this.error_detail.AutoSize = true;
            this.error_detail.Location = new System.Drawing.Point(430, 211);
            this.error_detail.Name = "error_detail";
            this.error_detail.Size = new System.Drawing.Size(0, 13);
            this.error_detail.TabIndex = 35;
            // 
            // textR1
            // 
            this.textR1.Location = new System.Drawing.Point(339, 73);
            this.textR1.MaxLength = 5;
            this.textR1.Name = "textR1";
            this.textR1.Size = new System.Drawing.Size(40, 20);
            this.textR1.TabIndex = 1;
            // 
            // textR2
            // 
            this.textR2.Location = new System.Drawing.Point(339, 117);
            this.textR2.MaxLength = 5;
            this.textR2.Name = "textR2";
            this.textR2.Size = new System.Drawing.Size(40, 20);
            this.textR2.TabIndex = 2;
            // 
            // textR3
            // 
            this.textR3.Location = new System.Drawing.Point(339, 158);
            this.textR3.MaxLength = 5;
            this.textR3.Name = "textR3";
            this.textR3.Size = new System.Drawing.Size(40, 20);
            this.textR3.TabIndex = 3;
            // 
            // textR4
            // 
            this.textR4.Location = new System.Drawing.Point(622, 69);
            this.textR4.MaxLength = 5;
            this.textR4.Name = "textR4";
            this.textR4.Size = new System.Drawing.Size(40, 20);
            this.textR4.TabIndex = 4;
            // 
            // textR5
            // 
            this.textR5.Location = new System.Drawing.Point(622, 117);
            this.textR5.MaxLength = 5;
            this.textR5.Name = "textR5";
            this.textR5.Size = new System.Drawing.Size(40, 20);
            this.textR5.TabIndex = 5;
            // 
            // textR6
            // 
            this.textR6.Location = new System.Drawing.Point(622, 158);
            this.textR6.MaxLength = 5;
            this.textR6.Name = "textR6";
            this.textR6.Size = new System.Drawing.Size(40, 20);
            this.textR6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(115, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "TagName :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(421, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "TagName :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(421, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "TagName :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(422, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "TagName :";
            // 
            // textR1_
            // 
            this.textR1_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textR1_.Location = new System.Drawing.Point(193, 69);
            this.textR1_.MaxLength = 200;
            this.textR1_.Name = "textR1_";
            this.textR1_.Size = new System.Drawing.Size(62, 20);
            this.textR1_.TabIndex = 1;
            // 
            // textR2_
            // 
            this.textR2_.Location = new System.Drawing.Point(193, 112);
            this.textR2_.MaxLength = 200;
            this.textR2_.Name = "textR2_";
            this.textR2_.Size = new System.Drawing.Size(62, 20);
            this.textR2_.TabIndex = 2;
            // 
            // textR3_
            // 
            this.textR3_.Location = new System.Drawing.Point(193, 158);
            this.textR3_.MaxLength = 200;
            this.textR3_.Name = "textR3_";
            this.textR3_.Size = new System.Drawing.Size(62, 20);
            this.textR3_.TabIndex = 3;
            // 
            // textR4_
            // 
            this.textR4_.Location = new System.Drawing.Point(489, 70);
            this.textR4_.MaxLength = 200;
            this.textR4_.Name = "textR4_";
            this.textR4_.Size = new System.Drawing.Size(63, 20);
            this.textR4_.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(112, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "TagName :";
            // 
            // textR5_
            // 
            this.textR5_.Location = new System.Drawing.Point(489, 115);
            this.textR5_.MaxLength = 200;
            this.textR5_.Name = "textR5_";
            this.textR5_.Size = new System.Drawing.Size(63, 20);
            this.textR5_.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(112, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "TagName :";
            // 
            // textR6_
            // 
            this.textR6_.Location = new System.Drawing.Point(489, 160);
            this.textR6_.MaxLength = 200;
            this.textR6_.Name = "textR6_";
            this.textR6_.Size = new System.Drawing.Size(63, 20);
            this.textR6_.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(286, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Value :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(286, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Value :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(286, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Value :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(569, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Value :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(569, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Value :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(569, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Value :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(781, 476);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.error_detail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.publish_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.topicTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.textR6_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.textR5_);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textR4_);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textR3_);
            this.Controls.Add(this.textR2_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textR1_);
            this.Controls.Add(this.textR1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textR2);
            this.Controls.Add(this.textR3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textR4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textR5);
            this.Controls.Add(this.textR6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoTSimulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox topicTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button publish_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label error_detail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textR6_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textR5_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textR4_;
        private System.Windows.Forms.TextBox textR3_;
        private System.Windows.Forms.TextBox textR2_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textR1_;
        private System.Windows.Forms.TextBox textR1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textR2;
        private System.Windows.Forms.TextBox textR3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textR4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textR5;
        private System.Windows.Forms.TextBox textR6;
    }
}

