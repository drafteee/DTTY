using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation.Collections;

namespace TimeTrackingYoutrack.Services
{
    public class NotificationService
    {
        public NotificationService()
        {
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                if (toastArgs is ToastNotificationActivatedEventArgsCompat toastActivationArgs)
                {
                    // Obtain the arguments from the notification
                    ToastArguments args = ToastArguments.Parse(toastActivationArgs.Argument);

                    // Obtain any user input (text boxes, menu selections) from the notification
                    ValueSet userInput = toastActivationArgs.UserInput;

                    // TODO:
                }
            };
        }

        public void Show()
        {
            int taskId = 9813;

            new ToastContentBuilder()
                .AddArgument("taskId", taskId)
                .AddText("Запущен таймер задачи _имя_")
                .AddText("Не забудьте выключить таймер перед уходом!")
                // Text box for replying
                .AddInputTextBox("tbReply", placeHolderContent: "Комментарий")

                .AddButton(new ToastButton()
                    .SetContent("Остановить")
                    .AddArgument("action", "stop"))
                .Show();
        }
    }
}
