using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;



namespace Ver2._1_Perceptrons
{
    class MainMethods
    {
        public MainMethods()
        {
        } // Constructore, first overload
        public static string ShowData(double[][] trainData)
        {
            string text = "";
            int numRows = trainData.Length;
            int numCols = trainData[0].Length;
            for (int i = 0; i < numRows; ++i)
            {
                text += ("[" + i.ToString().PadLeft(2, ' ') + "] ");
                for (int j = 0; j < numCols - 1; ++j)
                    text += (trainData[i][j].ToString("F1").PadLeft(6));
                text += (" -> " + trainData[i][numCols - 1].ToString("+0;-0") + "\n");
            }
            return text;
        } // Method, first overload - Output of train data
        public static string ShowVector(double[] vector, int decimals, bool newLine)
        {
            string text = "";
            for (int i = 0; i < vector.Length; ++i)
            {
                if (vector[i] >= 0.0)
                    text += (" "); // For sign.
                text += (vector[i].ToString("F" + decimals) + " ");
            }
            text += "\n";
            if (newLine == true)
                text += "\n";
            return text;
        } // Method, first overload - Output of double-vector. In this program: output of paramteres e.g. wights
        public void Plot_Data(Graphics gr, Data[] DatenSet)
        {
            // plot of LearningData points
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            for (int i = 0; i < DatenSet.GetLength(0); i++)
            {
                double x = 40 + (DatenSet[i].dataSet[0] * 400);
                double y = 40 + (DatenSet[i].dataSet[1] * 400);
                if (DatenSet[i].data_value == 1)
                {
                    PointF top_point = new PointF(Convert.ToInt32(x), Convert.ToInt32(y - 5));
                    PointF right_point = new PointF(Convert.ToInt32(x + 5), Convert.ToInt32(y + 5));
                    PointF left_point = new PointF(Convert.ToInt32(x - 5), Convert.ToInt32(y + 5));
                    PointF[] points = { top_point, right_point, left_point };
                    gr.FillPolygon(blueBrush, points);
                }
                else
                {
                    gr.FillEllipse(blueBrush, Convert.ToInt32(x - 5), Convert.ToInt32(y - 5), 10, 10);
                }
            }
        }// Methode for plot of data. First overload
        public void Plot_Data(Graphics gr, Data[] DatenSet, Perceptron p)
        {
            // plot of LearningData points
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            SolidBrush redBrush = new SolidBrush(Color.Red);
            for (int i = 0; i < DatenSet.GetLength(0); i++)
            {
                double x = 40 + (DatenSet[i].dataSet[0] * 400);
                double y = 40 + (DatenSet[i].dataSet[1] * 400);
                if (DatenSet[i].data_value == 1)
                {
                    PointF top_point = new PointF(Convert.ToInt32(x), Convert.ToInt32(y - 5));
                    PointF right_point = new PointF(Convert.ToInt32(x + 5), Convert.ToInt32(y + 5));
                    PointF left_point = new PointF(Convert.ToInt32(x - 5), Convert.ToInt32(y + 5));
                    PointF[] points = { top_point, right_point, left_point };
                    gr.DrawPolygon(pen, points);
                    if (DatenSet[i].data_value != p.ComputeOutput(DatenSet[i].dataSet))
                        gr.FillPolygon(redBrush, points);
                }
                else
                {
                    gr.DrawEllipse(pen, Convert.ToInt32(x - 5), Convert.ToInt32(y - 5), 10, 10);
                    if (DatenSet[i].data_value != p.ComputeOutput(DatenSet[i].dataSet))
                        gr.FillEllipse(redBrush, Convert.ToInt32(x - 5), Convert.ToInt32(y - 5), 10, 10);
                }
            }
        }// Methode for plot of data. Second overload (with perceptron instance for output prediction)
        public Graphics OutPut_Window()
        {
            Form w1 = new Form();
            w1.Text = "Output Window";                          // Set the caption bar text of the form w1.   
            w1.MaximizeBox = false;                             // Set the MaximizeBox to false to remove the maximize box.
            w1.MinimizeBox = false;                             // Set the MinimizeBox to false to remove the minimize box.
            w1.StartPosition = FormStartPosition.CenterScreen;  // Set the start position of the form to the center of the screen.
            w1.AutoSize = false;
            w1.Size = new Size(500, 620);
            Label Text1 = new Label(); // Create label for learning data.
            Text1.Location = new Point(10, 300);
            Text1.AutoSize = true;
            //Data.Text += "\nData for fit:\n";
            //Data.Text += MainMethods.ShowData(Daten);
            w1.Controls.Add(Text1);   // Add label "Data" to the form
            Graphics g = w1.CreateGraphics();
            w1.Show();             // show form w1}
            return g;
        }
        public void CoordinateSystem (Graphics gr)
        {
            Message(14, "Logic Separation", gr, 10, 10);
            // coordinate system 
            // origin: 40/40
            Pen myPen = new Pen(Color.Black, 1);
            Point p0 = new Point(40, 40); // X-axis
            Point p1 = new Point(40, 440);
            gr.DrawLine(myPen, p0, p1);

            Point p2 = new Point(40, 40); // Y-axis
            Point p3 = new Point(440, 40);
            gr.DrawLine(myPen, p2, p3);
            Message(10, "Streight Line = Real Seperation Function", gr, 10, 470);
            Message(10, "Dotted Line = Perceptron Seperation Function", gr, 10, 490);
            Message(10, "Blue Marker = TrainData", gr, 10, 510);
            Message(10, "Open Marker = TestData", gr, 10, 530);
            Message(10, "Red Marker = Wrong Forcast by Perceptron", gr, 10, 550);
        }
        public void Message (int size, string info, Graphics gr, Single x, Single y)
        {
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            StringFormat drawFormat = new System.Drawing.StringFormat();
            gr.DrawString(info, drawFont, drawBrush, x, y, drawFormat);
        }
        public void Create_QRCode(Control ctrl, string payload)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator(); // creating an instance of the QR-Code-Generator 
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            // generating bitmap e.g. for forms
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(2);
            PictureBox P = new PictureBox()
            {
                Size = new Size(120, 120),
                Location = new Point(63, 310),
            };
            ctrl.Controls.Add(P);
            P.Image = qrCodeImage;
        }
        public void PLot_Function(Graphics gr, bool dashed_line, Int32 X1, Int32 Y1, Int32 X2, Int32 Y2)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            float[] dashValues = { 3, 3 };
            if (dashed_line == true) 
                blackPen.DashPattern = dashValues;
            gr.DrawLine(blackPen, X1, Y1, X2, Y2);
        }
    }
}
