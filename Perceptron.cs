using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ver2._1_Perceptrons
{
    class Perceptron
    {
        // Class defines one single neuron (= perceptron) with user-specified number of synapses (= inputs)
        // Start conditions for wights of perceptron and bias by random 

        private int numInput;       // definition of number of inputs (synapses)
        private double[] inputs;    // vector of inputs
        private double[] weights;   // vestor of wights
        private double bias;        // offset of perceptron
        private int output;         // output of perceptron (+1 / -1)
        private Random rnd;         // random number (0..1) for initializing wights and bias

        public Perceptron(int numInput)
        {
            this.numInput = numInput;               // Definition of number of inputs
            this.inputs = new double[numInput];
            this.weights = new double[numInput];
            this.rnd = new Random();               // Intilazion of new instance of Random-class - (0) = defined random value
            InitializeWeights();                    // method for initialization
        }
        // Constructor, first overload: wights and bias of perceptron by random  

        private void InitializeWeights()
        {
            double lo = -0.01;
            double hi = 0.01;
            for (int i = 0; i < weights.Length; ++i)
                weights[i] = (hi - lo) * rnd.NextDouble() + lo;
            bias = (hi - lo) * rnd.NextDouble() + lo;
        } // Method, first overload: wights and bias of perceptron by random

        public int ComputeOutput(double[] xValues)
        {
            if (xValues.Length != numInput)
                throw new Exception("Bad xValues in ComputeOutput");
            double sum = 0.0;
            for (int i = 0; i < numInput; ++i)
                sum += xValues[i] * this.weights[i];
            sum += this.bias;
            int result = Activation(sum);
            this.output = result;
            return result;
        } // Method, first overload: Calculate for given input-vector plus wights-vector sum of perceptron -> +1 or -1 -> see activation method below


        private static int Activation(double v)
        {
            if (v >= 0.0)
                return +1;
            else
                return -1;
        } // Method, first overload. Activation of perceptron output by checking percepton summ (see above): +1 or -1

        public double[] Train(Data[] trainData, double alpha, int maxEpochs)
        {
            int epoch = 0;
            double[] xValues = new double[numInput];
            int desired = 0;

            int[] sequence = new int[trainData.GetLength(0)];
            for (int i = 0; i < sequence.Length; ++i)
            {
                sequence[i] = i;
            }
            // initialize sequence of train data (for shuffling, see below)
            double error = 1;
            while (epoch < maxEpochs & error > 0)
            // train process will be stopped if no error (we are right!) or max. number of itterations (maxEpochs) will be reached 
            {
                Shuffle(sequence); // sequence of training sets will be shuffeld again and again to get better learning effect 
                error = 0;
                for (int i = 0; i < trainData.GetLength(0); ++i)
                {
                    int idx = sequence[i];
                    for (int k = 0; k < numInput; k++)
                        xValues[k] = trainData[idx].dataSet[k];
                    desired = (int)trainData[idx].data_value;   // -1 or +1. 
                    int computed = ComputeOutput(xValues);
                    error += CalcError(computed, desired);      // Calculation of error and sum over all train data-sets
                    Update(computed, desired, alpha, xValues);  // Modify weights and bias values
                } // for each data. 
                ++epoch;
            }
            double[] result = new double[numInput + 1];
            Array.Copy(this.weights, result, numInput);
            result[result.Length - 1] = bias; // Last cell is the value of bias
            return result;
        } // Method Train, first overload

        private double CalcError(int computed, int desired)
        {
            return (Math.Abs(computed - desired));
        }
        // Calculation of error between perceptrons output and target output while learning

        private void Shuffle(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; ++i)
            {
                int r = rnd.Next(i, sequence.Length);   // generate random integer number between i and sequenz.Length
                                                        // if in construktor Random(0) shuffeling will be always in the same way
                int tmp = sequence[r];
                sequence[r] = sequence[i];
                sequence[i] = tmp;
            }
        }
        // Method, first overload: shuffeling of sequence of train data-sets using "Fisher-Yates Algorithm"
        // Avoiding the use of always same sequence -> stable and better learning process (no infinite loop in learning process) 

        private void Update(int computed, int desired, double alpha, double[] inputs)
        {
            if (computed == desired) return; // We're good. 
            int delta = computed - desired; // If computed > desired, delta is +. 
            for (int i = 0; i < this.weights.Length; ++i) // Each input-weight pair. 
            {
                if (computed > desired && inputs[i] >= 0.0) // Need to reduce weights. 
                    weights[i] = weights[i] - (alpha * delta * inputs[i]); // delta +, alpha +, input + 
                else if (computed > desired && inputs[i] < 0.0) // Need to reduce weights. 
                    weights[i] = weights[i] + (alpha * delta * inputs[i]); // delta +, alpha +, input - 
                else if (computed < desired && inputs[i] >= 0.0) // Need to increase weights. 
                    weights[i] = weights[i] - (alpha * delta * inputs[i]); // delta -, aplha +, input + 
                else if (computed < desired && inputs[i] < 0.0) // Need to increase weights. 
                    weights[i] = weights[i] + (alpha * delta * inputs[i]); // delta -, alpha +, input -
            } // Each weight. 
            bias = bias - (alpha * delta);
        }
        // Methode, first overload: adaption of wights and bias. 
        // Sign of delta gives the direction of adaption (smaler/larger)
        // Absolut value of delta gives increment of change (scaled by alpha, the dumping factor - avoiding over-shooting) 

    } // Perceptron
}
