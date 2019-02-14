namespace Bridge
{
    //客户端各个系统的功能
    public interface IClientImp
    {
        void MessageBox(string msg);//表示不同平台下的弹窗
    }
}