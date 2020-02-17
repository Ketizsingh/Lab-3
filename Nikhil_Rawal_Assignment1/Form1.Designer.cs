namespace Nikhil_Rawal_Assignment1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.address = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.hotelname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.postalcode = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.noofguests = new System.Windows.Forms.ComboBox();
            this.Info = new System.Windows.Forms.Label();
            this.arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.arrivallabel = new System.Windows.Forms.Label();
            this.stay = new System.Windows.Forms.NumericUpDown();
            this.staylabel = new System.Windows.Forms.Label();
            this.infopanel = new System.Windows.Forms.Panel();
            this.resetbutton = new System.Windows.Forms.Button();
            this.noofpersonslabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stay)).BeginInit();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.Silver;
            this.address.Location = new System.Drawing.Point(7, 79);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(146, 22);
            this.address.TabIndex = 4;
            this.address.Text = "Street Address";
            this.address.Enter += new System.EventHandler(this.address_Enter);
            this.address.Leave += new System.EventHandler(this.address_Leave);
            // 
            // province
            // 
            this.province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province.ForeColor = System.Drawing.Color.Silver;
            this.province.Location = new System.Drawing.Point(67, 107);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(86, 22);
            this.province.TabIndex = 7;
            this.province.Text = "Province";
            this.province.Enter += new System.EventHandler(this.province_Enter);
            this.province.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.province_KeyPress);
            this.province.Leave += new System.EventHandler(this.province_Leave);
            // 
            // title
            // 
            this.title.AcceptsTab = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Silver;
            this.title.Location = new System.Drawing.Point(7, 51);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(54, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            this.title.Enter += new System.EventHandler(this.title_Enter);
            this.title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_KeyPress);
            this.title.Leave += new System.EventHandler(this.title_Leave);
            // 
            // hotelname
            // 
            this.hotelname.AutoSize = true;
            this.hotelname.BackColor = System.Drawing.Color.Transparent;
            this.hotelname.CausesValidation = false;
            this.hotelname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotelname.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelname.ForeColor = System.Drawing.Color.Gold;
            this.hotelname.Location = new System.Drawing.Point(252, 9);
            this.hotelname.Name = "hotelname";
            this.hotelname.Size = new System.Drawing.Size(196, 35);
            this.hotelname.TabIndex = 0;
            this.hotelname.Text = "Ceaser\'s Palace";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(7, 135);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 22);
            this.email.TabIndex = 9;
            this.email.Text = "Email ID";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            this.email.Validated += new System.EventHandler(this.email_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.Silver;
            this.phone.Location = new System.Drawing.Point(159, 134);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(119, 22);
            this.phone.TabIndex = 10;
            this.phone.Text = "Phone Number";
            this.phone.Enter += new System.EventHandler(this.phone_Enter);
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // lname
            // 
            this.lname.AcceptsTab = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Silver;
            this.lname.Location = new System.Drawing.Point(159, 50);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(119, 22);
            this.lname.TabIndex = 3;
            this.lname.Text = "Last Name";
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lname_KeyPress);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // fname
            // 
            this.fname.AcceptsTab = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Silver;
            this.fname.Location = new System.Drawing.Point(67, 51);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(86, 22);
            this.fname.TabIndex = 2;
            this.fname.Text = "First Name";
            this.fname.Enter += new System.EventHandler(this.fname_Enter);
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fname_KeyPress);
            this.fname.Leave += new System.EventHandler(this.fname_Leave);
            // 
            // postalcode
            // 
            this.postalcode.AccessibleName = "Postal Code";
            this.postalcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalcode.ForeColor = System.Drawing.Color.Silver;
            this.postalcode.Location = new System.Drawing.Point(159, 78);
            this.postalcode.Name = "postalcode";
            this.postalcode.Size = new System.Drawing.Size(119, 22);
            this.postalcode.TabIndex = 5;
            this.postalcode.Text = "Postal Code";
            this.postalcode.Enter += new System.EventHandler(this.postalcode_Enter);
            this.postalcode.Leave += new System.EventHandler(this.postalcode_Leave);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.ForeColor = System.Drawing.Color.Silver;
            this.city.Location = new System.Drawing.Point(7, 107);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(54, 22);
            this.city.TabIndex = 6;
            this.city.Text = "City";
            this.city.Enter += new System.EventHandler(this.city_Enter);
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_KeyPress);
            this.city.Leave += new System.EventHandler(this.city_Leave);
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.Silver;
            this.country.Location = new System.Drawing.Point(159, 106);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(119, 22);
            this.country.TabIndex = 8;
            this.country.Text = "Country";
            this.country.Enter += new System.EventHandler(this.country_Enter);
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
            this.country.Leave += new System.EventHandler(this.country_Leave);
            // 
            // noofguests
            // 
            this.noofguests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofguests.ForeColor = System.Drawing.Color.Black;
            this.noofguests.FormattingEnabled = true;
            this.noofguests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.noofguests.Location = new System.Drawing.Point(159, 163);
            this.noofguests.Name = "noofguests";
            this.noofguests.Size = new System.Drawing.Size(119, 24);
            this.noofguests.TabIndex = 11;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Info.Location = new System.Drawing.Point(6, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(215, 24);
            this.Info.TabIndex = 0;
            this.Info.Text = "Your Information Here";
            // 
            // arrivaldate
            // 
            this.arrivaldate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivaldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivaldate.Location = new System.Drawing.Point(140, 192);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(138, 22);
            this.arrivaldate.TabIndex = 12;
            this.arrivaldate.Value = new System.DateTime(2020, 2, 13, 23, 13, 2, 0);
            // 
            // arrivallabel
            // 
            this.arrivallabel.AutoSize = true;
            this.arrivallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivallabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arrivallabel.Location = new System.Drawing.Point(7, 194);
            this.arrivallabel.Name = "arrivallabel";
            this.arrivallabel.Size = new System.Drawing.Size(138, 16);
            this.arrivallabel.TabIndex = 0;
            this.arrivallabel.Text = "Arrival Date and Time";
            // 
            // stay
            // 
            this.stay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stay.Location = new System.Drawing.Point(159, 220);
            this.stay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stay.Name = "stay";
            this.stay.Size = new System.Drawing.Size(119, 22);
            this.stay.TabIndex = 13;
            this.stay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // staylabel
            // 
            this.staylabel.AutoSize = true;
            this.staylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staylabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.staylabel.Location = new System.Drawing.Point(7, 222);
            this.staylabel.Name = "staylabel";
            this.staylabel.Size = new System.Drawing.Size(76, 16);
            this.staylabel.TabIndex = 0;
            this.staylabel.Text = "Nights Stay";
            // 
            // infopanel
            // 
            this.infopanel.BackColor = System.Drawing.Color.Transparent;
            this.infopanel.Controls.Add(this.resetbutton);
            this.infopanel.Controls.Add(this.noofpersonslabel);
            this.infopanel.Controls.Add(this.submit);
            this.infopanel.Controls.Add(this.lname);
            this.infopanel.Controls.Add(this.Info);
            this.infopanel.Controls.Add(this.stay);
            this.infopanel.Controls.Add(this.email);
            this.infopanel.Controls.Add(this.staylabel);
            this.infopanel.Controls.Add(this.city);
            this.infopanel.Controls.Add(this.arrivaldate);
            this.infopanel.Controls.Add(this.province);
            this.infopanel.Controls.Add(this.arrivallabel);
            this.infopanel.Controls.Add(this.phone);
            this.infopanel.Controls.Add(this.noofguests);
            this.infopanel.Controls.Add(this.country);
            this.infopanel.Controls.Add(this.postalcode);
            this.infopanel.Controls.Add(this.fname);
            this.infopanel.Controls.Add(this.address);
            this.infopanel.Controls.Add(this.title);
            this.infopanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infopanel.Location = new System.Drawing.Point(12, 47);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(281, 288);
            this.infopanel.TabIndex = 0;
            // 
            // resetbutton
            // 
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(7, 248);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(119, 36);
            this.resetbutton.TabIndex = 15;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // noofpersonslabel
            // 
            this.noofpersonslabel.AutoSize = true;
            this.noofpersonslabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noofpersonslabel.Location = new System.Drawing.Point(7, 166);
            this.noofpersonslabel.Name = "noofpersonslabel";
            this.noofpersonslabel.Size = new System.Drawing.Size(115, 16);
            this.noofpersonslabel.TabIndex = 0;
            this.noofpersonslabel.Text = "Number of Guests";
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(159, 248);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 36);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // descriptionbox
            // 
            this.descriptionbox.BackColor = System.Drawing.Color.Transparent;
            this.descriptionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionbox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.descriptionbox.Location = new System.Drawing.Point(452, 47);
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(200, 284);
            this.descriptionbox.TabIndex = 0;
            this.descriptionbox.TabStop = false;
            this.descriptionbox.Text = resources.GetString("descriptionbox.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Nikhil_Rawal_Assignment1.Properties.Resources.Black_bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 369);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotelname);
            this.Controls.Add(this.infopanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "My_Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.stay)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label hotelname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox postalcode;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.ComboBox noofguests;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.DateTimePicker arrivaldate;
        private System.Windows.Forms.Label arrivallabel;
        private System.Windows.Forms.NumericUpDown stay;
        private System.Windows.Forms.Label staylabel;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label noofpersonslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox descriptionbox;
        private System.Windows.Forms.Button resetbutton;
    }
}

