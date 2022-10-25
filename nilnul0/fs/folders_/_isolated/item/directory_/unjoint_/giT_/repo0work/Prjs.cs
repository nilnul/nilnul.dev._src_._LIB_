using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.directory_.unjoint_.giT_.repo0work
{
	public class Prjs
	{
		nilnul.fs.folders_.isolated._prjs.Io io;
		public Prjs(nilnul.fs.folders_.isolated._prjs.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> seq_ofAddress(
			string folder
		) {
			

			var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder);

			switch (category)
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return new directory_.unjoint_.giT_.work.Prjs(io).seq_ofAddress(folder);
					break;

				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return new string[0];
					break;

				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					//break;
				default:
					throw new UnexpectedTypeException("eg: fatal: bad config line 19 in file .git/config. The reason might be some nuls are at the end");
					break;
			}

		}
	}
}
