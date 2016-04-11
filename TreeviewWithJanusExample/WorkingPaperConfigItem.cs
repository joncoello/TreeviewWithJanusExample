using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeviewWithJanusExample
{
    class WorkingPaperConfigItem : INotifyPropertyChanged
    {

        private bool _processEvents = true;

        private bool? _selected;
        public bool? Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                FirePropertyChanged("Selected");
            }
        }
        public string Name { get; set; }

        public WorkingPaperConfigItemCollection Items { get; private set; }

        public WorkingPaperConfigItem()
        {
            Items = new WorkingPaperConfigItemCollection();
            Items.ListChanged += Items_ListChanged;
            PropertyChanged += WorkingPaperConfigItem_PropertyChanged;
        }

        private void WorkingPaperConfigItem_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Selected")
            {
                if (Selected != null)
                {
                    _processEvents = false;
                    Items.ToList().ForEach(i => i.Selected = Selected);
                    _processEvents = true;
                }
            }
        }

        private void Items_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (_processEvents)
            {
                if (e.ListChangedType == ListChangedType.ItemChanged)
                {

                    var count = Items.Count(i => i.Selected == null || i.Selected.Value);

                    if (count == Items.Count)
                    {
                        Selected = true;
                    }
                    else if (count == 0)
                    {
                        Selected = false;
                    }
                    else
                    {
                        Selected = null;
                    }

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
