//using nilnul.fs.folder_.gitTop.module.repo._branches;
using nilnul.fs.git.module.be_.deV_.raW_;
using nilnul.fs.git.module.repo._branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.fs.git.module.repo.remotes_.deV_.raW_
{
	static public class _PubX
	{

		static public IEnumerable<nilnul.txt_.Vered3[]> _VeredsEs_assumeModuleAddress(
			string module
		)
		{
			return nilnul.fs.git.module.repo.remotes.vw_._EachAsTiersX._VeredsEs_assumeModuleAddress(module).Where(
				x =>
					nilnul.fs.git.module.repo.remote.be_.deV_.raW_._PubX.Be_ofRemote(x)
			);

			//return nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(
			//	module
			//).Select(
			//	y => y.Split('-').Select(
			//		z =>
			//		nilnul.txt_.Vered3.Parse(z)
			//	).ToArray()
			//).Where(
			//	x =>
			//		nilnul.fs.git.module.repo.remote.be_.deV_.raW_._PubX.Be_ofRemote(x)
			//);
		}

		[Obsolete(nameof(_VeredsEs_assumeModuleAddress))]
		static public IEnumerable<string[]> _Strung_assumeModuleAddress(
			string module
		)
		{

			return nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(
				module
			).Select(y => y.Split('-')).Where(
				x =>
					nilnul.fs.git.module.repo.remote.be_.deV_.raW_._PubX.Be_ofRemote(x)

			);
			
		}

		static public IEnumerable<string[]> Strung(ModuleI obj)
		{
			return _Strung_assumeModuleAddress(obj.top1.en.address.en.ToString());
			//throw new NotImplementedException();
		}
	}
}