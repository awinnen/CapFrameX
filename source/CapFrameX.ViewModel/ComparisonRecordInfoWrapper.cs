﻿using CapFrameX.OcatInterface;
using LiveCharts.Wpf;
using OxyPlot;
using OxyPlot.Series;
using Prism.Commands;
using Prism.Mvvm;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;

namespace CapFrameX.ViewModel
{
	public class ComparisonRecordInfoWrapper : BindableBase
	{
		private Color? _frametimeGraphColor;
		private SolidColorBrush _color;
		private ComparisonViewModel _viewModel;

		public Color? FrametimeGraphColor
		{
			get { return _frametimeGraphColor; }
			set
			{
				_frametimeGraphColor = value;
				RaisePropertyChanged();
				OnColorChanged();
			}
		}

		public SolidColorBrush Color
		{
			get { return _color; }
			set
			{
				_color = value;
				RaisePropertyChanged();
			}
		}

		public ComparisonRecordInfo WrappedRecordInfo { get; }

		public int CollectionIndex { get; set; }

		public ICommand MouseEnterCommand { get; }

		public ICommand MouseLeaveCommand { get; }

		public ICommand RemoveCommand { get; }

		public ComparisonRecordInfoWrapper(ComparisonRecordInfo info, ComparisonViewModel viewModel)
		{
			WrappedRecordInfo = info;
			_viewModel = viewModel;

			MouseEnterCommand = new DelegateCommand(OnMouseEnter);
			MouseLeaveCommand = new DelegateCommand(OnMouseLeave);
			RemoveCommand = new DelegateCommand(OnRemove);
		}

		private void OnMouseEnter()
		{
			if (!_viewModel.ComparisonModel.Series.Any())
				return;

			var index = _viewModel.ComparisonRecords.IndexOf(this);

			var frametimesChart = _viewModel.ComparisonModel.Series[index] as OxyPlot.Series.LineSeries;
			frametimesChart.StrokeThickness = 2;
			_viewModel.ComparisonModel.InvalidatePlot(true);

			// highlight bar chart chartpoint
			var series = _viewModel.ComparisonRowChartSeriesCollection;

			foreach (var item in series)
			{
				var rowSeries = item as RowSeries;
				rowSeries.HighlightChartPoint(_viewModel.ComparisonRecords.Count - index - 1);
			}
		}

		private void OnMouseLeave()
		{
			if (!_viewModel.ComparisonModel.Series.Any())
				return;

			var index = _viewModel.ComparisonRecords.IndexOf(this);

			var frametimesChart = _viewModel.ComparisonModel.Series[index] as OxyPlot.Series.LineSeries;
			frametimesChart.StrokeThickness = 1;
			_viewModel.ComparisonModel.InvalidatePlot(true);

			// unhighlight bar chart chartpoint
			var series = _viewModel.ComparisonRowChartSeriesCollection;

			foreach (var item in series)
			{
				var rowSeries = item as RowSeries;
				rowSeries.UnHighlightChartPoint(_viewModel.ComparisonRecords.Count - index - 1);
			}
		}

		private void OnRemove()
		{
			if (!_viewModel.ComparisonModel.Series.Any())
				return;

			_viewModel.RemoveComparisonItem(this);
		}

		private void OnColorChanged()
		{
			if (FrametimeGraphColor.HasValue && CollectionIndex >= 0 &&
				_viewModel.ComparisonModel.Series.Count > CollectionIndex &&
				_viewModel.ComparisonLShapeCollection.Count > CollectionIndex)
			{
				Color color = FrametimeGraphColor.Value;

				var frametimesChart = _viewModel.ComparisonModel.Series[CollectionIndex] as OxyPlot.Series.LineSeries;
				var lShapeChart = _viewModel.ComparisonLShapeCollection[CollectionIndex] as LiveCharts.Wpf.LineSeries;

				var solidColorBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
				frametimesChart.Color = OxyColor.FromArgb(color.A, color.R, color.G, color.B);
				lShapeChart.Stroke = solidColorBrush;
				Color = solidColorBrush;

				_viewModel.ComparisonModel.InvalidatePlot(true);
			}
		}

		public ComparisonRecordInfoWrapper Clone()
		{
			return new ComparisonRecordInfoWrapper(WrappedRecordInfo, _viewModel)
			{
				Color = Color,
				FrametimeGraphColor = FrametimeGraphColor,
				CollectionIndex = CollectionIndex
			};
		}
	}
}
