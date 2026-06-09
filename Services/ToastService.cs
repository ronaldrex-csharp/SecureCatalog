using SecureCatalog.Models;

namespace SecureCatalog.Services;

public class ToastService
{
    public event Action<ToastMessage>? OnShow;

    public void ShowToast(string message, string type = "success")
    {
        OnShow?.Invoke(new ToastMessage
        {
            Message = message,
            Type = type
        });
    }
}