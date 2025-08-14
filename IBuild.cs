using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src
{
	/// build is how src is different from file management;
	/// <summary>
	/// build many slns or prjs under a list of srcs;
	/// </summary>
	/// <remarks>
	/// when building, other srcs might be imported;
	/// 
	/// </remarks>
	/// build is placed in src in that:
	///		:for sql or js or other scripting language, src is just checked, packed, and interpreted , with nothing to build
	///		: the build is different from lang.Compile in that build is on sln|prj whileas 'compile' is on lang. compile is placed in the same of prj of lang, so shall be the build in the project of src;
	///			:: also build is on prj, with compiling out of question, hence it's not including the complexity of compilation;
	///			:: the build's result shall be fedback to the src, forming a relatively complete cirle of life; if build is separate, it's result cannot be fedback to itself, leaving a incomplete circle;
	///		:pak is excluded, reserved as a future project; thus build is either able to be included partly here, or there, not fully fledgling necessary as a separate prj;
	/// vs:
	///		<see cref="dev.src.prj.build_"/>
	///	vs:
	///		<see cref="nilnul.lang.ICompile"/> which is on the syntax and for the semantics of a lang, whileas this is based on compile to further extend the process by construction according to the structure of the project, as well as by calling events of post build, etc, to pack, push, and so on;
	///		
	internal class IBuild
	{
	}
}
