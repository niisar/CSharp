using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Text.RegularExpressions;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        var sourcestring = t1.Text;
        var lowerCase = sourcestring.ToLower();
        var r = new Regex(@"(^[a-z])|\.\s+(.)", RegexOptions.ExplicitCapture);
        int x =Regex.Matches(sourcestring, @"(^[a-z])|\.\s+(.)").Count;
        var result = r.Replace(lowerCase, s => s.Value.ToUpper());
        t2.Text = result;
        btn.Text = x.ToString();
    }
}