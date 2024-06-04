namespace ProjectManufactory;

public static class Options
{
	public static class Path
	{
		public static string EventBus => "/root/EventBus";
	}

	public static class Input
	{
		public static string ToggleBuilding => "toggle_building";
	}

	public static class Game
	{
		public static float PowerTickRate => 1/6;
	}
}