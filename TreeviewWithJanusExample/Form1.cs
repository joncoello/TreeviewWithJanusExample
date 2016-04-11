using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeviewWithJanusExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitGrid();
            GetData();

        }

        private void InitGrid()
        {
            GridEXColumn col;
            var rt = new GridEXTable();
            rt.HierarchicalMode = HierarchicalMode.SelfReferencingChildList;
            rt.SelfReferencingSettings.ChildListMember = "Items";

            col = rt.Columns.Add("Selected");
            col.EditType = EditType.CheckBox;
            col.ColumnType = ColumnType.CheckBox;
                        
            col = rt.Columns.Add("Name");

            gridEX1.RootTable = rt;
            gridEX1.Hierarchical = true;
            gridEX1.ColumnHeaders = InheritableBoolean.False;
            gridEX1.VisualStyle = VisualStyle.Office2010;
            gridEX1.GroupByBoxVisible = false;
            gridEX1.UpdateMode = UpdateMode.CellUpdate;



        }

        private void GetData()
        {
            var repo = new WorkingPaperConfigItemRepo();
            var items = repo.GetItems();

            gridEX1.SetDataBinding(items, string.Empty);

            gridEX1.ExpandRecords();
        }
        
        private void gridEX1_UpdatingCell(object sender, UpdatingCellEventArgs e)
        {
            //var item = gridEX1.GetRow().DataRow as WorkingPaperConfigItem;
            //if (e.Value == null)
            //{
            //    e.Value = true;
            //}
        }

        private void gridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
        {

        }

        private void gridEX1_EditingCell(object sender, EditingCellEventArgs e)
        {

        }

        private void gridEX1_MouseClick(object sender, MouseEventArgs e)
        {
            gridEX1.UpdateData();
        }

        private void gridEX1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void gridEX1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gridEX1.UpdateData();
            }
        }
    }
}
