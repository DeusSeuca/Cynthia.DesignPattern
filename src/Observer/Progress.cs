using System;
using System.Threading.Tasks;

namespace Observer
{
    //一个关于进度的类
    public class Progress
    {
        public event Action<float> OnChange;//0-1,进度条的进度事件

        public async Task StartAsync(int count)
        {
            for(var i = 0; i<count; i++)
            {
                await Task.Delay(10);
                OnChange((i+1)*(1f/count));//当进度改变时,通知观察者
            }
        }
    }
}