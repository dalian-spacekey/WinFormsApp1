using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;

namespace WinFormsApp1ContextMenu
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    public class SampleMenu : SharpContextMenu
    {
        protected override bool CanShowMenu() => true;

        protected override ContextMenuStrip CreateMenu()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add(new ToolStripMenuItem("さんぷる"));
            menu.Items.Add(new ToolStripSeparator());
            return menu;
        }
    }
}
