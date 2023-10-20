namespace CalculoQuadrado.View
{
    partial class FormularioQuadrado
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
            tbx_Valor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_Resultado = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // tbx_Valor
            // 
            tbx_Valor.Location = new Point(362, 120);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(299, 23);
            tbx_Valor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Symap_IV25", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(775, 97);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Cálculo Quadrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Symeteo_IV25", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(186, 117);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 2;
            label2.Text = "DIGITE O  VALOR:";
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = SystemColors.MenuHighlight;
            lbl_Resultado.Font = new Font("Showcard Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(189, 218);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(472, 197);
            lbl_Resultado.TabIndex = 3;
            lbl_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Calcular
            // 
            btn_Calcular.AutoSize = true;
            btn_Calcular.BackColor = Color.Transparent;
            btn_Calcular.Font = new Font("Syastro_IV25", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(189, 169);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(472, 28);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormularioQuadrado
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_Valor);
            KeyPreview = true;
            Name = "FormularioQuadrado";
            ShowIcon = false;
            Text = "SCQ -  Sistema de Cálculo Quadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_Valor;
        private Label label1;
        private Label label2;
        private Label lbl_Resultado;
        private Button btn_Calcular;
    }
}