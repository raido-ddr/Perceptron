using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        private Perceptron Perceptron { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateTrainingBtn_Click(object sender, EventArgs e)
        {
            int clusterCount = Convert.ToInt32(ClusterCountTxt.Text.Trim());
            int imagesPerCluster = Convert.ToInt32(ImagePerClusterTxt.Text.Trim());
            int featureCount = Convert.ToInt32(FeatureCountTxt.Text.Trim());
            
            ImageSetGenerator generator = ImageSetGenerator.Instance;

            ImageSet trainingSet = generator.GenerateRandomSet(clusterCount, 
                imagesPerCluster, featureCount);

            Perceptron = Perceptron.Instance;
            Perceptron.LoadTrainingSet(trainingSet);

            TrainingSetTxt.Text = Perceptron.ClustersToString();

            if (Perceptron.Train(trainingSet, 100) == true)
            {
                PredictorFunctionsTxt.Text = Perceptron.PredictorFunctionsToString();
            }
            else
            {
                PredictorFunctionsTxt.Text = "Trainig failed.";
            }
            

        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ClassifyBtn_Click(object sender, EventArgs e)
        {
            string[] testFeatures = TestVectorTxt.Text.Trim().Split(' ');
            ImageVector testVector = new ImageVector(testFeatures);

            int clusterCode = Perceptron.Classify(testVector);
            ClassTxt.Text = clusterCode.ToString();

        }
    }
}
