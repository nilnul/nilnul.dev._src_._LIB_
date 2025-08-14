using nilnul.fs.folder.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable_.giT_.nonplain
{
	public class InsideRaws_byGit
	{
		nilnul.fs.folders_._unjoint.Io io;

		public InsideRaws_byGit(nilnul.fs.folders_._unjoint.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> addresses_ofAddress(
			string folder
		)
		{

			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder))
			{
				
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return new delvable_.giT_.work.InsideRaws(io).addresses_ofAddress(folder);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo: //it has to be a bare repo
					return Enumerable.Empty<string>();
					break;
				default:
					throw new UnexpectedReachException(
						$"{folder} shall be work or repo;"
					);
					break;
			}

		}
	}
}





