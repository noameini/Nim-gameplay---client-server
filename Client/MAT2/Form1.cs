using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using Common;

namespace Client
{
    public partial class Form1 : Form
    {
        private UserControl1[] uc;
        private int val, addpensIDX, pens, BlueorRed;
        private ToolStripMenuItem last;
        public ICommon myICommon;
        int []UCnum;

        public Form1()
        {
            InitializeComponent();
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            ICommonFactory myICommonFactory = (ICommonFactory)Activator.GetObject(
                typeof(ICommonFactory),
                "http://localhost:1234/_Server_");

            myICommon = myICommonFactory.getNewInstance();


            this.Text = "Nim";
            last = toolS5;
            last.Checked = true;
            val = myICommon.numOfPens();
            UCnum = myICommon.randPens();
            newGame(val, UCnum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void newGame(int val, int [] ng)
        {
            if (uc != null)                           //
                for (int x = 0; x < uc.Length; x++)  //  **  Initializing  **
                    Controls.Remove(uc[x]);         //
            Random r = new Random();
            uc = new UserControl1[val];
            for (int i = 0; i < val; i++)
            {
                uc[i] = new UserControl1(UCnum[i]);
                uc[i].Location = new Point(i * uc[i].Width, 24);
                uc[i].myEvent += new myDelegate(Updating_Combo_Box);
                Controls.Add(uc[i]);
            }
            ClientSize = new Size(uc[0].Width * val + 2, uc[0].Height + 24);
            BlueorRed = 1;    //           1 = HUMAN      0 = COMPUTER 
        }

        public void isGameOver()

        {
            DialogResult res;
            if (BlueorRed == 0)
                res = MessageBox.Show("New Game?", "The game is over. Blue won.", MessageBoxButtons.YesNo);
            else
                res = MessageBox.Show("New Game?", "The game is over. Red won", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                UCnum=myICommon.randPens();
                newGame(val,UCnum);
            }
            else
                Close();
        }

        private void Updating_Combo_Box(object sender, myEventArgs e)
        {
            UserControl1 tmp = (UserControl1)sender;
            pens = int.Parse(e.myString);
            for (int i = 0; i < uc.Length; i++)
            {
                if (tmp == uc[i])
                    addpensIDX = i;
            }

            uc[addpensIDX].AddPens(pens, BlueorRed);
            myICommon.HumanMove(addpensIDX, pens);
            int[] a;
            BlueorRed = 1 - BlueorRed;
            if (myICommon.Check())
            {
                isGameOver();
                return;
            }
            a = myICommon.computerLogic();
            uc[a[0]].AddPens(a[1], BlueorRed);
            BlueorRed = 1 - BlueorRed;
            if (myICommon.Check())
                isGameOver();
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCnum = myICommon.randPens();
            newGame(val, UCnum);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ts = (ToolStripMenuItem)sender;
            last.Checked = false;
            last = ts;
            ts.Checked = true;
            val = int.Parse(ts.Text);
            myICommon.UpdateNumOfPens(val);
            UCnum = myICommon.randPens();
            newGame(val, UCnum);
        }

    }
}
