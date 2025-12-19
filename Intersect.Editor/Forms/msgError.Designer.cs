namespace Intersect.Editor.Forms
{

    partial class msgError
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
            btnErrorOk = new DarkUI.Controls.DarkButton();
            ErrorMSG = new Label();
            ErrorMsgBox = new RichTextBox();
            SuspendLayout();
            // 
            // btnErrorOk
            // 
            btnErrorOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnErrorOk.DialogResult = DialogResult.Cancel;
            btnErrorOk.Location = new System.Drawing.Point(304, 383);
            btnErrorOk.Margin = new Padding(4, 3, 4, 3);
            btnErrorOk.Name = "btnErrorOk";
            btnErrorOk.Padding = new Padding(6);
            btnErrorOk.Size = new Size(144, 30);
            btnErrorOk.TabIndex = 10;
            btnErrorOk.Text = "Ok";
            btnErrorOk.Click += btnErrorOk_Click;
            // 
            // ErrorMSG
            // 
            ErrorMSG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ErrorMSG.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ErrorMSG.ForeColor = System.Drawing.Color.White;
            ErrorMSG.ImageAlign = ContentAlignment.TopLeft;
            ErrorMSG.Location = new System.Drawing.Point(12, 9);
            ErrorMSG.Name = "ErrorMSG";
            ErrorMSG.Size = new Size(436, 40);
            ErrorMSG.TabIndex = 11;
            ErrorMSG.Text = "The Intersect Editor has encountered an error and must close. Error information can be found in logs/errors.log";
            ErrorMSG.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ErrorMsgBox
            // 
            ErrorMsgBox.BackColor = System.Drawing.Color.FromArgb(69, 73, 74);
            ErrorMsgBox.BorderStyle = BorderStyle.None;
            ErrorMsgBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ErrorMsgBox.ForeColor = System.Drawing.Color.Gainsboro;
            ErrorMsgBox.Location = new System.Drawing.Point(12, 52);
            ErrorMsgBox.Name = "ErrorMsgBox";
            ErrorMsgBox.ReadOnly = true;
            ErrorMsgBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            ErrorMsgBox.Size = new Size(436, 325);
            ErrorMsgBox.TabIndex = 12;
            ErrorMsgBox.Text = "";
            // 
            // msgError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            ClientSize = new Size(461, 425);
            Controls.Add(ErrorMsgBox);
            Controls.Add(ErrorMSG);
            Controls.Add(btnErrorOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "msgError";
            Text = "msgError";
            ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkButton btnErrorOk;
        private System.Windows.Forms.Label ErrorMSG;
        public System.Windows.Forms.RichTextBox ErrorMsgBox;
    }
}