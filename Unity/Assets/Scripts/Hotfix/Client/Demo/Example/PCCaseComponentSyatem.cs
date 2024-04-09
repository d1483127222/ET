namespace ET.Client
{
    [EntitySystemOf(typeof(PCCaseComponent))]
    public static partial class PCCaseComponentSyatem
    {
        private static void Awake(this ET.Client.PCCaseComponent self)
        {
            Log.Debug("PCCaseComponent Awake");
            
        }
    } 
}

