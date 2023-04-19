using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoinFlip_App
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      Random random= new Random();
      int heads, tails;
      private void flipButton_Click(object sender, EventArgs e)
      {
         int r = random.Next(1, 3);
         if(r ==1)
         {
            coinImage.ImageLocation = @"C:\Users\Matias Onores\Documents\Proyectos\CoinFlip App\Heads.png";
            heads++;
            headsLabel.Text= "Heads: " + heads.ToString();
         }
         else
         {
            coinImage.ImageLocation= @"C:\Users\Matias Onores\Documents\Proyectos\CoinFlip App\Tails.png";
            tails++;
            tailsLabel.Text = "Tails: " + tails.ToString();
         }
      }
   }
}
