		using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TWR_Gatekeeper_Bruteforcer
{
	public partial class MainForm : Form
	{
		int score = 0;
		int missingKey = 0;
		string[] keys = new String[7];
		string[] combinations = new String[36];
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			missingKey = 6;
			score = 6;
			if (textBox1.Text == string.Empty){score--; missingKey = 1;}
			if (textBox2.Text == string.Empty){score--; missingKey = 2;}
			if (textBox3.Text == string.Empty){score--; missingKey = 3;}
			if (textBox4.Text == string.Empty){score--; missingKey = 4;}
			if (textBox5.Text == string.Empty){score--; missingKey = 5;}
			if (textBox6.Text == string.Empty){score--; missingKey = 6;}
			if (score != 5) return;
			keys[0] = string.Empty;
			keys[1] = textBox1.Text.ToUpper();
			keys[2] = textBox2.Text.ToUpper();
			keys[3] = textBox3.Text.ToUpper();
			keys[4] = textBox4.Text.ToUpper();
			keys[5] = textBox5.Text.ToUpper();
			keys[6] = textBox6.Text.ToUpper();
			switch (missingKey)
			{
				case 1:
					combinations[0] = "1" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[1] = "2" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[2] = "3" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[3] = "4" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[4] = "5" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[5] = "6" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[6] = "7" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[7] = "8" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[8] = "9" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[9] = "0" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[10] = "Q" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[11] = "W" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[12] = "E" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[13] = "R" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[14] = "T" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[15] = "Y" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[16] = "U" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[17] = "I" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[18] = "O" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[19] = "P" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[20] = "A" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[21] = "S" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[22] = "D" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[23] = "F" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[24] = "G" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[25] = "H" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[26] = "J" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[27] = "K" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[28] = "L" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[29] = "Z" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[30] = "X" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[31] = "C" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[32] = "V" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[33] = "B" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[34] = "N" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[35] = "M" + keys[2] + keys[3] + keys[4] + keys[5] + keys[6];
				break;
				case 2:
					combinations[0] = keys[1] + "1" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[1] = keys[1] + "2" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[2] = keys[1] + "3" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[3] = keys[1] + "4" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[4] = keys[1] + "5" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[5] = keys[1] + "6" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[6] = keys[1] + "7" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[7] = keys[1] + "8" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[8] = keys[1] + "9" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[9] = keys[1] + "0" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[10] = keys[1] + "Q" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[11] = keys[1] + "W" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[12] = keys[1] + "E" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[13] = keys[1] + "R" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[14] = keys[1] + "T" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[15] = keys[1] + "Y" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[16] = keys[1] + "U" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[17] = keys[1] + "I" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[18] = keys[1] + "O" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[19] = keys[1] + "P" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[20] = keys[1] + "A" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[21] = keys[1] + "S" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[22] = keys[1] + "D" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[23] = keys[1] + "F" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[24] = keys[1] + "G" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[25] = keys[1] + "H" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[26] = keys[1] + "J" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[27] = keys[1] + "K" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[28] = keys[1] + "L" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[29] = keys[1] + "Z" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[30] = keys[1] + "X" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[31] = keys[1] + "C" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[32] = keys[1] + "V" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[33] = keys[1] + "B" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[34] = keys[1] + "N" + keys[3] + keys[4] + keys[5] + keys[6];
					combinations[35] = keys[1] + "M" + keys[3] + keys[4] + keys[5] + keys[6];
				break;
				case 3:
					combinations[0] = keys[1] + keys[2] + "1" + keys[4] + keys[5] + keys[6];
					combinations[1] = keys[1] + keys[2] + "2" + keys[4] + keys[5] + keys[6];
					combinations[2] = keys[1] + keys[2] + "3" + keys[4] + keys[5] + keys[6];
					combinations[3] = keys[1] + keys[2] + "4" + keys[4] + keys[5] + keys[6];
					combinations[4] = keys[1] + keys[2] + "5" + keys[4] + keys[5] + keys[6];
					combinations[5] = keys[1] + keys[2] + "6" + keys[4] + keys[5] + keys[6];
					combinations[6] = keys[1] + keys[2] + "7" + keys[4] + keys[5] + keys[6];
					combinations[7] = keys[1] + keys[2] + "8" + keys[4] + keys[5] + keys[6];
					combinations[8] = keys[1] + keys[2] + "9" + keys[4] + keys[5] + keys[6];
					combinations[9] = keys[1] + keys[2] + "0" + keys[4] + keys[5] + keys[6];
					combinations[10] = keys[1] + keys[2] + "Q" + keys[4] + keys[5] + keys[6];
					combinations[11] = keys[1] + keys[2] + "W" + keys[4] + keys[5] + keys[6];
					combinations[12] = keys[1] + keys[2] + "E" + keys[4] + keys[5] + keys[6];
					combinations[13] = keys[1] + keys[2] + "R" + keys[4] + keys[5] + keys[6];
					combinations[14] = keys[1] + keys[2] + "T" + keys[4] + keys[5] + keys[6];
					combinations[15] = keys[1] + keys[2] + "Y" + keys[4] + keys[5] + keys[6];
					combinations[16] = keys[1] + keys[2] + "U" + keys[4] + keys[5] + keys[6];
					combinations[17] = keys[1] + keys[2] + "I" + keys[4] + keys[5] + keys[6];
					combinations[18] = keys[1] + keys[2] + "O" + keys[4] + keys[5] + keys[6];
					combinations[19] = keys[1] + keys[2] + "P" + keys[4] + keys[5] + keys[6];
					combinations[20] = keys[1] + keys[2] + "A" + keys[4] + keys[5] + keys[6];
					combinations[21] = keys[1] + keys[2] + "S" + keys[4] + keys[5] + keys[6];
					combinations[22] = keys[1] + keys[2] + "D" + keys[4] + keys[5] + keys[6];
					combinations[23] = keys[1] + keys[2] + "F" + keys[4] + keys[5] + keys[6];
					combinations[24] = keys[1] + keys[2] + "G" + keys[4] + keys[5] + keys[6];
					combinations[25] = keys[1] + keys[2] + "H" + keys[4] + keys[5] + keys[6];
					combinations[26] = keys[1] + keys[2] + "J" + keys[4] + keys[5] + keys[6];
					combinations[27] = keys[1] + keys[2] + "K" + keys[4] + keys[5] + keys[6];
					combinations[28] = keys[1] + keys[2] + "L" + keys[4] + keys[5] + keys[6];
					combinations[29] = keys[1] + keys[2] + "Z" + keys[4] + keys[5] + keys[6];
					combinations[30] = keys[1] + keys[2] + "X" + keys[4] + keys[5] + keys[6];
					combinations[31] = keys[1] + keys[2] + "C" + keys[4] + keys[5] + keys[6];
					combinations[32] = keys[1] + keys[2] + "V" + keys[4] + keys[5] + keys[6];
					combinations[33] = keys[1] + keys[2] + "B" + keys[4] + keys[5] + keys[6];
					combinations[34] = keys[1] + keys[2] + "N" + keys[4] + keys[5] + keys[6];
					combinations[35] = keys[1] + keys[2] + "M" + keys[4] + keys[5] + keys[6];
				break;
				case 4:
					combinations[0] = keys[1] + keys[2] + keys[3] + "1" +  keys[5] + keys[6];
					combinations[1] = keys[1] + keys[2] + keys[3] + "2" +  keys[5] + keys[6];
					combinations[2] = keys[1] + keys[2] + keys[3] + "3" +  keys[5] + keys[6];
					combinations[3] = keys[1] + keys[2] + keys[3] + "4" +  keys[5] + keys[6];
					combinations[4] = keys[1] + keys[2] + keys[3] + "5" +  keys[5] + keys[6];
					combinations[5] = keys[1] + keys[2] + keys[3] + "6" +  keys[5] + keys[6];
					combinations[6] = keys[1] + keys[2] + keys[3] + "7" +  keys[5] + keys[6];
					combinations[7] = keys[1] + keys[2] + keys[3] + "8" +  keys[5] + keys[6];
					combinations[8] = keys[1] + keys[2] + keys[3] + "9" +  keys[5] + keys[6];
					combinations[9] = keys[1] + keys[2] + keys[3] + "0" +  keys[5] + keys[6];
					combinations[10] = keys[1] + keys[2] + keys[3] + "Q" + keys[5] + keys[6];
					combinations[11] = keys[1] + keys[2] + keys[3] + "W" + keys[5] + keys[6];
					combinations[12] = keys[1] + keys[2] + keys[3] + "E" + keys[5] + keys[6];
					combinations[13] = keys[1] + keys[2] + keys[3] + "R" + keys[5] + keys[6];
					combinations[14] = keys[1] + keys[2] + keys[3] + "T" + keys[5] + keys[6];
					combinations[15] = keys[1] + keys[2] + keys[3] + "Y" + keys[5] + keys[6];
					combinations[16] = keys[1] + keys[2] + keys[3] + "U" + keys[5] + keys[6];
					combinations[17] = keys[1] + keys[2] + keys[3] + "I" + keys[5] + keys[6];
					combinations[18] = keys[1] + keys[2] + keys[3] + "O" + keys[5] + keys[6];
					combinations[19] = keys[1] + keys[2] + keys[3] + "P" + keys[5] + keys[6];
					combinations[20] = keys[1] + keys[2] + keys[3] + "A" + keys[5] + keys[6];
					combinations[21] = keys[1] + keys[2] + keys[3] + "S" + keys[5] + keys[6];
					combinations[22] = keys[1] + keys[2] + keys[3] + "D" + keys[5] + keys[6];
					combinations[23] = keys[1] + keys[2] + keys[3] + "F" + keys[5] + keys[6];
					combinations[24] = keys[1] + keys[2] + keys[3] + "G" + keys[5] + keys[6];
					combinations[25] = keys[1] + keys[2] + keys[3] + "H" + keys[5] + keys[6];
					combinations[26] = keys[1] + keys[2] + keys[3] + "J" + keys[5] + keys[6];
					combinations[27] = keys[1] + keys[2] + keys[3] + "K" + keys[5] + keys[6];
					combinations[28] = keys[1] + keys[2] + keys[3] + "L" + keys[5] + keys[6];
					combinations[29] = keys[1] + keys[2] + keys[3] + "Z" + keys[5] + keys[6];
					combinations[30] = keys[1] + keys[2] + keys[3] + "X" + keys[5] + keys[6];
					combinations[31] = keys[1] + keys[2] + keys[3] + "C" + keys[5] + keys[6];
					combinations[32] = keys[1] + keys[2] + keys[3] + "V" + keys[5] + keys[6];
					combinations[33] = keys[1] + keys[2] + keys[3] + "B" + keys[5] + keys[6];
					combinations[34] = keys[1] + keys[2] + keys[3] + "N" + keys[5] + keys[6];
					combinations[35] = keys[1] + keys[2] + keys[3] + "M" + keys[5] + keys[6];
				break;
				case 5:
					combinations[0] = keys[1] + keys[2] + keys[3] + keys[4] + "1" + keys[6];
					combinations[1] = keys[1] + keys[2] + keys[3] + keys[4] + "2" + keys[6];
					combinations[2] = keys[1] + keys[2] + keys[3] + keys[4] + "3" + keys[6];
					combinations[3] = keys[1] + keys[2] + keys[3] + keys[4] + "4" + keys[6];
					combinations[4] = keys[1] + keys[2] + keys[3] + keys[4] + "5" + keys[6];
					combinations[5] = keys[1] + keys[2] + keys[3] + keys[4] + "6" + keys[6];
					combinations[6] = keys[1] + keys[2] + keys[3] + keys[4] + "7" + keys[6];
					combinations[7] = keys[1] + keys[2] + keys[3] + keys[4] + "8" + keys[6];
					combinations[8] = keys[1] + keys[2] + keys[3] + keys[4] + "9" + keys[6];
					combinations[9] = keys[1] + keys[2] + keys[3] + keys[4] + "0" + keys[6];
					combinations[10] = keys[1] + keys[2] + keys[3] + keys[4] + "Q" + keys[6];
					combinations[11] = keys[1] + keys[2] + keys[3] + keys[4] + "W" + keys[6];
					combinations[12] = keys[1] + keys[2] + keys[3] + keys[4] + "E" + keys[6];
					combinations[13] = keys[1] + keys[2] + keys[3] + keys[4] + "R" + keys[6];
					combinations[14] = keys[1] + keys[2] + keys[3] + keys[4] + "T" + keys[6];
					combinations[15] = keys[1] + keys[2] + keys[3] + keys[4] + "Y" + keys[6];
					combinations[16] = keys[1] + keys[2] + keys[3] + keys[4] + "U" + keys[6];
					combinations[17] = keys[1] + keys[2] + keys[3] + keys[4] + "I" + keys[6];
					combinations[18] = keys[1] + keys[2] + keys[3] + keys[4] + "O" + keys[6];
					combinations[19] = keys[1] + keys[2] + keys[3] + keys[4] + "P" + keys[6];
					combinations[20] = keys[1] + keys[2] + keys[3] + keys[4] + "A" + keys[6];
					combinations[21] = keys[1] + keys[2] + keys[3] + keys[4] + "S" + keys[6];
					combinations[22] = keys[1] + keys[2] + keys[3] + keys[4] + "D" + keys[6];
					combinations[23] = keys[1] + keys[2] + keys[3] + keys[4] + "F" + keys[6];
					combinations[24] = keys[1] + keys[2] + keys[3] + keys[4] + "G" + keys[6];
					combinations[25] = keys[1] + keys[2] + keys[3] + keys[4] + "H" + keys[6];
					combinations[26] = keys[1] + keys[2] + keys[3] + keys[4] + "J" + keys[6];
					combinations[27] = keys[1] + keys[2] + keys[3] + keys[4] + "K" + keys[6];
					combinations[28] = keys[1] + keys[2] + keys[3] + keys[4] + "L" + keys[6];
					combinations[29] = keys[1] + keys[2] + keys[3] + keys[4] + "Z" + keys[6];
					combinations[30] = keys[1] + keys[2] + keys[3] + keys[4] + "X" + keys[6];
					combinations[31] = keys[1] + keys[2] + keys[3] + keys[4] + "C" + keys[6];
					combinations[32] = keys[1] + keys[2] + keys[3] + keys[4] + "V" + keys[6];
					combinations[33] = keys[1] + keys[2] + keys[3] + keys[4] + "B" + keys[6];
					combinations[34] = keys[1] + keys[2] + keys[3] + keys[4] + "N" + keys[6];
					combinations[35] = keys[1] + keys[2] + keys[3] + keys[4] + "M" + keys[6];
				break;
				case 6:
					combinations[0] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "1";
					combinations[1] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "2";
					combinations[2] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "3";
					combinations[3] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "4";
					combinations[4] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "5";
					combinations[5] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "6";
					combinations[6] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "7";
					combinations[7] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "8";
					combinations[8] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "9";
					combinations[9] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "0";
					combinations[10] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "Q";
					combinations[11] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "W";
					combinations[12] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "E";
					combinations[13] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "R";
					combinations[14] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "T";
					combinations[15] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "Y";
					combinations[16] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "U";
					combinations[17] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "I";
					combinations[18] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "O";
					combinations[19] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "P";
					combinations[20] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "A";
					combinations[21] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "S";
					combinations[22] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "D";
					combinations[23] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "F";
					combinations[24] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "G";
					combinations[25] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "H";
					combinations[26] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "J";
					combinations[27] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "K";
					combinations[28] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "L";
					combinations[29] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "Z";
					combinations[30] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "X";
					combinations[31] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "C";
					combinations[32] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "V";
					combinations[33] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "B";
					combinations[34] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "N";
					combinations[35] = keys[1] + keys[2] + keys[3] + keys[4] + keys[5] + "M";
				break;
			}
			for (int j = 0; j < combinations.Length; j++)
			{
				combinations[j] = "gatekeeper " + combinations[j];
			}
			changePage(1);
			placeIndicator(0);
		}
		void changePage(int pageNumber){switch(pageNumber){
				case 1:
					label2.Text = "page 1/4";
					textBox7.Text = combinations[0];
					textBox8.Text = combinations[1];
					textBox9.Text = combinations[2];
					textBox10.Text = combinations[3];
					textBox11.Text = combinations[4];
					textBox12.Text = combinations[5];
					textBox13.Text = combinations[6];
					textBox14.Text = combinations[7];
					textBox15.Text = combinations[8];
				break;
				case 2:
					label2.Text = "page 2/4";
					textBox7.Text = combinations[9];
					textBox8.Text = combinations[10];
					textBox9.Text = combinations[11];
					textBox10.Text = combinations[12];
					textBox11.Text = combinations[13];
					textBox12.Text = combinations[14];
					textBox13.Text = combinations[15];
					textBox14.Text = combinations[16];
					textBox15.Text = combinations[17];
				break;
				case 3:
					label2.Text = "page 3/4";
					textBox7.Text = combinations[18];
					textBox8.Text = combinations[19];
					textBox9.Text = combinations[20];
					textBox10.Text = combinations[21];
					textBox11.Text = combinations[22];
					textBox12.Text = combinations[23];
					textBox13.Text = combinations[24];
					textBox14.Text = combinations[25];
					textBox15.Text = combinations[26];
				break;
				case 4:
					label2.Text = "page 4/4";
					textBox7.Text = combinations[27];
					textBox8.Text = combinations[28];
					textBox9.Text = combinations[29];
					textBox10.Text = combinations[30];
					textBox11.Text = combinations[31];
					textBox12.Text = combinations[32];
					textBox13.Text = combinations[33];
					textBox14.Text = combinations[34];
					textBox15.Text = combinations[35];
				break;
		}}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (label2.Text == "page 1/4") return;
			else if (label2.Text == "page 2/4") changePage(1);
			else if (label2.Text == "page 3/4") changePage(2);
			else if (label2.Text == "page 4/4") changePage(3);
			placeIndicator(0);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (label2.Text == "page 1/4") changePage(2);
			else if (label2.Text == "page 2/4") changePage(3);
			else if (label2.Text == "page 3/4") changePage(4);
			else if (label2.Text == "page 4/4") return;
			placeIndicator(0);
		}
		
		void placeIndicator(int indicator)
		{
					radioButton1.Checked = false;
					radioButton2.Checked = false;
					radioButton3.Checked = false;
					radioButton4.Checked = false;
					radioButton5.Checked = false;
					radioButton6.Checked = false;
					radioButton7.Checked = false;
					radioButton8.Checked = false;
					radioButton9.Checked = false;
					switch (indicator)
					{
						case 1: radioButton1.Checked = true; break;
						case 2: radioButton2.Checked = true; break;
						case 3: radioButton3.Checked = true; break;
						case 4: radioButton4.Checked = true; break;
						case 5: radioButton5.Checked = true; break;
						case 6: radioButton6.Checked = true; break;
						case 7: radioButton7.Checked = true; break;
						case 8: radioButton8.Checked = true; break;
						case 9: radioButton9.Checked = true; break;
					default: break;
					}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox7.Text);}catch{}
			placeIndicator(1);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox8.Text);}catch{}
			placeIndicator(2);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox9.Text);}catch{}
			placeIndicator(3);
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox10.Text);}catch{}
			placeIndicator(4);
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox11.Text);}catch{}
			placeIndicator(5);
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox12.Text);}catch{}
			placeIndicator(6);
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox13.Text);}catch{}
			placeIndicator(7);
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox14.Text);}catch{}
			placeIndicator(8);
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			try{Clipboard.SetText(textBox15.Text);}catch{}
			placeIndicator(9);
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
			textBox3.Text = string.Empty;
			textBox4.Text = string.Empty;
			textBox5.Text = string.Empty;
			textBox6.Text = string.Empty;
			textBox7.Text = string.Empty;
			textBox8.Text = string.Empty;
			textBox9.Text = string.Empty;
			textBox10.Text = string.Empty;
			textBox11.Text = string.Empty;
			textBox12.Text = string.Empty;
			textBox13.Text = string.Empty;
			textBox14.Text = string.Empty;
			textBox15.Text = string.Empty;
			changePage(1);
			placeIndicator(0);
			Array.Clear(keys, 0, keys.Length);
			Array.Clear(combinations, 0, combinations.Length);
		}
	}
}
