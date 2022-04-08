namespace Categorias
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.ListBoxSubcateg = new System.Windows.Forms.ListBox();
            this.txtCateg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnAddCateg = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSubcateg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSubcateg = new Bunifu.Framework.UI.BunifuImageButton();
            this.somaDataSet = new Categorias.somaDataSet();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Categorias.somaDataSetTableAdapters.categoriasTableAdapter();
            this.somaDataSet1 = new Categorias.somaDataSet1();
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter1 = new Categorias.somaDataSet1TableAdapters.categoriasTableAdapter();
            this.categoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCategParaSubcateg = new System.Windows.Forms.ComboBox();
            this.categoriasTableAdapter2 = new Categorias.somaDataSetTableAdapters.categoriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCateg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubcateg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCateg.TabIndex = 0;
            this.comboBoxCateg.SelectedIndexChanged += new System.EventHandler(this.comboBoxCateg_SelectedIndexChanged);
            // 
            // ListBoxSubcateg
            // 
            this.ListBoxSubcateg.FormattingEnabled = true;
            this.ListBoxSubcateg.Location = new System.Drawing.Point(12, 42);
            this.ListBoxSubcateg.Name = "ListBoxSubcateg";
            this.ListBoxSubcateg.Size = new System.Drawing.Size(180, 277);
            this.ListBoxSubcateg.TabIndex = 1;
            // 
            // txtCateg
            // 
            this.txtCateg.BackColor = System.Drawing.Color.White;
            this.txtCateg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCateg.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCateg.ForeColor = System.Drawing.Color.Black;
            this.txtCateg.HintForeColor = System.Drawing.Color.Empty;
            this.txtCateg.HintText = "Cadastrar categoria";
            this.txtCateg.isPassword = false;
            this.txtCateg.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCateg.LineIdleColor = System.Drawing.Color.Aqua;
            this.txtCateg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCateg.LineThickness = 2;
            this.txtCateg.Location = new System.Drawing.Point(200, 42);
            this.txtCateg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCateg.Name = "txtCateg";
            this.txtCateg.Size = new System.Drawing.Size(207, 25);
            this.txtCateg.TabIndex = 2;
            this.txtCateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddCateg
            // 
            this.btnAddCateg.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAddCateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCateg.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCateg.Image")));
            this.btnAddCateg.ImageActive = null;
            this.btnAddCateg.Location = new System.Drawing.Point(407, 42);
            this.btnAddCateg.Name = "btnAddCateg";
            this.btnAddCateg.Size = new System.Drawing.Size(26, 25);
            this.btnAddCateg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddCateg.TabIndex = 3;
            this.btnAddCateg.TabStop = false;
            this.btnAddCateg.Zoom = 10;
            this.btnAddCateg.Click += new System.EventHandler(this.btnAddCateg_Click);
            // 
            // txtSubcateg
            // 
            this.txtSubcateg.BackColor = System.Drawing.Color.White;
            this.txtSubcateg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubcateg.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubcateg.ForeColor = System.Drawing.Color.Black;
            this.txtSubcateg.HintForeColor = System.Drawing.Color.Empty;
            this.txtSubcateg.HintText = "Cadastrar Subcategoria";
            this.txtSubcateg.isPassword = false;
            this.txtSubcateg.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSubcateg.LineIdleColor = System.Drawing.Color.Aqua;
            this.txtSubcateg.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSubcateg.LineThickness = 2;
            this.txtSubcateg.Location = new System.Drawing.Point(200, 138);
            this.txtSubcateg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSubcateg.Name = "txtSubcateg";
            this.txtSubcateg.Size = new System.Drawing.Size(233, 25);
            this.txtSubcateg.TabIndex = 4;
            this.txtSubcateg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSubcateg
            // 
            this.btnSubcateg.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSubcateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubcateg.Image = ((System.Drawing.Image)(resources.GetObject("btnSubcateg.Image")));
            this.btnSubcateg.ImageActive = null;
            this.btnSubcateg.Location = new System.Drawing.Point(407, 179);
            this.btnSubcateg.Name = "btnSubcateg";
            this.btnSubcateg.Size = new System.Drawing.Size(26, 25);
            this.btnSubcateg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSubcateg.TabIndex = 6;
            this.btnSubcateg.TabStop = false;
            this.btnSubcateg.Zoom = 10;
            this.btnSubcateg.Click += new System.EventHandler(this.btnSubcateg_Click);
            // 
            // somaDataSet
            // 
            this.somaDataSet.DataSetName = "somaDataSet";
            this.somaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.somaDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // somaDataSet1
            // 
            this.somaDataSet1.DataSetName = "somaDataSet1";
            this.somaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataMember = "categorias";
            this.categoriasBindingSource1.DataSource = this.somaDataSet1;
            // 
            // categoriasTableAdapter1
            // 
            this.categoriasTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriasBindingSource2
            // 
            this.categoriasBindingSource2.DataMember = "categorias";
            this.categoriasBindingSource2.DataSource = this.somaDataSet;
            // 
            // cbxCategParaSubcateg
            // 
            this.cbxCategParaSubcateg.FormattingEnabled = true;
            this.cbxCategParaSubcateg.Location = new System.Drawing.Point(200, 179);
            this.cbxCategParaSubcateg.Name = "cbxCategParaSubcateg";
            this.cbxCategParaSubcateg.Size = new System.Drawing.Size(201, 21);
            this.cbxCategParaSubcateg.TabIndex = 7;
            // 
            // categoriasTableAdapter2
            // 
            this.categoriasTableAdapter2.ClearBeforeFill = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Categorias.Properties.Resources.icons8_categorize_96px_1;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.cbxCategParaSubcateg);
            this.Controls.Add(this.btnSubcateg);
            this.Controls.Add(this.txtSubcateg);
            this.Controls.Add(this.btnAddCateg);
            this.Controls.Add(this.txtCateg);
            this.Controls.Add(this.ListBoxSubcateg);
            this.Controls.Add(this.comboBoxCateg);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Category";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCateg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubcateg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCateg;
        private System.Windows.Forms.ListBox ListBoxSubcateg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCateg;
        private Bunifu.Framework.UI.BunifuImageButton btnAddCateg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSubcateg;
        private Bunifu.Framework.UI.BunifuImageButton btnSubcateg;
        private somaDataSet somaDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private somaDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private somaDataSet1 somaDataSet1;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private somaDataSet1TableAdapters.categoriasTableAdapter categoriasTableAdapter1;
        private System.Windows.Forms.BindingSource categoriasBindingSource2;
        private System.Windows.Forms.ComboBox cbxCategParaSubcateg;
        private somaDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter2;
    }
}

