using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HeroesCameraEditor
{
    public partial class CameraEditor : Form
    {
        static int SwitchEnd(int a)
        {
            byte[] b = BitConverter.GetBytes(a);
            byte[] c = { b[3], b[2], b[1], b[0] };
            return BitConverter.ToInt32(c, 0);
        }
        static uint SwitchEnd(uint a)
        {
            byte[] b = BitConverter.GetBytes(a);
            byte[] c = { b[3], b[2], b[1], b[0] };
            return BitConverter.ToUInt32(c, 0);
        }
        static float SwitchEnd(float a)
        {
            byte[] b = BitConverter.GetBytes(a);
            byte[] c = { b[3], b[2], b[1], b[0] };
            return BitConverter.ToSingle(c, 0);
        }

        public CameraEditor()
        {
            InitializeComponent();
            numericUpDown1.Maximum = Decimal.MaxValue;
            numericUpDown2.Maximum = Decimal.MaxValue;
            numericUpDown3.Maximum = Decimal.MaxValue;
            numericUpDown4.Maximum = Decimal.MaxValue;
            numericUpDown5.Maximum = Decimal.MaxValue;
            numericUpDown6.Maximum = Decimal.MaxValue;
            numericUpDown7.Maximum = Decimal.MaxValue;
            numericUpDown8.Maximum = Decimal.MaxValue;
            numericUpDown9.Maximum = Decimal.MaxValue;
            numericUpDown10.Maximum = Decimal.MaxValue;
            numericUpDown11.Maximum = Decimal.MaxValue;
            numericUpDown12.Maximum = Decimal.MaxValue;
            numericUpDown13.Maximum = Decimal.MaxValue;
            numericUpDown14.Maximum = Decimal.MaxValue;
            numericUpDown15.Maximum = Decimal.MaxValue;
            numericUpDown16.Maximum = Decimal.MaxValue;
            numericUpDown17.Maximum = Decimal.MaxValue;
            numericUpDown18.Maximum = Decimal.MaxValue;
            numericUpDown19.Maximum = Decimal.MaxValue;
            numericUpDown20.Maximum = Decimal.MaxValue;
            numericUpDown21.Maximum = Decimal.MaxValue;
            numericUpDown22.Maximum = Decimal.MaxValue;
            numericUpDown23.Maximum = Decimal.MaxValue;
            numericUpDown24.Maximum = Decimal.MaxValue;
            numericUpDown25.Maximum = Decimal.MaxValue;
            numericUpDown26.Maximum = Decimal.MaxValue;
            numericUpDown27.Maximum = Decimal.MaxValue;
            numericUpDown28.Maximum = Decimal.MaxValue;
            numericUpDown29.Maximum = Decimal.MaxValue;
            numericUpDown30.Maximum = Decimal.MaxValue;
            numericUpDown31.Maximum = Decimal.MaxValue;
            numericUpDown32.Maximum = Decimal.MaxValue;
            numericUpDown33.Maximum = Decimal.MaxValue;
            numericUpDown34.Maximum = Decimal.MaxValue;
            numericUpDown35.Maximum = Decimal.MaxValue;
            numericUpDown36.Maximum = Decimal.MaxValue;
            numericUpDown37.Maximum = Decimal.MaxValue;
            numericUpDown38.Maximum = Decimal.MaxValue;
            numericUpDown39.Maximum = Decimal.MaxValue;

            numericUpDown1.Minimum = Decimal.MinValue;
            numericUpDown2.Minimum = Decimal.MinValue;
            numericUpDown3.Minimum = Decimal.MinValue;
            numericUpDown4.Minimum = Decimal.MinValue;
            numericUpDown5.Minimum = Decimal.MinValue;
            numericUpDown6.Minimum = Decimal.MinValue;
            numericUpDown7.Minimum = Decimal.MinValue;
            numericUpDown8.Minimum = Decimal.MinValue;
            numericUpDown9.Minimum = Decimal.MinValue;
            numericUpDown10.Minimum = Decimal.MinValue;
            numericUpDown11.Minimum = Decimal.MinValue;
            numericUpDown12.Minimum = Decimal.MinValue;
            numericUpDown13.Minimum = Decimal.MinValue;
            numericUpDown14.Minimum = Decimal.MinValue;
            numericUpDown15.Minimum = Decimal.MinValue;
            numericUpDown16.Minimum = Decimal.MinValue;
            numericUpDown17.Minimum = Decimal.MinValue;
            numericUpDown18.Minimum = Decimal.MinValue;
            numericUpDown19.Minimum = Decimal.MinValue;
            numericUpDown20.Minimum = Decimal.MinValue;
            numericUpDown21.Minimum = Decimal.MinValue;
            numericUpDown22.Minimum = Decimal.MinValue;
            numericUpDown23.Minimum = Decimal.MinValue;
            numericUpDown24.Minimum = Decimal.MinValue;
            numericUpDown25.Minimum = Decimal.MinValue;
            numericUpDown26.Minimum = Decimal.MinValue;
            numericUpDown27.Minimum = Decimal.MinValue;
            numericUpDown28.Minimum = Decimal.MinValue;
            numericUpDown29.Minimum = Decimal.MinValue;
            numericUpDown30.Minimum = Decimal.MinValue;
            numericUpDown31.Minimum = Decimal.MinValue;
            numericUpDown32.Minimum = Decimal.MinValue;
            numericUpDown33.Minimum = Decimal.MinValue;
            numericUpDown34.Minimum = Decimal.MinValue;
            numericUpDown35.Minimum = Decimal.MinValue;
            numericUpDown36.Minimum = Decimal.MinValue;
            numericUpDown37.Minimum = Decimal.MinValue;
            numericUpDown38.Minimum = Decimal.MinValue;
            numericUpDown39.Minimum = Decimal.MinValue;
        }
        
        public string CameraFile;
        bool ProgramIsChangingStuff;
        int CurrentlySelectedCamera = -1;

        public class CameraEntry
        {
            public int Integer1;
            public int Integer2;
            public int Integer3;
            public int Integer4;
            public int Integer5;
            public float FloatX6;
            public float FloatY7;
            public float FloatZ8;
            public int Integer9;
            public int Integer10;
            public int Integer11;
            public float FloatX12;
            public float FloatY13;
            public float FloatZ14;
            public float FloatX15;
            public float FloatY16;
            public float FloatZ17;
            public int Integer18;
            public int Integer19;
            public int Integer20;
            public float FloatX21;
            public float FloatY22;
            public float FloatZ23;
            public float FloatX24;
            public float FloatY25;
            public float FloatZ26;
            public float FloatX27;
            public float FloatY28;
            public float FloatZ29;
            public int Integer30;
            public int Integer31;
            public float FloatX32;
            public float FloatY33;
            public float FloatZ34;
            public float FloatW35;
            public int Integer36;
            public int Integer37;
            public int Integer38;
            public int Integer39;
        }

        public List<CameraEntry> CameraStream = new List<CameraEntry>();
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraFile = null;
            CameraStream.Clear();
            ListBoxCameras.Items.Clear();
            LabelCameraCount.Text = "0 cameras";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenCamera = new OpenFileDialog()
            {
                Filter = "Binary Files|*.bin",
                FileName = CameraFile
            };
            if (OpenCamera.ShowDialog() == DialogResult.OK)
            {
                CameraFile = OpenCamera.FileName;
                LoadCAMfile();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CameraFile != null)
                CameraEditorSave();
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveCamera = new SaveFileDialog()
            {
                Filter = "Binary Files|*.bin",
                FileName = CameraFile
            };
            if (SaveCamera.ShowDialog() == DialogResult.OK)
            {
                CameraFile = SaveCamera.FileName;
                CameraEditorSave();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Can't believe you actually clicked that. Was it by accident? Well anyway, this program was made by igorseabra4, if you wanna talk to me search for me in Sonic Retro or whatever and you know the rest. This is a preview.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadCAMfile()
        {
            CameraStream.Clear();
            ListBoxCameras.Items.Clear();
            
            BinaryReader CameraReader = new BinaryReader(new FileStream(CameraFile, FileMode.Open));

            CameraReader.BaseStream.Position = 0;

            while (CameraReader.BaseStream.Position != CameraReader.BaseStream.Length)
            {
                CameraEntry TempCam = new CameraEntry();
                TempCam.Integer1 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer2 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer3 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer4 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer5 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.FloatX6 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY7 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ8 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.Integer9 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer10 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer11 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.FloatX12 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY13 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ14 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatX15 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY16 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ17 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.Integer18 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer19 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer20 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.FloatX21 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY22 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ23 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatX24 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY25 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ26 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatX27 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY28 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ29 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.Integer30 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer31 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.FloatX32 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatY33 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatZ34 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.FloatW35 = SwitchEnd(CameraReader.ReadSingle());
                TempCam.Integer36 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer37 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer38 = SwitchEnd(CameraReader.ReadInt32());
                TempCam.Integer39 = SwitchEnd(CameraReader.ReadInt32());

                if (TempCam.Integer1 == 0 & TempCam.Integer2 == 0 & TempCam.Integer3 == 0 & TempCam.Integer4 == 0 & TempCam.Integer5 == 0)
                    continue;

                CameraStream.Add(TempCam);
            }

            CameraReader.Close();

            LabelCameraCount.Text = CameraStream.Count().ToString() + " cameras";
            PopulateListBox();

            ListBoxCameras.SelectedIndex = -1;
        }

        byte[] ArraySwitch(int a)
        {
            byte[] b = BitConverter.GetBytes(a);
            b = new byte[] { b[3], b[2], b[1], b[0] };
            return b;
        }
        byte[] ArraySwitch(float a)
        {
            byte[] b = BitConverter.GetBytes(a);
            b = new byte[] { b[3], b[2], b[1], b[0] };
            return b;
        }

        private void CameraEditorSave()
        {
            BinaryWriter CameraWriter = new BinaryWriter(new FileStream(CameraFile, FileMode.Create));

            CameraWriter.BaseStream.SetLength(0x13800);
            CameraWriter.BaseStream.Position = 0;

            foreach (CameraEntry i in CameraStream)
            {
                if (i.Integer1 == 0 & i.Integer2 == 0 & i.Integer3 == 0 & i.Integer4 == 0 & i.Integer5 == 0)
                    continue;

                CameraWriter.Write(ArraySwitch(i.Integer1));
                CameraWriter.Write(ArraySwitch(i.Integer2));
                CameraWriter.Write(ArraySwitch(i.Integer3));
                CameraWriter.Write(ArraySwitch(i.Integer4));
                CameraWriter.Write(ArraySwitch(i.Integer5));
                CameraWriter.Write(ArraySwitch(i.FloatX6));
                CameraWriter.Write(ArraySwitch(i.FloatY7));
                CameraWriter.Write(ArraySwitch(i.FloatZ8));
                CameraWriter.Write(ArraySwitch(i.Integer9));
                CameraWriter.Write(ArraySwitch(i.Integer10));
                CameraWriter.Write(ArraySwitch(i.Integer11));
                CameraWriter.Write(ArraySwitch(i.FloatX12));
                CameraWriter.Write(ArraySwitch(i.FloatY13));
                CameraWriter.Write(ArraySwitch(i.FloatZ14));
                CameraWriter.Write(ArraySwitch(i.FloatX15));
                CameraWriter.Write(ArraySwitch(i.FloatY16));
                CameraWriter.Write(ArraySwitch(i.FloatZ17));
                CameraWriter.Write(ArraySwitch(i.Integer18));
                CameraWriter.Write(ArraySwitch(i.Integer19));
                CameraWriter.Write(ArraySwitch(i.Integer20));
                CameraWriter.Write(ArraySwitch(i.FloatX21));
                CameraWriter.Write(ArraySwitch(i.FloatY22));
                CameraWriter.Write(ArraySwitch(i.FloatZ23));
                CameraWriter.Write(ArraySwitch(i.FloatX24));
                CameraWriter.Write(ArraySwitch(i.FloatY25));
                CameraWriter.Write(ArraySwitch(i.FloatZ26));
                CameraWriter.Write(ArraySwitch(i.FloatX27));
                CameraWriter.Write(ArraySwitch(i.FloatY28));
                CameraWriter.Write(ArraySwitch(i.FloatZ29));
                CameraWriter.Write(ArraySwitch(i.Integer30));
                CameraWriter.Write(ArraySwitch(i.Integer31));
                CameraWriter.Write(ArraySwitch(i.FloatX32));
                CameraWriter.Write(ArraySwitch(i.FloatY33));
                CameraWriter.Write(ArraySwitch(i.FloatZ34));
                CameraWriter.Write(ArraySwitch(i.FloatW35));
                CameraWriter.Write(ArraySwitch(i.Integer36));
                CameraWriter.Write(ArraySwitch(i.Integer37));
                CameraWriter.Write(ArraySwitch(i.Integer38));
                CameraWriter.Write(ArraySwitch(i.Integer39));
            }

            if ( CameraWriter.BaseStream.Length != 0x13800)
            CameraWriter.BaseStream.SetLength(0x13800);

            CameraWriter.Close();
        }

        private void PopulateListBox()
        {
            ProgramIsChangingStuff = true;
            ListBoxCameras.Items.Clear();

            for (int i = 0; i < CameraStream.Count(); i++)
                ListBoxCameras.Items.Add("Camera " + (i + 1).ToString());
            ProgramIsChangingStuff = false;
        }

        private void ListBoxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramIsChangingStuff = true;

            CurrentlySelectedCamera = ListBoxCameras.SelectedIndex;

            if (CurrentlySelectedCamera != -1)
            {
                numericUpDown1.Value = CameraStream[CurrentlySelectedCamera].Integer1;
                numericUpDown2.Value = CameraStream[CurrentlySelectedCamera].Integer2;
                numericUpDown3.Value = CameraStream[CurrentlySelectedCamera].Integer3;
                numericUpDown4.Value = CameraStream[CurrentlySelectedCamera].Integer4;
                numericUpDown5.Value = CameraStream[CurrentlySelectedCamera].Integer5;
                numericUpDown6.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX6;
                numericUpDown7.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY7;
                numericUpDown8.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ8;
                numericUpDown9.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer9 * (360f / 65536f));
                numericUpDown10.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer10 * (360f / 65536f));
                numericUpDown11.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer11 * (360f / 65536f));
                numericUpDown12.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX12;
                numericUpDown13.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY13;
                numericUpDown14.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ14;
                numericUpDown15.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX15;
                numericUpDown16.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY16;
                numericUpDown17.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ17;
                numericUpDown18.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer18 * (360f / 65536f));
                numericUpDown19.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer19 * (360f / 65536f));
                numericUpDown20.Value = (decimal)(CameraStream[CurrentlySelectedCamera].Integer20 * (360f / 65536f));
                numericUpDown21.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX21;
                numericUpDown22.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY22;
                numericUpDown23.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ23;
                numericUpDown24.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX24;
                numericUpDown25.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY25;
                numericUpDown26.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ26;
                numericUpDown27.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX27;
                numericUpDown28.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY28;
                numericUpDown29.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ29;
                numericUpDown30.Value = CameraStream[CurrentlySelectedCamera].Integer30;
                numericUpDown31.Value = CameraStream[CurrentlySelectedCamera].Integer31;
                numericUpDown32.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatX32;
                numericUpDown33.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatY33;
                numericUpDown34.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatZ34;
                numericUpDown35.Value = (decimal)CameraStream[CurrentlySelectedCamera].FloatW35;
                numericUpDown36.Value = CameraStream[CurrentlySelectedCamera].Integer36;
                numericUpDown37.Value = CameraStream[CurrentlySelectedCamera].Integer37;
                numericUpDown38.Value = CameraStream[CurrentlySelectedCamera].Integer38;
                numericUpDown39.Value = CameraStream[CurrentlySelectedCamera].Integer39;

                if (buttonDelete.Enabled == false)
                    buttonDelete.Enabled = true;
            }

            LabelCameraCount.Text = "Camera " + (CurrentlySelectedCamera + 1).ToString() + "/" + CameraStream.Count().ToString();

            ProgramIsChangingStuff = false;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff & CurrentlySelectedCamera != -1)
            {
                CameraStream[CurrentlySelectedCamera].Integer1 = (int)numericUpDown1.Value;
                CameraStream[CurrentlySelectedCamera].Integer2 = (int)numericUpDown2.Value;
                CameraStream[CurrentlySelectedCamera].Integer3 = (int)numericUpDown3.Value;
                CameraStream[CurrentlySelectedCamera].Integer4 = (int)numericUpDown4.Value;
                CameraStream[CurrentlySelectedCamera].Integer5 = (int)numericUpDown5.Value;
                CameraStream[CurrentlySelectedCamera].FloatX6 = (float)numericUpDown6.Value;
                CameraStream[CurrentlySelectedCamera].FloatY7 = (float)numericUpDown7.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ8 = (float)numericUpDown8.Value;
                CameraStream[CurrentlySelectedCamera].Integer9 = (int)((float)numericUpDown9.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].Integer10 = (int)((float)numericUpDown10.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].Integer11 = (int)((float)numericUpDown11.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].FloatX12 = (float)numericUpDown12.Value;
                CameraStream[CurrentlySelectedCamera].FloatY13 = (float)numericUpDown13.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ14 = (float)numericUpDown14.Value;
                CameraStream[CurrentlySelectedCamera].FloatX15 = (float)numericUpDown15.Value;
                CameraStream[CurrentlySelectedCamera].FloatY16 = (float)numericUpDown16.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ17 = (float)numericUpDown17.Value;
                CameraStream[CurrentlySelectedCamera].Integer18 = (int)((float)numericUpDown18.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].Integer19 = (int)((float)numericUpDown19.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].Integer20 = (int)((float)numericUpDown20.Value * (65536f / 360f));
                CameraStream[CurrentlySelectedCamera].FloatX21 = (float)numericUpDown21.Value;
                CameraStream[CurrentlySelectedCamera].FloatY22 = (float)numericUpDown22.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ23 = (float)numericUpDown23.Value;
                CameraStream[CurrentlySelectedCamera].FloatX24 = (float)numericUpDown24.Value;
                CameraStream[CurrentlySelectedCamera].FloatY25 = (float)numericUpDown25.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ26 = (float)numericUpDown26.Value;
                CameraStream[CurrentlySelectedCamera].FloatX27 = (float)numericUpDown27.Value;
                CameraStream[CurrentlySelectedCamera].FloatY28 = (float)numericUpDown28.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ29 = (float)numericUpDown29.Value;
                CameraStream[CurrentlySelectedCamera].Integer30 = (int)numericUpDown30.Value;
                CameraStream[CurrentlySelectedCamera].Integer31 = (int)numericUpDown31.Value;
                CameraStream[CurrentlySelectedCamera].FloatX32 = (float)numericUpDown32.Value;
                CameraStream[CurrentlySelectedCamera].FloatY33 = (float)numericUpDown33.Value;
                CameraStream[CurrentlySelectedCamera].FloatZ34 = (float)numericUpDown34.Value;
                CameraStream[CurrentlySelectedCamera].FloatW35 = (float)numericUpDown35.Value;
                CameraStream[CurrentlySelectedCamera].Integer36 = (int)numericUpDown36.Value;
                CameraStream[CurrentlySelectedCamera].Integer37 = (int)numericUpDown37.Value;
                CameraStream[CurrentlySelectedCamera].Integer38 = (int)numericUpDown38.Value;
                CameraStream[CurrentlySelectedCamera].Integer39 = (int)numericUpDown39.Value;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CameraStream.Count == 512)
            {
                MessageBox.Show("Maximum amount of cameras reached");
                return;
            }

            CameraStream.Add(new CameraEntry());
            ListBoxCameras.Items.Add("Camera " + (CameraStream.Count).ToString());
            ListBoxCameras.SelectedIndex = CameraStream.Count - 1;
            LabelCameraCount.Text = "Camera " + (CurrentlySelectedCamera + 1).ToString() + "/" + CameraStream.Count().ToString();
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Save = CurrentlySelectedCamera;

            if (CurrentlySelectedCamera != -1)
            {
                CameraStream.RemoveAt(CurrentlySelectedCamera);
                ListBoxCameras.Items.RemoveAt(CurrentlySelectedCamera);

                for (int i = 0; i < ListBoxCameras.Items.Count; i++)
                    ListBoxCameras.Items[i] = "Camera " + (i + 1).ToString();

                if (CameraStream.Count > 0)
                    LabelCameraCount.Text = "Camera " + (CurrentlySelectedCamera + 1).ToString() + "/" + CameraStream.Count().ToString();
                else
                {
                    LabelCameraCount.Text = "0 cameras";
                    buttonDelete.Enabled = false;
                }

                if (Save < CameraStream.Count)
                    ListBoxCameras.SelectedIndex = Save;
                else
                    ListBoxCameras.SelectedIndex = CameraStream.Count - 1;                
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CameraStream.Clear();
            ListBoxCameras.Items.Clear();

            LabelCameraCount.Text = "0 cameras";
            buttonDelete.Enabled = false;
        }

        IntPtr Camera_X = new IntPtr(0x00A60C30);
        IntPtr Camera_Y = new IntPtr(0x00A60C34);
        IntPtr Camera_Z = new IntPtr(0x00A60C38);

        private void buttonTeleportToTrigger_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                MemManager.Write4bytes(Pointer0X, BitConverter.GetBytes((float)numericUpDown6.Value));
                MemManager.Write4bytes(Pointer0Y, BitConverter.GetBytes((float)numericUpDown7.Value));
                MemManager.Write4bytes(Pointer0Z, BitConverter.GetBytes((float)numericUpDown8.Value));
            }
            else MessageBox.Show("Error writing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void buttonGetTrigger_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                numericUpDown6.Value = (decimal)MemManager.ReadFloat(Pointer0X);
                numericUpDown7.Value = (decimal)MemManager.ReadFloat(Pointer0Y);
                numericUpDown8.Value = (decimal)MemManager.ReadFloat(Pointer0Z);
            }
            else MessageBox.Show("Error reading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGetCamera_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                numericUpDown15.Value = (decimal)MemManager.ReadFloat(Camera_X);
                numericUpDown16.Value = (decimal)MemManager.ReadFloat(Camera_Y);
                numericUpDown17.Value = (decimal)MemManager.ReadFloat(Camera_Z);
            }
            else MessageBox.Show("Error reading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGetA_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                numericUpDown21.Value = (decimal)MemManager.ReadFloat(Pointer0X);
                numericUpDown22.Value = (decimal)MemManager.ReadFloat(Pointer0Y);
                numericUpDown23.Value = (decimal)MemManager.ReadFloat(Pointer0Z);
            }
            else MessageBox.Show("Error reading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGetB_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                numericUpDown24.Value = (decimal)MemManager.ReadFloat(Pointer0X);
                numericUpDown25.Value = (decimal)MemManager.ReadFloat(Pointer0Y);
                numericUpDown26.Value = (decimal)MemManager.ReadFloat(Pointer0Z);
            }
            else MessageBox.Show("Error reading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGetC_Click(object sender, EventArgs e)
        {
            DetermineLeaderPositionPointers();
            if (ProcessIsAttached)
            {
                numericUpDown27.Value = (decimal)MemManager.ReadFloat(Pointer0X);
                numericUpDown28.Value = (decimal)MemManager.ReadFloat(Pointer0Y);
                numericUpDown29.Value = (decimal)MemManager.ReadFloat(Pointer0Z);
            }
            else MessageBox.Show("Error reading data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ProcessIsAttached = false;

        ReadWriteProcess MemManager = new ReadWriteProcess();
        IntPtr Pointer0X;
        IntPtr Pointer0Y;
        IntPtr Pointer0Z;

        public void DetermineLeaderPositionPointers()
        {
            MemManager.TryAttachToProcess("SONIC HEROES(TM)");
            Pointer0X = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x28);
            Pointer0Y = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x2c);
            Pointer0Z = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x30);
        }
    }

    public class ReadWriteProcess
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr OpenProcess(UInt32 dwDesiredAcess, bool bInheritHandle, Int32 dwProcessId);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesRead);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        const int PROCESS_WM_READ = 0x0010;

        //to keep track of it. not used yet.
        private Process targetProcess = null;
        //Used for ReadProcessMemory
        private IntPtr targetProcessHandle = IntPtr.Zero;
        private UInt32 PROCESS_ALL_ACCESS = 0x1f0fff;

        private UInt32 PROCESS_VM_READ = 0x10;
        public bool TryAttachToProcess(string windowCaption)
        {
            Process[] _allProcesses = Process.GetProcesses();
            foreach (Process pp in _allProcesses)
            {
                if (pp.MainWindowTitle.ToLower().Contains(windowCaption.ToLower()))
                {
                    //found it! proceed.
                    return TryAttachToProcess(pp);
                }
            }
            CameraEditor.ProcessIsAttached = false;
            return false;
        }

        public bool TryAttachToProcess(Process proc)
        {
            bool functionReturnValue = false;
            DetachFromProcess();
            //not already attached
            if (targetProcessHandle == IntPtr.Zero)
            {
                targetProcess = proc;
                targetProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, false, targetProcess.Id);
                if (targetProcessHandle == IntPtr.Zero)
                {
                    functionReturnValue = false;
                    CameraEditor.ProcessIsAttached = false;
                }
                else
                {
                    //if we get here, all connected and ready to use ReadProcessMemory()
                    functionReturnValue = true;
                    CameraEditor.ProcessIsAttached = true;
                }
                //already attached
            }
            else
            {
                functionReturnValue = false;
            }
            return functionReturnValue;
        }

        public void DetachFromProcess()
        {
            if (!(targetProcessHandle == IntPtr.Zero))
            {
                targetProcess = null;
                try
                {
                    CloseHandle(targetProcessHandle);
                    targetProcessHandle = IntPtr.Zero;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MemoryManager::DetachFromProcess::CloseHandle error " + Environment.NewLine + ex.Message);
                }
            }
        }

        public float ReadFloat(IntPtr addr)
        {
            byte[] rtnBytes = new byte[4];
            ReadProcessMemory(targetProcessHandle, addr, rtnBytes, 4, 0);
            return BitConverter.ToSingle(rtnBytes, 0);
        }

        public UInt16 ReadUInt16(IntPtr addr)
        {
            byte[] _rtnBytes = new byte[2];
            ReadProcessMemory(targetProcessHandle, addr, _rtnBytes, 2, 0);
            return BitConverter.ToUInt16(_rtnBytes, 0);
        }

        public UInt32 ReadUInt32(IntPtr addr)
        {
            byte[] _rtnBytes = new byte[4];
            ReadProcessMemory(targetProcessHandle, addr, _rtnBytes, 4, 0);
            return BitConverter.ToUInt32(_rtnBytes, 0);
        }

        public byte ReadByte(IntPtr addr)
        {
            byte[] _rtnByte = new byte[1];
            ReadProcessMemory(targetProcessHandle, addr, _rtnByte, 1, 0);
            return _rtnByte[0];
        }

        public void Write4bytes(IntPtr addr, byte[] vll)
        {
            WriteProcessMemory(targetProcessHandle, addr, vll, 4, 0);
        }
    }
}
