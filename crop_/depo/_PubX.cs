using System;
using System.Linq;
using System.Numerics;

namespace nilnul.dev.src.crop_.depo
{
	/// <summary>
	/// pub all pub branches to all pub remotes, by
	///		-) ensure remotes
	///		-) push to remotes.
	/// </summary>
	static public class _PubX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="pubBranchesArr">
		/// can be a hint  to later push
		/// </param>
		static public void _Vod_assumeModuleAddress(
			string module
			,
			string[] pubBranchesArr
		)
		{
			remotes_.pub._EnsureUnimaxX._Vod_assumeModuleAddress(module, pubBranchesArr);
			nilnul.fs.git.module.repo.push_._PubX._Vod_assumeModuleAddress_assumePubBranches(
				module,pubBranchesArr
			);
			
			
		}
		static public void _Vod_assumeModuleAddress(
			string module
		)
		{

			/// we assume this is nilnulExtsed
			///

			/// only if there exists pub branch, will create a public repo, as the repo name can be sensitive.
			///
			var branches = nilnul.fs.git.module.repo.branches_.local._VwX._CurrentAndRemaining(module);

			//var anyPub=branches.Any(
			//	b=>
			//	new nilnul.obj.str.re_.InitialSegment<string>(

			//	).re(
			//		new[] {"nilnul","pub" }
			//		,
			//		b.ToString().Split('-').Select(x=> nilnul.txt_.vered._KeyX._Txt(x) )
			//	)
			//);

			var
				pubBranchesArr = nilnul.fs.git.module.repo.branches_.local_.deV_.raW_._PubX._Filter(branches).ToArray();

			_Vod_assumeModuleAddress(module, pubBranchesArr);
			return;



		}
	}
}