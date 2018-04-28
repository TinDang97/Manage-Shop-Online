//
namespace DXApplication1
{
    partial class AddCustomer
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
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lastname = new DevExpress.XtraEditors.TextEdit();
            this.firstname = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.email = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.birth = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.gender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.addess = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.province = new DevExpress.XtraEditors.ComboBoxEdit();
            this.district = new DevExpress.XtraEditors.ComboBoxEdit();
            this.country = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.avatar = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lastname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.province.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.district.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.country.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(564, 309);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 23);
            this.simpleButton7.TabIndex = 22;
            this.simpleButton7.Text = "Đồng ý";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(437, 309);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Huỷ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(107, 95);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(196, 20);
            this.lastname.TabIndex = 3;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(107, 67);
            this.firstname.Name = "firstname";
            this.firstname.Properties.Mask.EditMask = "###0,###0";
            this.firstname.Size = new System.Drawing.Size(196, 20);
            this.firstname.TabIndex = 2;
            // 
            // password
            // 
            this.password.EditValue = "";
            this.password.Location = new System.Drawing.Point(107, 41);
            this.password.Name = "password";
            this.password.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.password.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.password.Properties.Name = "price";
            this.password.Properties.PasswordChar = '*';
            this.password.Properties.UseSystemPasswordChar = true;
            this.password.Size = new System.Drawing.Size(196, 20);
            this.password.TabIndex = 1;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(107, 12);
            this.username.Name = "username";
            this.username.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.username.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.username.Size = new System.Drawing.Size(196, 20);
            this.username.TabIndex = 0;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(83, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Tên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(88, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Họ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Mật khẩu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Tài khoản:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(77, 124);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 13);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(107, 121);
            this.email.Name = "email";
            this.email.Properties.Leave += new System.EventHandler(this.textEdit1_Properties_Leave);
            this.email.Size = new System.Drawing.Size(196, 20);
            this.email.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(54, 174);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 13);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Ngày sinh:";
            // 
            // birth
            // 
            this.birth.EditValue = null;
            this.birth.Location = new System.Drawing.Point(107, 171);
            this.birth.Name = "birth";
            this.birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birth.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birth.Properties.EditFormat.FormatString = "";
            this.birth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.birth.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.birth.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.birth.Properties.EditValueChanged += new System.EventHandler(this.textEdit2_Properties_EditValueChanged);
            this.birth.Size = new System.Drawing.Size(196, 20);
            this.birth.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(63, 200);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 13);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "Giới tính:";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(107, 197);
            this.gender.Name = "gender";
            this.gender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gender.Size = new System.Drawing.Size(196, 20);
            this.gender.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(40, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Số điện thoại:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(107, 145);
            this.phone.Name = "phone";
            this.phone.Properties.Mask.EditMask = "\\d?\\d?\\d? \\d\\d\\d \\d\\d\\d\\d+";
            this.phone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.phone.Size = new System.Drawing.Size(196, 20);
            this.phone.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(60, 236);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Quốc gia:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(20, 262);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 13);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Thành phố (Tỉnh):";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(33, 288);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Quận (Huyện):";
            // 
            // addess
            // 
            this.addess.Location = new System.Drawing.Point(107, 311);
            this.addess.Name = "addess";
            this.addess.Size = new System.Drawing.Size(196, 20);
            this.addess.TabIndex = 11;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(70, 314);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 13);
            this.labelControl12.TabIndex = 34;
            this.labelControl12.Text = "Địa chỉ:";
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(107, 259);
            this.province.Name = "province";
            this.province.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.province.Properties.SelectedIndexChanged += new System.EventHandler(this.province_Properties_SelectedIndexChanged);
            this.province.Size = new System.Drawing.Size(196, 20);
            this.province.TabIndex = 9;
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(107, 285);
            this.district.Name = "district";
            this.district.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.district.Size = new System.Drawing.Size(196, 20);
            this.district.TabIndex = 10;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(107, 233);
            this.country.Name = "country";
            this.country.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.country.Properties.SelectedIndexChanged += new System.EventHandler(this.country_Properties_SelectedIndexChanged);
            this.country.Size = new System.Drawing.Size(196, 20);
            this.country.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(309, 231);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(24, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "+";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(309, 195);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(24, 23);
            this.simpleButton3.TabIndex = 12;
            this.simpleButton3.Text = "+";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(309, 257);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(24, 23);
            this.simpleButton4.TabIndex = 16;
            this.simpleButton4.Text = "+";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(309, 283);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(24, 23);
            this.simpleButton5.TabIndex = 18;
            this.simpleButton5.Text = "+";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(339, 195);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(24, 23);
            this.simpleButton6.TabIndex = 13;
            this.simpleButton6.Text = "-";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(339, 231);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(24, 23);
            this.simpleButton8.TabIndex = 15;
            this.simpleButton8.Text = "-";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(339, 257);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(24, 23);
            this.simpleButton9.TabIndex = 17;
            this.simpleButton9.Text = "-";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(339, 283);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(24, 23);
            this.simpleButton10.TabIndex = 19;
            this.simpleButton10.Text = "-";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // avatar
            // 
            this.avatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.avatar.EditValue = global::DXApplication1.Properties.Resources.add21;
            this.avatar.Location = new System.Drawing.Point(395, 15);
            this.avatar.Name = "avatar";
            this.avatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.avatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.avatar.Size = new System.Drawing.Size(274, 263);
            this.avatar.TabIndex = 20;
            this.avatar.ToolTip = "Chọn để thêm ảnh";
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 357);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.addess);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.username);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.province);
            this.Controls.Add(this.district);
            this.Controls.Add(this.country);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm người dùng";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lastname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.province.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.district.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.country.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit avatar;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit lastname;
        private DevExpress.XtraEditors.TextEdit firstname;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.TextEdit username;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit email;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit birth;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit gender;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit phone;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit addess;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit province;
        private DevExpress.XtraEditors.ComboBoxEdit district;
        private DevExpress.XtraEditors.ComboBoxEdit country;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
    }
}