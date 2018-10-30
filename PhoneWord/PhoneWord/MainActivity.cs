using System.Collections.Generic;
using Android.Content;

using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace PhoneWord
{
    [Activity(Label = "Phone Word", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        static readonly List<string> phoneNumbers = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText phoneNumText = FindViewById<EditText>(Resource.Id.phoneNumText);
            TextView translatedText = FindViewById<TextView>(Resource.Id.translatedText);
            Button translateBtn = FindViewById<Button>(Resource.Id.translateBtn);
            Button historyBtn = FindViewById<Button>(Resource.Id.historyBtn);

            translateBtn.Click += (sender, e) =>
            {
                string translatedNum = Core.PhonewordTranslator.ToNumber(phoneNumText.Text);
                if (string.IsNullOrWhiteSpace(translatedNum))
                {
                    translatedText.Text = string.Empty;
                }
                else
                {
                    translatedText.Text = translatedNum;
                    phoneNumbers.Add(translatedNum);
                    historyBtn.Enabled = true;
                }
            };

            historyBtn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(HistoryActivity));
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };

        }
    }
}