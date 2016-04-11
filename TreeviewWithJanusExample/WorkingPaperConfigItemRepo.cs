using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeviewWithJanusExample
{
    class WorkingPaperConfigItemRepo
    {
        public BindingList<WorkingPaperConfigItem> GetItems()
        {
            var root = new WorkingPaperConfigItem()
            {
                Selected = false,
                Name = "Root"
            };

            root.Items.Add(new WorkingPaperConfigItem() { Selected = false, Name = "General" });
            root.Items.Add(new WorkingPaperConfigItem() { Selected = false, Name = "Members' Report" });

            return new BindingList<WorkingPaperConfigItem>() {
              root  
            };

        }
    }
}
