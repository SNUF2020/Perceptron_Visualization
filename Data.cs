using System;


namespace Ver2._1_Perceptrons
{
    class Data
    {
        private int numInput;           // definition of number of data per set
        public double[] dataSet;        // X-values
        public double[] ConstantVector; // definition of separation function (c_1, c_2, ...)
        public int data_value;          // description of state of data-set (+1 oder -1)
        private Random rnd;             // random number (0..1) for initializing wights and bias

        public Data(Random rnd, int numInput, double Konst)
        {
            this.numInput = numInput; // Number of X-values (= number of inputs of perceptron)
            this.dataSet = new double[numInput];
            this.rnd = rnd;
            this.ConstantVector = new double[numInput];
            GenerateConstantVector();
            GenerateDataSet(Konst);
        }
        // Constructor, first overload: Generation of one data-set by using random data

        private void GenerateDataSet(double Konst)
        {
            double lo = 0.0;
            double hi = 1.0;
            for (int i = 0; i < dataSet.Length; ++i)
            {
                dataSet[i] = (hi - lo) * rnd.NextDouble() + lo;
                //Thread.Sleep(rnd.Next(100));
            }
            this.data_value = computeResult(dataSet, Konst);
        }
        // Method, first overload: generation of data-set X1, X2, ... by random
        // data-state will be calculated based on X-vector ("dataSet")

        public static int computeResult(double x1, double x2, double m, double c)
        {
            if (x2 >= m * x1 + c) return +1;
            else return -1;
        }
        // Method, first overload: only for 2-dimensional separation funtion (numinput = 2)

        private static double computeResult(double x1, double x2, double r)
        {
            if ((Math.Sqrt(Math.Sqrt(x1) + Math.Sqrt(x2))) >= r) return +1;
            else return -1;
            // Ergebnis-Funktion
            // Radius (Abstand zum Nullpunkt) einer Koordinate (X1, X2) definiert Werte-Bereich für +1/-1
        }
        // Method, second overload: only for 2-dimensional separation funtion (numinput = 2)
        // transformation of X-vector into radial coordinates

        public int computeResult(double[] data, double c)
        {
            double summe = 0;
            for (int i = 0; i < data.Length; i++)
                summe = summe + data[i] * ConstantVector[i];
            if (summe >= c) return +1;
            else return -1;
        }
        // Method, third overload: General method for n-dimensions

        public void GenerateConstantVector()
        {
            ConstantVector[0] = 1;
            for (int i = 1; i < numInput; i++)
                ConstantVector[i] = -1;
        }
        // Method, first overload: static generation of constant array (+1, -1, -1, ...) -> diagonal separation function

        public void GenerateConstantVector(double limit_low, double limit_high)
        {
            for (int i = 0; i < numInput; i++)
                ConstantVector[i] = ((limit_high - limit_low) * rnd.NextDouble() + limit_low);
        }
        // Method, second overload: generation of c_1, c_2, ... c_n by random
    } // Data
}
