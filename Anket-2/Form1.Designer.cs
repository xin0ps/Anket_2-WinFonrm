namespace Anket_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Anket = new System.Windows.Forms.GroupBox();
            this.deyis = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dogumtxt = new System.Windows.Forms.RichTextBox();
            this.labeldogum = new System.Windows.Forms.Label();
            this.telefontxt = new System.Windows.Forms.RichTextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.RichTextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.RichTextBox();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.RichTextBox();
            this.labelad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_load_file = new System.Windows.Forms.Button();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.RichTextBox();
            this.label_file = new System.Windows.Forms.Label();
            this.error2 = new System.Windows.Forms.Label();
            this.Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anket
            // 
            this.Anket.Controls.Add(this.deyis);
            this.Anket.Controls.Add(this.error);
            this.Anket.Controls.Add(this.btn_save);
            this.Anket.Controls.Add(this.dogumtxt);
            this.Anket.Controls.Add(this.labeldogum);
            this.Anket.Controls.Add(this.telefontxt);
            this.Anket.Controls.Add(this.labelphone);
            this.Anket.Controls.Add(this.emailtxt);
            this.Anket.Controls.Add(this.labelemail);
            this.Anket.Controls.Add(this.soyadtxt);
            this.Anket.Controls.Add(this.labelsoyad);
            this.Anket.Controls.Add(this.adtxt);
            this.Anket.Controls.Add(this.labelad);
            this.Anket.Location = new System.Drawing.Point(12, 12);
            this.Anket.Name = "Anket";
            this.Anket.Size = new System.Drawing.Size(306, 455);
            this.Anket.TabIndex = 0;
            this.Anket.TabStop = false;
            this.Anket.Text = "Anket";
            this.Anket.Enter += new System.EventHandler(this.Anket_Enter);
            // 
            // deyis
            // 
            this.deyis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deyis.Location = new System.Drawing.Point(162, 337);
            this.deyis.Name = "deyis";
            this.deyis.Size = new System.Drawing.Size(138, 49);
            this.deyis.TabIndex = 12;
            this.deyis.Text = "Save";
            this.deyis.UseVisualStyleBackColor = true;
            this.deyis.Visible = false;
            this.deyis.Click += new System.EventHandler(this.deyis_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(25, 334);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(41, 20);
            this.error.TabIndex = 11;
            this.error.Text = "error";
            this.error.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save.Location = new System.Drawing.Point(162, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(138, 49);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Əlavə et";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dogumtxt
            // 
            this.dogumtxt.Location = new System.Drawing.Point(87, 282);
            this.dogumtxt.Name = "dogumtxt";
            this.dogumtxt.Size = new System.Drawing.Size(172, 29);
            this.dogumtxt.TabIndex = 9;
            this.dogumtxt.Text = "";
            // 
            // labeldogum
            // 
            this.labeldogum.AutoSize = true;
            this.labeldogum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldogum.Location = new System.Drawing.Point(16, 278);
            this.labeldogum.Name = "labeldogum";
            this.labeldogum.Size = new System.Drawing.Size(78, 28);
            this.labeldogum.TabIndex = 8;
            this.labeldogum.Text = "Doğum";
            // 
            // telefontxt
            // 
            this.telefontxt.Location = new System.Drawing.Point(87, 225);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(172, 29);
            this.telefontxt.TabIndex = 7;
            this.telefontxt.Text = "";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelphone.Location = new System.Drawing.Point(16, 221);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(74, 28);
            this.labelphone.TabIndex = 6;
            this.labelphone.Text = "Telefon";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(87, 164);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(172, 29);
            this.emailtxt.TabIndex = 5;
            this.emailtxt.Text = "";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelemail.Location = new System.Drawing.Point(16, 160);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(59, 28);
            this.labelemail.TabIndex = 4;
            this.labelemail.Text = "Email";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(87, 108);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(172, 29);
            this.soyadtxt.TabIndex = 3;
            this.soyadtxt.Text = "";
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsoyad.Location = new System.Drawing.Point(16, 104);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(67, 28);
            this.labelsoyad.TabIndex = 2;
            this.labelsoyad.Text = "Soyad";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(87, 50);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(172, 29);
            this.adtxt.TabIndex = 1;
            this.adtxt.Text = "";
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelad.Location = new System.Drawing.Point(16, 46);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(37, 28);
            this.labelad.TabIndex = 0;
            this.labelad.Text = "Ad";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(342, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 304);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_load_file
            // 
            this.btn_load_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_load_file.Location = new System.Drawing.Point(342, 418);
            this.btn_load_file.Name = "btn_load_file";
            this.btn_load_file.Size = new System.Drawing.Size(138, 49);
            this.btn_load_file.TabIndex = 11;
            this.btn_load_file.Text = "Load";
            this.btn_load_file.UseVisualStyleBackColor = true;
            this.btn_load_file.Click += new System.EventHandler(this.btn_load_file_Click);
            // 
            // btn_save_file
            // 
            this.btn_save_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_save_file.Location = new System.Drawing.Point(486, 418);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(138, 49);
            this.btn_save_file.TabIndex = 12;
            this.btn_save_file.Text = "Save";
            this.btn_save_file.UseVisualStyleBackColor = true;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // filename
            // 
            this.filename.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filename.Location = new System.Drawing.Point(404, 349);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(200, 36);
            this.filename.TabIndex = 13;
            this.filename.Text = "";
            this.filename.TextChanged += new System.EventHandler(this.filename_TextChanged);
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_file.Location = new System.Drawing.Point(324, 349);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(74, 28);
            this.label_file.TabIndex = 11;
            this.label_file.Text = "File adı";
            // 
            // error2
            // 
            this.error2.AutoSize = true;
            this.error2.ForeColor = System.Drawing.Color.Red;
            this.error2.Location = new System.Drawing.Point(342, 395);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(49, 20);
            this.error2.TabIndex = 12;
            this.error2.Text = "error2";
            this.error2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 479);
            this.Controls.Add(this.error2);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.btn_load_file);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Anket);
            this.Name = "Form1";
            this.Text = "Anket";
            this.Anket.ResumeLayout(false);
            this.Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Anket;
        private RichTextBox dogumtxt;
        private Label labeldogum;
        private RichTextBox telefontxt;
        private Label labelphone;
        private RichTextBox emailtxt;
        private Label labelemail;
        private RichTextBox soyadtxt;
        private Label labelsoyad;
        private RichTextBox adtxt;
        private Label labelad;
        private Button btn_save;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private Button btn_load_file;
        private Button btn_save_file;
        private RichTextBox filename;
        private Label label_file;
        private Label error;
        private Label error2;
        private Button deyis;
    }
}