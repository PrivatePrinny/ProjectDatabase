namespace ProjectDatabase.Utilities
{
	public class AppState : Observer
	{
	
		private String? selectedLanguage = null;
		public String? SelectedLanguage
		{
			get => selectedLanguage;
			set
			{
				selectedLanguage = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedBackendFramework = null;
		public String? SelectedBackendFramework
		{
			get => selectedBackendFramework;
			set
			{
				selectedBackendFramework = value;
				base.BroadcastStateChange();
			}
		}

		private String? selectedDatabase = null;
		public String? SelectedDatabase
		{
			get => selectedDatabase;
			set
			{
				selectedDatabase = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedDataAbstractionLayer = null;
		public String? SelectedDataAbstractionLayer
		{
			get => selectedDataAbstractionLayer;
			set
			{
				selectedDataAbstractionLayer = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedCloudProvider = null;
		public String? SelectedCloudProvider
		{
			get => selectedCloudProvider;
			set
			{
				selectedCloudProvider = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedFrontendFramework = null;
		public String? SelectedFrontendFramework
		{
			get => selectedFrontendFramework;
			set
			{
				selectedFrontendFramework = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedDevOpsTool = null;
		public String? SelectedDevOpsTool
		{
			get => selectedDevOpsTool;
			set
			{
				selectedDevOpsTool = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedMobileFramework = null;
		public String? SelectedMobileFramework
		{
			get => selectedMobileFramework;
			set
			{
				selectedMobileFramework = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedUIFramework = null;
		public String? SelectedUIFramework
		{
			get => selectedUIFramework;
			set
			{
				selectedUIFramework = value;
				base.BroadcastStateChange();
			}
		}
		private String? selectedFormFramework = null;
		public String? SelectedFormFramework
		{
			get => selectedFormFramework;
			set
			{
				selectedFormFramework = value;
				base.BroadcastStateChange();
			}
		}
	}
}
