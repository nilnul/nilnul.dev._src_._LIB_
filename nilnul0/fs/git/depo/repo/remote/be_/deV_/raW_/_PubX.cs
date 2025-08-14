using nilnul.fs.git.module.repo._branches;
using nilnul.txt_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.module.repo.remote.be_.deV_.raW_
{
	static public class _PubX
	{
		static public bool Be_ofRemote(
			IEnumerable<string> x
		) {
			
				if (x.Any())
				{
					if (nilnul.txt_.vered._KeyX._Txt(x.First()) == "pub")
					{
						return true;
					}
				}
				return false;
			

		}
		public static bool Be_ofRemote(IEnumerable<Vered3> x)
		{

				if (x.Any())
				{
					if (x.First().nom.ee == "pub")
					{
						return true;
					}
				}
				return false;


		}

		static public bool Be_ofRemote(
			string branch
		) {
			return Be_ofRemote(branch.Split('-'));

		}
	

	}
}
