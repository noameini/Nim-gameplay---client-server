using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ICommon
    {
        int numOfPens();
        void UpdateNumOfPens(int x);
        int[] randPens();
        bool Check();
        int[] computerLogic();
        void HumanMove(int a, int b);

    }
    public interface ICommonFactory
    {
        ICommon getNewInstance();
    }
}
