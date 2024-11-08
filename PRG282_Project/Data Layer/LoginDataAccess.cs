using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PRG282_Project.Presentation_Layer;

namespace PRG282_Project.Data_Layer
{
    public class LoginDataAccess
    {
        private string filePath = @"C:\Users\User\OneDrive\Desktop\PRG_Project\Admins.txt";

        public bool checkPassword(string username, string password)
        {
            bool valid = false;
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) !=null)
                        {
                            string[] user = line.Split(' ');
                            string uname = user[0];
                            string pword = user[1]; 

                            if (uname == username && pword == password)
                            {
                                valid = true;
                                break;
                            }
                          
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid File path...");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return valid;
            
        }

    }
}
