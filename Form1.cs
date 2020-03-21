using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ver2._1_Perceptrons
{
    // Program for perceptron with user-defined number of inputs (Synapse) - for graphical description limited in this case to 2
    // Definition of perceptron in class "Perceptron"
    // Definition of data-sets in class "Data"
    // Keeping Form1 as lean as possible all methodes are in class "MainMethodes"
    // Initial point for program from program "Perceptrons" from "Neuronal Networks using C# / Succinctly" (console application, see Version 1.1)
    // Input control (at KeyPress) at textBox_xy from home page "TrainYourProgrammer"
    // QR-code from Code-Bude, see e.g. GitHub

    // S.N.U.F 17.03.2020
    // Last change: 21.03.2020

    // Version 2.1:
    // Perceptron and Data class from Version 1.1
    // Windows-Forms application from Version 2.0

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Generation of MainMathode instance
            MainMethods Ausgabe1 = new MainMethods();
            //  Implementation of QR-code to Form1
            Ausgabe1.Create_QRCode(this, "MIT Licence\nCopyright (c) 2020 SNUF2020\n\nhttps://github.com/SNUF2020");
        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }// Program-End with Exit-Button

        private void textBox_Alpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        }
        // Input-control - just decimal numbers and control-keys are allowed 

        private void textBox_maxEpochs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        }
        // Input-control - just decimal numbers and control-keys are allowed 

        private void textBox_TrainData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        }
        // Input-control - just decimal numbers and control-keys are allowed 

        private void textBox_TestData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
        }
        // Input-control - just decimal numbers and control-keys are allowed 

        private void button_Start_Click(object sender, EventArgs e)
        {
            // Domain of definition
            int numInput = 2;                                             // Number of inputs X0, X1, ... Xn
            double alpha = Convert.ToDouble(textBox_Alpha.Text);          // increment width at train process
            int maxEpochs = Convert.ToInt32(textBox_maxEpochs.Text);      // max. number of itterations at train process
            int AnzahlDataSets = Convert.ToInt32(textBox_TrainData.Text); // Number of data-sets for learning perceptron
            int AnzahlTestSets = Convert.ToInt32(textBox_TestData.Text);  // Number of data-sets for testing perceptron
            double Konst = 0;                                             // Constant value at given separation funktion
            Random rand = new Random(); // generation of instance of Random-class. in case of (number) = defined random value
            
            // Generation of traing-data
            Data[] LernDaten = new Data[AnzahlDataSets]; // generation of data-array 
            for (int i = 0; i < AnzahlDataSets; i++)
                LernDaten[i] = new Data(rand, numInput, Konst); // alocation of data-sets to i-element of data-array

            // Generation of MainMathode instance
            MainMethods Ausgabe = new MainMethods();
           
            // Definition of output window and return graphics instance 
            Graphics g = Ausgabe.OutPut_Window(); // return Graphics instance for further use

            // Generation of Coordinate System
            Ausgabe.CoordinateSystem(g);

            // plot of real seperation function
            Ausgabe.PLot_Function(g, false, 40, 40, 440, 440);

            // plot of LearningData points
            Ausgabe.Plot_Data(g, LernDaten);

            // Generation of perceptron as object
            Perceptron p = new Perceptron(numInput);

            // Train the perceptron with learning data
            double[] weights = p.Train(LernDaten, alpha, maxEpochs); // return of optimized weights -> used for plot of perceptron seperation function
            
            // Generation of Test-Data
            Data[] TestDaten = new Data[AnzahlTestSets]; // generation of data-array 
            for (int i = 0; i < AnzahlTestSets; i++)
                TestDaten[i] = new Data(rand, numInput, Konst); // alocation of data-sets to i-element of data-array

            // plot of TestingData points
            Ausgabe.Plot_Data(g, TestDaten, p);

            // plot of perceptron seperation function
            Ausgabe.PLot_Function(g, true, 40, Convert.ToInt32(40 - ((weights[2]) / weights[1]) * 400), 440, Convert.ToInt32(40 - ((weights[2] + weights[0]) / weights[1]) * 400));

            //Ausgabe.Create_QRCode(this, "Perceptron-Program\nby S.NUF.2020\nUnder MIT Licence\n\nhttps://github.com/SNUF2020");
        }  // Start button      
    } // class Form1
} // name space Ver2._1_Perceptrons
