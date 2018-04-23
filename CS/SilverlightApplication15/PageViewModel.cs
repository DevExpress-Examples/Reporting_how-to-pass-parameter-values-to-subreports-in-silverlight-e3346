using System.ComponentModel;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightApplication15 {
    public partial class PageViewModel : INotifyPropertyChanged {
        public ReportServicePreviewModel ReportPreviewModel { get; private set; }
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
            ReportPreviewModel = new ReportServicePreviewModel("../ReportService1.svc") {
                ReportName = "SilverlightApplication15.Web.MasterReport, SilverlightApplication15.Web"
            };
            RecreateDocument = new DelegateCommand(ReportPreviewModel.CreateDocument);
        }
    }
}
