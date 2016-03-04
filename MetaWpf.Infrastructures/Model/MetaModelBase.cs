using System.Windows;
using System.ComponentModel;

namespace MetaWpf.Infrastructures.Model
{
    public abstract class MetaModelBase : DependencyObject, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region OnPropertyChanged
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion
    }
}
