
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
	public partial class moment
	{
		//Name["moment"]
		public virtual Moment _moment(MomentInput inp, MomentFormatSpecification format, bool strict) => default(Moment);
		//Name["moment"]
		public virtual Moment _moment(MomentInput inp, MomentFormatSpecification format, string language, bool strict) => default(Moment);
		public class RelativeTimeKey : Enumerated
		{
			public static string s = "s";
			public static string ss = "ss";
			public static string m = "m";
			public static string mm = "mm";
			public static string h = "h";
			public static string hh = "hh";
			public static string d = "d";
			public static string dd = "dd";
			public static string M = "M";
			public static string MM = "MM";
			public static string y = "y";
			public static string yy = "yy";
			public static implicit operator RelativeTimeKey(string value) { return new RelativeTimeKey(value); }
			public RelativeTimeKey(object value) { Value = value; }
		}
		public class CalendarKey : Enumerated
		{
			public static string sameDay = "sameDay";
			public static string nextDay = "nextDay";
			public static string lastDay = "lastDay";
			public static string nextWeek = "nextWeek";
			public static string lastWeek = "lastWeek";
			public static string sameElse = "sameElse";
			public static implicit operator CalendarKey(string value) { return new CalendarKey(value); }
			public CalendarKey(object value) { Value = value; }
		}
		public class LongDateFormatKey : Enumerated
		{
			public static string LTS = "LTS";
			public static string LT = "LT";
			public static string L = "L";
			public static string LL = "LL";
			public static string LLL = "LLL";
			public static string LLLL = "LLLL";
			public static string lts = "lts";
			public static string lt = "lt";
			public static string l = "l";
			public static string ll = "ll";
			public static string lll = "lll";
			public static string llll = "llll";
			public static implicit operator LongDateFormatKey(string value) { return new LongDateFormatKey(value); }
			public LongDateFormatKey(object value) { Value = value; }
		}
		public partial interface Locale
		{
			string calendar(CalendarKey key, Moment m, Moment now);
			string longDateFormat(LongDateFormatKey key);
			string invalidDate();
			string ordinal(double n);
			string preparse(string inp);
			string postformat(string inp);
			string relativeTime(double n, bool withoutSuffix, RelativeTimeKey key, bool isFuture);
			string pastFuture(double diff, string absRelTime);
			void set(Object config);
			string[] months();
			string[] monthsShort();
			double monthsParse(string monthName, string format, bool strict);
			RegExp monthsRegex(bool strict);
			RegExp monthsShortRegex(bool strict);
			double week(Moment m);
			double firstDayOfYear();
			double firstDayOfWeek();
			string[] weekdays();
			string[] weekdaysMin();
			string[] weekdaysShort();
			double weekdaysParse(string weekdayName, string format, bool strict);
			RegExp weekdaysRegex(bool strict);
			RegExp weekdaysShortRegex(bool strict);
			RegExp weekdaysMinRegex(bool strict);
			bool isPM(string input);
			string meridiem(double hour, double minute, bool isLower);
		}
		public partial interface StandaloneFormatSpec
		{
			string[] format { get; set; }
			string[] standalone { get; set; }
			RegExp isFormat { get; set; }
		}
		public partial interface WeekSpec
		{
			double dow { get; set; }
			double doy { get; set; }
		}
		public class CalendarSpecVal : TypeAlias
		{
			public CalendarSpecVal(Union<string, Func<MomentInput, Moment, string>> value) { Value = value; }
			public static implicit operator CalendarSpecVal(Union<string, Func<MomentInput, Moment, string>> value) { return new CalendarSpecVal(value); }
		}
		public partial interface CalendarSpec
		{
			CalendarSpecVal sameDay { get; set; }
			CalendarSpecVal nextDay { get; set; }
			CalendarSpecVal lastDay { get; set; }
			CalendarSpecVal nextWeek { get; set; }
			CalendarSpecVal lastWeek { get; set; }
			CalendarSpecVal sameElse { get; set; }
			Union<CalendarSpecVal, undefined> this[string x] { get; set; }
		}
		public class RelativeTimeSpecVal : TypeAlias
		{
			public RelativeTimeSpecVal(Union<string, Func<double, bool, RelativeTimeKey, bool, string>> value) { Value = value; }
			public static implicit operator RelativeTimeSpecVal(Union<string, Func<double, bool, RelativeTimeKey, bool, string>> value) { return new RelativeTimeSpecVal(value); }
		}
		public class RelativeTimeFuturePastVal : TypeAlias
		{
			public RelativeTimeFuturePastVal(Union<string, Func<string, string>> value) { Value = value; }
			public static implicit operator RelativeTimeFuturePastVal(Union<string, Func<string, string>> value) { return new RelativeTimeFuturePastVal(value); }
		}
		public partial interface RelativeTimeSpec
		{
			RelativeTimeFuturePastVal future { get; set; }
			RelativeTimeFuturePastVal past { get; set; }
			RelativeTimeSpecVal s { get; set; }
			RelativeTimeSpecVal ss { get; set; }
			RelativeTimeSpecVal m { get; set; }
			RelativeTimeSpecVal mm { get; set; }
			RelativeTimeSpecVal h { get; set; }
			RelativeTimeSpecVal hh { get; set; }
			RelativeTimeSpecVal d { get; set; }
			RelativeTimeSpecVal dd { get; set; }
			RelativeTimeSpecVal M { get; set; }
			RelativeTimeSpecVal MM { get; set; }
			RelativeTimeSpecVal y { get; set; }
			RelativeTimeSpecVal yy { get; set; }
		}
		public partial interface LongDateFormatSpec
		{
			string LTS { get; set; }
			string LT { get; set; }
			string L { get; set; }
			string LL { get; set; }
			string LLL { get; set; }
			string LLLL { get; set; }
			string lts { get; set; }
			string lt { get; set; }
			string l { get; set; }
			string ll { get; set; }
			string lll { get; set; }
			string llll { get; set; }
		}
		public class MonthWeekdayFn : TypeAlias
		{
			public MonthWeekdayFn(Func<Moment, string, string> value) { Value = value; }
			public static implicit operator MonthWeekdayFn(Func<Moment, string, string> value) { return new MonthWeekdayFn(value); }
		}
		public class WeekdaySimpleFn : TypeAlias
		{
			public WeekdaySimpleFn(Func<Moment, string> value) { Value = value; }
			public static implicit operator WeekdaySimpleFn(Func<Moment, string> value) { return new WeekdaySimpleFn(value); }
		}
		public partial interface LocaleSpecification
		{
			Union<string[], StandaloneFormatSpec, MonthWeekdayFn> months { get; set; }
			Union<string[], StandaloneFormatSpec, MonthWeekdayFn> monthsShort { get; set; }
			Union<string[], StandaloneFormatSpec, MonthWeekdayFn> weekdays { get; set; }
			Union<string[], StandaloneFormatSpec, WeekdaySimpleFn> weekdaysShort { get; set; }
			Union<string[], StandaloneFormatSpec, WeekdaySimpleFn> weekdaysMin { get; set; }
			RegExp meridiemParse { get; set; }
			Func<double, double, bool, string> meridiem { get; set; }
			Func<string, bool> isPM { get; set; }
			LongDateFormatSpec longDateFormat { get; set; }
			CalendarSpec calendar { get; set; }
			RelativeTimeSpec relativeTime { get; set; }
			string invalidDate { get; set; }
			Func<double, string> ordinal { get; set; }
			RegExp ordinalParse { get; set; }
			WeekSpec week { get; set; }
			object this[string x] { get; set; }
		}
		public partial interface MomentObjectOutput
		{
			double years { get; set; }
			double months { get; set; }
			double date { get; set; }
			double hours { get; set; }
			double minutes { get; set; }
			double seconds { get; set; }
			double milliseconds { get; set; }
		}
		public partial interface Duration
		{
			Duration clone();
			string humanize(bool withSuffix);
			Duration abs();
			double @as(unitOfTime.Base units);
			double get(unitOfTime.Base units);
			double milliseconds();
			double asMilliseconds();
			double seconds();
			double asSeconds();
			double minutes();
			double asMinutes();
			double hours();
			double asHours();
			double days();
			double asDays();
			double weeks();
			double asWeeks();
			double months();
			double asMonths();
			double years();
			double asYears();
			Duration add(DurationInputArg1 inp, DurationInputArg2 unit);
			Duration subtract(DurationInputArg1 inp, DurationInputArg2 unit);
			string locale();
			Locale localeData();
			string toISOString();
			string toJSON();
			bool isValid();
			Moment lang(LocaleSpecifier locale);
			Locale lang();
			string toIsoString();
		}
		public partial interface MomentRelativeTime
		{
			object future { get; set; }
			object past { get; set; }
			object s { get; set; }
			object ss { get; set; }
			object m { get; set; }
			object mm { get; set; }
			object h { get; set; }
			object hh { get; set; }
			object d { get; set; }
			object dd { get; set; }
			object M { get; set; }
			object MM { get; set; }
			object y { get; set; }
			object yy { get; set; }
		}
		public partial interface MomentLongDateFormat
		{
			string L { get; set; }
			string LL { get; set; }
			string LLL { get; set; }
			string LLLL { get; set; }
			string LT { get; set; }
			string LTS { get; set; }
			string l { get; set; }
			string ll { get; set; }
			string lll { get; set; }
			string llll { get; set; }
			string lt { get; set; }
			string lts { get; set; }
		}
		public partial interface MomentParsingFlags
		{
			bool empty { get; set; }
			string[] unusedTokens { get; set; }
			string[] unusedInput { get; set; }
			double overflow { get; set; }
			double charsLeftOver { get; set; }
			bool nullInput { get; set; }
			Union<string, undefined> invalidMonth { get; set; }
			bool invalidFormat { get; set; }
			bool userInvalidated { get; set; }
			bool iso { get; set; }
			object[] parsedDateParts { get; set; }
			Union<string, undefined> meridiem { get; set; }
		}
		public partial interface MomentParsingFlagsOpt
		{
			bool empty { get; set; }
			string[] unusedTokens { get; set; }
			string[] unusedInput { get; set; }
			double overflow { get; set; }
			double charsLeftOver { get; set; }
			bool nullInput { get; set; }
			string invalidMonth { get; set; }
			bool invalidFormat { get; set; }
			bool userInvalidated { get; set; }
			bool iso { get; set; }
			object[] parsedDateParts { get; set; }
			string meridiem { get; set; }
		}
		public partial interface MomentBuiltinFormat
		{
			object __momentBuiltinFormatBrand { get; set; }
		}
		public class MomentFormatSpecification : TypeAlias
		{
			public MomentFormatSpecification(Union<string, MomentBuiltinFormat, Union<string, MomentBuiltinFormat>[]> value) { Value = value; }
			public static implicit operator MomentFormatSpecification(Union<string, MomentBuiltinFormat, Union<string, MomentBuiltinFormat>[]> value) { return new MomentFormatSpecification(value); }
		}
		public partial class unitOfTime
		{
			public class unitOfTimeType_0 : Enumerated
			{
				public static string year = "year";
				public static string years = "years";
				public static string y = "y";
				public static string month = "month";
				public static string months = "months";
				public static string M = "M";
				public static string week = "week";
				public static string weeks = "weeks";
				public static string w = "w";
				public static string day = "day";
				public static string days = "days";
				public static string d = "d";
				public static string hour = "hour";
				public static string hours = "hours";
				public static string h = "h";
				public static string minute = "minute";
				public static string minutes = "minutes";
				public static string m = "m";
				public static string second = "second";
				public static string seconds = "seconds";
				public static string s = "s";
				public static string millisecond = "millisecond";
				public static string milliseconds = "milliseconds";
				public static string ms = "ms";
				public static implicit operator unitOfTimeType_0(string value) { return new unitOfTimeType_0(value); }
				public unitOfTimeType_0(object value) { Value = value; }
			}
			public class Base : TypeAlias
			{
				public Base(unitOfTimeType_0 value) { Value = value; }
				public static implicit operator Base(unitOfTimeType_0 value) { return new Base(value); }
			}
			public class _quarter : Enumerated
			{
				public static string quarter = "quarter";
				public static string quarters = "quarters";
				public static string Q = "Q";
				public static implicit operator _quarter(string value) { return new _quarter(value); }
				public _quarter(object value) { Value = value; }
			}
			public class _isoWeek : Enumerated
			{
				public static string isoWeek = "isoWeek";
				public static string isoWeeks = "isoWeeks";
				public static string W = "W";
				public static implicit operator _isoWeek(string value) { return new _isoWeek(value); }
				public _isoWeek(object value) { Value = value; }
			}
			public class _date : Enumerated
			{
				public static string date = "date";
				public static string dates = "dates";
				public static string D = "D";
				public static implicit operator _date(string value) { return new _date(value); }
				public _date(object value) { Value = value; }
			}
			public class DurationConstructor : TypeAlias
			{
				public DurationConstructor(Union<Base, _quarter> value) { Value = value; }
				public static implicit operator DurationConstructor(Union<Base, _quarter> value) { return new DurationConstructor(value); }
			}
			public class DurationAs : TypeAlias
			{
				public DurationAs(Base value) { Value = value; }
				public static implicit operator DurationAs(Base value) { return new DurationAs(value); }
			}
			public class StartOf : TypeAlias
			{
				public StartOf(Union<Base, _quarter, _isoWeek, _date, undefined> value) { Value = value; }
				public static implicit operator StartOf(Union<Base, _quarter, _isoWeek, _date, undefined> value) { return new StartOf(value); }
			}
			public class Diff : TypeAlias
			{
				public Diff(Union<Base, _quarter> value) { Value = value; }
				public static implicit operator Diff(Union<Base, _quarter> value) { return new Diff(value); }
			}
			public class MomentConstructor : TypeAlias
			{
				public MomentConstructor(Union<Base, _date> value) { Value = value; }
				public static implicit operator MomentConstructor(Union<Base, _date> value) { return new MomentConstructor(value); }
			}
			public class All : Enumerated
			{
				public class Base : TypeAlias
				{
					public Base(unitOfTimeType_0 value) { Value = value; }
					public static implicit operator Base(unitOfTimeType_0 value) { return new Base(value); }
				}
				public class _quarter : Enumerated
				{
					public static string quarter = "quarter";
					public static string quarters = "quarters";
					public static string Q = "Q";
					public static implicit operator _quarter(string value) { return new _quarter(value); }
					public _quarter(object value) { Value = value; }
				}
				public class _isoWeek : Enumerated
				{
					public static string isoWeek = "isoWeek";
					public static string isoWeeks = "isoWeeks";
					public static string W = "W";
					public static implicit operator _isoWeek(string value) { return new _isoWeek(value); }
					public _isoWeek(object value) { Value = value; }
				}
				public class _date : Enumerated
				{
					public static string date = "date";
					public static string dates = "dates";
					public static string D = "D";
					public static implicit operator _date(string value) { return new _date(value); }
					public _date(object value) { Value = value; }
				}
				public static string weekYear = "weekYear";
				public static string weekYears = "weekYears";
				public static string gg = "gg";
				public static string isoWeekYear = "isoWeekYear";
				public static string isoWeekYears = "isoWeekYears";
				public static string GG = "GG";
				public static string dayOfYear = "dayOfYear";
				public static string dayOfYears = "dayOfYears";
				public static string DDD = "DDD";
				public static string weekday = "weekday";
				public static string weekdays = "weekdays";
				public static string e = "e";
				public static string isoWeekday = "isoWeekday";
				public static string isoWeekdays = "isoWeekdays";
				public static string E = "E";
				public static implicit operator All(Base value) { return new All(value); }
				public static implicit operator All(_quarter value) { return new All(value); }
				public static implicit operator All(_isoWeek value) { return new All(value); }
				public static implicit operator All(_date value) { return new All(value); }
				public static implicit operator All(string value) { return new All(value); }
				public All(object value) { Value = value; }
			}
			public unitOfTime() { }
		}
		public partial interface MomentInputObject
		{
			double years { get; set; }
			double year { get; set; }
			double y { get; set; }
			double months { get; set; }
			double month { get; set; }
			double M { get; set; }
			double days { get; set; }
			double day { get; set; }
			double d { get; set; }
			double dates { get; set; }
			double date { get; set; }
			double D { get; set; }
			double hours { get; set; }
			double hour { get; set; }
			double h { get; set; }
			double minutes { get; set; }
			double minute { get; set; }
			double m { get; set; }
			double seconds { get; set; }
			double second { get; set; }
			double s { get; set; }
			double milliseconds { get; set; }
			double millisecond { get; set; }
			double ms { get; set; }
		}
		public partial interface DurationInputObject : MomentInputObject
		{
			double quarters { get; set; }
			double quarter { get; set; }
			double Q { get; set; }
			double weeks { get; set; }
			double week { get; set; }
			double w { get; set; }
		}
		public partial interface MomentSetObject : MomentInputObject
		{
			double weekYears { get; set; }
			double weekYear { get; set; }
			double gg { get; set; }
			double isoWeekYears { get; set; }
			double isoWeekYear { get; set; }
			double GG { get; set; }
			double quarters { get; set; }
			double quarter { get; set; }
			double Q { get; set; }
			double weeks { get; set; }
			double week { get; set; }
			double w { get; set; }
			double isoWeeks { get; set; }
			double isoWeek { get; set; }
			double W { get; set; }
			double dayOfYears { get; set; }
			double dayOfYear { get; set; }
			double DDD { get; set; }
			double weekdays { get; set; }
			double weekday { get; set; }
			double e { get; set; }
			double isoWeekdays { get; set; }
			double isoWeekday { get; set; }
			double E { get; set; }
		}
		public partial interface FromTo
		{
			MomentInput from { get; set; }
			MomentInput to { get; set; }
		}
		public class MomentInput : TypeAlias
		{
			public MomentInput(Union<Moment, Date, string, double, Union<double, string>[], MomentInputObject, undefined> value) { Value = value; }
			public static implicit operator MomentInput(Union<Moment, Date, string, double, Union<double, string>[], MomentInputObject, undefined> value) { return new MomentInput(value); }
		}
		public class DurationInputArg1 : TypeAlias
		{
			public DurationInputArg1(Union<Duration, double, string, FromTo, DurationInputObject, undefined> value) { Value = value; }
			public static implicit operator DurationInputArg1(Union<Duration, double, string, FromTo, DurationInputObject, undefined> value) { return new DurationInputArg1(value); }
		}
		public class DurationInputArg2 : TypeAlias
		{
			public DurationInputArg2(unitOfTime.DurationConstructor value) { Value = value; }
			public static implicit operator DurationInputArg2(unitOfTime.DurationConstructor value) { return new DurationInputArg2(value); }
		}
		public class LocaleSpecifier : TypeAlias
		{
			public LocaleSpecifier(Union<string, Moment, Duration, string[], bool> value) { Value = value; }
			public static implicit operator LocaleSpecifier(Union<string, Moment, Duration, string[], bool> value) { return new LocaleSpecifier(value); }
		}
		public partial interface MomentCreationData
		{
			MomentInput input { get; set; }
			MomentFormatSpecification format { get; set; }
			Locale locale { get; set; }
			bool isUTC { get; set; }
			bool strict { get; set; }
		}
		public partial interface Moment
		{
			string format(string format);
			Moment startOf(unitOfTime.StartOf unitOfTime);
			Moment endOf(unitOfTime.StartOf unitOfTime);
			Moment add(DurationInputArg1 amount, DurationInputArg2 unit);
			Moment add(unitOfTime.DurationConstructor unit, Union<double, string> amount);
			Moment subtract(DurationInputArg1 amount, DurationInputArg2 unit);
			Moment subtract(unitOfTime.DurationConstructor unit, Union<double, string> amount);
			string calendar(MomentInput time, CalendarSpec formats);
			Moment clone();
			double valueOf();
			Moment local(bool keepLocalTime);
			bool isLocal();
			Moment utc(bool keepLocalTime);
			bool isUTC();
			bool isUtc();
			Moment parseZone();
			bool isValid();
			double invalidAt();
			bool hasAlignedHourOffset(MomentInput other);
			MomentCreationData creationData();
			MomentParsingFlags parsingFlags();
			Moment year(double y);
			double year();
			Moment years(double y);
			double years();
			double quarter();
			double quarters();
			Moment month(Union<double, string> M);
			double month();
			Moment months(Union<double, string> M);
			double months();
			Moment day(Union<double, string> d);
			double day();
			Moment days(Union<double, string> d);
			double days();
			Moment date(double d);
			double date();
			Moment dates(double d);
			double dates();
			Moment hour(double h);
			double hour();
			Moment hours(double h);
			double hours();
			Moment minute(double m);
			double minute();
			Moment minutes(double m);
			double minutes();
			Moment second(double s);
			double second();
			Moment seconds(double s);
			double seconds();
			Moment millisecond(double ms);
			double millisecond();
			Moment milliseconds(double ms);
			double milliseconds();
			double weekday();
			double isoWeekday();
			double weekYear();
			double isoWeekYear();
			double week();
			double weeks();
			double isoWeek();
			double isoWeeks();
			double weeksInYear();
			double isoWeeksInYear();
			double dayOfYear();
			string from(MomentInput inp, bool suffix);
			string to(MomentInput inp, bool suffix);
			string fromNow(bool withoutSuffix);
			string toNow(bool withoutPrefix);
			double diff(MomentInput b, unitOfTime.Diff unitOfTime, bool precise);
			double[] toArray();
			Date toDate();
			string toISOString(bool keepOffset);
			string inspect();
			string toJSON();
			double unix();
			bool isLeapYear();
			double zone();
			double utcOffset();
			bool isUtcOffset();
			double daysInMonth();
			bool isDST();
			string zoneAbbr();
			string zoneName();
			bool isBefore(MomentInput inp, unitOfTime.StartOf granularity);
			bool isAfter(MomentInput inp, unitOfTime.StartOf granularity);
			bool isSame(MomentInput inp, unitOfTime.StartOf granularity);
			bool isSameOrAfter(MomentInput inp, unitOfTime.StartOf granularity);
			bool isSameOrBefore(MomentInput inp, unitOfTime.StartOf granularity);
			bool isBetween(MomentInput a, MomentInput b, unitOfTime.StartOf granularity, MomentType_0 inclusivity);
			Moment lang(LocaleSpecifier language);
			Locale lang();
			string locale();
			Locale localeData();
			bool isDSTShifted();
			Moment max(MomentInput inp, MomentFormatSpecification format, bool strict);
			Moment max(MomentInput inp, MomentFormatSpecification format, string language, bool strict);
			Moment min(MomentInput inp, MomentFormatSpecification format, bool strict);
			Moment min(MomentInput inp, MomentFormatSpecification format, string language, bool strict);
			double get(unitOfTime.All unit);
			Moment set(unitOfTime.All unit, double value);
			Moment set(MomentSetObject objectLiteral);
			MomentObjectOutput toObject();
		}
		public class MomentType_0 : Enumerated
		{
			public static string __ = "()";
			public static string ___ = "[)";
			public static string ____ = "(]";
			public static string _____ = "[]";
			public static implicit operator MomentType_0(string value) { return new MomentType_0(value); }
			public MomentType_0(object value) { Value = value; }
		}
		public partial interface momentType_3
		{
			string DATETIME_LOCAL { get; set; }
			string DATETIME_LOCAL_SECONDS { get; set; }
			string DATETIME_LOCAL_MS { get; set; }
			string DATE { get; set; }
			string TIME { get; set; }
			string TIME_SECONDS { get; set; }
			string TIME_MS { get; set; }
			string WEEK { get; set; }
			string MONTH { get; set; }
		}
		public virtual string version { get; set; }
		public virtual Moment fn { get; set; }
		public virtual MomentBuiltinFormat ISO_8601 { get; set; }
		public virtual MomentBuiltinFormat RFC_2822 { get; set; }
		public virtual string defaultFormat { get; set; }
		public virtual string defaultFormatUtc { get; set; }
		public virtual momentType_3 HTML5_FMT { get; set; }
		public virtual Moment utc(MomentInput inp, MomentFormatSpecification format, bool strict) => default(Moment);
		public virtual Moment utc(MomentInput inp, MomentFormatSpecification format, string language, bool strict) => default(Moment);
		public virtual Moment unix(double timestamp) => default(Moment);
		public virtual Moment invalid(MomentParsingFlagsOpt flags) => default(Moment);
		public virtual bool isMoment(object m) => default(bool);
		public virtual bool isDate(object m) => default(bool);
		public virtual bool isDuration(object d) => default(bool);
		public virtual string lang(string language) => default(string);
		public virtual string lang(string language, Locale definition) => default(string);
		public virtual string locale(string language) => default(string);
		public virtual string locale(string[] language) => default(string);
		public virtual string locale(string language, Union<LocaleSpecification, undefined> definition) => default(string);
		public virtual Locale localeData(Union<string, string[]> key) => default(Locale);
		public virtual Duration duration(DurationInputArg1 inp, DurationInputArg2 unit) => default(Duration);
		public virtual Moment parseZone(MomentInput inp, MomentFormatSpecification format, bool strict) => default(Moment);
		public virtual Moment parseZone(MomentInput inp, MomentFormatSpecification format, string language, bool strict) => default(Moment);
		public virtual string[] months() => default(string[]);
		public virtual string[] monthsShort() => default(string[]);
		public virtual string[] weekdays() => default(string[]);
		public virtual string[] weekdaysShort() => default(string[]);
		public virtual string[] weekdaysMin() => default(string[]);
		public virtual Moment min(Moment[] moments) => default(Moment);
		public virtual Moment max(Moment[] moments) => default(Moment);
		public virtual double now() => default(double);
		public virtual Locale defineLocale(string language, Union<LocaleSpecification, undefined> localeSpec) => default(Locale);
		public virtual Locale updateLocale(string language, Union<LocaleSpecification, undefined> localeSpec) => default(Locale);
		public virtual string[] locales() => default(string[]);
		public virtual string normalizeUnits(unitOfTime.All unit) => default(string);
		public virtual Union<double, bool> relativeTimeThreshold(string threshold) => default(Union<double, bool>);
		public virtual bool relativeTimeThreshold(string threshold, double limit) => default(bool);
		public virtual bool relativeTimeRounding(Func<double, double> fn) => default(bool);
		public virtual Func<double, double> relativeTimeRounding() => default(Func<double, double>);
		public virtual string calendarFormat(Moment m, Moment now) => default(string);
		public virtual double parseTwoDigitYear(string input) => default(double);
		public moment() { }
	}
}
