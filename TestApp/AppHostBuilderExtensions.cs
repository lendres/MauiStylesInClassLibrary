namespace TestLibrary;

public static class AppHostBuilderExtensions
{
	public static MauiAppBuilder UseTestLibrary(this MauiAppBuilder builder)
	{

		builder.Services.AddSingleton<TestLibrary.Resources.Styles.LibraryColors>();

		return builder;
	}
}