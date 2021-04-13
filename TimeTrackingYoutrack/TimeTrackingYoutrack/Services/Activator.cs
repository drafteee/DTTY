using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;

namespace TimeTrackingYoutrack.Services
{
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(INotificationActivationCallback))]
    [Guid("A3E120B9-44C3-447C-831D-81A68078B010"),ComVisible(true)]
    class Activator : NotificationActivator
    {
        public override void OnActivated(string arguments, NotificationUserInput userInput, string appUserModelId)
        {
            var a = 5;
            //if (arguments is ToastNotificationActivatedEventArgs toastActivationArgs)
            //{
            //    // Obtain the arguments from the notification
            //    ToastArguments args = ToastArguments.Parse(toastActivationArgs.Argument);

            //    // Obtain any user input (text boxes, menu selections) from the notification
            //    ValueSet userInput = toastActivationArgs.UserInput;

            //    // TODO: Show the corresponding content
            //}
        }
    }
}
