using System.ComponentModel;
using MetaWpf.Infrastructures.Abstracts;

namespace MetaWpf.Infrastructures
{
    public abstract class ViewModel : IViewModel, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        protected void InvokePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
