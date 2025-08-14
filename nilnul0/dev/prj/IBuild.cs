using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj
{
	/// <summary>
	/// after compilation, build the project.
	/// </summary>
	/// <remarks>
	/// within the prj build, many customized execution can be embedded. Eg: packageing can be inserted sometime during building.
	/// </remarks>
	/// schema:
	///		this is under nilnul.dev.src, in that when the build fails, src can then be altered on the feed back, and a rebuild would start to form a lifecycle; In this sense, build is a way to check src (against a target) just like compile is a way to check lang;
	/// vs:
	///		compile, which a lang tier comiler, whileas this is on project, that is projectwise, including embedding resource, initializing configuration, etc. <see cref="nilnul.lang.compile"/> which translates <see cref="nilnul.fs.git.repo.Snap"/> into <see cref="nilnul._app.ILib"/>;
	///		
	///		<see cref="nilnul.lang.tier_."/>
	///		<see cref="nilnul.dev.prj._build"/>
	///		<see cref="nilnul.dev.sln.build_"/>
	///		<see cref="nilnul.dev.sln.prj."/>
	///		<see cref="nilnul.dev.src.prj.build_"/>
	///		<see cref="nilnul.dev.src.sln."/>
	///		<see cref="nilnul.dev.src.sln.prj."/>
	///	vs:
	///		
	///		
	internal class IBuild
	{
	}
}
