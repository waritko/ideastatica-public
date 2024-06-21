﻿using ConnectionWebClient.ViewModels;
using IdeaStatiCa.ConnectionApi.Client;
using IdeaStatiCa.ConnectionApi.Factory;
using IdeaStatiCa.Plugin;
using IdeaStatiCa.Plugin.Api.ConnectionRest;
using IdeaStatiCa.PluginLogger;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Windows;

namespace ConnectionWebClient
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly IServiceProvider serviceProvider;
		private MainWindowViewModel? mainWindowViewModel;

		public App()
		{
			IConfiguration configuration = BuildConfiguration();
			var services = new ServiceCollection();

			services.AddSingleton<IConfiguration>(configuration);

			services.AddSingleton<IPluginLogger>(serviceProvider =>
			{
				SerilogFacade.Initialize();
				return LoggerProvider.GetLogger("con.restapi.client");
			});

			services.AddTransient<MainWindow>(serviceProvider => new MainWindow
			{
				DataContext = serviceProvider.GetRequiredService<MainWindowViewModel>()
			});
			services.AddTransient<MainWindowViewModel>();

			//services.AddTransient<HttpClient>(serviceProvider => new HttpClient() { BaseAddress = new Uri(configuration["CONNECTION_API_ENDPOINT"]!) });

			services.AddTransient<IConnectionApiClientFactory, ConnectionApiClientFactory>(serviceProvider =>
			{
				var setupDir = configuration["IdeaStatiCaSetupPath"];
				return new ConnectionApiClientFactory(setupDir, serviceProvider.GetRequiredService<IPluginLogger>());
			});

			serviceProvider = services.BuildServiceProvider();
		}

		protected override void OnExit(ExitEventArgs e)
		{
			if (this.mainWindowViewModel is IDisposable disp)
			{
				disp.Dispose();
			}
			this.mainWindowViewModel = null;
			base.OnExit(e);
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
			mainWindow.Show();
			this.mainWindowViewModel = mainWindow.DataContext as MainWindowViewModel;
			base.OnStartup(e);
		}

		public static IConfigurationRoot BuildConfiguration()
		{
			return new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();
		}
	}
}
