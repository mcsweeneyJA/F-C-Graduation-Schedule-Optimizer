using System.Windows;
using System.Reactive.Linq;

namespace QUT
{
    public partial class WizardProgress : Window
    {
        private ViewModel viewModel;
        public WizardProgress(ViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
        }

        private async void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            await viewModel.CancelWizard.Execute();
            Close();
        }
    }
}
