using System;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 观察者模式/事件模式
            //*观察者模式可以使得我们独立的改变目标与观察者,从而使二者达到松耦合
            //*目标发送通知时,无需'指定'观察者,通知(可以携带通知参数)会自动传播
            //*观察者自己决定是否需要订阅通知,目标对象对此一无所知
            //*观察者模式是基于事件的UI框架常用的设计模式,也是MVC模式的重要组成部分

            //目标,用来模拟一个进度(不变)
            var p = new Progress();

            //观察者,定义行为(变化)
            Action<float> bar = (x)=>{
                Console.WriteLine($"进度:【{(int)(x*100)}/100】");
            };

            //订阅目标,可以加入多个观察者(变化)
            p.OnChange+=bar;

            //执行目标方法
            _=p.StartAsync(128);
            Console.ReadLine();

            //可以轻松增加和去除观察者
            p.OnChange-=bar;
        }
    }
}
