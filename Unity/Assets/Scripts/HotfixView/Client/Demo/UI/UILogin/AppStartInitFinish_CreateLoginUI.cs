namespace ET.Client
{
	[Event(SceneType.Demo)]
	public class AppStartInitFinish_CreateLoginUI: AEvent<Scene, AppStartInitFinish>
	{
		protected override async ETTask Run(Scene root, AppStartInitFinish args)
		{
			await UIHelper.Create(root, UIType.UILogin, UILayer.Mid);

			Computer computer = root.GetComponent<ComputerComponent>().AddChild<Computer>();
			computer.AddComponent<PCCaseComponent>();
			computer.AddComponent<MonitorComponent, int>(10);
			computer.Open();
			computer.GetComponent<MonitorComponent>().ChangeBrightness(5);
			await root.GetComponent<TimerComponent>().WaitAsync(3000);
			computer?.Dispose();
		}
	}
}
