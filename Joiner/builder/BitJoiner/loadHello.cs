﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
/*                                                                                                             
                                              ---------------------                                          
                                     --------------------------------------                                  
                                    ++++++++++-----------------------------                                  
                                    +++++++++++++++++++++++----------------                                  
                                    +++++++++++++++++++++++----------------                                  
                                    ++++++++++++++++++++#++++--------------                                  
                                    ++++++++++++++++++#####+++---------++++                                  
                                    +++++++++++++++#####+#####+++++++++++++#                                 
                                    ####################+++#####+++++++####+                                 
                               +++++++++##############+++++++###########+#+                                  
                        ++++++++++++++++++++++++++++++#+++-++++++++##+#++++---                               
                  ++++++++++++++++++++##+##+++#####++#+++++++++++++#++++#+#-+---------                       
           -+++++++++++++++++++++++++++++++##########+++#+++#++++++#+###++--------------------               
    -+++++++++++++++++++++++++++++++++++++++++++++######++#++###+++++++-------------------------------       
     ++++++#++++++++++++++++++++++++++++++++++++++++++++++++++++++++-------------------------------+++++++   
            ++++++++#+++++++++++++++++++++++++++++++++###+++++++------------------------+++++++++++          
                   +++++++++#++++++++++++++++++++++++++#+#++-------------------+++++++++++-                  
                         +++++++++++#+++++++++++++++++++#+-------------+++++++++++                           
                               ++++++++++++++#++++++++++++++-++#++++++++++++                                 
                                      ++++++++++++++++++++++++++++++                                         
                                               +++++++++++++++                                               
                                                     ++                                                      
                    < !--_____ __ __    _____ ___ _____ _____ _____ __        ____  _____ _____  -->
                    <!-- | __  |  |  |  |  |  |_  | __  |   | |   __|  |   ___|    \|   __|  |  | -->
                    <!-- | __ -|_   _|  |    -|_  |    -| | | |   __|  |__|___|  |  |   __|  |  | -->
                    <!-- |_____| |_|    |__|__|___|__|__|_|___|_____|_____|   |____/|_____|\___/  -->
*/
namespace BitJoiner
{
    public partial class loadHello : Form
    {
        public loadHello()
        {
            InitializeComponent();
            author();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBar.Width += 3;

            if (loadingBar.Width >= 599)
            {
                timer1.Stop();
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
        }

        private void author()
        {
            Process.Start("https://github.com/k3rnel-dev");
        }
    }
}