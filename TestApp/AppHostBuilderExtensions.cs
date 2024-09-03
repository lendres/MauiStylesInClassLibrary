namespace TestAppTestLibrary;

public static class AppHostBuilderExtensions
{
	public static MauiAppBuilder UseDigitalProduction(this MauiAppBuilder builder)
	{

		builder.Services.AddSingleton<TestLibrary.Resources.Styles.LibraryColors>();

		return builder;
	}
}