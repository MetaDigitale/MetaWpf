using System.Windows.Media;

namespace MetaWpf.Common.UI.ToolbarsControls
{
    /// <summary>
    /// Interaction logic for ToolbarButtonContent.xaml
    /// </summary>
    public partial class ToolbarButtonContent
    {
        public ToolbarButtonContent()
        {
            this.InitializeComponent();
        }

        public Geometry PathData
        {
            set { this.IconPath.Data = value; }
        }
    }
}
