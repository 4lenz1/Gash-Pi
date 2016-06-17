using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Gash_Pi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Barcode barcode = new Barcode();
        ChargeProcess charge = new ChargeProcess();
        public MainPage()
        {
            this.InitializeComponent();
            //txtinput.Text = "200";
        }

        private void txtinput_TextChanged(object sender, TextChangedEventArgs e)
        {
          
            barcode.decode(txtinput.Text);

            txtShowStatus.Text = "請投入" + charge.ChargeAmount.ToString() + "元";

            txtinput.Visibility = Visibility.Collapsed;
        }

        private void btninput_Click(object sender, RoutedEventArgs e)
        {
            //simulate $$$ counting machine
            int insert = Int32.Parse(insertMoney.Text);
            int currentinsertmoney , refundMoney;

            if (charge.CurrentChargeAmount + insert  < charge.ChargeAmount) {
                currentinsertmoney  =  charge.CurrentChargeAmount += Int32.Parse(insertMoney.Text);

            }else if(charge.CurrentChargeAmount + insert > charge.ChargeAmount)
            {
                //refund 
                refundMoney = charge.ChargeAmount + insert; 
            }
            else
            {
                //refund nothing
            }
            //TO-DO
            //calculate money for refund
        }
    }
}