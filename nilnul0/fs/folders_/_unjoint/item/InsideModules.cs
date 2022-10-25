using nilnul.fs.folder.be;
using nilnul.num.quotient.stream.fibanacci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item
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

			if (nilnul.fs.folder.be_.git_.Repo.Singleton.Be_ofAddress(folder) )
			{
				return new string[0];
			}

			return new item.div_.delvable.InsideModules(io).addresses_ofAddress(folder);
	
		}
	}
}





