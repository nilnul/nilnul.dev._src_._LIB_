namespace nilnul.dev.src.div_
{
	/// <summary>
	/// if any dnt is dotLed, including:
	///		.
	///		..
	///		...
	///		.a
	///	they are ignored by as non raw code, leaving them to bot software to deal with.
	/// </summary>
	/// <remarks>
	///	note: dotFollowed is also not words.
	///	but for a file, dotFollowed is considered normal file, with ext as ".". But we don't use it at all in practice.
	///		or we can different .nilnul. from .nilnul?
	///		or used in versioned as : abc.def.  followed by version 1.2.3, and fully as abc.def.1.2.3
	/// consective dot, such as "..", "..." is also nonwordsable.
	/// 
	/// </remarks>
	/// alias:
	///		bot
	public interface INonwordsable { }
}
