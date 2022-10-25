using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.fork_
{
	/// <summary>
	/// do some minore changes, such as
	///		make it strong named, adding .snk file if necessary.
	///		change the pak version to one that is higher than the unforked ones in order to feend off the updating notice of the unforked ones, as unadapted doesnot work in stronged named projects.
	/// </summary>
	/// 
	public interface IAdapt
	{
		/*
		 eg:
			octokit

		it's a sdk proj.
			-we changed one of its targets to net48.
			-we changed the dll version to static from dynamic, if necessary. as strongnamed prj allows no version mismatch in designer time.
			-disable the post-build events, as the .csproj file is not changed, such as version generating, ,to support this. we can disable by making buildCfg such as "Symbol" to "Symbol1".
			-change the package version's pacth.build to a noticable one such that one can tell it's adapted. We change use nilnul convention such as: 220811.130212.
		after building,
			a package is generated in the bin folder.
			manually push it. by the cmd, say:
				nuget push Octokit.2.1.220811.130212.nupkg -src my


		 */
	}
}
