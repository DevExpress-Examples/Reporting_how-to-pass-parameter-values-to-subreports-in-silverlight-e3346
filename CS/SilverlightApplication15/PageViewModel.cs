using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Input;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
// ...

namespace SilverlightApplication15 {
    public class PageViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public ReportPreviewModel ReportPreviewModel { get; private set; }
        public string SubreportParameter {
            get {
                var param = ReportPreviewModel.Parameters["xrSubreport1.parameter1"];
                return param != null ? (string)param.Value : null;
            }
            set {
                ReportPreviewModel.Parameters["xrSubreport1.parameter1"].Value = value;
                RaiseSubreportParameterPropertyChanged();
            }
        }
        public ICommand RecreateDocument { get; private set; }

        public PageViewModel() {
            RecreateDocument = new DelegateCommand(DoRecreateDocument, () => true);
            ReportPreviewModel = new ReportPreviewModel("../ReportService1.svc") {
                ReportName = "SilverlightApplication15.Web.MasterReport"
            };
            ReportPreviewModel.RequestDefaultParameterValues += ReportPreviewModel_RequestDefaultParameterValues;
        }

        void ReportPreviewModel_RequestDefaultParameterValues(object sender, EventArgs e) {
            RaiseSubreportParameterPropertyChanged();
        }

        void DoRecreateDocument() {
            ReportPreviewModel.CreateDocument();
        }

        void RaisePropertyChanged<T>(Expression<Func<T>> property) {
            PropertyExtensions.RaisePropertyChanged(this, PropertyChanged, property);
        }

        void RaiseSubreportParameterPropertyChanged() {
            RaisePropertyChanged(() => SubreportParameter);
        }
    }
}
