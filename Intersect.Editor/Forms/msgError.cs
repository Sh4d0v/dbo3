using Intersect.Editor.Core;
using Intersect.Editor.Localization;
using Intersect.Utilities;

namespace Intersect.Editor.Forms;
public partial class msgError : Form
{
    public msgError()
    {
        InitializeComponent();
    }
    private void msgError_Load(object sender, EventArgs e)
    {
        InitLocalization();
    }

    private void btnErrorOk_Click(object sender, EventArgs e)
    {
        Environment.Exit(1);
    }

    private void InitLocalization()
    {
        Text = Strings.ErrorWindow.title;
        btnErrorOk.Text = Strings.ErrorWindow.okay;
        ErrorMsgBox.Text = "";
    }

}
