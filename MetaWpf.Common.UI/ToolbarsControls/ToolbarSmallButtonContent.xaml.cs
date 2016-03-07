using System.Windows.Media;

namespace MetaWpf.Common.UI.ToolbarsControls
{
    /// <summary>
    /// Interaction logic for ToolbarSmallButtonContent.xaml
    /// </summary>
    public partial class ToolbarSmallButtonContent
    {
        public ToolbarSmallButtonContent()
        {
            this.InitializeComponent();
        }

        public Geometry PathData
        {
            set { this.IconPath.Data = value; }
        }
    }
}
