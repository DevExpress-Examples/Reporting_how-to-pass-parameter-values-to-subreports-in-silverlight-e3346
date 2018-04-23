using System.ComponentModel;

namespace SilverlightApplication15 {
    public partial class PageViewModel {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string propertyName) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
