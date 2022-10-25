using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.div_.unjoint
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
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					return new item.div_.unjoint_.giT_.plain.Prjs(io).seq_ofAddress(folder);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return new item_.unjoint_.plain.Prjs(io).seq_ofAddress(folder);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					break;
				default:
					break;
			}

		}
	}
}
