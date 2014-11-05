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
            this.IterationsLimitTxt = new System.Windows.Forms.TextBox();
            this.TrainBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ImagePerClusterTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FeatureCountTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClusterCountTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TrainingSetTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PredictorFunctionsTxt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClassifyBtn = new System.Windows.Forms.Button();
            this.ClassTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestVectorTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.IterationsLimitTxt);
            this.groupBox1.Controls.Add(this.TrainBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ImagePerClusterTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FeatureCountTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClusterCountTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input data";
            // 
            // IterationsLimitTxt
            // 
            this.IterationsLimitTxt.Location = new System.Drawing.Point(387, 28);
            this.IterationsLimitTxt.Name = "IterationsLimitTxt";
            this.IterationsLimitTxt.Size = new System.Drawing.Size(54, 20);
            this.IterationsLimitTxt.TabIndex = 9;
            this.IterationsLimitTxt.Text = "200";
            // 
            // TrainBtn
            // 
            this.TrainBtn.Location = new System.Drawing.Point(15, 145);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(75, 23);
            this.TrainBtn.TabIndex = 2;
            this.TrainBtn.Text = "Train";
            this.TrainBtn.UseVisualStyleBackColor = true;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Training iterations limit:";
            // 
            // ImagePerClusterTxt
            // 
            this.ImagePerClusterTxt.Location = new System.Drawing.Point(143, 85);
            this.ImagePerClusterTxt.Name = "ImagePerClusterTxt";
            this.ImagePerClusterTxt.Size = new System.Drawing.Size(57, 20);
            this.ImagePerClusterTxt.TabIndex = 7;
            this.ImagePerClusterTxt.Text = "2";
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
            // FeatureCountTxt
            // 
            this.FeatureCountTxt.Location = new System.Drawing.Point(143, 58);
            this.FeatureCountTxt.Name = "FeatureCountTxt";
            this.FeatureCountTxt.Size = new System.Drawing.Size(57, 20);
            this.FeatureCountTxt.TabIndex = 5;
            this.FeatureCountTxt.Text = "3";
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
            // ClusterCountTxt
            // 
            this.ClusterCountTxt.Location = new System.Drawing.Point(143, 28);
            this.ClusterCountTxt.Name = "ClusterCountTxt";
            this.ClusterCountTxt.Size = new System.Drawing.Size(57, 20);
            this.ClusterCountTxt.TabIndex = 1;
            this.ClusterCountTxt.Text = "4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrainingSetTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 283);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Training set";
            // 
            // TrainingSetTxt
            // 
            this.TrainingSetTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrainingSetTxt.Location = new System.Drawing.Point(15, 22);
            this.TrainingSetTxt.Multiline = true;
            this.TrainingSetTxt.Name = "TrainingSetTxt";
            this.TrainingSetTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TrainingSetTxt.Size = new System.Drawing.Size(454, 238);
            this.TrainingSetTxt.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PredictorFunctionsTxt);
            this.groupBox3.Location = new System.Drawing.Point(510, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 283);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Predictor functions";
            // 
            // PredictorFunctionsTxt
            // 
            this.PredictorFunctionsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredictorFunctionsTxt.Location = new System.Drawing.Point(18, 22);
            this.PredictorFunctionsTxt.Multiline = true;
            this.PredictorFunctionsTxt.Name = "PredictorFunctionsTxt";
            this.PredictorFunctionsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PredictorFunctionsTxt.Size = new System.Drawing.Size(407, 238);
            this.PredictorFunctionsTxt.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClassifyBtn);
            this.groupBox4.Controls.Add(this.ClassTxt);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TestVectorTxt);
            this.groupBox4.Location = new System.Drawing.Point(510, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classification";
            // 
            // ClassifyBtn
            // 
            this.ClassifyBtn.Location = new System.Drawing.Point(17, 140);
            this.ClassifyBtn.Name = "ClassifyBtn";
            this.ClassifyBtn.Size = new System.Drawing.Size(75, 23);
            this.ClassifyBtn.TabIndex = 4;
            this.ClassifyBtn.Text = "Classify";
            this.ClassifyBtn.UseVisualStyleBackColor = true;
            this.ClassifyBtn.Click += new System.EventHandler(this.ClassifyBtn_Click);
            // 
            // ClassTxt
            // 
            this.ClassTxt.Location = new System.Drawing.Point(18, 104);
            this.ClassTxt.Name = "ClassTxt";
            this.ClassTxt.Size = new System.Drawing.Size(74, 20);
            this.ClassTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Test vector features:";
            // 
            // TestVectorTxt
            // 
            this.TestVectorTxt.Location = new System.Drawing.Point(18, 47);
            this.TestVectorTxt.Name = "TestVectorTxt";
            this.TestVectorTxt.Size = new System.Drawing.Size(323, 20);
            this.TestVectorTxt.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perceptron";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ImagePerClusterTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FeatureCountTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClusterCountTxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TrainingSetTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TrainBtn;
        private System.Windows.Forms.TextBox PredictorFunctionsTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ClassifyBtn;
        private System.Windows.Forms.TextBox ClassTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TestVectorTxt;
        private System.Windows.Forms.TextBox IterationsLimitTxt;
        private System.Windows.Forms.Label label6;
    }
}

