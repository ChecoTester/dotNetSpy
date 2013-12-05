using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using System.Windows.Forms;

namespace dotNetSpy
{
    public partial class MainForm : Form
    {
        private List<AutomationElement> _stack = new List<AutomationElement>();
        ElementExplorer _current = new ElementExplorer();
        ElementExplorer _child = new ElementExplorer();
        List<Tuple<string, AutomationElement>> _currentChildren = new List<Tuple<string,AutomationElement>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private bool openElement(AutomationElement element)
        {
            _current.SetElement(element);
            try
            {
                _currentChildren = _current.GetChildren();
                listChildren.Items.Clear();
                foreach (var childRecord in _currentChildren)
                    listChildren.Items.Add(childRecord.Item1);
            }
            catch
            {
                MessageBox.Show("Unable to open selected element");
                return false;
            }
            return true;
        }

        private void chainElement(AutomationElement element)
        {
            _stack.Add(element);
            openElement(element);
            enableButtons();
        }

        private void openRoot()
        {
            _stack.Clear();
            chainElement(AutomationElement.RootElement);
        }

        private void showProperties(AutomationElement element)
        {
            _child.SetElement(element);
            Dictionary<string, string> props = _child.GetProperties();
            listProperties.Items.Clear();
            listProperties.Items.AddRange(props
                .Select(kvp => 
                    new ListViewItem(new string[] { kvp.Key, kvp.Value }))
                .ToArray());
        }

        private void enableButtons()
        {
            tbBack.Enabled = (_stack.Count > 1);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            openRoot();
        }

        private void tbGoToRoot_Click(object sender, EventArgs e)
        {
            openRoot();
        }

        private void tbBack_Click(object sender, EventArgs e)
        {
            int lastIndex = _stack.Count - 1;
            if (lastIndex > 0)
            {
                if (openElement(_stack[lastIndex - 1]))
                    _stack.RemoveAt(lastIndex);
            }
            enableButtons();
        }

        private void listChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listChildren.SelectedIndex;
            if ((i >= 0) && (i < _currentChildren.Count))
                showProperties(_currentChildren[i].Item2);
        }

        private void listChildren_DoubleClick(object sender, EventArgs e)
        {
            int i = listChildren.SelectedIndex;
            if ((i >= 0) && (i < _currentChildren.Count))
                chainElement(_currentChildren[i].Item2);
        }

    }
}
