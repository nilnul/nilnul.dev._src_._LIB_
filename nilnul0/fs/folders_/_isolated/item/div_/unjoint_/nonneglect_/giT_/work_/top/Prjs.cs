using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.div_.unjoint_.nonneglect_.giT_.work_.top
{
	public class Prjs
	{
		public nilnul.fs.folders_.isolated._prjs.Io io;
		public Prjs(nilnul.fs.folders_.isolated._prjs.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> seq_ofAddress(
			string folder
		)
		{
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be_ofAddress(folder))
			{
				yield return folder;
				yield break; //assume prj is not recursive.
			}

			foreach (var dirAddress in nilnul.fs.folder.dirs_._NotDotLedX.Addresses_ofAddress(folder))
			{

			}

			foreach (var dirAddress in nilnul.fs.folder._DirsX._Shields_ofAddress(folder))
			{

				if (nilnul.fs.folder.be_.link_._ThisSymX.Be(dirAddress) )
				{
					foreach (var item in collection)
					{

					}

				}
				if (!dirAddress.denote.en.StartsWith("."))
				{


					var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder);

					switch (category)
					{
						case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

							foreach (
								var item in new item_.unjoint_.plain.Prjs(io).seq_ofAddress(folder)
							)
							{
								yield return item;
							} ;
							break;
						case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

							foreach (
								var item in new item.directory_._.unjoint_.plain.Prjs(io).seq_ofAddress(folder)
							)
							{
								yield return item;
							} ;



							break;
						case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
							
						default:
							throw new UnexpectedReachException();
							break;
					}
				}


			}

		}
	}
}
