using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserServer
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now;
            }

        }
        private string Name;

        public string DisplayName
        {
            get { return Name; }
            set { Label1.Text = value; }
        }
        public DateTime GetDate

        {
            get { return Calendar1.SelectedDate; }

        }
        public bool disablefuturedates;

        public bool DisableFutureDates
        {
            set { disablefuturedates = value; }

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString();
            Calendar1.Visible = false;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (disablefuturedates & e.Day.Date > DateTime.Now)
                e.Day.IsSelectable = false;
        }
    }
}