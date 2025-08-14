using nilnul.fs.folder.be;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable_.giT_.nonplain
{
	public class InsideModules
	{
		nilnul.fs.folders_._unjoint.Io io;

		public InsideModules(nilnul.fs.folders_._unjoint.Io io)
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
					return new delvable_.giT_.work.InsideModules(io).addresses_ofAddress(folder);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo: //it has to be a bare repo
					return Enumerable.Empty<string>();
					break;
				default:
					Trace.TraceError($"{folder} shall be work or repo; exception when trichnomy like: bad config line of nuls at the end;");
					return Enumerable.Empty<string>();

					break;

					//throw new UnexpectedReachException(
					//	$"{folder} shall be work or repo; exception when trichnomy like: bad config line of nuls at the end;"
					//);
					break;
			}


		}
	}
}





