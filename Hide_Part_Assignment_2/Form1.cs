using System;
using System.Collections.Generic;
using System.Collections;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.Operations;


namespace Hide_Part_Assignment_2
{
    public partial class frm_User_Input_Form : Form
    {
        private Model modelobj;
        private Tekla.Structures.Model.UI.Picker pickerobj;
        private Hashtable allModelObject;
        public frm_User_Input_Form()
        {
            modelobj = new Model();  //create a model instance 
            pickerobj = new Tekla.Structures.Model.UI.Picker(); //creating object of picker class to accept input from user
            allModelObject = new Hashtable();
            InitializeComponent();
        }

        ~frm_User_Input_Form()
        {
            modelobj = null;
            pickerobj = null;
        }

        private void frm_User_Input_Form_Load(object sender, EventArgs e)
        {
            //txtBox_PartName.Text = "Please Enter Part name";
        }

        private void txtBox_PartName_TextChanged(object sender, EventArgs e)
        {
            //if(txtBox_PartName.Text == "Please Enter Part name")
            //{

            //}
            //txtBox_PartName.Text = "";
            //txtBox_PartName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Part_Click(object sender, EventArgs e)
        {
            if (!(modelobj.GetConnectionStatus()))
            {
                MessageBox.Show("Tekla structures not connected");
                return;
            }

            //Insert models in opened CAD file
            if(cbx_ModelType.Text == "I-Beam")
            {
                this.insertIBeam();
            }
            else if (cbx_ModelType.Text == "Hollow-Pipe")
            {
                this.insertHollowPipe();
            }
            else if(cbx_ModelType.Text == "Column-Welded Box Profile")
            {
                this.insertWeldedBoxProfileColumn();
            }
            else if(cbx_ModelType.Text == "Polybeam-L Angle")
            {
                this.insertPolyBeamLAngle();
            }
            else if(cbx_ModelType.Text == "Contour Plate")
            {
                this.insertContourPlate();
            }

   

        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void insertIBeam()
        {
            //accepting start and end point of I-beam from user
            Point startPoint = pickerobj.PickPoint("Pick start point of I-Beam");  
            Point endPoint = pickerobj.PickPoint("Pick end point of I-Beam");  

            //To create beam,create object of a beam class
            //default constructor:  Initializes a new instance of the Beam class. The start and end points are in the origin.
            Beam beamobj = new Beam(startPoint,endPoint);
            
            //Initialise non static characteristics of Beam class to create it

            beamobj.Profile.ProfileString = "ISMB200"; //type of beam profile

            beamobj.Name = txtBox_PartName.Text; //give name to part as per users provision

            beamobj.Finish = "PAINT";  //Gets or sets the finish of the part. 

            beamobj.StartPointOffset = new Offset(); //Gets or sets the beam's start point offset.

            beamobj.EndPointOffset = new Offset(); //Gets or sets the beam's end point offset. 

            beamobj.Material.MaterialString = "IS2062";

            beamobj.Class = "3";

            //Inserts the beam into the model database. All the attributes/characteristics must be set. 
            if (beamobj.Insert())
            {
                modelobj.CommitChanges();
            }

            allModelObject.Add(cbx_ModelType.Text, beamobj);
        }


        private void insertHollowPipe()
        {
            //accepting start and end point of I-beam from user
            Point startPoint = pickerobj.PickPoint("Pick start point of Hollow-pipe");
            Point endPoint = pickerobj.PickPoint("Pick end point of Hollow-pipe");

            //To create beam,create object of a beam class
            //default constructor:  Initializes a new instance of the Beam class. The start and end points are in the origin.
            Beam beamobj = new Beam(startPoint, endPoint);

            //Initialise non static characteristics of Beam class to create it

            beamobj.Profile.ProfileString = "CFCHS200*10"; //type of beam profile

            beamobj.Name = txtBox_PartName.Text; //give name to part as per users provision

            beamobj.Finish = "PAINT";  //Gets or sets the finish of the part. 

            beamobj.StartPointOffset = new Offset(); //Gets or sets the beam's start point offset.

            beamobj.EndPointOffset = new Offset(); //Gets or sets the beam's end point offset. 

            beamobj.Material.MaterialString = "S355J2H";

            beamobj.Class = "2";

            //Inserts the beam into the model database. All the attributes/characteristics must be set. 
            if (beamobj.Insert())
            {
                modelobj.CommitChanges();
            }

            allModelObject.Add(cbx_ModelType.Text, beamobj);
        }


        private void insertWeldedBoxProfileColumn()
        {
            //accepting start and end point of I-beam from user
            Point startPoint = pickerobj.PickPoint("Pick start point of column");
            Point endPoint = new Point();
            endPoint.X = startPoint.X;
            endPoint.Y = startPoint.Y;
            endPoint.Z = 5000.0D;


            //To create beam,create object of a beam class
            //default constructor:  Initializes a new instance of the Beam class. The start and end points are in the origin.
            Beam beamobj = new Beam(startPoint, endPoint);

            //Initialise non static characteristics of Beam class to create it

            beamobj.Profile.ProfileString = "HK300-10-15*200-25"; //type of beam profile

            beamobj.Name = txtBox_PartName.Text; //give name to part as per users provision

            beamobj.Finish = "PAINT";  //Gets or sets the finish of the part. 

            beamobj.StartPointOffset = new Offset(); //Gets or sets the beam's start point offset.

            beamobj.EndPointOffset = new Offset(); //Gets or sets the beam's end point offset. 

            beamobj.Material.MaterialString = "IS2062s";

            beamobj.Class = "5";

            //setting column parameters
            //Position positionobj = new Position();
            beamobj.Position.Plane = Position.PlaneEnum.MIDDLE;
            beamobj.Position.Rotation = Position.RotationEnum.FRONT;
            beamobj.Position.Depth = Position.DepthEnum.MIDDLE;


            //Inserts the beam into the model database. All the attributes/characteristics must be set. 
            if (beamobj.Insert())
            {
                modelobj.CommitChanges();
            }

            allModelObject.Add(cbx_ModelType.Text, beamobj);
            //MessageBox.Show(string.Format("string is : {0}", beamobj));

        }

        private void insertPolyBeamLAngle()
        {
            ContourPoint point = new ContourPoint(new Point(pickerobj.PickPoint("Pick first point of column")), null);
            ContourPoint point2 = new ContourPoint(new Point(pickerobj.PickPoint("Pick second point of column")), null);
            ContourPoint point3 = new ContourPoint(new Point(pickerobj.PickPoint("Pick third point of column")), null);

            PolyBeam polyBeamobj = new PolyBeam();

            polyBeamobj.AddContourPoint(point);
            polyBeamobj.AddContourPoint(point2);
            polyBeamobj.AddContourPoint(point3);

            polyBeamobj.Profile.ProfileString = "BLL100*100*5";
            polyBeamobj.Name = txtBox_PartName.Text;
            polyBeamobj.Material.MaterialString = "S355J2H";
            polyBeamobj.Finish = "PAINT";
            polyBeamobj.Class = "13";

            if(polyBeamobj.Insert())
            {
                modelobj.CommitChanges();
            }

            allModelObject.Add(cbx_ModelType.Text, polyBeamobj);

        }


        private void insertContourPlate()
        {
            ContourPoint point = new ContourPoint(new Point(pickerobj.PickPoint("Pick first point of column")), null);
            ContourPoint point2 = new ContourPoint(new Point(pickerobj.PickPoint("Pick second point of column")), null);
            ContourPoint point3 = new ContourPoint(new Point(pickerobj.PickPoint("Pick third point of column")), null);
            ContourPoint point4 = new ContourPoint(new Point(pickerobj.PickPoint("Pick third point of column")), null);

            ContourPlate countorplateobj = new ContourPlate();

            countorplateobj.AddContourPoint(point);
            countorplateobj.AddContourPoint(point2);
            countorplateobj.AddContourPoint(point3);
            countorplateobj.AddContourPoint(point4);

            countorplateobj.Profile.ProfileString = "PL50";
            countorplateobj.Name = txtBox_PartName.Text;
            countorplateobj.Material.MaterialString = "IS2062";
            countorplateobj.Finish = "PAINT";
            countorplateobj.Class = "11";

            if (countorplateobj.Insert())
            {
                modelobj.CommitChanges();
            }

            allModelObject.Add(cbx_ModelType.Text,countorplateobj);
        }

        //private void showSelectedPartOnly()
        //{
        //    //string sTemp = cbx_ModelType.Text;

        //    //List<string> hideItemList = new List<string>();

        //    //foreach(string item in cbx_ModelType.Items)
        //    //{
        //    //    if(txtBox_PartName.Text != sTemp)
        //    //    {
        //    //        hideItemList.Add(item);
        //    //    }
        //    //}

        //    Operation.ShowOnlySelected(Operation.UnselectedModeEnum.Hidden);

        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_ModelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Show_Part_Click(object sender, EventArgs e)
        {
            ArrayList objectsToSelect = new ArrayList();

            Tekla.Structures.Model.UI.ModelObjectSelector modelobjselectorobj = new Tekla.Structures.Model.UI.ModelObjectSelector();

            foreach (string partType in allModelObject.Keys)
            {
                if (partType == cbx_ModelType.Text)
                {
                    objectsToSelect.Add(allModelObject[partType]);
                    modelobjselectorobj.Select(objectsToSelect);
                }

            }
            
            Operation.ShowOnlySelected(Operation.UnselectedModeEnum.Hidden);

            modelobj.CommitChanges();
        }
    }
}
