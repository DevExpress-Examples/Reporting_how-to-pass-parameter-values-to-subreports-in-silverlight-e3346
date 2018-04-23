using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Input;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightApplication15 {
    public partial class PageViewModel : INotifyPropertyChanged {
        public ReportPreviewModel ReportPreviewModel { get; private set; }
        public ICommand RecreateDocument { get; private set; }

        public string SubreportParameter {
            get {
                var param = ReportPreviewModel.Parameters["xrSubreport1.parameter1"];
                return param != null ? (string)param.Value : string.Empty;
            }
            set {
                ReportPreviewModel.Parameters["xrSubreport1.parameter1"].Value = value;
                RaisePropertyChanged("SubreportParameter");
            }
        }

        public PageViewModel() {
            RecreateDocument = new DelegateCommand<object>(DoRecreateDocument);
            ReportPreviewModel = new ReportPreviewModel("../ReportService1.svc") {
                ReportName = "SilverlightApplication15.Web.MasterReport, SilverlightApplication15.Web"
            };
        }

        void DoRecreateDocument(object o) {
            ReportPreviewModel.CreateDocument();
        }
    }
}
