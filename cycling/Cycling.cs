using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cycling
{
    public partial class Cycling : Form
    {
        /// <summary>
        /// Store all the global variable here and most oof them are in a get/set method.
        /// </summary>
        #region "varable"

        private static int _MaxHR = 0;

        public int MaxHR
        {
            get
            {
                return _MaxHR;
            }
            set
            {
                _MaxHR = value;
            }
        }

        private static int _MinHR = 0;

        public int MinHR
        {
            get
            {
                return _MinHR;
            }
            set
            {
                _MinHR = value;
            }
        }

        private static double _AverHR = 0;

        public double AverHR
        {
            get
            {
                return _AverHR;
            }
            set
            {
                _AverHR = value;
            }
        }

        private static double _MaxSP = 0.0;

        public double MaxSP
        {
            get
            {
                return _MaxSP;
            }
            set
            {
                _MaxSP = value;
            }
        }

        private static double _MinSP = 0.0;

        public double MinSP
        {
            get
            {
                return _MinSP;
            }
            set
            {
                _MinSP = value;
            }
        }

        private static double _AverSP = 0.0;

        public double AverSP
        {
            get
            {
                return _AverSP;
            }
            set
            {
                _AverSP = value;
            }
        }

        private static double _Distance = 0.0;

        public double Distance
        {
            get
            {
                return _Distance;
            }
            set
            {
                _Distance = value;
            }
        }

        public static int _pedallingIndex;

        public int pedallingIndex
        {
            get
            {
                return _pedallingIndex;
            }
            set
            {
                _pedallingIndex = value;
            }
        }

        private static int _MaxpedallingIndex = 0;

        public int MaxpedallingIndex
        {
            get
            {
                return _MaxpedallingIndex;
            }
            set
            {
                _MaxpedallingIndex = value;
            }
        }

        private static int _MinpedallingIndex = 0;

        public int MinpedallingIndex
        {
            get
            {
                return _MinpedallingIndex;
            }
            set
            {
                _MinpedallingIndex = value;
            }
        }

        private static double _AverpedallingIndex = 0.0;

        public double AverpedallingIndex
        {
            get
            {
                return _AverpedallingIndex;
            }
            set
            {
                _AverpedallingIndex = value;
            }
        }

        private static double _MaxPO = 0.0;

        public double MaxPO
        {
            get
            {
                return _MaxPO;
            }
            set
            {
                _MaxPO = value;
            }
        }

        private static double _MinPO = 0.0;

        public double MinPO
        {
            get
            {
                return _MinPO;
            }
            set
            {
                _MinPO = value;
            }
        }

        private static double _AverPO = 0.0;

        public double AverPO
        {
            get
            {
                return _AverPO;
            }
            set
            {
                _AverPO = value;
            }
        }

        private static double _MaxAL = 0.0;

        public double MaxAL
        {
            get
            {
                return _MaxAL;
            }
            set
            {
                _MaxAL = value;
            }
        }

        private static double _MinAL = 0.0;

        public double MinAL
        {
            get
            {
                return _MinAL;
            }
            set
            {
                _MinAL = value;
            }
        }

        private static double _AverAL = 0.0;

        public double AverAL
        {
            get
            {
                return _AverAL;
            }
            set
            {
                _AverAL = value;
            }
        }

        private static int _PowerB = 0;

        public int PowerB
        {
            get
            {
                return _PowerB;
            }
            set
            {
                _PowerB = value;
            }
        }

        private static int _MaxLeftPower = 0;

        public int MaxLeftPower
        {
            get
            {
                return _MaxLeftPower;
            }
            set
            {
                _MaxLeftPower = value;
            }
        }

        private static int _MinLeftPower = 0;

        public int MinLeftPower
        {
            get
            {
                return _MinLeftPower;
            }
            set
            {
                _MinLeftPower = value;
            }
        }

        private static double _AverLeftPower = 0.0;

        public double AverLeftPower
        {
            get
            {
                return _AverLeftPower;
            }
            set
            {
                _AverLeftPower = value;
            }
        }

        private static int _MaxLeftIndex = 0;

        public int MaxLeftIndex
        {
            get
            {
                return _MaxLeftIndex;
            }
            set
            {
                _MaxLeftIndex = value;
            }
        }

        private static int _MinLeftIndex = 0;

        public int MinLeftIndex
        {
            get
            {
                return _MinLeftIndex;
            }
            set
            {
                _MinLeftIndex = value;
            }
        }

        private static double _AverLeftIndex = 0.0;

        public double AverLeftIndex
        {
            get
            {
                return _AverLeftIndex;
            }
            set
            {
                _AverLeftIndex = value;
            }
        }

        private static int _MaxrRightPower = 0;

        public int MaxrRightPower
        {
            get
            {
                return _MaxrRightPower;
            }
            set
            {
                _MaxrRightPower = value;
            }
        }

        private static int _MinRightPower = 0;

        public int MinRightPower
        {
            get
            {
                return _MinRightPower;
            }
            set
            {
                _MinRightPower = value;
            }
        }

        private static double _AverRightPower = 0.0;

        public double AverRightPower
        {
            get
            {
                return _AverRightPower;
            }
            set
            {
                _AverRightPower = value;
            }
        }

        private static int _MaxRightIndex = 0;

        public int MaxRightIndex
        {
            get
            {
                return _MaxRightIndex;
            }
            set
            {
                _MaxRightIndex = value;
            }
        }

        private static int _MinRightIndex = 0;

        public int MinRightIndex
        {
            get
            {
                return _MinRightIndex;
            }
            set
            {
                _MinRightIndex = value;
            }
        }

        private static double _AverRightIndex = 0.0;

        public double AverRightIndex
        {
            get
            {
                return _AverRightIndex;
            }
            set
            {
                _AverRightIndex = value;
            }
        }


        private static bool _KM = true;

        public bool KM 
        {
            get
            {
                return _KM;
            }
            set
            {
                _KM = value;
            }
        }

        private static bool _Open = false;

        public bool Open
        {
            get
            {
                return _Open;
            }
            set
            {
                _Open = value;
            }
        }

        public double Drate = 0.6213;

        public double mile1 = 0.0;

        #endregion
        public Cycling()
        {
            InitializeComponent();

        }

        /// <summary>
        ///  Click to open .hrm data file then store the spilted line of data into a dataGridView 
        ///  and send all the data to other summary methods to process. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void openToolStripMenuItem1_Click(object sender, EventArgs e)    //open records method
        {
            int count = 0;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();     //set up the file dialog
            openFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Hrm Documents (*.hrm)|*.hrm|All Files (*.*)|*.*";   //read .hrm files
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //start read data
            {
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);     //read files

                String line = file.ReadLine();      //read lanes 
                if (line == "[HRData]")
                {   
                    while ((line = file.ReadLine()) != null)    //add records to every datagridview
                    {   
                        String[] splitline = line.Split('\t');

                        double DoubleSpeed = int.Parse(splitline[1]);

                        DoubleSpeed = DoubleSpeed / 10;

                        if (count == 0)
                        {
                            Initial(int.Parse(splitline[0]), DoubleSpeed, int.Parse(splitline[2]), int.Parse(splitline[3]), int.Parse(splitline[4]), int.Parse(splitline[5]));
                        }

                        DataGridViewRow dgvr = new DataGridViewRow();
                        foreach (DataGridViewColumn c in this.dataGridView1.Columns)
                        {
                            dgvr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                        }
                        dgvr.Cells[0].Value = count;
                        dgvr.Cells[1].Value = splitline[0];
                        dgvr.Cells[2].Value = DoubleSpeed;
                        dgvr.Cells[3].Value = splitline[2];
                        dgvr.Cells[4].Value = splitline[3];
                        dgvr.Cells[5].Value = splitline[4];
                        dgvr.Cells[6].Value = splitline[5];

                        this.dataGridView1.Rows.Add(dgvr); 

                        count++;    //time order

                        HeartRate(int.Parse(splitline[0]), count);  //pass value to method HearRate to process
                        Speed(DoubleSpeed, count); // pass value to method Speed to process
                        Altitude(int.Parse(splitline[3]), count); // pass value to method Power to process
                        Power(int.Parse(splitline[4]), count); // pass value to method Power to process
                        PowerBalanceCalculation(int.Parse(splitline[5]), count);
                        Open = true;
                    }
                }

                else
                {
                    MessageBox.Show("error");   //error message
                }
            }
        }

        /// <summary>
        /// set up the Initial value as the first line record
        /// </summary>
        /// <param name="HR"></param>
        /// <param name="SP"></param>
        /// <param name="CA"></param>
        /// <param name="AL"></param>
        /// <param name="PO"></param>
        /// <param name="PB"></param>
        public void Initial(int HR, double SP, int CA, int AL, int PO, int PB) 
        {
            MaxHR = HR;
            MinHR = HR;
            MaxSP = SP;
            MinSP = SP;
            MaxPO = PO;
            MinPO = PO;
            MaxAL = AL;
            MinAL = AL;
            PowerB = PB;
        }
        /// <summary>
        /// the methods are used to process these datas, calculate the max, min and average of 
        /// all the datas on the file
        /// </summary>
        public void HeartRate (int HR, int count)   //process the summary about the HeartRate
        {   
                //Max HR
            if (HR >= MaxHR)
            {
                MaxHR = HR;
                this.label2.Text = "Max:              "+ MaxHR.ToString();
            }
    
                //Min HR
            if (HR <= MinHR)
            {
                MinHR = HR;
                this.label3.Text = "Min:                " + MinHR.ToString();
            }

                //Average HR
            if (count == 1)
            {
                AverHR = (AverHR + HR)/count;
                this.label7.Text = "Average:       " + AverHR.ToString();
            }

            else if (count >= 2)
            {
                AverHR = ((AverHR * (count - 1)) + HR) / count;

                this.label7.Text = "Average:       " + Math.Round(AverHR, 2).ToString(); // make the number clear
            }
        }

        public void Speed(double SP, int count) // process the summary about the Speed
        {
            double mile;    //km in miles
            
            // Max SP
            if (SP > MaxSP)
            {
                MaxSP = SP;
                mile = MaxSP * Drate;

                if (KM == true)
                {
                    this.label9.Text = "Max:              " + MaxSP.ToString();
                }

                else if (KM == false) 
                {
                    this.label9.Text = "Max:              " + Math.Round(mile, 2);
                }
            }

            //Min SP
            if (SP <= MinSP)
            {
                MinSP = SP;
                mile = MaxSP * Drate;

                if (KM == true)
                {
                this.label4.Text = "Min:               " + MinSP.ToString();
                }

                else if (KM == false)
                {
                    this.label14.Text = "Min:               " + Math.Round(mile, 2);
                }
            }

            //Average SP
            if (count == 1)
            {
                AverSP = (AverSP + SP) / count;
                mile = AverSP * Drate;

                if (KM == true)
                {
                    this.label10.Text = "Average:       " + AverSP.ToString();
                }

                else if (KM==false)
                {
                    this.label10.Text = "Average:       "+ Math.Round(mile, 2);
                }
            }

            else if (count >= 2)
            {
                AverSP = ((AverSP * (count - 1)) + SP) / count;
                mile = AverSP * Drate;

                if (KM == true) 
                { 
                    this.label10.Text = "Average:       " + Math.Round(AverSP, 2).ToString();
                }

                else if (KM == false)
                {
                    this.label10.Text = "Average:       " + Math.Round(mile, 2);
                }
            }

            //Distance
            Distance = (Distance * 3600 + SP) / 3600;
            mile1 = Distance * Drate;

            if (KM == true)
            {
                this.label11.Text = "Total:      " + Math.Round(Distance, 2).ToString();
            }
            
            else if (KM == false)
            {
                this.label11.Text = "Total:      " + Math.Round(mile1, 2);
            }

        }

        public void Power(int PO, int count)
        {
            //Max Power
            if (PO>= MaxPO)
            {
                MaxPO = PO;
                this.label13.Text = "Max:              " + MaxPO.ToString();
            }

            //Min Power
            if(PO < MinPO)
            {
                MinPO = PO;
                this.label12.Text = "Min:               " + MinPO.ToString();
            }

            //Average Power
            if (count == 1)
            {
                AverPO = (AverPO + PO) / count;
                this.label14.Text = "Average:       " + AverPO.ToString();
            }

            else if (count >= 2)
            {
                AverPO = ((AverPO * (count - 1)) + PO) / count;

                this.label14.Text = "Average:       " + Math.Round(AverPO, 2).ToString(); // make the number clear
            }
        }

        public void Altitude(int AL, int count)
        {
            //Max Altitude
            if (AL >= MaxAL)
            {
                MaxAL = AL;
                this.label15.Text = "Max:              " + MaxAL.ToString();
            }

            //Min Altitude
            if (AL <= MinAL)
            {
                MinAL = AL;
                this.label17.Text = "Min:               " + MinAL.ToString();
            }

            //Average Altitude
            if (count == 1)
            {
                AverPO = (AverPO + AL) / count;
                this.label16.Text = "Average:       " + AverAL.ToString();
            }

            else if (count >= 2)
            {
                AverAL = ((AverAL * (count - 1)) + AL) / count;

                this.label16.Text = "Average:       " + Math.Round(AverAL, 2).ToString(); // make the number clear
            }
        }
        /// <summary>
        /// The part contain some different calculations. 
        /// First, need to AND the PowerBalance data with 0xff and 0xff00, which is seprate the low nibble and the high one
        /// the 0xff and 0xff00 are present the 0000000011111111 and 1111111100000000 in hexi way, because this c# cant process the binary then change it a little bit
        /// Second, process compare these valuse after the calculation. 
        /// Finally add their into a datagridview and summary them.
        /// </summary>
        /// <param name="PW"></param>
        /// <param name="count"></param>
        public void PowerBalanceCalculation(int PW, int count)
        {
            int powerFromleftLeg = PW & 0xff;

            pedallingIndex = (PW & 0xff00) >> 8;

            leftRightLeg(powerFromleftLeg, count);
            pedalingIndex(pedallingIndex, count);

            DataGridViewRow dgvr2 = new DataGridViewRow();
            foreach (DataGridViewColumn c in this.dataGridView2.Columns)
            {
                dgvr2.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
            }
            dgvr2.Cells[0].Value = count-1;
            dgvr2.Cells[1].Value = PW;
            dgvr2.Cells[2].Value = pedallingIndex;
            dgvr2.Cells[3].Value = powerFromleftLeg;
            dgvr2.Cells[4].Value = 100 - powerFromleftLeg;

            this.dataGridView2.Rows.Add(dgvr2);

        }

        public void pedalingIndex(int pedalingIndex, int count)
        {
            if (count == 1)
            {
                MaxpedallingIndex = MinpedallingIndex = pedalingIndex;
                AverpedallingIndex = pedalingIndex;
                this.label34.Text = MaxpedallingIndex.ToString();
                this.label35.Text = MinpedallingIndex.ToString();
                this.label36.Text = AverpedallingIndex.ToString();
            }

            if (count > 1)
            {
                if (MaxpedallingIndex <= pedalingIndex)
                {
                    MaxpedallingIndex = pedalingIndex;
                    this.label34.Text = MaxpedallingIndex.ToString();
                }

                if (MinpedallingIndex >= pedalingIndex)
                {
                    MinpedallingIndex = pedalingIndex;
                    this.label35.Text = MinpedallingIndex.ToString();
                }

                AverpedallingIndex = (AverpedallingIndex * (count - 1) + pedalingIndex) / count;
                this.label36.Text = Math.Round(AverpedallingIndex, 2).ToString();
            }
        }

        public void leftRightLeg(int powerFromleftLeg, int count)
        {
            if (count <= 1)
            {
                MaxLeftIndex = MinLeftIndex = powerFromleftLeg;

                AverLeftIndex = powerFromleftLeg;

                MaxRightIndex = MinLeftIndex = 100 - powerFromleftLeg;

                AverRightIndex = 100 - powerFromleftLeg;

                this.label27.Text = powerFromleftLeg.ToString();
                this.label28.Text = powerFromleftLeg.ToString();
                this.label29.Text = powerFromleftLeg.ToString();

                this.label30.Text = (100 - powerFromleftLeg).ToString();
                this.label31.Text = (100 - powerFromleftLeg).ToString();
                this.label32.Text = (100 - powerFromleftLeg).ToString();
            }

            else
            {
                if (MaxLeftIndex <= powerFromleftLeg)
                {
                    MaxLeftIndex = powerFromleftLeg;

                    MinRightIndex = 100 - powerFromleftLeg;

                    this.label27.Text = MaxLeftIndex.ToString();

                    this.label31.Text = MinRightIndex.ToString();
                }

                if (MinLeftIndex >= powerFromleftLeg)
                {
                    MinLeftIndex = powerFromleftLeg;

                    MaxRightIndex= 100 - MinLeftIndex;

                    this.label28.Text = MinLeftIndex.ToString();

                    this.label30.Text = MaxRightIndex.ToString();
                }

                AverLeftIndex = ((AverLeftIndex * (count - 1)) + powerFromleftLeg) / count;
                this.label29.Text = Math.Round(AverLeftIndex,2).ToString();

                AverRightIndex = (AverRightIndex * (count - 1) + 100 - powerFromleftLeg) / count;
                this.label32.Text = Math.Round(AverRightIndex, 2).ToString();
            }
        }
        /// <summary>
        /// change the unit from km to mile or mile to km.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kilometerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KM = true;
            this.kilometerToolStripMenuItem.Checked = true;
            this.mileToolStripMenuItem.Checked = false;
            this.label20.Text = "Km/h";
            this.label21.Text = "Km";

            if (Open == true)
            {
                this.label9.Text = "Max:              " + MaxSP.ToString();
                this.label4.Text = "Min:               " + MinSP.ToString();
                this.label10.Text = "Average:       " + Math.Round(AverSP,1).ToString();
                this.label11.Text = "Total:      " + Math.Round(Distance, 2).ToString();
            }
        }

        private void mileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KM = false;
            this.kilometerToolStripMenuItem.Checked = false;
            this.mileToolStripMenuItem.Checked = true;
            this.label20.Text = "Mile/h";
            this.label21.Text = "Mile";

            if (Open == true)
            {
                this.label9.Text = "Max:              " + (MaxSP * Drate).ToString();
                this.label4.Text = "Min:               " + (MinSP * Drate).ToString();
                this.label10.Text = "Average:       " + Math.Round(AverSP * Drate, 1).ToString();
                this.label11.Text = "Total:      " + Math.Round(Distance * Drate, 2);
            }

        }

    }
}
