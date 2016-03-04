using System.ComponentModel;
using MetaWpf.Infrastructures.Abstracts;

namespace MetaWpf.Infrastructures
{
    public class RegionModel : IRegion, INotifyPropertyChanged
    {
        private IViewModel context;

        public IViewModel Context
        {
            get { return this.context; }
            set
            {
                this.context = value;
                this.InvokePropertyChanged("Context");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void InvokePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
