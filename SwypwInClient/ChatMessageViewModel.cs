using System.Collections.ObjectModel;

namespace SwypwInClient
{
    class ChatMessageViewModel
    {
        public ObservableCollection<ChatMessage> Messages { get; set; } = new ObservableCollection<ChatMessage>();        
    }
}
