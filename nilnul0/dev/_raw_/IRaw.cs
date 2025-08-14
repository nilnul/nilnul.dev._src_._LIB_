namespace nilnul.dev.src
{

	/// <summary>
	/// a raw/src, where we put our slns in.
	/// </summary>
	/// <remarks>
	/// a raw is an address.
	/// It can be nonexistant. in that case, it's ignored.
	///		it might be a nonexistant path inside a higher depo
	/// It can be a file. in that case, a warning is issued.
	///		If it's a file, it might be in a higher-tiered depo, and it's tackled there.
	///	It can be folder, be it linked or not.
	///		This is the primary and intended case.
	///	It cannot be a gir repo
	///		in that case an exception is thrown,traced, and ignored
	/// </remarks>
	/// alias:
	///		src has been taken by <see cref="nilnul.dev.ISrc"/> in prj:<see cref="nilnul.DevI"/>; We need to inherit some type in this prj, so we need to recreate the type here. 
	class IRaw {

	}
}
