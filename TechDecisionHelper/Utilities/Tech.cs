namespace ProjectDatabase.Utilities
{
	public class Tech
	{
		const String CSharp = "C#";
		const String JavaScript = "JavaScript";
		const String PHP = "PHP";
		const String Python = "Python";
		const String TypeScript = "TypeScript";
		

		public static readonly string[] Languages = new string[]
		{
			CSharp,
			JavaScript,
			PHP,
			Python,
			TypeScript
		};

		public static readonly string[] netBackendFrameworks = new string[]
		{
			"ASP.NET Core",
		};
		public static readonly string[] phpBackendFrameworks = new string[]
		{
			"CakePHP",
			"Laravel",
			"Symfony",
			"Zend Framework",
		};
		public static readonly string[] jsBackendFrameworks = new string[]
		{
			"Express.js",
			"Node.js",
			"NestJS",
		};
		public static readonly string[] pythonBackendFrameworks = new string[]
		{
			"Django",
		};



		public static string[] BackendFrameworks (String? language)
		{
			switch (language)
			{
				case (CSharp):
					return netBackendFrameworks;
				case JavaScript:
				case TypeScript:
					return jsBackendFrameworks;
				case PHP:
					return phpBackendFrameworks;
				case Python:
					return pythonBackendFrameworks;
				default:
					String[] langArray = netBackendFrameworks
						.Concat(jsBackendFrameworks)
						.Concat(phpBackendFrameworks)
						.Concat(pythonBackendFrameworks)
						.ToArray();
					langArray.Sort();
					return langArray;
			}	
		}

		public static readonly string[] Databases = new string[]
		{
			"MariaDB",
			"MongoDB",
			"MySQL",
			"PostgreSQL",
			"SQL Server",
			"SQLite",
		};

		public static readonly string[] DataAbstractionLayers = new string[]
		{
			"Entity Framework Core",
			"Doctrine",
		};

		public static readonly string[] CloudProviders = new string[]
		{
			"Azure",
			"AWS",
			"Google Cloud",
		};

		public static readonly string[] FrontendFrameworks = new string[]
		{
			"Angular",
			"jQuery",
			"React",
			"Vue.js",
		};

		public static readonly string[] DevOpsTools = new string[]
		{
			"Docker",
			"GitLab CI/CD",
			"Jenkins",
			"Kubernetes",
		};

		public static readonly string[] MobileFrameworks = new string[]
		{
			"Xamarin",
			"React Native",
			"MAUI"
		};

		public static readonly string[] UIFrameworks = new string[]
		{
			"Bootstrap",
			"MAUI",
			"MudBlazor",
			"Tailwind CSS",
			"WinForms",
			"WPF",
		};

		public static readonly string[] FormFrameworks = new string[]
		{
			"ASP.NET MVC",
			"ASP.NET Web Forms",
			"Blazor",
			"Laravel Formello",
			"Razor Pages",
		};
	}
}
