using PRG282_Project.Business_Logic_Layer;
using PRG282_Project.Data_Layer;
using System;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer.Applicant
{
    public partial class ApplicantDetails : Form
    {
        private ApplicantManager applicantManager;
       
        private string uploadedDocumentPath;
        private bool isFormValid; // Flag to check if the form is valid

        public ApplicantDetails()
        {
            InitializeComponent();
            applicantManager = new ApplicantManager();
            uploadedDocumentPath = string.Empty;

            // Add event handlers for input changes
            txtSAIdNumber.TextChanged += InputFields_TextChanged;
            txtFirstName.TextChanged += InputFields_TextChanged;
            txtSurname.TextChanged += InputFields_TextChanged;
            txtEmail.TextChanged += InputFields_TextChanged;
            cmbCourses.SelectedIndexChanged += InputFields_TextChanged;
            radioButtonMale.CheckedChanged += InputFields_TextChanged;
            radioButtonFemale.CheckedChanged += InputFields_TextChanged;
        }

        private void ApplicantDetails_Load(object sender, EventArgs e)
        {
            // Load event logic (if any)
        }

        private string GetSelectedGender()
        {
            if (radioButtonMale.Checked)
            {
                return "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                return "Female";
            }
            else
            {
                return "Other";
            }
        }

        private void btnUploadDocument_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Supporting Document (ID Picture)";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    uploadedDocumentPath = openFileDialog.FileName;
                    lblDocumentPath.Text = uploadedDocumentPath; // Display the file path
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saIdNumber = txtSAIdNumber.Text;
            string firstName = txtFirstName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string gender = GetSelectedGender();
            string course = cmbCourses.SelectedItem?.ToString() ?? string.Empty;

         
            // Call the business layer to save the applicant
            try
            {
                applicantManager.AddApplicant(saIdNumber, firstName, surname, course, email, gender, uploadedDocumentPath);
                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving information: {ex.Message}");
            }
        }

        private void btnFormValidate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                btnSave.Enabled = true; // Enable the save button
                isFormValid = true; // Set the flag to true
                MessageBox.Show("Form is valid. You can proceed with saving the applicant information.");
            }
        }

        private void InputFields_TextChanged(object sender, EventArgs e)
        {
            // If the form was previously valid, disable the save button when fields change
            if (isFormValid)
            {
                btnSave.Enabled = false; // Disable the save button
                isFormValid = false; // Reset the form valid flag
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtSAIdNumber.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cmbCourses.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields, including selecting a course.");
                return false;
            }

            if (txtSAIdNumber.Text.Length != 13)
            {
                MessageBox.Show("SA ID number must be exactly 13 characters long.");
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(uploadedDocumentPath))
            {
                MessageBox.Show("Please upload a supporting document (ID picture).");
                return false;
            }

            return true; // All validations passed
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
