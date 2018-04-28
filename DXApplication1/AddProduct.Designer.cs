//ádadsasdasd
namespace DXApplication1
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.name = new DevExpress.XtraEditors.TextEdit();
            this.price = new DevExpress.XtraEditors.TextEdit();
            this.quantity = new DevExpress.XtraEditors.TextEdit();
            this.content = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.colorsBox = new System.Windows.Forms.ComboBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.CatogoryBox = new System.Windows.Forms.ComboBox();
            this.Countrybox = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.content.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Tên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Giá:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Số lượng:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Nội dung:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(51, 128);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Màu:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(38, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Kích cỡ:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 183);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Danh mục:";
            this.labelControl7.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(28, 211);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Sản xuất:";
            this.labelControl8.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(196, 20);
            this.name.TabIndex = 0;
            // 
            // price
            // 
            this.price.EditValue = "";
            this.price.Location = new System.Drawing.Point(81, 41);
            this.price.Name = "price";
            this.price.Properties.Mask.EditMask = "###0,###0,###0.###0";
            this.price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.price.Properties.Name = "price";
            this.price.Size = new System.Drawing.Size(196, 20);
            this.price.TabIndex = 1;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(81, 67);
            this.quantity.Name = "quantity";
            this.quantity.Properties.Mask.EditMask = "###0,###0";
            this.quantity.Size = new System.Drawing.Size(196, 20);
            this.quantity.TabIndex = 2;
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(81, 95);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(196, 20);
            this.content.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(391, 247);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Huỷ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // colorsBox
            // 
            this.colorsBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.colorsBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.colorsBox.BackColor = System.Drawing.SystemColors.Window;
            this.colorsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorsBox.FormattingEnabled = true;
            this.colorsBox.Location = new System.Drawing.Point(81, 124);
            this.colorsBox.Name = "colorsBox";
            this.colorsBox.Size = new System.Drawing.Size(195, 21);
            this.colorsBox.TabIndex = 4;
            this.colorsBox.SelectedIndexChanged += new System.EventHandler(this.colorsBox_SelectedIndexChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(81, 151);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(195, 21);
            this.sizeBox.TabIndex = 5;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // CatogoryBox
            // 
            this.CatogoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatogoryBox.FormattingEnabled = true;
            this.CatogoryBox.Location = new System.Drawing.Point(82, 180);
            this.CatogoryBox.Name = "CatogoryBox";
            this.CatogoryBox.Size = new System.Drawing.Size(195, 21);
            this.CatogoryBox.TabIndex = 6;
            this.CatogoryBox.SelectedIndexChanged += new System.EventHandler(this.CatogoryBox_SelectedIndexChanged);
            // 
            // Countrybox
            // 
            this.Countrybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countrybox.FormattingEnabled = true;
            this.Countrybox.Location = new System.Drawing.Point(82, 207);
            this.Countrybox.Name = "Countrybox";
            this.Countrybox.Size = new System.Drawing.Size(195, 21);
            this.Countrybox.TabIndex = 7;
            this.Countrybox.SelectedIndexChanged += new System.EventHandler(this.Countrybox_SelectedIndexChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(283, 123);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(23, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "+";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(283, 152);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(23, 23);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "+";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(283, 178);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(23, 23);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "+";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(283, 205);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(23, 23);
            this.simpleButton5.TabIndex = 12;
            this.simpleButton5.Text = "+";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(283, 94);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(23, 23);
            this.simpleButton6.TabIndex = 13;
            this.simpleButton6.Text = "+";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.EditValue = global::DXApplication1.Properties.Resources.add21;
            this.pictureBox.Location = new System.Drawing.Point(350, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureBox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureBox.Size = new System.Drawing.Size(253, 215);
            this.pictureBox.TabIndex = 18;
            this.pictureBox.ToolTip = "Chọn để thêm ảnh";
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(494, 247);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 23);
            this.simpleButton7.TabIndex = 8;
            this.simpleButton7.Text = "Đồng ý";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 282);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Countrybox);
            this.Controls.Add(this.CatogoryBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.colorsBox);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.addProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.content.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit name;
        private DevExpress.XtraEditors.TextEdit price;
        private DevExpress.XtraEditors.TextEdit quantity;
        private DevExpress.XtraEditors.TextEdit content;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox colorsBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ComboBox CatogoryBox;
        private System.Windows.Forms.ComboBox Countrybox;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.PictureEdit pictureBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}