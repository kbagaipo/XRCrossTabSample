using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XRCrossTabSample
{
    public partial class XRCrossTab : DevExpress.XtraEditors.XtraForm
    {
        List<People> peopleList = new List<People>();

        public XRCrossTab()
        {
            InitializeComponent();
            
            peopleList.Add(new People {
                Name = "Name1",
                Sex = "Male"
            });
            peopleList.Add(new People
            {
                Name = "Name2",
                Sex = "Male"
            });
            peopleList.Add(new People
            {
                Name = "Name3",
                Sex = "Male"
            });
            peopleList.Add(new People
            {
                Name = "Name4",
                Sex = "Male"
            });
            peopleList.Add(new People
            {
                Name = "Name5",
                Sex = "Male"
            });
            peopleList.Add(new People
            {
                Name = "Name6",
                Sex = "Female"
            });
            peopleList.Add(new People
            {
                Name = "Name7",
                Sex = "Female"
            });
            peopleList.Add(new People
            {
                Name = "Name8",
                Sex = "Female"
            });
            peopleList.Add(new People
            {
                Name = "Name9",
                Sex = "Female"
            });
            peopleList.Add(new People
            {
                Name = "Name10",
                Sex = "Female"
            });

           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 xtraReport1 = new XtraReport1();
            xtraReport1.RequestParameters = false;
            xtraReport1.DataSource = peopleList;
            ReportPrintTool tool = new ReportPrintTool(xtraReport1);
            tool.ShowPreviewDialog();
        }
    }
}
