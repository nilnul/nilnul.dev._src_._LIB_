using nilnul.obj.seq.be_;
using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.fs.git.module.repo.push_
{
	static public class _PubX
	{
		static public void _Vod_assumeModuleAddress_assumePubBranches(
			string module
			,
			IEnumerable<string> pubBranches
		)
		{

			if (pubBranches.None())
			{
				///there is no pub branch, we shall not leak this repo name.
				return;
			}

			var currentRemotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(
				module
			).Select(y=>y.Split('-')).Where(
				x=> {
					if (x.Any())
					{
						if (nilnul.txt_.vered._KeyX._Txt(x.First())=="pub")
						{
							return true;
						}
					}
					return false;
				}
			);



			var remoteAsIdentyEs = currentRemotes.Select(
				x=> x.Select( y=> nilnul.txt_.Vered3.Parse(y))
			);

			var pubRemotes = nilnul.fs.git.module.repo.remotes_.deV_.raW_._PubX._VeredsEs_assumeModuleAddress(module);

			///eg: pub-github-org-ssh

			var grouped= pubRemotes.GroupBy(
				x=>x.Skip(1)
				,
				new nilnul.obj.str.Eq<Vered3>(
					new nilnul.obj.eq_.HashNil<Vered3>(
						(v1,v2) => v1.nom.ee ==v2.nom.ee
					)
				)
			);

			foreach (var item in grouped)
			{
				/// it must be at least one, as we are in group
				var maxOfGroup = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
					item
					,
					(r1, r2) => {
						return nilnul.num.str.Comparer_assumeStrOfNum.Singleton.Compare(
							r1.Select(v => v.ver.main.en)
							,
							r2.Select(v => v.ver.main.en)

						)>0;
						
					}
				);

				if (maxOfGroup.Count()!=1)
				{
					Trace.TraceError(
						$"remotes of {module} for {string.Join("-", item.First().Select(s=>s.nom))} is not unique."
					);
				}
				else
				{


					foreach (var branch in pubBranches)
					{
							var remote = string.Join<Vered3>("-", maxOfGroup.First());

						try
						{
							nilnul.win.prog_.git.run.cod.vow_._NilX.OfAddress(
							   module
							   ,
							   $"push {remote} {branch}"
						   );
						}
						catch (Exception ex)
						{
							Trace.WriteLine(
								$"when pushing to {remote} of branch:{branch} @ {module}: {ex.ToString()}"
							);
						}
					}

				}
			}




		}

		static public void _Vod_assumeModuleAddress(
			string module
		)
		{
			var pubBranches = nilnul.fs.git.module.repo.branches_.local_.deV_.raW_._PubX._Txts_assumeModuleAddress(module);
			_Vod_assumeModuleAddress_assumePubBranches(module,pubBranches);
		}
	}
}
