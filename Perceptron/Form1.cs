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
            DisableClassification();
        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            int clusterCount = Convert.ToInt32(ClusterCountTxt.Text.Trim());
            int imagesPerCluster = Convert.ToInt32(ImagePerClusterTxt.Text.Trim());
            int featureCount = Convert.ToInt32(FeatureCountTxt.Text.Trim());
            int iterationsLimit = Convert.ToInt32(IterationsLimitTxt.Text.Trim());
            
            ImageSetGenerator generator = ImageSetGenerator.Instance;
            Perceptron = Perceptron.Instance;

            ImageSet trainingSet;
            ClearTrainingSetOutput();
           
            do
            {
                DisableClassification();
                trainingSet = generator.GenerateRandomSet(clusterCount,
                    imagesPerCluster, featureCount);
                Perceptron.LoadTrainingSet(trainingSet);


            } while (!Perceptron.Train(trainingSet, iterationsLimit));
           
            TrainingSetTxt.Text = Perceptron.ClustersToString();
            PredictorFunctionsTxt.Text = Perceptron.PredictorFunctionsToString();
            EnableClassification();

        }

        private void ClassifyBtn_Click(object sender, EventArgs e)
        {
            string[] testFeatures = TestVectorTxt.Text.Trim().Split(' ');
            ImageVector testVector = new ImageVector(testFeatures);

             try
            {
                int clusterCode = Perceptron.Classify(testVector);
                ClassTxt.Text = clusterCode.ToString();
            }
            catch (IndexOutOfRangeException exc)
            {
                MessageBox.Show("Test image dimension error.");
            }
        }

        private void EnableClassification()
        {
            ClassifyBtn.Enabled = true;
        }

        private void DisableClassification()
        {
            ClassifyBtn.Enabled = false;
        }

        private void ClearTrainingSetOutput()
        {
            TrainingSetTxt.Clear();
        }
    }
}
