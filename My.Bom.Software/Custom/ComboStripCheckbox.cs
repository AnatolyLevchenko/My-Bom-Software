using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace My.Bom.Software.Custom
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip |
                                       ToolStripItemDesignerAvailability.ContextMenuStrip |
                                       ToolStripItemDesignerAvailability.StatusStrip)]
    public class ComboStripCheckbox : ToolStripControlHost
    {
        public event EventHandler<bool> CheckedChanged;
        private readonly CheckBox _box;

        public ComboStripCheckbox()
            : base(new CheckBox())
        {
            Font = Constants.BoldHeaderFont;
            _box = Control as CheckBox;

            if (_box != null)
                _box.CheckedChanged += BoxOnCheckedChanged;
        }

        private void BoxOnCheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(this, _box.Checked);
        }

        [Browsable(true)]
        public bool Checked {
            get {
                if (_box == null)
                    return false;
                return _box.Checked;
            }
            set {
                if (_box != null)
                    _box.Checked = value;
            }
        }
    }
}
