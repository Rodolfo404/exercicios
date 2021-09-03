using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RodForms.Repository;

namespace RodForms
{
    public partial class Lista : System.Web.UI.Page
    {
        private ChocRepository repository;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.repository = new ChocRepository();
            this.dgChoc.DataSource = repository.Listar();
            this.dgChoc.DataBind();

        }
    }
}