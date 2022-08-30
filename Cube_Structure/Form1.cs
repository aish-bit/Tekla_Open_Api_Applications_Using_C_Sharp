using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;


namespace Cube_Structure
{
    public partial class Input_Form : Form
    {
        //private non static characteristics of class
        private Beam beam;
        private Point point;
        private Point point2;
        private Model model;

        public Input_Form()
        {
            InitializeComponent();
            beam = new Beam();   //memory allocation to beam class
            model = new Model();  //create a model instance 
        }

        ~Input_Form()
        {
            //deallocating memory
            point = null;
            point2 = null;
            beam = null;
            model = null;
        }

        private void Create_Cube_Click(object sender, EventArgs e)
        {
            //Chekc connection status with model

            if (!(model.GetConnectionStatus()))
            {
                MessageBox.Show("Tekla structures not connected");
                return;
            }

            //local variables of function
            bool bFlag = false;
            int iArrayLoopCnt1 = 0;
            int iArrayIndex = 0;

            double[,] arr = new double[12, 6];

            arr[0,0]  = 0.0D;  arr[0,1]  = 0.0D;  arr[0,2]  = 0.0D;  arr[0,3] = 5000.0D; arr[0,4] = 0.0D; arr[0,5] = 0.0D;
            arr[1,0]  = 5000.0D;  arr[1,1]  = 0.0D;  arr[1,2]  = 0.0D;  arr[1,3] = 5000.0D; arr[1,4] = 5000.0D; arr[1,5] = 0.0D;
            arr[2,0] = 5000.0D; arr[2,1] = 5000.0D; arr[2, 2] = 0.0D; arr[2, 3] = 00.0D; arr[2, 4] = 5000.0D; arr[2, 5] = 0.0D;
            arr[3,0] = 00.0D; arr[3,1] = 5000.0D; arr[3, 2] = 0.0D; arr[3, 3] = 00.0D; arr[3, 4] = 00.0D; arr[3, 5] = 0.0D;
            
            arr[4,0] = 0.0D; arr[4,1] = 0.0D; arr[4, 2] = 0.0D; arr[4, 3] = 0.0D; arr[4, 4] = 0.0D; arr[4, 5] = 5000.0D;
            arr[5,0] = 5000.0D; arr[5,1] = 0.0D; arr[5, 2] = 0.0D; arr[5, 3] = 5000.0D; arr[5, 4] = 0.0D; arr[5, 5] = 5000.0D;
            arr[6,0] = 0.0D; arr[6,1] = 5000.0D; arr[6, 2] = 0.0D; arr[6, 3] = 0.0D; arr[6, 4] = 5000.0D; arr[6, 5] = 5000.0D;
            arr[7,0] = 5000.0D; arr[7,1] = 5000.0D; arr[7, 2] = 0.0D; arr[7, 3] = 5000.0D; arr[7, 4] = 5000.0D; arr[7, 5] = 5000.0D;
            
            arr[8,0] = 0.0D; arr[8,1] = 0.0D; arr[8, 2] = 5000.0D; arr[8, 3] = 5000.0D; arr[8, 4] = 00.0D; arr[8, 5] = 5000.0D;
            arr[9,0] = 5000.0D; arr[9,1] = 0.0D; arr[9, 2] = 5000.0D; arr[9, 3] = 5000.0D; arr[9, 4] = 5000.0D; arr[9, 5] = 5000.0D;
            arr[10,0] = 5000.0D; arr[10,1] = 5000.0D; arr[10, 2] = 5000.0D; arr[10, 3] =00.0D; arr[10, 4] = 5000.0D; arr[10, 5] = 5000.0D;
            arr[11,0] = 000.0D; arr[11,1] = 00.0D; arr[11, 2] = 5000.0D; arr[11, 3] = 000.0D; arr[11, 4] = 5000.0D; arr[11, 5] = 5000.0D;


                //traversal  
                for (iArrayLoopCnt1 = 0; iArrayLoopCnt1 < arr.GetLength(0); iArrayLoopCnt1++)
                {
                    // creating start and end point of beam
                    point = new Point(arr[iArrayLoopCnt1, iArrayIndex], arr[iArrayLoopCnt1, (iArrayIndex + 1)], arr[iArrayLoopCnt1, (iArrayIndex + 2)]);  //we will assign it to start point
                    point2 = new Point(arr[iArrayLoopCnt1, (iArrayIndex + 3)], arr[iArrayLoopCnt1, (iArrayIndex + 4)], arr[iArrayLoopCnt1, (iArrayIndex + 5)]); //we will assign it to end point
                    
                    
                    //Initialise non static characteristics of Beam class to create it
                    beam.StartPoint = point; //Gets or sets the start point of the beam.

                    beam.EndPoint = point2;  //Gets or sets the end point of the beam.

                    beam.Profile.ProfileString = "CFRHS150*5"; //profile of beam assign

                    beam.Finish = "PAINT";  //Gets or sets the finish of the part. 

                    beam.StartPointOffset = new Offset(); //Gets or sets the beam's start point offset.

                    beam.EndPointOffset = new Offset(); //Gets or sets the beam's end point offset. 

                    beam.Material.MaterialString = "E295";

                    beam.Class = "4";

                    //Inserts the beam into the model database. All the attributes/characteristics must be set. 
                    bFlag = beam.Insert();

                    if (bFlag == true)
                    {
                        model.CommitChanges();
                    }

                    iArrayIndex = 0;

                }

            

            

            
        }
    }
}



