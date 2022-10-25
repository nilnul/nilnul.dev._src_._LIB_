﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item_.unjoint_.plain_.nonprj.dir_.notDotLed_.unjoint
{
	class Prjs
	{
		nilnul.fs.folders_.isolated._prjs.Io io;

		public IEnumerable<string> seq_ofAddress(
			string folder
		) {

			var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folder);

			switch (category)
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					return new item_.unjoint_.plain.Prjs(io).seq_ofAddress(folder);
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
