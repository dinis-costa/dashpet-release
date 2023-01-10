using System;
using System.Linq;
using System.Windows.Forms;

namespace DashPetApp.Services
{
    public class GroupBoxUtils
    {
        /// <summary>
        /// There are two types of Button.Tag in the aplication, action & option.
        /// 
        /// Action - These are the New, Edit, Delete, Confirm buttons.
        /// Option - These are the Cancel & Save buttons.
        /// 
        /// This method receives a Button switches its state, also switching the state on the remaining buttons in the GroupBox.
        /// So when one of the Action buttons are pressed the option buttons become disabled, and vice-versa.
        /// </summary>
        /// <param name="snd">Button that send the event.</param>
        public void ButtonsMode(Button snd)
        {
            if (snd != null)
            {
                bool mode = true;

                switch (snd.Tag.ToString())
                {
                    case "action": mode = false; break;
                    case "option": mode = true; break;
                }

                foreach (var btn in snd.Parent.Controls) // Refers to a GroupBox, which in this program is always the sender.Parent.
                {
                    if (btn is Button btnSel)
                    {
                        switch (btnSel.Tag.ToString())
                        {
                            case "action": btnSel.Enabled = mode; break;
                            case "option": btnSel.Enabled = !mode; break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Receives a GroupBox <paramref name="gb"/> and reset the text of its controls determined.
        /// </summary>
        /// <param name="gb">GroupBox where the event originated.</param>
        public void ClearGroupBox(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox || control is ComboBox || control is DateTimePicker) control.Text = string.Empty;
            }
        }

        /// <summary>
        /// Recives the GroupBox that started the event.
        /// Enabled/Disables the remaining group boxes.
        /// </summary>
        /// <param name="gb">GroupBox from the event.</param>
        /// <param name="value">GroupBox.Enabled value</param>
        public void EnableGroupBoxes(GroupBox gb, bool value)
        {
            foreach (GroupBox control in gb.Parent.Controls)
            {
                if (control != gb)
                {
                    control.Enabled = value;
                }
            }
        }

        /// <summary>
        /// The elements on the GroupBox <paramref name="gb"/> that are marked on Control.Tag as "field":
        /// Are make writtabled/read-only with .ReadOnly (TextBox) or .Enabled (if they are other type of control).
        /// </summary>
        /// <param name="option">The to enable or disable the property.</param>
        /// <param name="gb">GroupBox where the event originated.</param>
        public void MakeFieldsWritable(bool option, GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control.Tag != null)
                {
                    if (control.Tag.ToString().Contains("field"))
                    {
                        if (control is TextBox) (control as TextBox).ReadOnly = !option;
                        else control.Enabled = option;
                    }
                }
            }
        }

        /// <summary>
        /// Uses methods in this class to generate what should occur if a .Tag "New" button is clicked.
        /// </summary>
        /// <param name="snd"></param>
        /// <param name="gb"></param>
        public void NewClickBehavior(object snd, GroupBox gb)
        {
            ButtonsMode((Button)snd); // Switches which button are enabled/clickable.
            EnableGroupBoxes(gb, false); // Disables all other GroupBoxes.
            ClearGroupBox(gb); // Clears .Tag "field" in the GroupBox.
            MakeFieldsWritable(true, gb); // Makes the fields writtable.
        }

        /// <summary>
        /// Uses methods in this class to generate what should occur if a .Tag "Edit" button is clicked.
        /// </summary>
        /// <param name="snd"></param>
        /// <param name="gb"></param>
        public void EditClickBehavior(object snd, GroupBox gb)
        {
            ButtonsMode((Button)snd);
            EnableGroupBoxes(gb, false);
            MakeFieldsWritable(true, gb);
        }

        /// <summary>
        /// Receives current GroupBox, and performs validations on its Control.Tag "field".
        /// Commented the type of control and database size.
        /// These validations are not strict, it's just a general ideia of what would be allowed and in which format.
        /// </summary>
        /// <param name="gb"></param>
        /// <returns>Boolean as sucessful/unsuccessful validation.</returns>
        public bool Validate(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control.Tag != null)
                {
                    if ((control is TextBox || control is DateTimePicker || control is ComboBox) && control.Tag.ToString().Contains("field"))
                    {
                        // Name Validation
                        if (control.Tag.ToString().Contains("name"))
                        {
                            if (control.Text.Length < 1 || control.Text.Length > 300 || control.Text.Any(x => char.IsDigit(x)))
                            {
                                MessageBox.Show("Invalid Name field.");
                                return false;
                            }
                        } // 300

                        // Alternate Name Validation
                        if (control.Tag.ToString().Contains("handle"))
                        {
                            if (control.Text.Length < 1 || control.Text.Length > 100)
                            {
                                MessageBox.Show("Invalid Name field.");
                                return false;
                            }
                        } //100

                        // Document Validation
                        if (control.Tag.ToString().Contains("doc"))
                        {
                            if (control.Text.Length < 8 || control.Text.Length > 20 || control.Text.Any(x => char.IsLetter(x)))
                            {
                                MessageBox.Show("Invalid Doc. field.");
                                return false;
                            }
                        } //20

                        // Phone Validation
                        if (control.Tag.ToString().Contains("phone"))
                        {
                            if (control.Text.Length < 9 || control.Text.Length > 50 || control.Text.Any(x => char.IsLetter(x)))
                            {
                                MessageBox.Show("Invalid Phone field.");
                                return false;
                            }
                        } //50

                        // Email Validation
                        if (control.Tag.ToString().Contains("email"))
                        {
                            if (control.Text.Length < 320)
                            {
                                try
                                {
                                    var email = new System.Net.Mail.MailAddress(control.Text);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Invalid Email field.");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Email field.");
                                return false;
                            }
                        } //320

                        // Address Validation
                        if (control.Tag.ToString().Contains("address"))
                        {
                            if (control.Text.Length < 5 || !(control.Text.Any(x => char.IsDigit(x)) && control.Text.Any(x => char.IsLetter(x))) || control.Text.Length > 500)
                            {
                                MessageBox.Show("Invalid Address field.");
                                return false;
                            }
                        } //500

                        // Notes Validation
                        if (control.Tag.ToString().Contains("notes"))
                        {
                            if (control.Text.Length > 1000)
                            {
                                MessageBox.Show("Invalid Notes field.");
                                return false;
                            }
                        } //1000

                        // Float Validation
                        if (control.Tag.ToString().Contains("float"))
                        {
                            if (control.Text.Length < 10)
                            {
                                try
                                {
                                    var value = decimal.Parse(control.Text);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Invalid Numeric field.");
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Numeric field.");
                                return false;
                            }
                        } //10

                        // DateTimePicker
                        if (control is DateTimePicker)
                        {
                            try
                            {
                                DateTime value = (control as DateTimePicker).Value;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Select a date in the date picker.");
                                return false;
                            }
                        }

                        // ComboBox
                        if (control is ComboBox)
                        {
                            if ((control as ComboBox).SelectedItem == null || (control as ComboBox).SelectedIndex == -1)
                            {
                                MessageBox.Show("Select an option in the combo box.");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
