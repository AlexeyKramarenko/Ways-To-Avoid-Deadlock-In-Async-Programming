﻿namespace Application
{
    partial class FewTasksForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "2. BLOCKING UI CALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BLOCKING_UI_CALL);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "3. NON-BLOCKING UI CALL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NON_BLOCKING_UI_CALL);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "4. ContinueWith";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CONTINUE_WITH);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "5. GetAwaiter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GET_AWAITER);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "1. BLOCKING UI CALL with DEADLOCK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BLOCKING_UI_CALL_WITH_DEADLOCK);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PROBLEMATIC METHODS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ASYNC METHODS:";
            // 
            // FewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 246);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FewTasksForm";
            this.Text = "FewTasksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}