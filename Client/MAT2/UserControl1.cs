using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public delegate void myDelegate(object sender, myEventArgs e);

    public partial class UserControl1 : UserControl
    {
        public event myDelegate myEvent;
        private Bitmap gray, red, blue;
        private PictureBox[] pb;
        private ComboBox cb;

        public UserControl1() { }

        public UserControl1(int r)
        {
            InitializeComponent();
            Init(r);
        }

        public bool isEnabled()
        {
            if (cb.Enabled)
                return true;
            return false;
        }

        public void Init(int r)
        {
            //Random rand = new Random();
            gray = new Bitmap("../../GrayPen.bmp");
            red = new Bitmap("../../RedPen.bmp");
            blue = new Bitmap("../../BluePen.bmp");
            //int x = rand.Next(1, 31);
            cb = new ComboBox();
            cb.Location = new Point(gray.Width / 3, 2);
            cb.Size = new Size(40, 21);
            Controls.Add(cb);
            int x = r;
            pb = new PictureBox[30];
            Size = new Size(gray.Width, 30 * gray.Height + cb.Height + 4);
            cb.Text = "" + x;
            for (int i = 0; i < x; i++)
            {
                if (i != 0)
                    cb.Items.Add("" + i);
                pb[i] = new PictureBox();
                pb[i].Image = gray;
                pb[i].Size = new Size(gray.Width, gray.Height - 1);
                pb[i].Location = new Point(0, ClientSize.Height - gray.Height * (i + 1));
                Controls.Add(pb[i]);
            }
            cb.SelectionChangeCommitted += new EventHandler(Combo_Box_Click);
            cb.Items.Add("" + x);
            cb.ForeColor = Color.Blue;
        }

        public void CBdisable() { cb.Enabled = false; }

        public void CBenable() { cb.Enabled = true; }

        public void CBforeColor(int blueOrRed)
        {
            if (blueOrRed == 0)
                cb.ForeColor = Color.Blue;
            else
                cb.ForeColor = Color.Red;
        }

        public int HowManyGray()
        {
            int cnt = 0;
            for (int i = pb.Length - 1; i >= 0; i--)
                if (pb[i] != null && pb[i].Image == gray)
                    cnt++;
            return cnt;
        }

        public void AddPens(int pens, int RedOrBlue)
        {
            int cnt = pens;
            int g = HowManyGray();
            for (int i = pb.Length - 1; i >= 0; i--)
            {
                if (cnt == 0)
                    break;
                if (pb[i] != null && pb[i].Image == gray)
                {
                    if (RedOrBlue == 0)
                        pb[i].Image = red;
                    else
                        pb[i].Image = blue;
                    cnt--;
                }
            }

            for (int i = g; i > g - pens; i--)
            {
                cb.Items.Remove("" + i);
            }
            cb.Text = "" + HowManyGray();
            if (HowManyGray() == 0)
                cb.Text = "";
        }

        private void Combo_Box_Click(object sender, EventArgs e)
        {
            myEventArgs temp = new myEventArgs(((ComboBox)sender).SelectedItem.ToString());
            if (myEvent != null)
                myEvent(this, temp);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

    }
}
