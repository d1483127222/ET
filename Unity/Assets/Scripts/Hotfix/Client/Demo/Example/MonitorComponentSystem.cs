namespace ET.Client
{
    [EntitySystemOf(typeof(MonitorComponent))]
    [FriendOfAttribute(typeof(MonitorComponent))]
    public static partial class MonitorComponentSystem
    {
        private static void Awake(this MonitorComponent self, int args2)
        {
            Log.Debug("MonitorComponent Awake");
            self.Brightness = args2;
        }

        private static void Destroy(this MonitorComponent self)
        {
            
            Log.Debug("MonitorComponent Destroy");
        }

        public static void ChangeBrightness(this MonitorComponent self,int value)
        {
            self.Brightness = value;
        }

    }  
}


