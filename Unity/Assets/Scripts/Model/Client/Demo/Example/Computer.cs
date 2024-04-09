namespace ET.Client
{
    /// <summary>
    /// Computer属于ComputerComponent的子实体
    /// </summary>
    [ChildOf(typeof(ComputerComponent))]
    public class Computer:Entity,IAwake,IUpdate,IDestroy
    {
    
    }
}

