
namespace GestionStock
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFiltre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.Location = new System.Drawing.Point(814, 12);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(174, 58);
            this.btnAfficher.TabIndex = 0;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(32, 429);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 82;
            this.grd.RowTemplate.Height = 33;
            this.grd.Size = new System.Drawing.Size(923, 390);
            this.grd.TabIndex = 1;
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(32, 380);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(294, 33);
            this.cmb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libelle :";
            // 
            // txtLib
            // 
            this.txtLib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLib.Location = new System.Drawing.Point(169, 54);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(236, 44);
            this.txtLib.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "PU :";
            // 
            // txtPU
            // 
            this.txtPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPU.Location = new System.Drawing.Point(169, 119);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(236, 44);
            this.txtPU.TabIndex = 4;
            this.txtPU.TextChanged += new System.EventHandler(this.txtPU_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtPU);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLib);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 236);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel article :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Aqua;
            this.btnAjouter.Location = new System.Drawing.Point(486, 168);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 51);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Visible = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(647, 380);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(308, 31);
            this.txtFiltre.TabIndex = 6;
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 841);
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btnAfficher);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txtFiltre;
    }
}

