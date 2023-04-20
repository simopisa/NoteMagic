using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NoteMagic.Data;

namespace NoteMagic;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, Label = "Note",
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize, ScreenOrientation = ScreenOrientation.Portrait)]
public class MainActivity : MauiAppCompatActivity
{
    public override bool OnKeyUp([GeneratedEnum] Keycode keyCode, KeyEvent e)
    {
        if (!VolumeUpAndDown.CAN_USE_VOLUME_KEY)
        {
            if (keyCode == Keycode.VolumeDown)
            {

                if (VolumeUpAndDown.COUNTER > 0)
                {
                    VolumeUpAndDown.COUNTER--;

                }
                return true;
            }

            if (keyCode == Keycode.VolumeUp)
            {

                if (VolumeUpAndDown.COUNTER < 13)
                {
                    VolumeUpAndDown.COUNTER++;

                }
                return true;
            }
        }
        

        return base.OnKeyUp(keyCode, e);
    }
    
    public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
    {
        if (!VolumeUpAndDown.CAN_USE_VOLUME_KEY)
        {
            if (keyCode == Keycode.VolumeDown)
            {

                return true;
            }

            if (keyCode == Keycode.VolumeUp)
            {

                return true;
            }
        }
        
        return base.OnKeyDown(keyCode, e);
    }
}
