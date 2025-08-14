using nilnul.fs.git.module.repo._branches;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.module.be_.deV_.raW_
{
	public class NilnulPub
		:
		nilnul.fs.git.module.BeI
	{

		/// <summary>
		/// the main/mastr for pub from nilnul
		/// </summary>
		public static string[] PREFIX = new[] { "nilnul","pub" };
		static public bool _Be_ofBranch(
			string branch
		) {
			return
				new nilnul.obj.str.re_.InitialSegment<string>(

				).re(
					PREFIX
					//new[] { "nilnul", "pub" }
					,
					branch.Split('-').Select(x => nilnul.txt_.vered._KeyX._Txt(x))
				)
			;

		}
		static public bool _Be_ofBranches(
			IEnumerable<string> branches
		) {
			return branches.Any(
				b => _Be_ofBranch(b));

		}
		public bool _Be_ofBranches(CurrentAndRemaining currentAndRemaining)
		{

			return _Be_ofBranches(
				currentAndRemaining.Select(b=>b.en)
			);
		}

		public bool _be_assumeModuleAddress(
			string	 module
		){

			///
			/// only if there exists pub branch, will create a public repo, as the repo name can be sensitive.
			///

			return _Be_ofBranches( nilnul.fs.git.module.repo.branches_.local._VwX._CurrentAndRemaining(module)

			);
		}


		public bool be(ModuleI obj)
		{
			return _be_assumeModuleAddress(obj.top1.en.address.en.ToString());
			//throw new NotImplementedException();
		}


		static public NilnulPub Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NilnulPub>.Instance;
			}
		}


	}
}
