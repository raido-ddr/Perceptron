namespace Perceptron
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClassCountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FeatureCountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrainingVectorCount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrainingSetTxt = new System.Windows.Forms.TextBox();
            this.GenerateTrainingBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of classes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrainingVectorCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FeatureCountTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClassCountTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input data";
            // 
            // ClassCountTxt
            // 
            this.ClassCountTxt.Location = new System.Drawing.Point(143, 28);
            this.ClassCountTxt.Name = "ClassCountTxt";
            this.ClassCountTxt.Size = new System.Drawing.Size(57, 20);
            this.ClassCountTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of features:";
            // 
            // FeatureCountTxt
            // 
            this.FeatureCountTxt.Location = new System.Drawing.Point(143, 58);
            this.FeatureCountTxt.Name = "FeatureCountTxt";
            this.FeatureCountTxt.Size = new System.Drawing.Size(57, 20);
            this.FeatureCountTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vectors per class:";
            // 
            // TrainingVectorCount
            // 
            this.TrainingVectorCount.Location = new System.Drawing.Point(143, 85);
            this.TrainingVectorCount.Name = "TrainingVectorCount";
            this.TrainingVectorCount.Size = new System.Drawing.Size(57, 20);
            this.TrainingVectorCount.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrainingSetTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 283);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training set";
            // 
            // TrainingSetTxt
            // 
            this.TrainingSetTxt.Location = new System.Drawing.Point(15, 27);
            this.TrainingSetTxt.Multiline = true;
            this.TrainingSetTxt.Name = "TrainingSetTxt";
            this.TrainingSetTxt.Size = new System.Drawing.Size(286, 238);
            this.TrainingSetTxt.TabIndex = 0;
            // 
            // GenerateTrainingBtn
            // 
            this.GenerateTrainingBtn.Location = new System.Drawing.Point(21, 460);
            this.GenerateTrainingBtn.Name = "GenerateTrainingBtn";
            this.GenerateTrainingBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateTrainingBtn.TabIndex = 3;
            this.GenerateTrainingBtn.Text = "Generate";
            this.GenerateTrainingBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.GenerateTrainingBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perceptron";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TrainingVectorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FeatureCountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassCountTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TrainingSetTxt;
        private System.Windows.Forms.Button GenerateTrainingBtn;
    }
}

