using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src
{
	/// <summary>
	/// division of <see cref="nilnul.dev.ISrc"/> which is:
	///		a folder
	///		,
	///		if it's symlink, it cannot point into the src such that no cycle is formed.
	///		,
	///		each dir can be parsed by cognom successfully as empty cognom.
	///	eg:
	///		the root src itself.
	///		
	/// </summary>
	/// alias:
	///		delegate
	///		subsrc
	///		derived
	///		dispatch
	internal class ISubsrc
	{
	}
}
