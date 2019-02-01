﻿using CapFrameX.Contracts.Configuration;
using CapFrameX.Contracts.OcatInterface;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace CapFrameX.ViewModel
{
	public class StateViewModel : BindableBase
	{
		private readonly IRecordDirectoryObserver _recordObserver;
		private readonly IEventAggregator _eventAggregator;
		private readonly IAppConfiguration _appConfiguration;

		public bool IsDirectoryObserving
		{
			get { return _recordObserver.IsActive; }
			set { _recordObserver.IsActive = value; RaisePropertyChanged(); }
		}

		public string VersionString
		{
			get
			{
				Assembly assembly = GetAssemblyByName("CapFrameX");
				return FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion + " Beta";
			}
		}

		public StateViewModel(IRecordDirectoryObserver recordObserver, 
							  IEventAggregator eventAggregator,
							  IAppConfiguration appConfiguration)
		{
			_recordObserver = recordObserver;
			_eventAggregator = eventAggregator;
			_appConfiguration = appConfiguration;
		}

		private Assembly GetAssemblyByName(string name)
		{
			return AppDomain.CurrentDomain.GetAssemblies().
				   SingleOrDefault(assembly => assembly.GetName().Name == name);
		}
	}
}