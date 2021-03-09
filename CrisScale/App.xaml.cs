using System;
using System.Windows;

namespace CrisScale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Dispatcher.UnhandledException += OnDispatcherUnhandledException;
        }

        private void OnDispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string errorMessage = string.Format("An unhandled exception occurred: {0}", e.Exception.Message);
            MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            // OR whatever you want like logging etc. MessageBox it's just example
            // for quick debugging etc.
            e.Handled = true;
            App.Current.Shutdown();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

            MainWindow wnd = new MainWindow();

            if (e.Args.Length == 2)
            {
                int tip = 0;
                tip = Int32.TryParse(e.Args[1].ToString(), out tip) ? tip : 0;
                if (tip == 1)
                {
                    wnd.comanda.NumePo = e.Args[0];
                    wnd.GetComandaAchizitie();
                    wnd.tabComandaAchizitie.IsSelected = true;
                    wnd.tabAeBrut.IsEnabled = false;
                }

                if (tip == 2)
                {
                    wnd.aviz.NumeSh = e.Args[0];
                    wnd.GetAvizBrut();
                    wnd.tabAeBrut.IsSelected = true;
                    wnd.tabComandaAchizitie.IsEnabled = false;

                }



            }
            wnd.Show();
        }

    }
}

