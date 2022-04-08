using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorias
{
    public partial class Category : Form
    {
        Operacoes op = new Operacoes();
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {

            op.sendToCombo(comboBoxCateg, cbxCategParaSubcateg);
        }

        private void btnAddCateg_Click(object sender, EventArgs e)
        {
            try
            {
    op.addCategoria(txtCateg);
            op.sendToCombo(comboBoxCateg, cbxCategParaSubcateg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo vazio, preencha o campo categoria", "Nulo", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            
        }

        private void comboBoxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            op.sentToListBox(ListBoxSubcateg, comboBoxCateg);
            
        }

        private void btnSubcateg_Click(object sender, EventArgs e)
        {
            try{
        op.addSubCateg(txtSubcateg, cbxCategParaSubcateg);
            }catch(ArgumentNullException)
            {
                MessageBox.Show("ID inexistente, insira um id válido", "ID invalido", MessageBoxButtons.OK
                   , MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                 MessageBox.Show("Registrou-se campos vazios ou caracteres nulos, adicione caracteres validos", "Campos e caracteres nulos", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
           
           
        }
    }
}
