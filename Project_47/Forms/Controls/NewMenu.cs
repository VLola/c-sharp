using Project_47;
using Project_47.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_47.Forms.Controls
{
    public class NewMenu:MenuStrip
    {
        private ToolStripMenuItem File;

        private ToolStripMenuItem Create;
        private ToolStripMenuItem Open;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem PrintPageSettings;
        private ToolStripMenuItem SendByEmail;
        private ToolStripMenuItem AboutTheProgram;
        private ToolStripMenuItem Exit;
        // Print
        private ToolStripMenuItem Print;
        private ToolStripMenuItem RegularPrinting;
        private ToolStripMenuItem FastPrinting;
        private ToolStripMenuItem Preview;
        // Save As
        private ToolStripMenuItem SaveAs;
        private ToolStripMenuItem RTF_document;
        private ToolStripMenuItem OfficeOpenXML_document;
        private ToolStripMenuItem TextOpenDocument;
        private ToolStripMenuItem PlainText;
        private ToolStripMenuItem Save_As;

        private Panel panel1;
        private ToolStripMenuItem HomeToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMenuItem;
        public NewMenu(Form1 form)
        {
            ImageScalingSize = new Size(36, 36);
            BackColor = Color.White;

            Items.AddRange(new ToolStripItem[] { File = new ToolStripMenuItem("File"), HomeToolStripMenuItem = new ToolStripMenuItem("Home"), ViewToolStripMenuItem = new ToolStripMenuItem("View") });

            File.DropDownItems.AddRange(new ToolStripItem[] {
                Create = new NewToolStripMenuItem("Create", Resources.Create)
                ,Open = new NewToolStripMenuItem("Open", Resources.Open)
                ,Save = new NewToolStripMenuItem("Save", Resources.Save)
                ,SaveAs = new NewToolStripMenuItem("Save As", Resources.SaveAs)
                ,new ToolStripSeparator()
                ,Print = new NewToolStripMenuItem("Print", Resources.Print)
                ,PrintPageSettings = new NewToolStripMenuItem("Page settings", Resources.PrintPageSettings)
                ,SendByEmail = new NewToolStripMenuItem("Send by email", Resources.SendByEmail)
                ,new ToolStripSeparator()
                ,AboutTheProgram = new NewToolStripMenuItem("About the program", Resources.AboutTheProgram)
                ,Exit = new NewToolStripMenuItem("Exit", Resources.Exit)
            });

            SaveAs.DropDownItems.AddRange(new ToolStripItem[] {
                new NewToolStripTextBox("Save a copy of the document")
                ,new ToolStripSeparator()
                ,RTF_document = new NewToolStripMenuItem("RTF document", Resources.RTF_document)
                ,OfficeOpenXML_document = new NewToolStripMenuItem("OfficeOpen XML document", Resources.OfficeOpenXML_document)
                ,TextOpenDocument = new NewToolStripMenuItem("Text OpenDocument", Resources.TextOpenDocument)
                ,PlainText = new NewToolStripMenuItem("Plain text", Resources.PlainText)
                ,Save_As = new NewToolStripMenuItem("Other formats", Resources.SaveAs)
            });

            Print.DropDownItems.AddRange(new ToolStripItem[] {
                new NewToolStripTextBox("Document preview and printing")
                ,new ToolStripSeparator()
                ,RegularPrinting = new NewToolStripMenuItem("Print", Resources.Print)
                ,FastPrinting = new NewToolStripMenuItem("FastPrinting", Resources.FastPrinting)
                ,Preview = new NewToolStripMenuItem("Preview", Resources.Preview)
            });

            panel1 = new NewPanel();
            panel1.Visible = true;

            HomeToolStripMenuItem.Click += new EventHandler(Home);
            ViewToolStripMenuItem.Click += new EventHandler(View);
            form.Controls.Add(this);
            form.Controls.Add(panel1);
        }
        private void Home(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void View(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
