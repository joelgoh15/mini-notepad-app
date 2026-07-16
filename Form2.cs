using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project12_1
{
    public partial class formNotepadA1 : Form
    {
        public formNotepadA1()
        {
            InitializeComponent();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new tab button

            //create a new tab
            System.Windows.Forms.TabPage newTabPage = new System.Windows.Forms.TabPage("Page " + (tabControlA1.TabCount  +1).ToString());

            //create a new rich text box control
            System.Windows.Forms.RichTextBox newRichTextBox = new System.Windows.Forms.RichTextBox();

            //to get the number of richtextbox control that currently exist in form
            int numberOfRichTextBoxControls = this.Controls.OfType<RichTextBox>().Count();

            numberOfRichTextBoxControls = numberOfRichTextBoxControls + 1;

            //set properties for newly created richtextbox control
            newRichTextBox.Name = "richTextBox" + numberOfRichTextBoxControls.ToString();
            newRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newRichTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newRichTextBox.Location = new System.Drawing.Point(6, 6);
            newRichTextBox.Name = "richTextBox1";
            newRichTextBox.Size = new System.Drawing.Size(1006, 558);
            newRichTextBox.TabIndex = 0;
            //assign context menu option
            newRichTextBox.ContextMenuStrip = this.contextMenuStripRichTextBox;

            //new rich text box right click event handler
            //newRichTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            newRichTextBox.MouseDown += (objectSender, mouseEventArgsE) =>
            {
                if (mouseEventArgsE.Button == MouseButtons.Right)
                {
                    // Example: Show a context menu or just a message
                    //MessageBox.Show("Right-click detected!");

                    //option-1
                    // Optional: manually show the menu
                    newRichTextBox.ContextMenuStrip?.Show(newRichTextBox, mouseEventArgsE.Location);

                }
            };


            //add newly created new richtextbox to tabpage
            newTabPage.Controls.Add(newRichTextBox);

            //add tab newly created tab page to current tab control
            tabControlA1.TabPages.Add(newTabPage);




        }




        private void deleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //delete tab button
            
            // Check if there is a selected tab
            if (tabControlA1.SelectedTab != null)
            {
                if (tabControlA1.SelectedTab.Name == "tabPage1")
                {
                    MessageBox.Show("Not allowed to delete tab Page 1", "Page 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }


                // Get the selected TabPage
                TabPage selectedTab = tabControlA1.SelectedTab;

                // Remove all controls from the TabPage
                selectedTab.Controls.Clear();

                // Remove the TabPage from the TabControl
                tabControlA1.TabPages.Remove(selectedTab);

                // Dispose of the TabPage to free resources
                selectedTab.Dispose();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save button

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
                saveFileDialog.Title = "Save the contents";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Determine the selected file format
                    RichTextBoxStreamType streamType = saveFileDialog.FilterIndex == 2
                        ? RichTextBoxStreamType.PlainText
                        : RichTextBoxStreamType.RichText;

                    // Save content to the selected file
                    //get current  selected tab
                    TabPage selectedTab = tabControlA1.SelectedTab;
                    //get contecnt of rich text box in current selecetd tab for save file operations
                    System.Windows.Forms.RichTextBox currentRichTextBox = selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();
                    currentRichTextBox.SaveFile(saveFileDialog.FileName, streamType);


                    MessageBox.Show("File saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open file button
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt";
                openFileDialog.Title = "Open a file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Determine the file format
                        RichTextBoxStreamType streamType = openFileDialog.FilterIndex == 2
                            ? RichTextBoxStreamType.PlainText
                            : RichTextBoxStreamType.RichText;

                        //determine the  currentn selcted tab by user
                        TabPage selectedTab = tabControlA1.SelectedTab;
                        
                        //determine the current richtextbox control in seletced tab for load fiel operations
                        System.Windows.Forms.RichTextBox currentRichTextBox = selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();
                        currentRichTextBox.LoadFile(openFileDialog.FileName, streamType);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Could not open file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //undo button
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox = 
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            currentRichTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //redo button
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            currentRichTextBox.Redo();  


        }

        private void toggleUnderlineTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toggle underline text button
            
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;
            FontStyle newFontStyle;

            // Toggle underline
            if (currentFont.Underline)
            {
                // Remove underline
                newFontStyle = currentFont.Style & ~FontStyle.Underline;
            }
            else
            {
                // Add underline
                newFontStyle = currentFont.Style | FontStyle.Underline; 
            }

            currentRichTextBox.SelectionFont = new Font(currentFont, newFontStyle);

            //toggle indicator for on or off
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (toggleUnderlineTextToolStripMenuItem.Checked == false)
            {
                toggleUnderlineTextToolStripMenuItem.Checked = true;
                toggleUnderlineTextToolStripMenuItem.Image = Image.FromFile(image_file_path);
                toggleUnderlineTextToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            }
            else {
                toggleUnderlineTextToolStripMenuItem.Checked = false;
                toggleUnderlineTextToolStripMenuItem.Image = null;
            }

        }



        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //times new roman font style
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Times New Roman", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (timesNToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = true;
                timesNToolStripMenuItem.Image = Image.FromFile(image_file_path);
                timesNToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;


                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;
                
                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;


                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;


                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;


                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;


            }

        }

        private void freestyleScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //freestyle script font
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Freestyle Script", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (freestyleScriptToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = true;
                freestyleScriptToolStripMenuItem.Image = Image.FromFile(image_file_path);
                freestyleScriptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;
                

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;


                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;


                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;


            }

        }

        private void eightPtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //8pt button option
            
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            //currentRichTextBox.SelectionFont = new Font("Freestyle Script", currentFont.Size, currentFont.Style);
            currentRichTextBox.SelectionFont = new Font(currentFont.FontFamily, 8, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (eightPtToolStripMenuItem.Checked == false)
            {
                //font size 8pt options
                eightPtToolStripMenuItem.Checked = true;
                eightPtToolStripMenuItem.Image = Image.FromFile(image_file_path);
                eightPtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //font size 10pt options
                tenPtToolStripMenuItem.Checked = false;
                tenPtToolStripMenuItem.Image = null;

                //font size 12pt options
                twelvePtToolStripMenuItem.Checked = false;
                twelvePtToolStripMenuItem.Image = null;

                //font size 18pt options
                eightteenPtToolStripMenuItem.Checked = false;
                eightteenPtToolStripMenuItem.Image = null;

                //sont size 22pt options
                twentytwoPtToolStripMenuItem.Checked = false;
                twentytwoPtToolStripMenuItem.Image = null;

            }


        }

        private void tenPtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //10pt button option
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font(currentFont.FontFamily, 10, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (tenPtToolStripMenuItem.Checked == false)
            {
                //font size 8pt options
                eightPtToolStripMenuItem.Checked = false;
                eightPtToolStripMenuItem.Image = null;
                
                //font size 10pt options
                tenPtToolStripMenuItem.Checked = true;
                tenPtToolStripMenuItem.Image = Image.FromFile(image_file_path);
                tenPtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //font size 12pt options
                twelvePtToolStripMenuItem.Checked = false;
                twelvePtToolStripMenuItem.Image = null;

                //font size 18pt options
                eightteenPtToolStripMenuItem.Checked = false;
                eightteenPtToolStripMenuItem.Image = null;

                //sont size 22pt options
                twentytwoPtToolStripMenuItem.Checked = false;
                twentytwoPtToolStripMenuItem.Image = null;

            }

        }

        private void twelvePtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //12pt button option
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font(currentFont.FontFamily, 12, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (twelvePtToolStripMenuItem.Checked == false)
            {
                //font size 8pt options
                eightPtToolStripMenuItem.Checked = false;
                eightPtToolStripMenuItem.Image = null;

                //font size 10pt options
                tenPtToolStripMenuItem.Checked = false;
                tenPtToolStripMenuItem.Image = null;
                

                //font size 12pt options
                twelvePtToolStripMenuItem.Checked = true;
                twelvePtToolStripMenuItem.Image = Image.FromFile(image_file_path);
                twelvePtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //font size 18pt options
                eightteenPtToolStripMenuItem.Checked = false;
                eightteenPtToolStripMenuItem.Image = null;

                //sont size 22pt options
                twentytwoPtToolStripMenuItem.Checked = false;
                twentytwoPtToolStripMenuItem.Image = null;

            }


        }

        private void eightteenPtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //18pt button option
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font(currentFont.FontFamily, 18, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (eightteenPtToolStripMenuItem.Checked == false)
            {
                //font size 8pt options
                eightPtToolStripMenuItem.Checked = false;
                eightPtToolStripMenuItem.Image = null;
                
                //font size 10pt options
                tenPtToolStripMenuItem.Checked = false;
                tenPtToolStripMenuItem.Image = null;

                //font size 12pt options
                twelvePtToolStripMenuItem.Checked = false;
                twelvePtToolStripMenuItem.Image = null;

                //font size 18pt options
                eightteenPtToolStripMenuItem.Checked = true;
                eightteenPtToolStripMenuItem.Image = Image.FromFile(image_file_path);
                eightteenPtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //sont size 22pt options
                twentytwoPtToolStripMenuItem.Checked = false;
                twentytwoPtToolStripMenuItem.Image = null;

            }

        }

        private void twentytwoPtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //22pt button option

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            //currentRichTextBox.SelectionFont = new Font("Freestyle Script", currentFont.Size, currentFont.Style);
            currentRichTextBox.SelectionFont = new Font(currentFont.FontFamily, 22, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (twentytwoPtToolStripMenuItem.Checked == false)
            {
                //font size 8pt options
                eightPtToolStripMenuItem.Checked = false;
                eightPtToolStripMenuItem.Image = null;
                
                //font size 10pt options
                tenPtToolStripMenuItem.Checked = false;
                tenPtToolStripMenuItem.Image = null;

                //font size 12pt options
                twelvePtToolStripMenuItem.Checked = false;
                twelvePtToolStripMenuItem.Image = null;

                //font size 18pt options
                eightteenPtToolStripMenuItem.Checked = false;
                eightteenPtToolStripMenuItem.Image = null;

                //sont size 22pt options
                twentytwoPtToolStripMenuItem.Checked = true;
                twentytwoPtToolStripMenuItem.Image = Image.FromFile(image_file_path); ;
                twentytwoPtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            }
        }

        private void lucidaHandwritingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lucida Handwriting

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Lucida Handwriting", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (lucidaHandwritingToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = true;
                lucidaHandwritingToolStripMenuItem.Image = Image.FromFile(image_file_path);
                lucidaHandwritingToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;
                

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;


                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;


            }

        }

        private void segoeScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Segoe Script

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Segoe Script", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (segoeScriptToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = true;
                segoeScriptToolStripMenuItem.Image = Image.FromFile(image_file_path);
                segoeScriptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;
                

                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;


            }



        }

        private void brushScriptMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Brush Script MT

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Brush Script MT", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (brushScriptMTToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = true;
                brushScriptMTToolStripMenuItem.Image = Image.FromFile(image_file_path);
                brushScriptMTToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;
                
                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;


            }


        }

        private void edwardianScriptITCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edwardian Script ITC

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Edwardian Script ITC", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (edwardianScriptITCToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;

                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = true;
                edwardianScriptITCToolStripMenuItem.Image = Image.FromFile(image_file_path);
                edwardianScriptITCToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;
                

            }


        }

        private void frenchScriptMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //French Script MT

            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("French Script MT", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (frenchScriptMTToolStripMenuItem.Checked == false)
            {
                //kunstler script
                kunstlerScriptToolStripMenuItem.Checked = false;
                kunstlerScriptToolStripMenuItem.Image = null;
                

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;

                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = true;
                frenchScriptMTToolStripMenuItem.Image = Image.FromFile(image_file_path);
                frenchScriptMTToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

            }

        }

        private void kunstlerScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kunstler Script
            TabPage selectedTab = tabControlA1.SelectedTab;
            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            Font currentFont = currentRichTextBox.SelectionFont;

            currentRichTextBox.SelectionFont = new Font("Kunstler Script", currentFont.Size, currentFont.Style);

            //set toggle switch to this font name to true
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;

            if (kunstlerScriptToolStripMenuItem.Checked == false)
            {
                kunstlerScriptToolStripMenuItem.Checked = true;
                kunstlerScriptToolStripMenuItem.Image = Image.FromFile(image_file_path);
                kunstlerScriptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;

                //unset the other font names
                //times new roman
                timesNToolStripMenuItem.Checked = false;
                timesNToolStripMenuItem.Image = null;

                //freestyle script
                freestyleScriptToolStripMenuItem.Checked = false;
                freestyleScriptToolStripMenuItem.Image = null;

                //lucida handwriting
                lucidaHandwritingToolStripMenuItem.Checked = false;
                lucidaHandwritingToolStripMenuItem.Image = null;

                //segeo script
                segoeScriptToolStripMenuItem.Checked = false;
                segoeScriptToolStripMenuItem.Image = null;

                //brush script mt
                brushScriptMTToolStripMenuItem.Checked = false;
                brushScriptMTToolStripMenuItem.Image = null;

                //edwardian script itc
                edwardianScriptITCToolStripMenuItem.Checked = false;
                edwardianScriptITCToolStripMenuItem.Image = null;

                //french Script mtt
                frenchScriptMTToolStripMenuItem.Checked = false;
                frenchScriptMTToolStripMenuItem.Image = null;

            }




        }

        private void formNotepadA1_Load(object sender, EventArgs e)
        {
            string image_folder = Environment.CurrentDirectory;
            string folder_name = "folder_image";
            string file_name = "checkmark_16px.png";
            string image_file_path = image_folder + "\\" + folder_name + "\\" + file_name;


            //check on times new roman
            if (timesNToolStripMenuItem.Checked == false)
            {
                timesNToolStripMenuItem.Checked = true;
                timesNToolStripMenuItem.Image = Image.FromFile(image_file_path);
                timesNToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            }

            //check on 10pt font size selection
            if (tenPtToolStripMenuItem.Checked == false) {
                tenPtToolStripMenuItem.Checked = true;
                tenPtToolStripMenuItem.Image = Image.FromFile(image_file_path);
                tenPtToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            }


        }

        

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                //option-1
                // Optional: manually show the menu
                richTextBox1.ContextMenuStrip?.Show(richTextBox1, e.Location);

                //option-2
                //if (richTextBox1.ContextMenuStrip.Visible == false)
                //{
                    //richTextBox1.ContextMenuStrip?.Show(richTextBox1, e.Location);
                //}
                //else {
                    //richTextBox1.ContextMenuStrip.Visible = false;
                //}


            }
        }

        private void contectMenuStripRichTextBoxToolStripMenuItemFontColor_Click(object sender, EventArgs e)
        {
            //rich text box, riht click context menu options, font color

            //find the current active rich text box being used
            TabPage selectedTab = tabControlA1.SelectedTab;

            System.Windows.Forms.RichTextBox currentRichTextBox =
                selectedTab.Controls.OfType<System.Windows.Forms.RichTextBox>().FirstOrDefault();

            //use color dialog to pick color
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    //set to new font color selection
                    currentRichTextBox.SelectionColor = colorDialog.Color;
                }
            }


        }



       
    }
}
