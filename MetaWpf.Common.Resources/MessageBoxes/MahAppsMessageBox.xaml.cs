using System;
using System.Windows;
using System.Windows.Input;

namespace MetaWpf.Common.Resources.MessageBoxes
{
    /// <summary>
    /// Interaction logic for MahAppsMessageBox.xaml
    /// </summary>
    public partial class MahAppsMessageBox
    {
        private MessageBoxButton _buttons = MessageBoxButton.OK;
        private MessageBoxResult _result = MessageBoxResult.None;

        public MahAppsMessageBox()
        {
            this.InitializeComponent();
        }

        #region internal Properties
        internal MessageBoxButton Buttons
        {
            get { return this._buttons; }
            set
            {
                this._buttons = value;
                // Set all Buttons Visibility Properties
                this.SetButtonsVisibility();
            }
        }

        internal MessageBoxResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }
        #endregion

        #region SetButtonsVisibility Method
        internal void SetButtonsVisibility()
        {
            switch (this._buttons)
            {
                case MessageBoxButton.OK:
                    this.btnOk.Visibility = Visibility.Visible;
                    this.btnCancel.Visibility = Visibility.Collapsed;
                    this.btnYes.Visibility = Visibility.Collapsed;
                    this.btnNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxButton.OKCancel:
                    this.btnOk.Visibility = Visibility.Visible;
                    this.btnCancel.Visibility = Visibility.Visible;
                    this.btnYes.Visibility = Visibility.Collapsed;
                    this.btnNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxButton.YesNo:
                    this.btnOk.Visibility = Visibility.Collapsed;
                    this.btnCancel.Visibility = Visibility.Collapsed;
                    this.btnYes.Visibility = Visibility.Visible;
                    this.btnNo.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNoCancel:
                    this.btnOk.Visibility = Visibility.Collapsed;
                    this.btnCancel.Visibility = Visibility.Visible;
                    this.btnYes.Visibility = Visibility.Visible;
                    this.btnNo.Visibility = Visibility.Visible;
                    break;
            }
        }
        #endregion

        #region Button Click Events
        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            this.Result = MessageBoxResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Result = MessageBoxResult.No;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Result = MessageBoxResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Result = MessageBoxResult.OK;
            this.Close();
        }
        #endregion

        public MessageBoxResult Show(string message)
        {
            return this.Show(message, string.Empty, MessageBoxButton.OK);
        }

        public MessageBoxResult Show(string message, string caption)
        {
            return this.Show(message, caption, MessageBoxButton.OK);
        }

        public MessageBoxResult Show(string message, string caption, MessageBoxButton buttons)
        {
            var result = MessageBoxResult.None;

            this.title.Text = caption;
            this.tbMessage.Text = message;
            this.Buttons = buttons;
            // If just an OK button, allow the user to just move away from the dialog
            if (buttons == MessageBoxButton.OK)
                this.ShowDialog();
            else
            {
                this.ShowDialog();
                result = this.Result;
            }

            return result;
        }
    }
}
