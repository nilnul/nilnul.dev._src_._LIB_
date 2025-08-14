using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev
{
	/// <summary>
	/// make this a base portable, in other words, the ancestor directory is disregarded.
	/// </summary>
	/// <remarks>
	/// for src code, we can compile it into tgt code.
	/// </remarks>
	/// alias:
	///		raw
	///		codebase
	///			,cb
	///		code
	///		src
	///			,which can also mean from a src to tgt, but raw cannot mean that. hence ,raw is preferred here, as it cannot be used there.
	///	vs:
	///		<see cref="nilnul.fs.git.repo.Snap"/>, which is a revision of src code.
	///		
	public interface IRaw: nilnul.fs.IAddress
	{
	}
}
