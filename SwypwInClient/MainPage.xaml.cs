using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwypwInClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = (Application.Current as App).SwypeChat;
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {            
            (Application.Current as App).Broadcast(new ChatMessage { Username = name.Text, Message = text.Text });
           // Frame.Navigate(typeof(Page2));
        }
    }
}
