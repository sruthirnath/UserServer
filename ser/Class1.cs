using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ser
{
    public class Class1:CompositeControl
    {
        Label Label1;
        TextBox txt;
        ImageButton imgbutn;
        Calendar calender;


        protected override void CreateChildControls()
        {
            Controls.Clear();
            Label1 = new Label();
            Label1.ID = "lblDisplay";

            txt = new TextBox();
            txt.ID = "txtHolder";
            txt.Width = Unit.Pixel(100);

            imgbutn = new ImageButton();
            imgbutn.ID = "imgCalender";
            imgbutn.Height = Unit.Pixel(30);

            calender = new Calendar();
            calender.ID = "calDate";

            this.Controls.Add(Label1);
            this.Controls.Add(txt);
            this.Controls.Add(imgbutn);
            this.Controls.Add(calender);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Label1.RenderControl(writer);
            txt.RenderControl(writer);
            imgbutn.RenderControl(writer);
            calender.RenderControl(writer);
        }

    }
}
