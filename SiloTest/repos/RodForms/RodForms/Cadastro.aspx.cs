using RodForms.Model;
using RodForms.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RodForms
{
    public partial class Cadastro : System.Web.UI.Page
    {
        private ChocRepository repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.repository = new ChocRepository();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Choc model = new Choc();
            model.Id = Convert.ToInt32(this.txtId.Text);
            model.Nome = this.txtNome.Text;
            model.Tipo = this.txtTipo.Text;
            model.Gramagem = Convert.ToInt32(this.txtGra.Text);
            repository.Salvar(model);
            limparCampo();
            
        }

        protected void limparCampo()
        {
            this.txtId.Text = String.Empty;
            this.txtNome.Text = String.Empty;
            this.txtTipo.Text = String.Empty;
            this.txtGra.Text = String.Empty;
        }
    }
}