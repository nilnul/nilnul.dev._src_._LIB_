using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src
{
	/// <summary>
	/// a sln, comprising a <see cref="nilnul.rel_.net_.IAcyclic4all"/> of <see cref="nilnul.dev.IPrj"/>s.
	/// eg:
	///		abc
	///		abc.def
	///		(abc)\def.gh
	///	the words_.started can be retrieved with no exception.
	/// </summary>
	/// <remarks>
	/// vs:<see cref="ICrop"/>, which can be, say, abc/def,which is not a sln.
	/// </remarks>
	/// alias:
	///		sln has been taken by <see cref="nilnul.dev.src.ISln"/> in prj:<see cref="nilnul.DevI"/>; We need to inherit some type in this prj, so we need to recreate the type here. To append a ver:1 here to avoid name conflicting.
	class ISln1:src.crop_.ISln
	{
	}
}
