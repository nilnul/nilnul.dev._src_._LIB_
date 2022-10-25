using System;
using System.Linq;
using System.Numerics;

namespace nilnul.dev.src.crop_.depo.remotes_.pub
{
	static public class _EnsureUnimaxX
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

			
			//pubBranchesArr = pubBranches.ToArray();
			var bePub = nilnul.fs.git.module.be_.deV_.raW_.NilnulPub._Be_ofBranches(pubBranchesArr);

			if (!bePub)
			{

				///there is no pub branch, we shall not leak this repo name.
				return;
			}

			var currentRemotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq_ofAddress(
				module
			).Select(y => y.Split('-')).Where(
				x =>
				{
					if (x.Any())
					{
						if (nilnul.txt_.vered._KeyX._Txt(x.First()) == "pub")
						{
							return true;
						}
					}
					return false;
				}
			);

			var remoteAsIdentyEs = currentRemotes.Select(
				x => x.Select(y => nilnul.txt_.Vered3.Parse(y))
			);  //eg: pub1-github3

			foreach (var client in nilnul.fs.git.Properties.SettingsX.clients_pub_dict)
			{
				var clientKey = client.Key;
				var clientKeyNormed = nilnul.txt_._vered.Name._CreateByAppendingUnderscoreIfNecessary(clientKey);

				/// find max one.
				/// note: pub-github001, and pub-github1 are same big. In this case, we need to create a new one called: pub-github2.
				///


				//var remote4svrFound = remoteAsIdentyEs.Any(
				//	i => i.Skip(1).FirstOrDefault()?.nom == keyNormed
				//);

				var remotes4ThisSvr = remoteAsIdentyEs.Where(
					i => i.Skip(1).FirstOrDefault()?.nom == clientKeyNormed
				);

				var maxes = nilnul.rel_.net_.poset.nodes_._MaximalX._Maximal_funcAssumeGt(
					remotes4ThisSvr
					,
					(r1, r2) =>
					{
						var v1 = r1.ElementAt(1)._ver;
						var v2 = r2.ElementAt(1).ver;
						return v1.main.en.CompareTo(v2.main.en) > 0;
					}
				);

				if (maxes.Count() == 1)
				{
					continue;
				}

				//create the repo.
				var repoName = nilnul.dev.src.sln.div_.crop.cognome.ThrowIfNotInSrc.Singleton.getName_ofAddress(
					module
				);

				var createdName = client.Value.ensure_assumeUnnormed(new nilnul.fs.git.svr.repo.Name(repoName));

				var urn = client.Value.urn(
					new nilnul.fs.git.svr.repo.Name(createdName)
				);  //note some might prefer https. let user specify this in client.

				BigInteger ver = 0;
				if (maxes.Any())
				{
					ver = (maxes.First().Last().ver.main.en + 1);//.ToString();
				}

				var verAsTxt = nilnul.num.phrase_._DecX.Phrase(ver);

				/// todo: create remote
				nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_moduleOfAddress_assumeUrn(
					module
					,
					$"pub-{clientKeyNormed}{verAsTxt}"
					,
					urn //.ToString()
				);

			}
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