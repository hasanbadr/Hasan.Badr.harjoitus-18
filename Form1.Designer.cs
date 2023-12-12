namespace Hasan.Badr.harjoitus18
{
    partial class AvainhenkilotForm
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
            label1 = new Label();
            label2 = new Label();
            OppilaitosCB = new ComboBox();
            VastuuhenkilöCB = new ComboBox();
            label3 = new Label();
            OsoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            PuhLB = new Label();
            SähköpostiLB = new Label();
            OsastoLB = new Label();
            TitteliLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(606, 65);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 85);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 1;
            label2.Text = "Valitse Oppilaitos";
            // 
            // OppilaitosCB
            // 
            OppilaitosCB.FormattingEnabled = true;
            OppilaitosCB.Location = new Point(15, 133);
            OppilaitosCB.Name = "OppilaitosCB";
            OppilaitosCB.Size = new Size(130, 23);
            OppilaitosCB.TabIndex = 2;
            OppilaitosCB.SelectedIndexChanged += OppilaitosCB_SelectedIndexChanged;
            // 
            // VastuuhenkilöCB
            // 
            VastuuhenkilöCB.FormattingEnabled = true;
            VastuuhenkilöCB.Location = new Point(325, 133);
            VastuuhenkilöCB.Name = "VastuuhenkilöCB";
            VastuuhenkilöCB.Size = new Size(156, 23);
            VastuuhenkilöCB.TabIndex = 4;
            VastuuhenkilöCB.TabStopChanged += VastuuhenkilöCB_TabStopChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(325, 85);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 3;
            label3.Text = "Valitse vastuuhenkilö";
            // 
            // OsoiteLB
            // 
            OsoiteLB.AutoSize = true;
            OsoiteLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OsoiteLB.Location = new Point(15, 183);
            OsoiteLB.Name = "OsoiteLB";
            OsoiteLB.Size = new Size(55, 21);
            OsoiteLB.TabIndex = 5;
            OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PostinumeroLB.Location = new Point(15, 231);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(98, 21);
            PostinumeroLB.TabIndex = 6;
            PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PostitoimipaikkaLB.Location = new Point(15, 279);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(124, 21);
            PostitoimipaikkaLB.TabIndex = 7;
            PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PuhelinLB.Location = new Point(15, 327);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(62, 21);
            PuhelinLB.TabIndex = 8;
            PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            PuhLB.AutoSize = true;
            PuhLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PuhLB.Location = new Point(325, 327);
            PuhLB.Name = "PuhLB";
            PuhLB.Size = new Size(62, 21);
            PuhLB.TabIndex = 12;
            PuhLB.Text = "Puhelin";
            // 
            // SähköpostiLB
            // 
            SähköpostiLB.AutoSize = true;
            SähköpostiLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SähköpostiLB.Location = new Point(325, 279);
            SähköpostiLB.Name = "SähköpostiLB";
            SähköpostiLB.Size = new Size(87, 21);
            SähköpostiLB.TabIndex = 11;
            SähköpostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            OsastoLB.AutoSize = true;
            OsastoLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OsastoLB.Location = new Point(325, 231);
            OsastoLB.Name = "OsastoLB";
            OsastoLB.Size = new Size(58, 21);
            OsastoLB.TabIndex = 10;
            OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            TitteliLB.AutoSize = true;
            TitteliLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitteliLB.Location = new Point(325, 183);
            TitteliLB.Name = "TitteliLB";
            TitteliLB.Size = new Size(48, 21);
            TitteliLB.TabIndex = 9;
            TitteliLB.Text = "Titteli";
            // 
            // AvainhenkilotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 385);
            Controls.Add(PuhLB);
            Controls.Add(SähköpostiLB);
            Controls.Add(OsastoLB);
            Controls.Add(TitteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(OsoiteLB);
            Controls.Add(VastuuhenkilöCB);
            Controls.Add(label3);
            Controls.Add(OppilaitosCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AvainhenkilotForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Oppilaitosten avainhenkilöt";
            Load += AvainhenkilotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox OppilaitosCB;
        private ComboBox VastuuhenkilöCB;
        private Label label3;
        private Label OsoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label PuhLB;
        private Label SähköpostiLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}