
using System;
using Date = System.DateTime;
using LivingThing.TCCS.Attributes;
using LivingThing.TCCS.Definitions.Javascript;
using LivingThing.TCCS.Definitions.Util;
#pragma warning disable CS0626
#pragma warning disable CS0824
#pragma warning disable CS0108
#pragma warning disable IDE1006

namespace LivingThing.TCCS.Definitions
{
	public partial class Chart
	{
		public Chart(Union<string, CanvasRenderingContext2D, HTMLCanvasElement, Union<CanvasRenderingContext2D, HTMLCanvasElement>[]> context, Chart.ChartConfiguration options)
		{
		}

		public partial interface ChartType_0
		{
			Union<Chart.ChartOptions, Chart.ChartFontOptions, ChartType_0Type_0> global { get; set; }
			object this[string key] { get; set; }
		}
		public partial interface ChartType_0Type_0
		{
			Chart.ChartTooltipOptions tooltips { get; set; }
		}
		public partial interface ChartType_1
		{
			object this[string key] { get; set; }
		}
		public partial interface ChartType_2
		{
			object this[string key] { get; set; }
		}
		public partial interface ChartType_3
		{
			bool disableCSSInjection { get; set; }
		}
		public partial interface ChartType_4
		{
			Chart this[string key] { get; set; }
		}
		public class ChartType : Enumerated
		{
			public static string line = "line";
			public static string bar = "bar";
			public static string horizontalBar = "horizontalBar";
			public static string radar = "radar";
			public static string doughnut = "doughnut";
			public static string polarArea = "polarArea";
			public static string bubble = "bubble";
			public static string pie = "pie";
			public static string scatter = "scatter";
			public static implicit operator ChartType(string value) { return new ChartType(value); }
			public ChartType(object value) { Value = value; }
		}
		public class TimeUnit : Enumerated
		{
			public static string millisecond = "millisecond";
			public static string second = "second";
			public static string minute = "minute";
			public static string hour = "hour";
			public static string day = "day";
			public static string week = "week";
			public static string month = "month";
			public static string quarter = "quarter";
			public static string year = "year";
			public static implicit operator TimeUnit(string value) { return new TimeUnit(value); }
			public TimeUnit(object value) { Value = value; }
		}
		public class ScaleType : Enumerated
		{
			public static string category = "category";
			public static string linear = "linear";
			public static string logarithmic = "logarithmic";
			public static string time = "time";
			public static string radialLinear = "radialLinear";
			public static implicit operator ScaleType(string value) { return new ScaleType(value); }
			public ScaleType(object value) { Value = value; }
		}
		public class PointStyle : Enumerated
		{
			public static string circle = "circle";
			public static string cross = "cross";
			public static string crossRot = "crossRot";
			public static string dash = "dash";
			public static string line = "line";
			public static string rect = "rect";
			public static string rectRounded = "rectRounded";
			public static string rectRot = "rectRot";
			public static string star = "star";
			public static string triangle = "triangle";
			public static implicit operator PointStyle(string value) { return new PointStyle(value); }
			public PointStyle(object value) { Value = value; }
		}
		public class PositionType : Enumerated
		{
			public static string left = "left";
			public static string right = "right";
			public static string top = "top";
			public static string bottom = "bottom";
			public static string chartArea = "chartArea";
			public static implicit operator PositionType(string value) { return new PositionType(value); }
			public PositionType(object value) { Value = value; }
		}
		public class InteractionMode : Enumerated
		{
			public static string point = "point";
			public static string nearest = "nearest";
			public static string single = "single";
			public static string label = "label";
			public static string index = "index";
			public static string x_axis = "x-axis";
			public static string dataset = "dataset";
			public static string x = "x";
			public static string y = "y";
			public static implicit operator InteractionMode(string value) { return new InteractionMode(value); }
			public InteractionMode(object value) { Value = value; }
		}
		public class Easing : Enumerated
		{
			public static string linear = "linear";
			public static string easeInQuad = "easeInQuad";
			public static string easeOutQuad = "easeOutQuad";
			public static string easeInOutQuad = "easeInOutQuad";
			public static string easeInCubic = "easeInCubic";
			public static string easeOutCubic = "easeOutCubic";
			public static string easeInOutCubic = "easeInOutCubic";
			public static string easeInQuart = "easeInQuart";
			public static string easeOutQuart = "easeOutQuart";
			public static string easeInOutQuart = "easeInOutQuart";
			public static string easeInQuint = "easeInQuint";
			public static string easeOutQuint = "easeOutQuint";
			public static string easeInOutQuint = "easeInOutQuint";
			public static string easeInSine = "easeInSine";
			public static string easeOutSine = "easeOutSine";
			public static string easeInOutSine = "easeInOutSine";
			public static string easeInExpo = "easeInExpo";
			public static string easeOutExpo = "easeOutExpo";
			public static string easeInOutExpo = "easeInOutExpo";
			public static string easeInCirc = "easeInCirc";
			public static string easeOutCirc = "easeOutCirc";
			public static string easeInOutCirc = "easeInOutCirc";
			public static string easeInElastic = "easeInElastic";
			public static string easeOutElastic = "easeOutElastic";
			public static string easeInOutElastic = "easeInOutElastic";
			public static string easeInBack = "easeInBack";
			public static string easeOutBack = "easeOutBack";
			public static string easeInOutBack = "easeInOutBack";
			public static string easeInBounce = "easeInBounce";
			public static string easeOutBounce = "easeOutBounce";
			public static string easeInOutBounce = "easeInOutBounce";
			public static implicit operator Easing(string value) { return new Easing(value); }
			public Easing(object value) { Value = value; }
		}
		public class TextAlignment : Enumerated
		{
			public static string left = "left";
			public static string center = "center";
			public static string right = "right";
			public static implicit operator TextAlignment(string value) { return new TextAlignment(value); }
			public TextAlignment(object value) { Value = value; }
		}
		public class BorderAlignment : Enumerated
		{
			public static string center = "center";
			public static string inner = "inner";
			public static implicit operator BorderAlignment(string value) { return new BorderAlignment(value); }
			public BorderAlignment(object value) { Value = value; }
		}
		public partial interface ChartType_14
		{
			double this[PositionType key] { get; set; }
		}
		public class BorderWidth : TypeAlias
		{
			public BorderWidth(Union<double, ChartType_14> value) { Value = value; }
			public static implicit operator BorderWidth(Union<double, ChartType_14> value) { return new BorderWidth(value); }
		}
		public partial interface ChartArea
		{
			double top { get; set; }
			double right { get; set; }
			double bottom { get; set; }
			double left { get; set; }
		}
		public partial interface ChartLegendItem
		{
			string text { get; set; }
			string fillStyle { get; set; }
			bool hidden { get; set; }
			double index { get; set; }
			ChartLegendItemType_0 lineCap { get; set; }
			double[] lineDash { get; set; }
			double lineDashOffset { get; set; }
			ChartLegendItemType_1 lineJoin { get; set; }
			double lineWidth { get; set; }
			string strokeStyle { get; set; }
			PointStyle pointStyle { get; set; }
		}
		public class ChartLegendItemType_0 : Enumerated
		{
			public static string butt = "butt";
			public static string round = "round";
			public static string square = "square";
			public static implicit operator ChartLegendItemType_0(string value) { return new ChartLegendItemType_0(value); }
			public ChartLegendItemType_0(object value) { Value = value; }
		}
		public class ChartLegendItemType_1 : Enumerated
		{
			public static string bevel = "bevel";
			public static string round = "round";
			public static string miter = "miter";
			public static implicit operator ChartLegendItemType_1(string value) { return new ChartLegendItemType_1(value); }
			public ChartLegendItemType_1(object value) { Value = value; }
		}
		public partial interface ChartLegendLabelItem : ChartLegendItem
		{
			double datasetIndex { get; set; }
		}
		public partial interface ChartTooltipItem
		{
			string label { get; set; }
			string value { get; set; }
			Union<string, double> xLabel { get; set; }
			Union<string, double> yLabel { get; set; }
			double datasetIndex { get; set; }
			double index { get; set; }
			double x { get; set; }
			double y { get; set; }
		}
		public partial interface ChartTooltipLabelColor
		{
			ChartColor borderColor { get; set; }
			ChartColor backgroundColor { get; set; }
		}
		public partial interface ChartTooltipCallback
		{
			Union<string, string[]> beforeTitle(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> title(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> afterTitle(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> beforeBody(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> beforeLabel(ChartTooltipItem tooltipItem, ChartData data);
			Union<string, string[]> label(ChartTooltipItem tooltipItem, ChartData data);
			ChartTooltipLabelColor labelColor(ChartTooltipItem tooltipItem, Chart chart);
			string labelTextColor(ChartTooltipItem tooltipItem, Chart chart);
			Union<string, string[]> afterLabel(ChartTooltipItem tooltipItem, ChartData data);
			Union<string, string[]> afterBody(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> beforeFooter(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> footer(ChartTooltipItem[] _item, ChartData data);
			Union<string, string[]> afterFooter(ChartTooltipItem[] _item, ChartData data);
		}
		public partial interface ChartAnimationParameter
		{
			object chartInstance { get; set; }
			object animationObject { get; set; }
		}
		public partial interface ChartPoint
		{
			Union<double, string, Date, moment.Moment> x { get; set; }
			Union<double, string, Date, moment.Moment> y { get; set; }
			double r { get; set; }
			Union<double, string, Date, moment.Moment> t { get; set; }
		}
		public partial interface ChartConfiguration
		{
			Union<ChartType, string> type { get; set; }
			ChartData data { get; set; }
			ChartOptions options { get; set; }
			PluginServiceRegistrationOptions[] plugins { get; set; }
		}
		public partial interface ChartData
		{
			Union<string, string[], double, double[], Date, Date[], moment.Moment, moment.Moment[]>[] labels { get; set; }
			ChartDataSets[] datasets { get; set; }
		}
		public partial interface RadialChartOptions : ChartOptions
		{
			RadialLinearScale scale { get; set; }
		}
		public partial interface ChartSize
		{
			double height { get; set; }
			double width { get; set; }
		}
		public partial interface ChartOptions
		{
			bool responsive { get; set; }
			double responsiveAnimationDuration { get; set; }
			double aspectRatio { get; set; }
			bool maintainAspectRatio { get; set; }
			string[] events { get; set; }
			ChartTitleOptions title { get; set; }
			ChartLegendOptions legend { get; set; }
			ChartTooltipOptions tooltips { get; set; }
			ChartHoverOptions hover { get; set; }
			ChartAnimationOptions animation { get; set; }
			ChartElementsOptions elements { get; set; }
			ChartLayoutOptions layout { get; set; }
			RadialLinearScale scale { get; set; }
			Union<ChartScales, LinearScale, LogarithmicScale, TimeScale> scales { get; set; }
			bool showLines { get; set; }
			bool spanGaps { get; set; }
			double cutoutPercentage { get; set; }
			double circumference { get; set; }
			double rotation { get; set; }
			double devicePixelRatio { get; set; }
			ChartPluginsOptions plugins { get; set; }
			string legendCallback(Chart chart);
			object onHover(Chart @this, MouseEvent @event, object[] activeElements);
			object onClick(MouseEvent @event, object[] activeElements);
			void onResize(Chart @this, ChartSize newSize);
		}
		public partial interface ChartFontOptions
		{
			ChartColor defaultFontColor { get; set; }
			string defaultFontFamily { get; set; }
			double defaultFontSize { get; set; }
			string defaultFontStyle { get; set; }
		}
		public partial interface ChartTitleOptions
		{
			bool display { get; set; }
			PositionType position { get; set; }
			bool fullWidth { get; set; }
			double fontSize { get; set; }
			string fontFamily { get; set; }
			ChartColor fontColor { get; set; }
			string fontStyle { get; set; }
			double padding { get; set; }
			Union<string, string[]> text { get; set; }
		}
		public partial interface ChartLegendOptions
		{
			ChartLegendOptionsType_0 align { get; set; }
			bool display { get; set; }
			PositionType position { get; set; }
			bool fullWidth { get; set; }
			ChartLegendLabelOptions labels { get; set; }
			bool reverse { get; set; }
			void onClick(MouseEvent @event, ChartLegendLabelItem legendItem);
			void onHover(MouseEvent @event, ChartLegendLabelItem legendItem);
			void onLeave(MouseEvent @event, ChartLegendLabelItem legendItem);
		}
		public class ChartLegendOptionsType_0 : Enumerated
		{
			public static string center = "center";
			public static string end = "end";
			public static string start = "start";
			public static implicit operator ChartLegendOptionsType_0(string value) { return new ChartLegendOptionsType_0(value); }
			public ChartLegendOptionsType_0(object value) { Value = value; }
		}
		public partial interface ChartLegendLabelOptions
		{
			double boxWidth { get; set; }
			double fontSize { get; set; }
			string fontStyle { get; set; }
			ChartColor fontColor { get; set; }
			string fontFamily { get; set; }
			double padding { get; set; }
			bool usePointStyle { get; set; }
			ChartLegendLabelItem[] generateLabels(Chart chart);
			object filter(ChartLegendLabelItem legendItem, ChartData data);
		}
		public partial interface ChartTooltipOptions
		{
			bool enabled { get; set; }
			Action<ChartTooltipModel> custom { get; set; }
			InteractionMode mode { get; set; }
			bool intersect { get; set; }
			ChartColor backgroundColor { get; set; }
			TextAlignment titleAlign { get; set; }
			string titleFontFamily { get; set; }
			double titleFontSize { get; set; }
			string titleFontStyle { get; set; }
			ChartColor titleFontColor { get; set; }
			double titleSpacing { get; set; }
			double titleMarginBottom { get; set; }
			TextAlignment bodyAlign { get; set; }
			string bodyFontFamily { get; set; }
			double bodyFontSize { get; set; }
			string bodyFontStyle { get; set; }
			ChartColor bodyFontColor { get; set; }
			double bodySpacing { get; set; }
			TextAlignment footerAlign { get; set; }
			string footerFontFamily { get; set; }
			double footerFontSize { get; set; }
			string footerFontStyle { get; set; }
			ChartColor footerFontColor { get; set; }
			double footerSpacing { get; set; }
			double footerMarginTop { get; set; }
			double xPadding { get; set; }
			double yPadding { get; set; }
			double caretSize { get; set; }
			double cornerRadius { get; set; }
			string multiKeyBackground { get; set; }
			ChartTooltipCallback callbacks { get; set; }
			string position { get; set; }
			double caretPadding { get; set; }
			bool displayColors { get; set; }
			ChartColor borderColor { get; set; }
			double borderWidth { get; set; }
			bool filter(ChartTooltipItem _item, ChartData data);
			double itemSort(ChartTooltipItem itemA, ChartTooltipItem itemB, ChartData data);
		}
		public partial interface ChartTooltipModel
		{
			string[] afterBody { get; set; }
			string backgroundColor { get; set; }
			string[] beforeBody { get; set; }
			ChartTooltipModelBody[] body { get; set; }
			string bodyFontColor { get; set; }
			double bodyFontSize { get; set; }
			double bodySpacing { get; set; }
			string borderColor { get; set; }
			double borderWidth { get; set; }
			double caretPadding { get; set; }
			double caretSize { get; set; }
			double caretX { get; set; }
			double caretY { get; set; }
			double cornerRadius { get; set; }
			ChartTooltipItem[] dataPoints { get; set; }
			bool displayColors { get; set; }
			string[] footer { get; set; }
			string footerFontColor { get; set; }
			double footerFontSize { get; set; }
			double footerMarginTop { get; set; }
			double footerSpacing { get; set; }
			double height { get; set; }
			string[] labelColors { get; set; }
			string[] labelTextColors { get; set; }
			string legendColorBackground { get; set; }
			double opacity { get; set; }
			string[] title { get; set; }
			string titleFontColor { get; set; }
			double titleFontSize { get; set; }
			double titleMarginBottom { get; set; }
			double titleSpacing { get; set; }
			double width { get; set; }
			double x { get; set; }
			string xAlign { get; set; }
			double xPadding { get; set; }
			double y { get; set; }
			string yAlign { get; set; }
			double yPadding { get; set; }
			string _bodyAlign { get; set; }
			string _bodyFontFamily { get; set; }
			string _bodyFontStyle { get; set; }
			string _footerAlign { get; set; }
			string _footerFontFamily { get; set; }
			string _footerFontStyle { get; set; }
			string _titleAlign { get; set; }
			string _titleFontFamily { get; set; }
			string _titleFontStyle { get; set; }
		}
		public partial interface ChartTooltipModelBody
		{
			string[] before { get; set; }
			string[] lines { get; set; }
			string[] after { get; set; }
		}
		public partial interface ChartPluginsOptions
		{
			object this[string pluginId] { get; set; }
		}
		public partial interface ChartTooltipsStaticConfiguration
		{
			ChartTooltipsStaticConfigurationType_0 positioners { get; set; }
		}
		public partial interface ChartTooltipsStaticConfigurationType_0
		{
			ChartTooltipPositioner this[string mode] { get; set; }
		}
		public class ChartTooltipPositioner : TypeAlias
		{
			public ChartTooltipPositioner(Func<object[], Point, Point> value) { Value = value; }
			public static implicit operator ChartTooltipPositioner(Func<object[], Point, Point> value) { return new ChartTooltipPositioner(value); }
		}
		public partial interface ChartHoverOptions
		{
			InteractionMode mode { get; set; }
			double animationDuration { get; set; }
			bool intersect { get; set; }
			object onHover(Chart @this, MouseEvent @event, object[] activeElements);
		}
		public partial interface ChartAnimationObject
		{
			double currentStep { get; set; }
			double numSteps { get; set; }
			Easing easing { get; set; }
			void render(object arg);
			void onAnimationProgress(object arg);
			void onAnimationComplete(object arg);
		}
		public partial interface ChartAnimationOptions
		{
			double duration { get; set; }
			Easing easing { get; set; }
			bool animateRotate { get; set; }
			bool animateScale { get; set; }
			void onProgress(object chart);
			void onComplete(object chart);
		}
		public partial interface ChartElementsOptions
		{
			ChartPointOptions point { get; set; }
			ChartLineOptions line { get; set; }
			ChartArcOptions arc { get; set; }
			ChartRectangleOptions rectangle { get; set; }
		}
		public partial interface ChartArcOptions
		{
			ChartColor backgroundColor { get; set; }
			ChartColor borderColor { get; set; }
			double borderWidth { get; set; }
		}
		public partial interface ChartLineOptions
		{
			ChartLineOptionsType_0 cubicInterpolationMode { get; set; }
			double tension { get; set; }
			ChartColor backgroundColor { get; set; }
			double borderWidth { get; set; }
			ChartColor borderColor { get; set; }
			string borderCapStyle { get; set; }
			object[] borderDash { get; set; }
			double borderDashOffset { get; set; }
			string borderJoinStyle { get; set; }
			bool capBezierPoints { get; set; }
			ChartLineOptionsType_1 fill { get; set; }
			bool stepped { get; set; }
		}
		public class ChartLineOptionsType_0 : Enumerated
		{
			public static string @default = "default";
			public static string monotone = "monotone";
			public static implicit operator ChartLineOptionsType_0(string value) { return new ChartLineOptionsType_0(value); }
			public ChartLineOptionsType_0(object value) { Value = value; }
		}
		public class ChartLineOptionsType_1 : Enumerated
		{
			public static string zero = "zero";
			public static string top = "top";
			public static string bottom = "bottom";
			public static implicit operator ChartLineOptionsType_1(string value) { return new ChartLineOptionsType_1(value); }
			public static implicit operator ChartLineOptionsType_1(bool value) { return new ChartLineOptionsType_1(value); }
			public ChartLineOptionsType_1(object value) { Value = value; }
		}
		public partial interface ChartPointOptions
		{
			double radius { get; set; }
			PointStyle pointStyle { get; set; }
			ChartColor backgroundColor { get; set; }
			double borderWidth { get; set; }
			ChartColor borderColor { get; set; }
			double hitRadius { get; set; }
			double hoverRadius { get; set; }
			double hoverBorderWidth { get; set; }
		}
		public partial interface ChartRectangleOptions
		{
			ChartColor backgroundColor { get; set; }
			double borderWidth { get; set; }
			ChartColor borderColor { get; set; }
			string borderSkipped { get; set; }
		}
		public partial interface ChartLayoutOptions
		{
			Union<ChartLayoutPaddingObject, double> padding { get; set; }
		}
		public partial interface ChartLayoutPaddingObject
		{
			double top { get; set; }
			double right { get; set; }
			double bottom { get; set; }
			double left { get; set; }
		}
		public partial interface GridLineOptions
		{
			bool display { get; set; }
			bool circular { get; set; }
			ChartColor color { get; set; }
			double[] borderDash { get; set; }
			double borderDashOffset { get; set; }
			Union<double, double[]> lineWidth { get; set; }
			bool drawBorder { get; set; }
			bool drawOnChartArea { get; set; }
			bool drawTicks { get; set; }
			double tickMarkLength { get; set; }
			double zeroLineWidth { get; set; }
			ChartColor zeroLineColor { get; set; }
			double[] zeroLineBorderDash { get; set; }
			double zeroLineBorderDashOffset { get; set; }
			bool offsetGridLines { get; set; }
			double z { get; set; }
		}
		public partial interface ScaleTitleOptions
		{
			bool display { get; set; }
			string labelString { get; set; }
			Union<double, string> lineHeight { get; set; }
			ChartColor fontColor { get; set; }
			string fontFamily { get; set; }
			double fontSize { get; set; }
			string fontStyle { get; set; }
			Union<ChartLayoutPaddingObject, double> padding { get; set; }
		}
		public partial interface TickOptions : NestedTickOptions
		{
			Union<NestedTickOptions, bool> minor { get; set; }
			Union<MajorTickOptions, bool> major { get; set; }
		}
		public partial interface NestedTickOptions
		{
			bool autoSkip { get; set; }
			double autoSkipPadding { get; set; }
			ChartColor backdropColor { get; set; }
			double backdropPaddingX { get; set; }
			double backdropPaddingY { get; set; }
			bool beginAtZero { get; set; }
			bool display { get; set; }
			ChartColor fontColor { get; set; }
			string fontFamily { get; set; }
			double fontSize { get; set; }
			string fontStyle { get; set; }
			double labelOffset { get; set; }
			double lineHeight { get; set; }
			object max { get; set; }
			double maxRotation { get; set; }
			double maxTicksLimit { get; set; }
			object min { get; set; }
			double minRotation { get; set; }
			bool mirror { get; set; }
			double padding { get; set; }
			bool reverse { get; set; }
			double sampleSize { get; set; }
			bool showLabelBackdrop { get; set; }
			NestedTickOptionsType_0 source { get; set; }
			double stepSize { get; set; }
			double suggestedMax { get; set; }
			double suggestedMin { get; set; }
			Union<string, double> callback(object value, object index, object values);
		}
		public class NestedTickOptionsType_0 : Enumerated
		{
			public static string auto = "auto";
			public static string data = "data";
			public static string labels = "labels";
			public static implicit operator NestedTickOptionsType_0(string value) { return new NestedTickOptionsType_0(value); }
			public NestedTickOptionsType_0(object value) { Value = value; }
		}
		public partial interface MajorTickOptions : NestedTickOptions
		{
			bool enabled { get; set; }
		}
		public partial interface AngleLineOptions
		{
			bool display { get; set; }
			ChartColor color { get; set; }
			double lineWidth { get; set; }
			double[] borderDash { get; set; }
			double borderDashOffset { get; set; }
		}
		public partial interface PointLabelOptions
		{
			ChartColor fontColor { get; set; }
			string fontFamily { get; set; }
			double fontSize { get; set; }
			string fontStyle { get; set; }
			Union<double, string> lineHeight { get; set; }
			object callback(object arg);
		}
		public partial interface LinearTickOptions : TickOptions
		{
			double maxTicksLimit { get; set; }
			double stepSize { get; set; }
			double precision { get; set; }
			double suggestedMin { get; set; }
			double suggestedMax { get; set; }
		}
		public partial interface LogarithmicTickOptions : TickOptions
		{
		}
		public class ChartColor : TypeAlias
		{
			public ChartColor(Union<string, CanvasGradient, CanvasPattern, string[]> value) { Value = value; }
			public static implicit operator ChartColor(Union<string, CanvasGradient, CanvasPattern, string[]> value) { return new ChartColor(value); }
		}
		public partial interface ChartType_15
		{
			Chart chart { get; set; }
			double dataIndex { get; set; }
			ChartDataSets dataset { get; set; }
			double datasetIndex { get; set; }
		}
		public class Scriptable<T> : TypeAlias
		{
			public Scriptable(Func<ChartType_15, T> value) { Value = value; }
			public static implicit operator Scriptable<T>(Func<ChartType_15, T> value) { return new Scriptable<T>(value); }
		}
		public partial interface ChartDataSets
		{
			ChartDataSetsType_0 cubicInterpolationMode { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> backgroundColor { get; set; }
			double barPercentage { get; set; }
			ChartDataSetsType_1 barThickness { get; set; }
			Union<BorderAlignment, BorderAlignment[], Scriptable<BorderAlignment>> borderAlign { get; set; }
			Union<BorderWidth, BorderWidth[], Scriptable<BorderWidth>> borderWidth { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> borderColor { get; set; }
			ChartDataSetsType_2 borderCapStyle { get; set; }
			double[] borderDash { get; set; }
			double borderDashOffset { get; set; }
			ChartDataSetsType_3 borderJoinStyle { get; set; }
			Union<PositionType, PositionType[], Scriptable<PositionType>> borderSkipped { get; set; }
			double categoryPercentage { get; set; }
			Union<Union<double, object, undefined>[], ChartPoint[]> data { get; set; }
			Union<bool, double, string> fill { get; set; }
			Union<double, double[], Scriptable<double>> hitRadius { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> hoverBackgroundColor { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> hoverBorderColor { get; set; }
			Union<double, double[], Scriptable<double>> hoverBorderWidth { get; set; }
			double hoverRadius { get; set; }
			string label { get; set; }
			double lineTension { get; set; }
			double maxBarThickness { get; set; }
			double minBarLength { get; set; }
			ChartDataSetsType_4 steppedLine { get; set; }
			double order { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> pointBorderColor { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> pointBackgroundColor { get; set; }
			Union<double, double[], Scriptable<double>> pointBorderWidth { get; set; }
			Union<double, double[], Scriptable<double>> pointRadius { get; set; }
			Union<double, double[], Scriptable<double>> pointRotation { get; set; }
			Union<double, double[], Scriptable<double>> pointHoverRadius { get; set; }
			Union<double, double[], Scriptable<double>> pointHitRadius { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> pointHoverBackgroundColor { get; set; }
			Union<ChartColor, ChartColor[], Scriptable<ChartColor>> pointHoverBorderColor { get; set; }
			Union<double, double[], Scriptable<double>> pointHoverBorderWidth { get; set; }
			Union<PointStyle, HTMLImageElement, HTMLCanvasElement, Union<PointStyle, HTMLImageElement, HTMLCanvasElement>[], Scriptable<Union<PointStyle, HTMLImageElement, HTMLCanvasElement>>> pointStyle { get; set; }
			Union<double, double[], Scriptable<double>> radius { get; set; }
			Union<double, double[], Scriptable<double>> rotation { get; set; }
			string xAxisID { get; set; }
			string yAxisID { get; set; }
			Union<ChartType, string> type { get; set; }
			bool hidden { get; set; }
			bool hideInLegendAndTooltip { get; set; }
			bool showLine { get; set; }
			string stack { get; set; }
			bool spanGaps { get; set; }
			double weight { get; set; }
		}
		public class ChartDataSetsType_0 : Enumerated
		{
			public ChartDataSetsType_0() { }
			public static string @default = "default";
			public static string monotone = "monotone";
			public static implicit operator ChartDataSetsType_0(string value) { return new ChartDataSetsType_0(value); }
			public ChartDataSetsType_0(object value) { Value = value; }
		}
		public class ChartDataSetsType_1 : Enumerated
		{
			public static string flex = "flex";
			public static implicit operator ChartDataSetsType_1(double value) { return new ChartDataSetsType_1(value); }
			public static implicit operator ChartDataSetsType_1(string value) { return new ChartDataSetsType_1(value); }
			public ChartDataSetsType_1(object value) { Value = value; }
		}
		public class ChartDataSetsType_2 : Enumerated
		{
			public static string butt = "butt";
			public static string round = "round";
			public static string square = "square";
			public static implicit operator ChartDataSetsType_2(string value) { return new ChartDataSetsType_2(value); }
			public ChartDataSetsType_2(object value) { Value = value; }
		}
		public class ChartDataSetsType_3 : Enumerated
		{
			public static string bevel = "bevel";
			public static string round = "round";
			public static string miter = "miter";
			public static implicit operator ChartDataSetsType_3(string value) { return new ChartDataSetsType_3(value); }
			public ChartDataSetsType_3(object value) { Value = value; }
		}
		public class ChartDataSetsType_4 : Enumerated
		{
			public static string before = "before";
			public static string after = "after";
			public static string middle = "middle";
			public static implicit operator ChartDataSetsType_4(string value) { return new ChartDataSetsType_4(value); }
			public static implicit operator ChartDataSetsType_4(bool value) { return new ChartDataSetsType_4(value); }
			public ChartDataSetsType_4(object value) { Value = value; }
		}
		public partial interface ChartScales
		{
			Union<ScaleType, string> type { get; set; }
			bool display { get; set; }
			Union<PositionType, string> position { get; set; }
			GridLineOptions gridLines { get; set; }
			ScaleTitleOptions scaleLabel { get; set; }
			TickOptions ticks { get; set; }
			ChartXAxe[] xAxes { get; set; }
			ChartYAxe[] yAxes { get; set; }
		}
		public partial interface CommonAxe
		{
			string bounds { get; set; }
			Union<ScaleType, string> type { get; set; }
			Union<bool, string> display { get; set; }
			string id { get; set; }
			bool stacked { get; set; }
			string position { get; set; }
			TickOptions ticks { get; set; }
			GridLineOptions gridLines { get; set; }
			ScaleTitleOptions scaleLabel { get; set; }
			TimeScale time { get; set; }
			bool offset { get; set; }
			void beforeUpdate(object scale);
			void beforeSetDimension(object scale);
			void beforeDataLimits(object scale);
			void beforeBuildTicks(object scale);
			void beforeTickToLabelConversion(object scale);
			void beforeCalculateTickRotation(object scale);
			void beforeFit(object scale);
			void afterUpdate(object scale);
			void afterSetDimension(object scale);
			void afterDataLimits(object scale);
			double[] afterBuildTicks(object scale, double[] ticks);
			void afterTickToLabelConversion(object scale);
			void afterCalculateTickRotation(object scale);
			void afterFit(object scale);
		}
		public partial interface ChartXAxe : CommonAxe
		{
			ChartXAxeType_0 distribution { get; set; }
		}
		public class ChartXAxeType_0 : Enumerated
		{
			public static string linear = "linear";
			public static string series = "series";
			public static implicit operator ChartXAxeType_0(string value) { return new ChartXAxeType_0(value); }
			public ChartXAxeType_0(object value) { Value = value; }
		}
		public partial interface ChartYAxe : CommonAxe
		{
		}
		public partial interface LinearScale : ChartScales
		{
			LinearTickOptions ticks { get; set; }
		}
		public partial interface LogarithmicScale : ChartScales
		{
			LogarithmicTickOptions ticks { get; set; }
		}
		public partial interface TimeDisplayFormat
		{
			string millisecond { get; set; }
			string second { get; set; }
			string minute { get; set; }
			string hour { get; set; }
			string day { get; set; }
			string week { get; set; }
			string month { get; set; }
			string quarter { get; set; }
			string year { get; set; }
		}
		public partial interface TimeScale : ChartScales
		{
			TimeDisplayFormat displayFormats { get; set; }
			bool isoWeekday { get; set; }
			string max { get; set; }
			string min { get; set; }
			Union<string, Func<object, object>> parser { get; set; }
			TimeUnit round { get; set; }
			string tooltipFormat { get; set; }
			TimeUnit unit { get; set; }
			double unitStepSize { get; set; }
			double stepSize { get; set; }
			TimeUnit minUnit { get; set; }
		}
		public partial interface RadialLinearScale
		{
			bool animate { get; set; }
			PositionType position { get; set; }
			AngleLineOptions angleLines { get; set; }
			PointLabelOptions pointLabels { get; set; }
			LinearTickOptions ticks { get; set; }
			bool display { get; set; }
			GridLineOptions gridLines { get; set; }
		}
		public partial interface Point
		{
			double x { get; set; }
			double y { get; set; }
		}
		public partial interface PluginServiceGlobalRegistration
		{
			string id { get; set; }
		}
		public partial interface PluginServiceRegistrationOptions
		{
			void beforeInit(Chart chartInstance, object options);
			void afterInit(Chart chartInstance, object options);
			void beforeUpdate(Chart chartInstance, object options);
			void afterUpdate(Chart chartInstance, object options);
			void beforeLayout(Chart chartInstance, object options);
			void afterLayout(Chart chartInstance, object options);
			void beforeDatasetsUpdate(Chart chartInstance, object options);
			void afterDatasetsUpdate(Chart chartInstance, object options);
			void beforeDatasetUpdate(Chart chartInstance, object options);
			void afterDatasetUpdate(Chart chartInstance, object options);
			void beforeRender(Chart chartInstance, object options);
			void afterRender(Chart chartInstance, object options);
			void beforeDraw(Chart chartInstance, Easing easing, object options);
			void afterDraw(Chart chartInstance, Easing easing, object options);
			void beforeDatasetsDraw(Chart chartInstance, Easing easing, object options);
			void afterDatasetsDraw(Chart chartInstance, Easing easing, object options);
			void beforeDatasetDraw(Chart chartInstance, Easing easing, object options);
			void afterDatasetDraw(Chart chartInstance, Easing easing, object options);
			void beforeTooltipDraw(Chart chartInstance, object tooltipData, object options);
			void afterTooltipDraw(Chart chartInstance, object tooltipData, object options);
			void beforeEvent(Chart chartInstance, Event @event, object options);
			void afterEvent(Chart chartInstance, Event @event, object options);
			void resize(Chart chartInstance, ChartSize newChartSize, object options);
			void destroy(Chart chartInstance);
			void afterScaleUpdate(Chart chartInstance, object options);
		}
		public partial interface ChartUpdateProps
		{
			double duration { get; set; }
			bool lazy { get; set; }
			Easing easing { get; set; }
		}
		public partial interface ChartRenderProps
		{
			double duration { get; set; }
			bool lazy { get; set; }
			Easing easing { get; set; }
		}
		public partial interface DoughnutModel
		{
			ChartColor backgroundColor { get; set; }
			BorderAlignment borderAlign { get; set; }
			string borderColor { get; set; }
			double borderWidth { get; set; }
			double circumference { get; set; }
			double endAngle { get; set; }
			double innerRadius { get; set; }
			double outerRadius { get; set; }
			double startAngle { get; set; }
			double x { get; set; }
			double y { get; set; }
		}
		[Name("Chart")]
		public virtual Chart _Chart { get; set; }
		public virtual Chart.ChartConfiguration config { get; set; }
		public virtual Chart.ChartData data { get; set; }
		public virtual Func<object> destroy { get; set; }
		public virtual Func<Chart.ChartUpdateProps, object> update { get; set; }
		public virtual Func<Chart.ChartRenderProps, object> render { get; set; }
		public virtual Func<Chart> stop { get; set; }
		public virtual Func<Chart> resize { get; set; }
		public virtual Func<Chart> clear { get; set; }
		public virtual Func<string> toBase64Image { get; set; }
		public virtual Func<object> generateLegend { get; set; }
		public virtual Func<object, object[]> getElementAtEvent { get; set; }
		public virtual Func<object, object[]> getElementsAtEvent { get; set; }
		public virtual Func<object, object[]> getDatasetAtEvent { get; set; }
		public virtual Func<double, Meta> getDatasetMeta { get; set; }
		public virtual Union<CanvasRenderingContext2D, object> ctx { get; set; }
		public virtual Union<HTMLCanvasElement, object> canvas { get; set; }
		public virtual Union<double, object> width { get; set; }
		public virtual Union<double, object> height { get; set; }
		public virtual Union<double, object> aspectRatio { get; set; }
		public virtual Chart.ChartOptions options { get; set; }
		public virtual Chart.ChartArea chartArea { get; set; }
		public virtual PluginServiceStatic pluginService { get; set; }
		public virtual PluginServiceStatic plugins { get; set; }
		public virtual ChartType_0 defaults { get; set; }
		public virtual ChartType_1 controllers { get; set; }
		public virtual ChartType_2 helpers { get; set; }
		public virtual ChartType_3 platform { get; set; }
		public virtual Chart.ChartTooltipsStaticConfiguration Tooltip { get; set; }
		public virtual ChartType_4 instances { get; set; }
		public Chart(Union<string, CanvasRenderingContext2D, HTMLCanvasElement, Union<CanvasRenderingContext2D, HTMLCanvasElement>>[] context, Chart.ChartConfiguration options) { }
		public Chart() { }
	}
	public partial class PluginServiceStatic
	{
		public virtual void register(Union<Chart.PluginServiceGlobalRegistration, Chart.PluginServiceRegistrationOptions> plugin) { }
		public virtual void unregister(Union<Chart.PluginServiceGlobalRegistration, Chart.PluginServiceRegistrationOptions> plugin) { }
		public PluginServiceStatic() { }
	}
	public partial interface Meta
	{
		Chart.ChartType type { get; set; }
		MetaData[] data { get; set; }
		Chart.ChartDataSets dataset { get; set; }
		MetaType_0 controller { get; set; }
		bool hidden { get; set; }
		string total { get; set; }
		string xAxisID { get; set; }
		string yAxisID { get; set; }
		MetaType_1 _filler { get; set; }
	}
	public partial interface MetaType_0
	{
		object this[string key] { get; set; }
	}
	public partial interface MetaType_1
	{
		object this[string key] { get; set; }
	}
	public partial interface MetaData
	{
		Chart _chart { get; set; }
		double _datasetIndex { get; set; }
		double _index { get; set; }
		Model _model { get; set; }
		object _start { get; set; }
		Model _view { get; set; }
		Chart.ChartScales _xScale { get; set; }
		Chart.ChartScales _yScale { get; set; }
		bool hidden { get; set; }
	}
	public partial interface Model
	{
		string backgroundColor { get; set; }
		Chart.BorderAlignment borderAlign { get; set; }
		string borderColor { get; set; }
		double borderWidth { get; set; }
		double circumference { get; set; }
		double controlPointNextX { get; set; }
		double controlPointNextY { get; set; }
		double controlPointPreviousX { get; set; }
		double controlPointPreviousY { get; set; }
		double endAngle { get; set; }
		double hitRadius { get; set; }
		double innerRadius { get; set; }
		double outerRadius { get; set; }
		string pointStyle { get; set; }
		string radius { get; set; }
		bool skip { get; set; }
		double startAngle { get; set; }
		undefined steppedLine { get; set; }
		double tension { get; set; }
		double x { get; set; }
		double y { get; set; }
		double @base { get; set; }
		double head { get; set; }
	}
}
