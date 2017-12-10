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

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            HttpChannel chnl = new HttpChannel(1234);
            ChannelServices.RegisterChannel(chnl, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(ServerPartFactory),
                "_Server_",
                WellKnownObjectMode.Singleton);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    class ServerPart : MarshalByRefObject, ICommon
    {
        private int val = 5;
        private int[] UC = new int[5];
        

        public bool Check()
        {
            for (int i = 0; i < val; i++)  //  TRUE = is over  
                if(UC[i]!=0)
                    return false;
                return true;
        }

        public void HumanMove(int a, int b)
        {
            UC[a] = UC[a] - b;
        }

        public void UpdateNumOfPens(int x)
        {
            val = x;
            UC = new int[val];
        }

        public int[] computerLogic()
        {
            Random rand = new Random();
            int num;
            int S = 0;
            int grayp = 0;
            int idx = 0;
            for (num = 0; num < val; num++)
            {
                S ^= UC[num];
            }
            if (S != 0)
            {
                for (int i = 0; i < val; i++)
                {
                    if (UC[i] != 0)
                    {
                        idx = i;
                        grayp = UC[i] + 1;
                        while ((S != 0) && (grayp > 0))
                        {
                            grayp--;
                            S = 0;
                            for (num = 0; num < val; num++)
                            {
                                if (num == idx)
                                {
                                    S ^= UC[num] - grayp;
                                }
                                else
                                {
                                    S ^= UC[num];
                                }
                            }
                        }
                        if (S == 0)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                while (true)
                {
                    num = rand.Next(val);
                    if (UC[num] != 0)
                    {
                        grayp = rand.Next(UC[num] - 1) + 1;
                        idx = num;
                        break;
                    }
                }
            }
            int []a =new int[2];
            a[0]=idx; a[1]=grayp;
            UC[idx] -= grayp;
            return a;
        }

        public int numOfPens()
        {
            return val;
        }

        public int[] randPens()
        {
            Random r = new Random();
            for (int i = 0; i < val;i++ )
                UC[i] = r.Next(1, 31);
            return UC;
        }

    }

    class ServerPartFactory : MarshalByRefObject, ICommonFactory
    {
        public ServerPartFactory()
        {
        }
        public ICommon getNewInstance()
        {
            return new ServerPart();
        }
    }
}