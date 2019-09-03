using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysHolder.Windows
{
    public partial class PasswordGenerator : Form
    {
        /// <summary>
        /// Variables
        /// </summary>
        char[] numbersArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] smallLettersArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] biLettersArray = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] specialSignsArray = new char[] { '!', '=', '?', '&', '%', '$', '@' };

        /// <summary>
        /// Class constructor
        /// </summary>
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to generate random password
        /// </summary>
        /// <param name="length">Length of password</param>
        /// <param name="hasNumbers">Password has numbers</param>
        /// <param name="hasSmall">Password has small letters</param>
        /// <param name="hasBig">Password has big letters</param>
        /// <param name="hasSpecial">Password has special signs</param>
        /// <returns>Returns random builded password</returns>
        public string GeneratePassword(int length, bool hasNumbers, bool hasSmall, bool hasBig, bool hasSpecial)
        {
            List<int> whatInPassword = new List<int>();
            if (hasNumbers)
                whatInPassword.Add(0);
            if (hasSmall)
                whatInPassword.Add(1);
            if (hasBig)
                whatInPassword.Add(2);
            if (hasSpecial)
                whatInPassword.Add(3);
            char[] passwrodChar = new char[length];
            for (int i = 0; i < passwrodChar.Length; i++)
            {
                Random random = new Random();
                passwrodChar[i] = Convert.ToChar(whatInPassword[random.Next(0, whatInPassword.Count - 1)]);
                Thread.Sleep(20);
            }
            for(int i = 0; i < passwrodChar.Length; i++)
            {
                Random random = new Random();
                if (passwrodChar[i] == 0)
                {
                    passwrodChar[i] = numbersArray[random.Next(0,numbersArray.Length - 1)];
                }
                else if (passwrodChar[i] == 1)
                {
                    passwrodChar[i] = smallLettersArray[random.Next(0, smallLettersArray.Length - 1)];
                }
                else if (passwrodChar[i] == 2)
                {
                    passwrodChar[i] = biLettersArray[random.Next(0, biLettersArray.Length - 1)];
                }
                else if (passwrodChar[i] == 3)
                {
                    passwrodChar[i] = specialSignsArray[random.Next(0, specialSignsArray.Length - 1)];
                }
                Thread.Sleep(20);
            }
            string passwordString = new string(passwrodChar);
            return passwordString;
        }

        /// <summary>
        /// This method run when generate button clicked
        /// </summary>
        private void generateBT_Click(object sender, EventArgs e)
        {
            passwordTB.Text = GeneratePassword(Convert.ToInt32(lengthNUD.Value), hasNumbers.Checked, hasSmall.Checked, hasBig.Checked, hasSpecial.Checked);
        }
    }
}
