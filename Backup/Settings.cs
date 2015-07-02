/*
 * Created by SharpDevelop.
 * User: AdrianClepcea
 * Date: 2/1/2005
 * Time: 11:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Enigma
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListBox lstSelectedRotors;
		private System.Windows.Forms.Label lblRotorStructure;
		private System.Windows.Forms.ListBox lstAvailableRotors;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbReflector;
		private System.Windows.Forms.ToolTip ttDown;
		private System.Windows.Forms.ToolTip ttSelect;
		private System.Windows.Forms.ToolTip ttDeselect;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDeselect;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.ToolTip ttUp;
		private string rotor1,rotor2,rotor3,rotor4,rotor5;
		private MainForm mf;
		private ArrayList al1, al2, al3;
		
		public Settings(MainForm mf)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.mf = mf;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Settings));
			this.ttUp = new System.Windows.Forms.ToolTip(this.components);
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnDeselect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUp = new System.Windows.Forms.Button();
			this.ttDeselect = new System.Windows.Forms.ToolTip(this.components);
			this.ttSelect = new System.Windows.Forms.ToolTip(this.components);
			this.ttDown = new System.Windows.Forms.ToolTip(this.components);
			this.cmbReflector = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lstAvailableRotors = new System.Windows.Forms.ListBox();
			this.lblRotorStructure = new System.Windows.Forms.Label();
			this.lstSelectedRotors = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
			this.btnSelect.Location = new System.Drawing.Point(152, 40);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(40, 32);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Click += new System.EventHandler(this.BtnSelectClick);
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(152, 160);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(40, 32);
			this.btnDown.TabIndex = 4;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Reflector";
			// 
			// btnOk
			// 
			this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point(256, 328);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 32);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "Ok";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// btnDeselect
			// 
			this.btnDeselect.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselect.Image")));
			this.btnDeselect.Location = new System.Drawing.Point(152, 80);
			this.btnDeselect.Name = "btnDeselect";
			this.btnDeselect.Size = new System.Drawing.Size(40, 32);
			this.btnDeselect.TabIndex = 2;
			this.btnDeselect.Click += new System.EventHandler(this.BtnDeselectClick);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Available rotors";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(208, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Selected rotors";
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(152, 120);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(40, 32);
			this.btnUp.TabIndex = 3;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// cmbReflector
			// 
			this.cmbReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbReflector.Items.AddRange(new object[] {
						"Reflector B = YRUHQSLDPXNGOKMIEBFZCWVJAT",
						"Reflector C = FVPJIAOYEDRZXWGCTKUQSBNMHL"});
			this.cmbReflector.Location = new System.Drawing.Point(16, 296);
			this.cmbReflector.Name = "cmbReflector";
			this.cmbReflector.Size = new System.Drawing.Size(312, 21);
			this.cmbReflector.TabIndex = 14;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblRotorStructure);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 72);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rotor layout";
			// 
			// btnCancel
			// 
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(176, 328);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 32);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// lstAvailableRotors
			// 
			this.lstAvailableRotors.Items.AddRange(new object[] {
						"Rotor I",
						"Rotor II",
						"Rotor III",
						"Rotor IV",
						"Rotor V"});
			this.lstAvailableRotors.Location = new System.Drawing.Point(16, 32);
			this.lstAvailableRotors.Name = "lstAvailableRotors";
			this.lstAvailableRotors.Size = new System.Drawing.Size(120, 160);
			this.lstAvailableRotors.TabIndex = 0;
			this.lstAvailableRotors.SelectedIndexChanged += new System.EventHandler(this.LstAvailableRotorsSelectedIndexChanged);
			// 
			// lblRotorStructure
			// 
			this.lblRotorStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRotorStructure.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.lblRotorStructure.Location = new System.Drawing.Point(8, 42);
			this.lblRotorStructure.Name = "lblRotorStructure";
			this.lblRotorStructure.Size = new System.Drawing.Size(296, 23);
			this.lblRotorStructure.TabIndex = 9;
			this.lblRotorStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstSelectedRotors
			// 
			this.lstSelectedRotors.Location = new System.Drawing.Point(208, 32);
			this.lstSelectedRotors.Name = "lstSelectedRotors";
			this.lstSelectedRotors.Size = new System.Drawing.Size(120, 160);
			this.lstSelectedRotors.TabIndex = 5;
			// 
			// Settings
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(344, 376);
			this.Controls.Add(this.cmbReflector);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lstSelectedRotors);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnDeselect);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.lstAvailableRotors);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsLoad);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		void BtnCancelClick(object sender, System.EventArgs e)
		{
			Close();
		}
		
		void SettingsLoad(object sender, System.EventArgs e)
		{
			al1 = new ArrayList();
			al2 = new ArrayList();
			al3 = new ArrayList();
			al1.Add("Rotor I");
			al1.Add("Rotor II");
			al1.Add("Rotor III");
			al1.Add("Rotor IV");
			al1.Add("Rotor V");
			rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
			rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
			rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
			rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
			rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK";
			al2.Add(rotor1);
			al2.Add(rotor2);
			al2.Add(rotor3);
			al2.Add(rotor4);
			al2.Add(rotor5);
			al3.Add("Q");
			al3.Add("E");
			al3.Add("V");
			al3.Add("J");
			al3.Add("Z");
			lstAvailableRotors.Items.Clear();
			for(int i=0;i<al1.Count;i++){
				lstAvailableRotors.Items.Add(al1[i]);
			}
			ttSelect.SetToolTip(btnSelect,"Selecteaza rotorul");
			ttDeselect.SetToolTip(btnDeselect,"Deselecteaza rotorul");
			ttUp.SetToolTip(btnUp,"Muta rotorul in sus");
			ttDown.SetToolTip(btnDown,"Muta rotorul in jos");
			
			for(int i=0;i<cmbReflector.Items.Count;i++){
				if(cmbReflector.Items[i].ToString().EndsWith(mf.GetReflector())){
				   	cmbReflector.SelectedIndex = i;
				}
			}
			
			for(int i=0;i<al2.Count;i++){
				if(al2[i].ToString()==mf.GetLeftRotor()){
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			
			for(int i=0;i<al2.Count;i++){
				if(al2[i].ToString()==mf.GetMiddleRotor()){
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			for(int i=0;i<al2.Count;i++){
				if(al2[i].ToString()==mf.GetRightRotor()){
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
		}
		
		void LstAvailableRotorsSelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(lstAvailableRotors.SelectedIndex<0){
				return;
			}
			for(int i=0;i<al1.Count;i++){
				if(lstAvailableRotors.SelectedItem.ToString() == "" + al1[i]){
					lblRotorStructure.Text = "" + al2[i];
					return;
				}
			}
			lblRotorStructure.Text = "";
		}
		
		void BtnSelectClick(object sender, System.EventArgs e)
		{
			if(lstAvailableRotors.SelectedIndex<0){
				MessageBox.Show(this,"Selecteaza un rotor prima data!","Atentie!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			lstSelectedRotors.Items.Add(lstAvailableRotors.SelectedItem);
			lstAvailableRotors.Items.Remove(lstAvailableRotors.SelectedItem);
			lblRotorStructure.Text = "";
		}
		
		void BtnDeselectClick(object sender, System.EventArgs e)
		{
			if(lstSelectedRotors.SelectedIndex<0){
				MessageBox.Show(this,"Selecteaza un rotor prima data!","Atentie!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			lstAvailableRotors.Items.Add(lstSelectedRotors.SelectedItem);
			lstSelectedRotors.Items.Remove(lstSelectedRotors.SelectedItem);
		}
		
		void BtnUpClick(object sender, System.EventArgs e)
		{
			if(lstSelectedRotors.SelectedIndex<=0){
				return;
			}
			
			string strTemp = ""+lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex-1];
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex -1 ] = lstSelectedRotors.SelectedItem;
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
			lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex - 1;
			
		}
		
		void BtnDownClick(object sender, System.EventArgs e)
		{
			if(lstSelectedRotors.SelectedIndex<0 || lstSelectedRotors.SelectedIndex == lstSelectedRotors.Items.Count-1){
				return;
			}
			
			string strTemp = ""+lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex+1];
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex +1 ] = lstSelectedRotors.SelectedItem;
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
			lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex + 1;
		}
		
		void BtnOkClick(object sender, System.EventArgs e)
		{
			if(lstSelectedRotors.Items.Count!=3){
				MessageBox.Show(this,"Trebuie sa alegeti exact trei rotoare!","Atentie!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			
			ArrayList alRot = new ArrayList();
			ArrayList alRotName = new ArrayList();
			ArrayList alRotNotch = new ArrayList();
			
			for(int j=0;j<lstSelectedRotors.Items.Count;j++){
				for(int i=0;i<al1.Count;i++){
					if(lstSelectedRotors.Items[j].ToString() == "" + al1[i]){
						alRot.Add(al2[i]);
						alRotName.Add(al1[i].ToString().Substring(al1[i].ToString().LastIndexOf(" ")).Trim());
						alRotNotch.Add(al3[i]);
						break;
					}
				}
			}
			
			mf.ChangeRotors(alRot[0].ToString(),
			                alRotName[0].ToString(),
			                alRotNotch[0].ToString().ToCharArray()[0],
			                alRot[1].ToString(),
			                alRotName[1].ToString(),
			                alRotNotch[1].ToString().ToCharArray()[0],
			                alRot[2].ToString(),
			                alRotName[2].ToString(),
			                alRotNotch[2].ToString().ToCharArray()[0]);
			
			if(cmbReflector.SelectedIndex>-0){
				mf.SetReflector(cmbReflector.SelectedItem.ToString().Substring(cmbReflector.SelectedItem.ToString().LastIndexOf("=")+2).Trim());
			}
			//MessageBox.Show("\""+mf.GetReflector()+"\"");
			Close();
		}
		
	}
}
