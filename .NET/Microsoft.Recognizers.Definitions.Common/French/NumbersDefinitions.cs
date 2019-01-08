//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\French\French-Numbers.yaml
//     - Language: French
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.French
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = @"Fr";
		public const string RoundNumberIntegerRegex = @"(cent|mille|millions|million|milliard|milliards|billion|billions)";
		public const string ZeroToNineIntegerRegex = @"(et un|un|une|deux|trois|quatre|cinq|six|sept|huit|neuf)";
		public const string TenToNineteenIntegerRegex = @"((seize|quinze|quatorze|treize|douze|onze)|dix(\Wneuf|\Whuit|\Wsept)?)";
		public const string TensNumberIntegerRegex = @"(quatre\Wvingt(s|\Wdix)?|soixante\Wdix|vingt|trente|quarante|cinquante|soixante|septante|octante|huitante|nonante)";
		public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
		public const string NegativeNumberTermsRegex = @"^[.]";
		public static readonly string NegativeNumberSignRegex = $@"^({NegativeNumberTermsRegex}\s+).*";
		public static readonly string HundredsNumberIntegerRegex = $@"(({ZeroToNineIntegerRegex}(\s+cent))|cent|((\s+cent\s)+{TensNumberIntegerRegex}))";
		public static readonly string BelowHundredsRegex = $@"(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}([-\s]+({TenToNineteenIntegerRegex}|{ZeroToNineIntegerRegex}))?))|{ZeroToNineIntegerRegex})";
		public static readonly string BelowThousandsRegex = $@"(({HundredsNumberIntegerRegex}(\s+{BelowHundredsRegex})?|{BelowHundredsRegex}|{TenToNineteenIntegerRegex})|cent\s+{TenToNineteenIntegerRegex})";
		public static readonly string SupportThousandsRegex = $@"(({BelowThousandsRegex}|{BelowHundredsRegex})\s+{RoundNumberIntegerRegex}(\s+{RoundNumberIntegerRegex})?)";
		public static readonly string SeparaIntRegex = $@"({SupportThousandsRegex}(\s+{SupportThousandsRegex})*(\s+{BelowThousandsRegex})?|{BelowThousandsRegex})";
		public static readonly string AllIntRegex = $@"({SeparaIntRegex}|mille(\s+{BelowThousandsRegex})?)";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!([,\.]\d+[a-zA-Z]))(?={placeholder})";
		public static readonly string NumbersWithSuffix = $@"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+douzaine(s)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((demi\s+)?\s+douzaine)|({AllIntRegex}\s+douzaines?))(?=\b)";
		public const string SimpleRoundOrdinalRegex = @"(centi[eè]me|milli[eè]me|millioni[eè]me|milliardi[eè]me|billioni[eè]me)";
		public const string OneToNineOrdinalRegex = @"(premier|premi[eè]re|deuxi[eè]me|second[e]|troisi[eè]me|tiers|tierce|quatri[eè]me|cinqui[eè]me|sixi[eè]me|septi[eè]me|huiti[eè]me|neuvi[eè]me)";
		public const string SpecialUnderHundredOrdinalRegex = @"(onzi[eè]me|douzi[eè]me)";
		public const string TensOrdinalRegex = @"(quatre-vingt-dixi[eè]me|quatre-vingti[eè]me|huitanti[eè]me|octanti[eè]me|soixante-dixi[eè]me|septanti[eè]me|soixanti[eè]me|cinquanti[eè]me|quaranti[eè]me|trenti[eè]me|vingti[eè]me)";
		public static readonly string HundredOrdinalRegex = $@"({AllIntRegex}(\s+(centi[eè]me\s)))";
		public static readonly string UnderHundredOrdinalRegex = $@"((({AllIntRegex}(\W)?)?{OneToNineOrdinalRegex})|({TensNumberIntegerRegex}(\W)?)?{OneToNineOrdinalRegex}|{TensOrdinalRegex}|{SpecialUnderHundredOrdinalRegex})";
		public static readonly string UnderThousandOrdinalRegex = $@"((({HundredOrdinalRegex}(\s)?)?{UnderHundredOrdinalRegex})|(({AllIntRegex}(\W)?)?{SimpleRoundOrdinalRegex})|{HundredOrdinalRegex})";
		public static readonly string OverThousandOrdinalRegex = $@"(({AllIntRegex})(i[eè]me))";
		public static readonly string ComplexOrdinalRegex = $@"(({OverThousandOrdinalRegex}(\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex}|{UnderHundredOrdinalRegex})";
		public static readonly string SuffixOrdinalRegex = $@"(({AllIntRegex})({SimpleRoundOrdinalRegex}))";
		public static readonly string ComplexRoundOrdinalRegex = $@"((({SuffixOrdinalRegex}(\s)?)?{ComplexOrdinalRegex})|{SuffixOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"({ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1er|2e|2eme|3e|3eme|4e|4eme|5e|5eme|6e|6eme|7e|7eme|8e|8eme|9e|9eme|0e|0eme))|(11e|11eme|12e|12eme))(?=\b)";
		public static readonly string OrdinalFrenchRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+((et)\s+)?)?({AllIntRegex})(\s+((et)\s)?)((({AllOrdinalRegex})s?|({SuffixOrdinalRegex})s?)|demis?|tiers?|quarts?)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(et\s+)?)?(un|une)(\s+)(({AllOrdinalRegex})|({SuffixOrdinalRegex})|(et\s+)?demis?)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+sur\s+(?<denominator>({AllIntRegex})|((\d+)(?!\.)))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"({AllIntRegex}(\s+(virgule|point)){AllPointRegex})";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))\d+[,\.]\d+(?!([,\.]\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))[,\.]\d+(?!([,\.]\d+))(?={placeholder})";
		public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[,\.])))\d+[,\.]\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[,\.])))\d+[,\.]\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))(\d+([,\.]\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))(\d+([,\.]\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly string NumberWithSuffixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(pourcentages|pourcents|pourcentage|pourcent)\b)";
		public static readonly string NumberWithPrefixPercentage = $@"((?<!{BaseNumbers.NumberReplaceToken})%|pourcent|pourcent des|pourcentage de)(\s*)({BaseNumbers.NumberReplaceToken})(?=\s|$)";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = @"sur";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = @"six";
		public const string WordSeparatorToken = @"et";
		public static readonly string[] WrittenDecimalSeparatorTexts = { @"virgule" };
		public static readonly string[] WrittenGroupSeparatorTexts = { @"point", @"points" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { @"et", @"-" };
		public static readonly string[] WrittenFractionSeparatorTexts = { @"et", @"sur" };
		public const string HalfADozenRegex = @"(?<=\b)+demi\s+douzaine";
		public static readonly string DigitalNumberRegex = $@"((?<=\b)(cent|mille|million|millions|milliard|milliards|billions|billion|douzaine(s)?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
		public const string AmbiguousFractionConnectorsRegex = @"^[.]";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ @"zéro", 0 },
			{ @"zero", 0 },
			{ @"un", 1 },
			{ @"une", 1 },
			{ @"deux", 2 },
			{ @"trois", 3 },
			{ @"quatre", 4 },
			{ @"cinq", 5 },
			{ @"six", 6 },
			{ @"sept", 7 },
			{ @"huit", 8 },
			{ @"neuf", 9 },
			{ @"dix", 10 },
			{ @"onze", 11 },
			{ @"douze", 12 },
			{ @"treize", 13 },
			{ @"quatorze", 14 },
			{ @"quinze", 15 },
			{ @"seize", 16 },
			{ @"dix-sept", 17 },
			{ @"dix-huit", 18 },
			{ @"dix-neuf", 19 },
			{ @"vingt", 20 },
			{ @"trente", 30 },
			{ @"quarante", 40 },
			{ @"cinquante", 50 },
			{ @"soixante", 60 },
			{ @"soixante-dix", 70 },
			{ @"septante", 70 },
			{ @"quatre-vingts", 80 },
			{ @"quatre-vingt", 80 },
			{ @"quatre vingts", 80 },
			{ @"quatre vingt", 80 },
			{ @"quatre-vingt-dix", 90 },
			{ @"quatre-vingt dix", 90 },
			{ @"quatre vingt dix", 90 },
			{ @"quatre-vingts-dix", 90 },
			{ @"quatre-vingts-onze", 91 },
			{ @"quatre-vingt-onze", 91 },
			{ @"quatre-vingts-douze", 92 },
			{ @"quatre-vingt-douze", 92 },
			{ @"quatre-vingts-treize", 93 },
			{ @"quatre-vingt-treize", 93 },
			{ @"quatre-vingts-quatorze", 94 },
			{ @"quatre-vingt-quatorze", 94 },
			{ @"quatre-vingts-quinze", 95 },
			{ @"quatre-vingt-quinze", 95 },
			{ @"quatre-vingts-seize", 96 },
			{ @"quatre-vingt-seize", 96 },
			{ @"huitante", 80 },
			{ @"octante", 80 },
			{ @"nonante", 90 },
			{ @"cent", 100 },
			{ @"mille", 1000 },
			{ @"un million", 1000000 },
			{ @"million", 1000000 },
			{ @"millions", 1000000 },
			{ @"un milliard", 1000000000 },
			{ @"milliard", 1000000000 },
			{ @"milliards", 1000000000 },
			{ @"un mille milliards", 1000000000000 },
			{ @"un billion", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ @"premier", 1 },
			{ @"première", 1 },
			{ @"premiere", 1 },
			{ @"deuxième", 2 },
			{ @"deuxieme", 2 },
			{ @"second", 2 },
			{ @"seconde", 2 },
			{ @"troisième", 3 },
			{ @"demi", 2 },
			{ @"tiers", 3 },
			{ @"tierce", 3 },
			{ @"quart", 4 },
			{ @"quarts", 4 },
			{ @"troisieme", 3 },
			{ @"quatrième", 4 },
			{ @"quatrieme", 4 },
			{ @"cinquième", 5 },
			{ @"cinquieme", 5 },
			{ @"sixième", 6 },
			{ @"sixieme", 6 },
			{ @"septième", 7 },
			{ @"septieme", 7 },
			{ @"huitième", 8 },
			{ @"huitieme", 8 },
			{ @"neuvième", 9 },
			{ @"neuvieme", 9 },
			{ @"dixième", 10 },
			{ @"dixieme", 10 },
			{ @"onzième", 11 },
			{ @"onzieme", 11 },
			{ @"douzième", 12 },
			{ @"douzieme", 12 },
			{ @"treizième", 13 },
			{ @"treizieme", 13 },
			{ @"quatorzième", 14 },
			{ @"quatorizieme", 14 },
			{ @"quinzième", 15 },
			{ @"quinzieme", 15 },
			{ @"seizième", 16 },
			{ @"seizieme", 16 },
			{ @"dix-septième", 17 },
			{ @"dix-septieme", 17 },
			{ @"dix-huitième", 18 },
			{ @"dix-huitieme", 18 },
			{ @"dix-neuvième", 19 },
			{ @"dix-neuvieme", 19 },
			{ @"vingtième", 20 },
			{ @"vingtieme", 20 },
			{ @"trentième", 30 },
			{ @"trentieme", 30 },
			{ @"quarantième", 40 },
			{ @"quarantieme", 40 },
			{ @"cinquantième", 50 },
			{ @"cinquantieme", 50 },
			{ @"soixantième", 60 },
			{ @"soixantieme", 60 },
			{ @"soixante-dixième", 70 },
			{ @"soixante-dixieme", 70 },
			{ @"septantième", 70 },
			{ @"septantieme", 70 },
			{ @"quatre-vingtième", 80 },
			{ @"quatre-vingtieme", 80 },
			{ @"huitantième", 80 },
			{ @"huitantieme", 80 },
			{ @"octantième", 80 },
			{ @"octantieme", 80 },
			{ @"quatre-vingt-dixième", 90 },
			{ @"quatre-vingt-dixieme", 90 },
			{ @"nonantième", 90 },
			{ @"nonantieme", 90 },
			{ @"centième", 100 },
			{ @"centieme", 100 },
			{ @"millième", 1000 },
			{ @"millieme", 1000 },
			{ @"millionième", 1000000 },
			{ @"millionieme", 1000000 },
			{ @"milliardième", 1000000000 },
			{ @"milliardieme", 1000000000 },
			{ @"billionieme", 1000000000000 },
			{ @"billionième", 1000000000000 },
			{ @"trillionième", 1000000000000000000 },
			{ @"trillionieme", 1000000000000000000 }
		};
		public static readonly Dictionary<string, long> PrefixCardinalMap = new Dictionary<string, long>
		{
			{ @"deux", 2 },
			{ @"trois", 3 },
			{ @"quatre", 4 },
			{ @"cinq", 5 },
			{ @"six", 6 },
			{ @"sept", 7 },
			{ @"huit", 8 },
			{ @"neuf", 9 },
			{ @"dix", 10 },
			{ @"onze", 11 },
			{ @"douze", 12 },
			{ @"treize", 13 },
			{ @"quatorze", 14 },
			{ @"quinze", 15 },
			{ @"seize", 16 },
			{ @"dix sept", 17 },
			{ @"dix-sept", 17 },
			{ @"dix-huit", 18 },
			{ @"dix huit", 18 },
			{ @"dix-neuf", 19 },
			{ @"dix neuf", 19 },
			{ @"vingt", 20 },
			{ @"vingt-et-un", 21 },
			{ @"vingt et un", 21 },
			{ @"vingt-deux", 21 },
			{ @"vingt deux", 22 },
			{ @"vingt-trois", 23 },
			{ @"vingt trois", 23 },
			{ @"vingt-quatre", 24 },
			{ @"vingt quatre", 24 },
			{ @"vingt-cinq", 25 },
			{ @"vingt cinq", 25 },
			{ @"vingt-six", 26 },
			{ @"vingt six", 26 },
			{ @"vingt-sept", 27 },
			{ @"vingt sept", 27 },
			{ @"vingt-huit", 28 },
			{ @"vingt huit", 28 },
			{ @"vingt-neuf", 29 },
			{ @"vingt neuf", 29 },
			{ @"trente", 30 },
			{ @"quarante", 40 },
			{ @"cinquante", 50 },
			{ @"soixante", 60 },
			{ @"soixante-dix", 70 },
			{ @"soixante dix", 70 },
			{ @"septante", 70 },
			{ @"quatre-vingt", 80 },
			{ @"quatre vingt", 80 },
			{ @"huitante", 80 },
			{ @"octante", 80 },
			{ @"nonante", 90 },
			{ @"quatre vingt dix", 90 },
			{ @"quatre-vingt-dix", 90 },
			{ @"cent", 100 },
			{ @"deux cent", 200 },
			{ @"trois cents", 300 },
			{ @"quatre cents", 400 },
			{ @"cinq cent", 500 },
			{ @"six cent", 600 },
			{ @"sept cent", 700 },
			{ @"huit cent", 800 },
			{ @"neuf cent", 900 }
		};
		public static readonly Dictionary<string, long> SuffixOrdinalMap = new Dictionary<string, long>
		{
			{ @"millième", 1000 },
			{ @"million", 1000000 },
			{ @"milliardième", 1000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ @"cent", 100 },
			{ @"mille", 1000 },
			{ @"million", 1000000 },
			{ @"millions", 1000000 },
			{ @"milliard", 1000000000 },
			{ @"milliards", 1000000000 },
			{ @"billion", 1000000000000 },
			{ @"billions", 1000000000000 },
			{ @"centieme", 100 },
			{ @"centième", 100 },
			{ @"millieme", 1000 },
			{ @"millième", 1000 },
			{ @"millionième", 1000000 },
			{ @"millionieme", 1000000 },
			{ @"milliardième", 1000000000 },
			{ @"milliardieme", 1000000000 },
			{ @"billionième", 1000000000000 },
			{ @"billionieme", 1000000000000 },
			{ @"centiemes", 100 },
			{ @"centièmes", 100 },
			{ @"millièmes", 1000 },
			{ @"milliemes", 1000 },
			{ @"millionièmes", 1000000 },
			{ @"millioniemes", 1000000 },
			{ @"milliardièmes", 1000000000 },
			{ @"milliardiemes", 1000000000 },
			{ @"billionièmes", 1000000000000 },
			{ @"billioniemes", 1000000000000 },
			{ @"douzaine", 12 },
			{ @"douzaines", 12 },
			{ @"k", 1000 },
			{ @"m", 1000000 },
			{ @"g", 1000000000 },
			{ @"b", 1000000000 },
			{ @"t", 1000000000000 }
		};
	}
}