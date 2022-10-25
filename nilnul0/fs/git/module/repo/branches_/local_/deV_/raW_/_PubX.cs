//using nilnul.fs.folder_.gitTop.module.repo._branches;
using nilnul.fs.git.module.be_.deV_.raW_;
using nilnul.fs.git.module.repo._branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.fs.git.module.repo.branches_.local_.deV_.raW_
{
	static public class _PubX
	{

		static public IEnumerable<string> _Filter(
			IEnumerable<string> branches
		)
		{
			return branches.Where(
				b => NilnulPub._Be_ofBranch(b)
			);

		}
		static public IEnumerable<string> _Filter(CurrentAndRemaining currentAndRemaining)
		{

			return _Filter(
				currentAndRemaining.Select(b => b.en)
			);
		}

		static public IEnumerable<string> _Txts_assumeModuleAddress(
			string module
		)
		{

			///
			/// only if there exists pub branch, will create a public repo, as the repo name can be sensitive.
			///

			return _Filter(nilnul.fs.git.module.repo.branches_.local._VwX._CurrentAndRemaining(module)

			);
		}


		static public IEnumerable<string> Txts(ModuleI obj)
		{
			return _Txts_assumeModuleAddress(obj.top1.en.address.en.ToString());
			//throw new NotImplementedException();
		}


	}
}
