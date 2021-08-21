package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MovieApp.Droid.MainApplication, MovieApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc649589af84a3bcf36b.MainApplication.class, crc649589af84a3bcf36b.MainApplication.__md_methods);
		
	}
}
