using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile
{

    public sealed class MainNotifications
    {

        #region Common

        public static readonly string Common_NotificationAndroidChannelID = "Common";
        public static readonly string Common_NotificationAndroidChannelName = "Common";
        public static readonly string Common_NotificationAndroidChannelDescription = "Provide common notification";
        public static readonly string Common_NotificationAndroidSmallIconResourceName = "notif_icon";


        //public static Notification CreateBackgroundSyncNotification(string message)
        //{
        //    return CreateBackgroundSyncNotification(AppInfo.Name, message);
        //}

        //public static Notification CreateBackgroundSyncNotification(string title, string message)
        //{
        //    var notification = new Notification();

        //    notification.Title = title;
        //    notification.Message = message;

        //    if (Device.RuntimePlatform == Device.Android)
        //    {
        //        notification.Android.AutoCancel = true;
        //        //notification.Android.ChannelId = BackgroundSync_NotificationAndroidChannelID;
        //        //notification.Android.Channel = BackgroundSync_NotificationAndroidChannelName;
        //        //notification.Android.ChannelDescription = BackgroundSync_NotificationAndroidChannelDescription;
        //        notification.Android.SmallIconResourceName = BackgroundSync_NotificationAndroidSmallIconResourceName;
        //    }

        //    return notification;
        //}

        //public static Notification CreateNotification(string title, string message)
        //{
        //    var notification = new Notification();

        //    notification.Title = title;
        //    notification.Message = message;

        //    if (Device.RuntimePlatform == Device.Android)
        //    {
        //        notification.Android.AutoCancel = true;
        //        //notification.Android.ChannelId = BackgroundSync_NotificationAndroidChannelID;
        //        //notification.Android.Channel = BackgroundSync_NotificationAndroidChannelName;
        //        //notification.Android.ChannelDescription = BackgroundSync_NotificationAndroidChannelDescription;
        //        notification.Android.SmallIconResourceName = BackgroundSync_NotificationAndroidSmallIconResourceName;
        //    }

        //    return notification;
        //}

        #endregion

        #region Background Sync

        public static readonly string BackgroundSync_NotificationAndroidChannelID = "BackgroundSync";
        public static readonly string BackgroundSync_NotificationAndroidChannelName = "Background sync";
        public static readonly string BackgroundSync_NotificationAndroidChannelDescription = "Provide status of data sync process";
        public static readonly string BackgroundSync_NotificationAndroidSmallIconResourceName = "notif_icon";


        //public static Notification CreateBackgroundSyncNotification(string message)
        //{
        //    return CreateBackgroundSyncNotification(AppInfo.Name, message);
        //}

        //public static Notification CreateBackgroundSyncNotification(string title, string message)
        //{
        //    var notification = new Notification();

        //    notification.Title = title;
        //    notification.Message = message;

        //    if (Device.RuntimePlatform == Device.Android)
        //    {
        //        notification.Android.AutoCancel = true;
        //        //notification.Android.ChannelId = BackgroundSync_NotificationAndroidChannelID;
        //        //notification.Android.Channel = BackgroundSync_NotificationAndroidChannelName;
        //        //notification.Android.ChannelDescription = BackgroundSync_NotificationAndroidChannelDescription;
        //        notification.Android.SmallIconResourceName = BackgroundSync_NotificationAndroidSmallIconResourceName;
        //    }

        //    return notification;
        //}

        #endregion

    }

}
