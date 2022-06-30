using Android.App;
using Android.Content;
using ArduLens_prism.Services;
using Prism.DryIoc;
using MyApp = Android.App.Application;

namespace ArduLens_prism
{
    [BroadcastReceiver(Enabled = true, Exported = true, DirectBootAware = true)]
    [IntentFilter(new[] { Intent.ActionBootCompleted, Intent.ActionLockedBootCompleted, "android.intent.action.QUICKBOOT_POWERON" })]
    class AutoStartReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
        //    AlarmManager alarmManager = (AlarmManager)MyApp.Context.GetSystemService(Context.AlarmService);
        //    Intent i = new Intent(MyApp.Context, Java.Lang.Class.FromType(typeof(StepCounter.AlarmReceiver)));
        //    PendingIntent pending = PendingIntent.GetBroadcast(MyApp.Context, 1, i, PendingIntentFlags.UpdateCurrent);
        //    alarmManager.SetRepeating(AlarmType.RtcWakeup, Java.Lang.JavaSystem.CurrentTimeMillis() + 2500, AlarmManager.IntervalFifteenMinutes, pending);
        }
    }
}
