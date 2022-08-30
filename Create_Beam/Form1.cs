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



namespace Create_Beam
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            
            //create a model instance and chekc connection status
            Model model = new Model();

            if (!(model.GetConnectionStatus()))
            {
                MessageBox.Show("Tekla structures not connected");
                return;
            }


            //creating start and end point of beam
            Point point = new Point(0, 0, 0);  //we will assign it to start point
            Point point2 = new Point(5000, 0, 0); //we will assign it to end point

            //To create beam create object of a beam class
            //default constructor:  Initializes a new instance of the Beam class. The start and end points are in the origin.
            Beam beam = new Beam();

            //Initialise non static characteristics of Beam class to create it
            beam.StartPoint = point; //Gets or sets the start point of the beam.
                                     
            beam.EndPoint = point2;  //Gets or sets the end point of the beam.

            beam.Profile.ProfileString = "CFRHS150*5";

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


        }
    }
}
