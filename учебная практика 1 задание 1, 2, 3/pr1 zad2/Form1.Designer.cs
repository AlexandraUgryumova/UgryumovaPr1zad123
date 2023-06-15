
namespace pr1_zad2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.prib_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.kol1_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sale_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kol2_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteSong_btn = new System.Windows.Forms.Button();
            this.ClearPlaylist_btn = new System.Windows.Forms.Button();
            this.StartPlaylist_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Next_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 732);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.prib_lbl);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.kol1_txt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.sale_txt);
            this.tabPage1.Controls.Add(this.name_txt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.kol2_txt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(612, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "задание 2";
            // 
            // prib_lbl
            // 
            this.prib_lbl.AutoSize = true;
            this.prib_lbl.Location = new System.Drawing.Point(454, 425);
            this.prib_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prib_lbl.Name = "prib_lbl";
            this.prib_lbl.Size = new System.Drawing.Size(18, 20);
            this.prib_lbl.TabIndex = 14;
            this.prib_lbl.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(45, 611);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "добавить товар";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kol1_txt
            // 
            this.kol1_txt.Location = new System.Drawing.Point(45, 571);
            this.kol1_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kol1_txt.Name = "kol1_txt";
            this.kol1_txt.Size = new System.Drawing.Size(192, 26);
            this.kol1_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 546);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 486);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "цена";
            // 
            // sale_txt
            // 
            this.sale_txt.Location = new System.Drawing.Point(45, 511);
            this.sale_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sale_txt.Name = "sale_txt";
            this.sale_txt.Size = new System.Drawing.Size(192, 26);
            this.sale_txt.TabIndex = 9;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(45, 451);
            this.name_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(192, 26);
            this.name_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "название товара";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(374, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "купить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kol2_txt
            // 
            this.kol2_txt.Location = new System.Drawing.Point(374, 512);
            this.kol2_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kol2_txt.Name = "kol2_txt";
            this.kol2_txt.Size = new System.Drawing.Size(180, 26);
            this.kol2_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 488);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "количество товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "прибыль";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(374, 451);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(45, 77);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 320);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "список товаров";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Ivory;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.DeleteSong_btn);
            this.tabPage2.Controls.Add(this.ClearPlaylist_btn);
            this.tabPage2.Controls.Add(this.StartPlaylist_btn);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.Next_btn);
            this.tabPage2.Controls.Add(this.Back_btn);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(612, 699);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "задание 3";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // DeleteSong_btn
            // 
            this.DeleteSong_btn.BackColor = System.Drawing.Color.Moccasin;
            this.DeleteSong_btn.Enabled = false;
            this.DeleteSong_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSong_btn.Location = new System.Drawing.Point(72, 518);
            this.DeleteSong_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteSong_btn.Name = "DeleteSong_btn";
            this.DeleteSong_btn.Size = new System.Drawing.Size(200, 35);
            this.DeleteSong_btn.TabIndex = 6;
            this.DeleteSong_btn.Text = "удалить песню";
            this.DeleteSong_btn.UseVisualStyleBackColor = false;
            this.DeleteSong_btn.Click += new System.EventHandler(this.DeleteSong_btn_Click);
            // 
            // ClearPlaylist_btn
            // 
            this.ClearPlaylist_btn.BackColor = System.Drawing.Color.Moccasin;
            this.ClearPlaylist_btn.Enabled = false;
            this.ClearPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearPlaylist_btn.Location = new System.Drawing.Point(72, 472);
            this.ClearPlaylist_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearPlaylist_btn.Name = "ClearPlaylist_btn";
            this.ClearPlaylist_btn.Size = new System.Drawing.Size(200, 35);
            this.ClearPlaylist_btn.TabIndex = 5;
            this.ClearPlaylist_btn.Text = "очистить плейлист";
            this.ClearPlaylist_btn.UseVisualStyleBackColor = false;
            this.ClearPlaylist_btn.Click += new System.EventHandler(this.ClearPlaylist_btn_Click);
            // 
            // StartPlaylist_btn
            // 
            this.StartPlaylist_btn.BackColor = System.Drawing.Color.Moccasin;
            this.StartPlaylist_btn.Enabled = false;
            this.StartPlaylist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartPlaylist_btn.Location = new System.Drawing.Point(72, 426);
            this.StartPlaylist_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPlaylist_btn.Name = "StartPlaylist_btn";
            this.StartPlaylist_btn.Size = new System.Drawing.Size(200, 35);
            this.StartPlaylist_btn.TabIndex = 4;
            this.StartPlaylist_btn.Text = "вернуться в начало";
            this.StartPlaylist_btn.UseVisualStyleBackColor = false;
            this.StartPlaylist_btn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(357, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 346);
            this.panel1.TabIndex = 3;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_btn.Location = new System.Drawing.Point(10, 285);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(213, 35);
            this.Add_btn.TabIndex = 7;
            this.Add_btn.Text = "добавить";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(10, 217);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "путь до муз файла";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "название песни";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "автор песни";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "добавить песню";
            // 
            // Next_btn
            // 
            this.Next_btn.BackColor = System.Drawing.Color.Moccasin;
            this.Next_btn.Enabled = false;
            this.Next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next_btn.Location = new System.Drawing.Point(280, 426);
            this.Next_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(48, 85);
            this.Next_btn.TabIndex = 2;
            this.Next_btn.Text = ">>";
            this.Next_btn.UseVisualStyleBackColor = false;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Moccasin;
            this.Back_btn.Enabled = false;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back_btn.Location = new System.Drawing.Point(15, 426);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(48, 85);
            this.Back_btn.TabIndex = 1;
            this.Back_btn.Text = "<<";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(12, 68);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(316, 340);
            this.listBox2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "играет песня:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(620, 732);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "задание 2 и 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kol1_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sale_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kol2_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label prib_lbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Next_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button DeleteSong_btn;
        private System.Windows.Forms.Button ClearPlaylist_btn;
        private System.Windows.Forms.Button StartPlaylist_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

