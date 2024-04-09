namespace ET.Client
{
    /// <summary>
    /// 只能添加到scene上
    /// </summary>
    [ComponentOf(typeof(Scene))]
    public class ComputerComponent:Entity,IAwake,IDestroy,IUpdate
    {
    
    }
}

