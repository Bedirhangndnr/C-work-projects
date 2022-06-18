
namespace denemesudoku
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
            this.components = new System.ComponentModel.Container();
            this.play_btn = new System.Windows.Forms.Button();
            this.warning_lbl = new System.Windows.Forms.Label();
            this.try_lbl = new System.Windows.Forms.Label();
            this.number_bx = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.success_or_not_lbl = new System.Windows.Forms.Label();
            this.easy_btn_ = new System.Windows.Forms.RadioButton();
            this.medium_btn_ = new System.Windows.Forms.RadioButton();
            this.hard_btn_ = new System.Windows.Forms.RadioButton();
            this.username_txtbx_ = new System.Windows.Forms.TextBox();
            this.user_btn = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.time_lbl_ = new System.Windows.Forms.Label();
            this.score_lbl_ = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.id_lbl_ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.arrengement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(626, 278);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(75, 23);
            this.play_btn.TabIndex = 3;
            this.play_btn.Text = "PLAY";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // warning_lbl
            // 
            this.warning_lbl.AutoSize = true;
            this.warning_lbl.Location = new System.Drawing.Point(623, 318);
            this.warning_lbl.Name = "warning_lbl";
            this.warning_lbl.Size = new System.Drawing.Size(0, 13);
            this.warning_lbl.TabIndex = 4;
            // 
            // try_lbl
            // 
            this.try_lbl.AutoSize = true;
            this.try_lbl.Location = new System.Drawing.Point(623, 340);
            this.try_lbl.Name = "try_lbl";
            this.try_lbl.Size = new System.Drawing.Size(47, 13);
            this.try_lbl.TabIndex = 5;
            this.try_lbl.Text = "Number:";
            // 
            // number_bx
            // 
            this.number_bx.Location = new System.Drawing.Point(676, 337);
            this.number_bx.Name = "number_bx";
            this.number_bx.Size = new System.Drawing.Size(25, 20);
            this.number_bx.TabIndex = 6;
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(626, 363);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 23);
            this.enter_btn.TabIndex = 7;
            this.enter_btn.Text = "ENTER";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // success_or_not_lbl
            // 
            this.success_or_not_lbl.AutoSize = true;
            this.success_or_not_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success_or_not_lbl.Location = new System.Drawing.Point(640, 404);
            this.success_or_not_lbl.Name = "success_or_not_lbl";
            this.success_or_not_lbl.Size = new System.Drawing.Size(0, 25);
            this.success_or_not_lbl.TabIndex = 8;
            // 
            // easy_btn_
            // 
            this.easy_btn_.AutoSize = true;
            this.easy_btn_.Location = new System.Drawing.Point(626, 207);
            this.easy_btn_.Name = "easy_btn_";
            this.easy_btn_.Size = new System.Drawing.Size(48, 17);
            this.easy_btn_.TabIndex = 9;
            this.easy_btn_.TabStop = true;
            this.easy_btn_.Text = "Easy";
            this.easy_btn_.UseVisualStyleBackColor = true;
            this.easy_btn_.CheckedChanged += new System.EventHandler(this.easy_btn__CheckedChanged);
            // 
            // medium_btn_
            // 
            this.medium_btn_.AutoSize = true;
            this.medium_btn_.Location = new System.Drawing.Point(626, 230);
            this.medium_btn_.Name = "medium_btn_";
            this.medium_btn_.Size = new System.Drawing.Size(62, 17);
            this.medium_btn_.TabIndex = 10;
            this.medium_btn_.TabStop = true;
            this.medium_btn_.Text = "Medium";
            this.medium_btn_.UseVisualStyleBackColor = true;
            this.medium_btn_.CheckedChanged += new System.EventHandler(this.medium_btn__CheckedChanged);
            // 
            // hard_btn_
            // 
            this.hard_btn_.AutoSize = true;
            this.hard_btn_.Location = new System.Drawing.Point(626, 253);
            this.hard_btn_.Name = "hard_btn_";
            this.hard_btn_.Size = new System.Drawing.Size(48, 17);
            this.hard_btn_.TabIndex = 11;
            this.hard_btn_.TabStop = true;
            this.hard_btn_.Text = "Hard";
            this.hard_btn_.UseVisualStyleBackColor = true;
            this.hard_btn_.CheckedChanged += new System.EventHandler(this.hard_btn__CheckedChanged);
            // 
            // username_txtbx_
            // 
            this.username_txtbx_.Location = new System.Drawing.Point(612, 68);
            this.username_txtbx_.Name = "username_txtbx_";
            this.username_txtbx_.Size = new System.Drawing.Size(100, 20);
            this.username_txtbx_.TabIndex = 12;
            // 
            // user_btn
            // 
            this.user_btn.AutoSize = true;
            this.user_btn.Location = new System.Drawing.Point(609, 52);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(55, 13);
            this.user_btn.TabIndex = 13;
            this.user_btn.Text = "Username";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Location = new System.Drawing.Point(609, 100);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(35, 13);
            this.score_lbl.TabIndex = 14;
            this.score_lbl.Text = "Score";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(666, 100);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(30, 13);
            this.time_lbl.TabIndex = 15;
            this.time_lbl.Text = "Time";
            // 
            // time_lbl_
            // 
            this.time_lbl_.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.time_lbl_.Location = new System.Drawing.Point(661, 127);
            this.time_lbl_.Name = "time_lbl_";
            this.time_lbl_.Size = new System.Drawing.Size(35, 13);
            this.time_lbl_.TabIndex = 17;
            // 
            // score_lbl_
            // 
            this.score_lbl_.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.score_lbl_.Location = new System.Drawing.Point(609, 127);
            this.score_lbl_.Name = "score_lbl_";
            this.score_lbl_.Size = new System.Drawing.Size(35, 13);
            this.score_lbl_.TabIndex = 18;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(714, 100);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(16, 13);
            this.id_lbl.TabIndex = 19;
            this.id_lbl.Text = "Id";
            // 
            // id_lbl_
            // 
            this.id_lbl_.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.id_lbl_.Location = new System.Drawing.Point(714, 127);
            this.id_lbl_.Name = "id_lbl_";
            this.id_lbl_.Size = new System.Drawing.Size(35, 13);
            this.id_lbl_.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // arrengement
            // 
            this.arrengement.Location = new System.Drawing.Point(626, 415);
            this.arrengement.Name = "arrengement";
            this.arrengement.Size = new System.Drawing.Size(162, 23);
            this.arrengement.TabIndex = 21;
            this.arrengement.Text = "arrengement/sırlama";
            this.arrengement.UseVisualStyleBackColor = true;
            this.arrengement.Click += new System.EventHandler(this.arrengement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrengement);
            this.Controls.Add(this.id_lbl_);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.score_lbl_);
            this.Controls.Add(this.time_lbl_);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.score_lbl);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.username_txtbx_);
            this.Controls.Add(this.hard_btn_);
            this.Controls.Add(this.medium_btn_);
            this.Controls.Add(this.easy_btn_);
            this.Controls.Add(this.success_or_not_lbl);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.number_bx);
            this.Controls.Add(this.try_lbl);
            this.Controls.Add(this.warning_lbl);
            this.Controls.Add(this.play_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Label warning_lbl;
        private System.Windows.Forms.Label try_lbl;
        private System.Windows.Forms.TextBox number_bx;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label success_or_not_lbl;
        private System.Windows.Forms.RadioButton easy_btn_;
        private System.Windows.Forms.RadioButton medium_btn_;
        private System.Windows.Forms.RadioButton hard_btn_;
        private System.Windows.Forms.TextBox username_txtbx_;
        private System.Windows.Forms.Label user_btn;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label time_lbl_;
        private System.Windows.Forms.Label score_lbl_;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label id_lbl_;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button arrengement;
    }
}

