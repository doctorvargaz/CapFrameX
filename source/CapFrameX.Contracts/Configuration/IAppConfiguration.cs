﻿using CapFrameX.Statistics.NetStandard.Contracts;

namespace CapFrameX.Contracts.Configuration
{
	public interface IAppConfiguration : IFrametimeStatisticProviderOptions
	{
		double StutteringFactor { get; set; }

		double StutteringThreshold { get; set; }

		string ObservedDirectory { get; set; }

		string ScreenshotDirectory { get; set; }

		bool UseSingleRecordMaxStatisticParameter { get; set; }

		bool UseSingleRecord99QuantileStatisticParameter { get; set; }

		bool UseSingleRecordP95QuantileStatisticParameter { get; set; }

		bool UseSingleRecordAverageStatisticParameter { get; set; }

		bool UseSingleRecordMedianStatisticParameter { get; set; }

		bool UseSingleRecordP5QuantileStatisticParameter { get; set; }

		bool UseSingleRecordP1QuantileStatisticParameter { get; set; }

		bool UseSingleRecordP0Dot1QuantileStatisticParameter { get; set; }

		bool UseSingleRecordP0Dot2QuantileStatisticParameter { get; set; }

		bool UseSingleRecordP1LowAverageStatisticParameter { get; set; }

		bool UseSingleRecordP0Dot1LowAverageStatisticParameter { get; set; }

		bool UseSingleRecordMinStatisticParameter { get; set; }

		bool UseSingleRecordAdaptiveSTDStatisticParameter { get; set; }

		bool UseSingleRecordCpuFpsPerWattParameter { get; set; }

		bool UseSingleRecordGpuFpsPerWattParameter { get; set; }

		string CaptureHotKey { get; set; }

		string OverlayHotKey { get; set; }

		string OverlayConfigHotKey { get; set; }

		string HotkeySoundMode { get; set; }

		double CaptureTime { get; set; }

		double VoiceSoundLevel { get; set; }

		double SimpleSoundLevel { get; set; }

		string FirstMetric { get; set; }

		string SecondMetric { get; set; }

		string ThirdMetric { get; set; }

		string SecondMetricOverlay { get; set; }

		string ThirdMetricOverlay { get; set; }

		string ComparisonContext { get; set; }

		string SecondComparisonContext { get; set; }

		string RecordingListSortMemberPath { get; set; }

		string RecordingListSortDirection { get; set; }

		string SyncRangeLower { get; set; }

		string SyncRangeUpper { get; set; }

		bool ShowOutlierWarning { get; set; }

		string HardwareInfoSource { get; set; }

		string CustomCpuDescription { get; set; }

		string CustomGpuDescription { get; set; }

		string CustomRamDescription { get; set; }	
		
		bool IsOverlayActive { get; set; }

		string ResetHistoryHotkey { get; set; }

		bool UseRunHistory { get; set; }

		bool UseAggregation { get; set; }

		string OutlierHandling { get; set; }

		int SelectedHistoryRuns { get; set; }

		int OSDRefreshPeriod { get; set; }
		
		string CloudDownloadDirectory { get; set; }
		
		bool SaveAggregationOnly { get; set; }

		int OutlierPercentageOverlay { get; set; }

		string RelatedMetricOverlay { get; set; }

		int InputLagOffset { get; set; }

		string SecondMetricAggregation { get; set; }

		string ThirdMetricAggregation { get; set; }

		string RelatedMetricAggregation { get; set; }

		int OutlierPercentageAggregation { get; set; }

		bool AreThresholdsReversed { get; set; }

		string CaptureRootDirectory { get; set; }

		bool ShareProcessListEntries { get; set; }

		bool AutoUpdateProcessList { get; set; }

		bool UseSensorLogging { get; set; }
		
		bool AreThresholdsPercentage { get; set; }

		int OverlayEntryConfigurationFile { get; set; }

		int SensorLoggingRefreshPeriod { get; set; }

		bool ShowThresholdTimes { get; set; }

		string CaptureFileMode { get; set; }

		bool StartMinimized { get; set; }

		bool Autostart { get; set; }

		bool IsGpuAccelerationActive { get; set; }
	}
}
