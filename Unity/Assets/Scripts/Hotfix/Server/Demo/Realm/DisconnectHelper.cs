namespace ET.Server
{
    public static class DisconnectHelper
    {
        public static async ETTask Disconnect(this Session self)
        {
            if (self == null || self.IsDisposed)
            {
                return;
            }

            long instanced = self.InstanceId;
            TimerComponent timerComponent = self.Root().GetComponent<TimerComponent>();
            //等一秒是因为，这个session又重复调用的话，不销毁，也可能1秒内被销毁
            await timerComponent.WaitAsync(1000);
            if (self.InstanceId != instanced)
            {
                return;
            }
            self.Dispose();
        }
    }
}

