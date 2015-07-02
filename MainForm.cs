using System;
using System.Drawing;
using System.Windows.Forms;

namespace Enigma
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnRotor1Down;
		private System.Windows.Forms.Label lblRotorD;
		private System.Windows.Forms.Label lblRotorS;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRotor2Down;
		private System.Windows.Forms.Label lblRotor3;
		private System.Windows.Forms.Label lblRotor1;
		private System.Windows.Forms.TextBox txtInit;
		private System.Windows.Forms.Button btnRotor1Up;
		private System.Windows.Forms.TextBox txtFinal;
		private System.Windows.Forms.Button btnRotor2Up;
		private System.Windows.Forms.Label lblRotorM;
		private System.Windows.Forms.Button btnRotor3Up;
		private System.Windows.Forms.Label lblRotor2;
		private System.Windows.Forms.Button btnRotor3Down;
		private System.Windows.Forms.Button btnDespre;
		
		private Rotor rr,rm,rl,reflector;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnDespre = new System.Windows.Forms.Button();
			this.btnRotor3Down = new System.Windows.Forms.Button();
			this.lblRotor2 = new System.Windows.Forms.Label();
			this.btnRotor3Up = new System.Windows.Forms.Button();
			this.lblRotorM = new System.Windows.Forms.Label();
			this.btnRotor2Up = new System.Windows.Forms.Button();
			this.txtFinal = new System.Windows.Forms.TextBox();
			this.btnRotor1Up = new System.Windows.Forms.Button();
			this.txtInit = new System.Windows.Forms.TextBox();
			this.lblRotor1 = new System.Windows.Forms.Label();
			this.lblRotor3 = new System.Windows.Forms.Label();
			this.btnRotor2Down = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblRotorS = new System.Windows.Forms.Label();
			this.lblRotorD = new System.Windows.Forms.Label();
			this.btnRotor1Down = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDespre
			// 
			this.btnDespre.Image = ((System.Drawing.Image)(resources.GetObject("btnDespre.Image")));
			this.btnDespre.Location = new System.Drawing.Point(64, 112);
			this.btnDespre.Name = "btnDespre";
			this.btnDespre.Size = new System.Drawing.Size(40, 32);
			this.btnDespre.TabIndex = 11;
			this.btnDespre.Click += new System.EventHandler(this.BtnDespreClick);
			// 
			// btnRotor3Down
			// 
			this.btnRotor3Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor3Down.Image")));
			this.btnRotor3Down.Location = new System.Drawing.Point(16, 152);
			this.btnRotor3Down.Name = "btnRotor3Down";
			this.btnRotor3Down.Size = new System.Drawing.Size(32, 64);
			this.btnRotor3Down.TabIndex = 13;
			this.btnRotor3Down.Click += new System.EventHandler(this.BtnRotor3DownClick);
			// 
			// lblRotor2
			// 
			this.lblRotor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRotor2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotor2.Location = new System.Drawing.Point(56, 112);
			this.lblRotor2.Name = "lblRotor2";
			this.lblRotor2.Size = new System.Drawing.Size(32, 32);
			this.lblRotor2.TabIndex = 10;
			this.lblRotor2.Text = "A";
			this.lblRotor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRotor3Up
			// 
			this.btnRotor3Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor3Up.Image")));
			this.btnRotor3Up.Location = new System.Drawing.Point(16, 40);
			this.btnRotor3Up.Name = "btnRotor3Up";
			this.btnRotor3Up.Size = new System.Drawing.Size(32, 64);
			this.btnRotor3Up.TabIndex = 12;
			this.btnRotor3Up.Click += new System.EventHandler(this.BtnRotor3UpClick);
			// 
			// lblRotorM
			// 
			this.lblRotorM.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotorM.Location = new System.Drawing.Point(56, 16);
			this.lblRotorM.Name = "lblRotorM";
			this.lblRotorM.Size = new System.Drawing.Size(32, 24);
			this.lblRotorM.TabIndex = 19;
			this.lblRotorM.Text = "II";
			this.lblRotorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRotor2Up
			// 
			this.btnRotor2Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor2Up.Image")));
			this.btnRotor2Up.Location = new System.Drawing.Point(56, 40);
			this.btnRotor2Up.Name = "btnRotor2Up";
			this.btnRotor2Up.Size = new System.Drawing.Size(32, 64);
			this.btnRotor2Up.TabIndex = 14;
			this.btnRotor2Up.Click += new System.EventHandler(this.BtnRotor2UpClick);
			// 
			// txtFinal
			// 
			this.txtFinal.Location = new System.Drawing.Point(16, 152);
			this.txtFinal.Multiline = true;
			this.txtFinal.Name = "txtFinal";
			this.txtFinal.Size = new System.Drawing.Size(432, 88);
			this.txtFinal.TabIndex = 10;
			// 
			// btnRotor1Up
			// 
			this.btnRotor1Up.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor1Up.Image")));
			this.btnRotor1Up.Location = new System.Drawing.Point(96, 40);
			this.btnRotor1Up.Name = "btnRotor1Up";
			this.btnRotor1Up.Size = new System.Drawing.Size(32, 64);
			this.btnRotor1Up.TabIndex = 15;
			this.btnRotor1Up.Click += new System.EventHandler(this.BtnRotor1UpClick);
			// 
			// txtInit
			// 
			this.txtInit.Location = new System.Drawing.Point(16, 16);
			this.txtInit.Multiline = true;
			this.txtInit.Name = "txtInit";
			this.txtInit.Size = new System.Drawing.Size(432, 88);
			this.txtInit.TabIndex = 9;
			this.txtInit.TextChanged += new System.EventHandler(this.TxtInitTextChanged);
			this.txtInit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtInitKeyUp);
			// 
			// lblRotor1
			// 
			this.lblRotor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRotor1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotor1.Location = new System.Drawing.Point(96, 112);
			this.lblRotor1.Name = "lblRotor1";
			this.lblRotor1.Size = new System.Drawing.Size(32, 32);
			this.lblRotor1.TabIndex = 11;
			this.lblRotor1.Text = "A";
			this.lblRotor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRotor3
			// 
			this.lblRotor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRotor3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotor3.Location = new System.Drawing.Point(16, 112);
			this.lblRotor3.Name = "lblRotor3";
			this.lblRotor3.Size = new System.Drawing.Size(32, 32);
			this.lblRotor3.TabIndex = 9;
			this.lblRotor3.Text = "A";
			this.lblRotor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRotor2Down
			// 
			this.btnRotor2Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor2Down.Image")));
			this.btnRotor2Down.Location = new System.Drawing.Point(56, 152);
			this.btnRotor2Down.Name = "btnRotor2Down";
			this.btnRotor2Down.Size = new System.Drawing.Size(32, 64);
			this.btnRotor2Down.TabIndex = 16;
			this.btnRotor2Down.Click += new System.EventHandler(this.BtnRotor2DownClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblRotorS);
			this.groupBox1.Controls.Add(this.lblRotorM);
			this.groupBox1.Controls.Add(this.lblRotorD);
			this.groupBox1.Controls.Add(this.btnRotor1Down);
			this.groupBox1.Controls.Add(this.btnRotor2Down);
			this.groupBox1.Controls.Add(this.btnRotor1Up);
			this.groupBox1.Controls.Add(this.btnRotor2Up);
			this.groupBox1.Controls.Add(this.btnRotor3Down);
			this.groupBox1.Controls.Add(this.btnRotor3Up);
			this.groupBox1.Controls.Add(this.lblRotor1);
			this.groupBox1.Controls.Add(this.lblRotor2);
			this.groupBox1.Controls.Add(this.lblRotor3);
			this.groupBox1.Location = new System.Drawing.Point(456, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 232);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rotors";
			// 
			// lblRotorS
			// 
			this.lblRotorS.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotorS.Location = new System.Drawing.Point(16, 16);
			this.lblRotorS.Name = "lblRotorS";
			this.lblRotorS.Size = new System.Drawing.Size(32, 24);
			this.lblRotorS.TabIndex = 20;
			this.lblRotorS.Text = "I";
			this.lblRotorS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRotorD
			// 
			this.lblRotorD.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotorD.Location = new System.Drawing.Point(96, 16);
			this.lblRotorD.Name = "lblRotorD";
			this.lblRotorD.Size = new System.Drawing.Size(32, 24);
			this.lblRotorD.TabIndex = 18;
			this.lblRotorD.Text = "III";
			this.lblRotorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnRotor1Down
			// 
			this.btnRotor1Down.Image = ((System.Drawing.Image)(resources.GetObject("btnRotor1Down.Image")));
			this.btnRotor1Down.Location = new System.Drawing.Point(96, 152);
			this.btnRotor1Down.Name = "btnRotor1Down";
			this.btnRotor1Down.Size = new System.Drawing.Size(32, 64);
			this.btnRotor1Down.TabIndex = 17;
			this.btnRotor1Down.Click += new System.EventHandler(this.BtnRotor1DownClick);
			// 
			// btnSettings
			// 
			this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
			this.btnSettings.Location = new System.Drawing.Point(16, 112);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(40, 32);
			this.btnSettings.TabIndex = 12;
			this.btnSettings.Click += new System.EventHandler(this.BtnSettingsClick);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(280, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 32);
			this.button1.TabIndex = 14;
			this.button1.Text = "Encrypt / Decrypt";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(618, 256);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.btnDespre);
			this.Controls.Add(this.txtFinal);
			this.Controls.Add(this.txtInit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Enigma";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			rr = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO",lblRotor1,'V');
			rm = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE",lblRotor2,'E');
			rl = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ",lblRotor3,'Q');
			reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT",null,'\0');
			
			//J,Z
			
			rr.SetNextRotor(rm);
			rm.SetNextRotor(rl);
			rl.SetNextRotor(reflector);
			rm.SetPreviousRotor(rr);
			rl.SetPreviousRotor(rm);
			reflector.SetPreviousRotor(rl);
			
		}
		
		void BtnDespreClick(object sender, System.EventArgs e)
		{
			About a = new About();
			a.ShowDialog();
		}
		
		void BtnSettingsClick(object sender, System.EventArgs e)
		{
			Settings s = new Settings(this);
			s.ShowDialog();
		}
		
		void BtnCripteazaClick(object sender, System.EventArgs e)
		{
			
		}
		
		void TxtInitTextChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void TxtInitKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			/*if((e.KeyValue>=65 && e.KeyValue<=90) && !e.Control){
				rr.Move();
				rr.PutDataIn((char)e.KeyValue);
				txtFinal.AppendText(""+rr.GetDataOut());
			}*/

		}
		
		//move the first(right) rotor up
		void BtnRotor1UpClick(object sender, System.EventArgs e)
		{
			rr.Move();
		}
		
		//move the first rotor down
		void BtnRotor1DownClick(object sender, System.EventArgs e)
		{
			rr.MoveBack();
		}
		
		//move the second rotor up
		void BtnRotor2UpClick(object sender, System.EventArgs e)
		{
			rm.Move();
		}
		
		//move the second (midle) rotor down
		void BtnRotor2DownClick(object sender, System.EventArgs e)
		{
			rm.MoveBack();
		}
		
		//move the third(left) rotor up
		void BtnRotor3UpClick(object sender, System.EventArgs e)
		{
			rl.Move();
		}
		
		//move the third rotor down
		void BtnRotor3DownClick(object sender, System.EventArgs e)
		{
			rl.MoveBack();
		}
		
		//encrypt the data in the upper text box, and put the result in the lower one
		void Button1Click(object sender, System.EventArgs e)
		{
			//HDXCONVRWUEUVEZWDXDFCHXGO
			char[] chIn = txtInit.Text.ToUpper().ToCharArray();
			txtFinal.Text = "";
			for(int i=0;i<chIn.Length;i++){
				if(chIn[i]>=65 && chIn[i]<=90){
					rr.Move();
                    if (rr.GetOffset() % 5 == 0)
                        SetReflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                    else
                        SetReflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
					rr.PutDataIn(chIn[i]);
					txtFinal.AppendText(""+rr.GetDataOut());
				}
			}
		}
		
		//method to change the rotors that are used
		public void ChangeRotors(string rot1,string rotName1,char rotNotch1,
		                         string rot2,string rotName2,char rotNotch2,
		                         string rot3,string rotName3,char rotNotch3){
			lblRotorS.Text = rotName1;
			lblRotorM.Text = rotName2;
			lblRotorD.Text = rotName3;
			rr = null;
			rm = null;
			rl = null;
			
			rr = new Rotor(rot3,lblRotor1,rotNotch3);
			rm = new Rotor(rot2,lblRotor2,rotNotch2);
			rl = new Rotor(rot1,lblRotor3,rotNotch1);
			
			rr.ResetOffset();
			rm.ResetOffset();
			rl.ResetOffset();
			
			rr.SetNextRotor(rm);
			rm.SetNextRotor(rl);
			rl.SetNextRotor(reflector);
			rm.SetPreviousRotor(rr);
			rl.SetPreviousRotor(rm);
			reflector.SetPreviousRotor(rl);
			
			lblRotor1.Text = "A";
			lblRotor2.Text = "A";
			lblRotor3.Text = "A";
		}
		
		//change the reflector
		public void SetReflector(string refl){
			reflector = new Rotor(refl,null,'\0');
			reflector.SetPreviousRotor(rl);
			rl.SetNextRotor(reflector);
		}
		
		//get the selected reflector
		public string GetReflector(){
			return reflector.GetLayout();
		}
		
		public string GetRightRotor(){
			return rr.GetLayout();
		}
		public string GetMiddleRotor(){
			return rm.GetLayout();
		}
		public string GetLeftRotor(){
			return rl.GetLayout();
		}
	}
}
