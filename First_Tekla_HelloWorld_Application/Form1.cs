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
using Tekla.Structures.Model.Operations;


namespace First_Tekla_HelloWorld_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a model instance and chekc connection status
            Model mobj = new Model();
            if(!(mobj.GetConnectionStatus()))
            {
                MessageBox.Show("Tekla structures not connected");
                return;
            }

            //Get model info and send a "Hello World" message to the message box
            ModelInfo miobj = mobj.GetInfo();
            String name = miobj.ModelName;

            MessageBox.Show(string.Format("Hello World! Your current model is named : {0}", name));

            //Say hello world message to the tekla structures command prompt
            Operation.DisplayPrompt(string.Format("Hello World! Your current model is named : {0}", name));

        }
    }
}
